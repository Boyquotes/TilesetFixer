using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Drawing.Imaging;

namespace TilesetFixer
{
	public partial class Form1 : Form
	{
		List<string> supportedFormats = new List<string>
		{
			".png",
			".jpg",
			".jpeg",
			".bmp",
		};

		const string ConfigFile = "setting.json";

		class Config
		{
			[JsonProperty("output")]
			public string OutputPath = "";

			[JsonProperty("add_suffix")]
			public bool AddSuffix = true;

			[JsonProperty("width")]
			public int Width = 32;

			[JsonProperty("height")]
			public int Height = 32;

			[JsonProperty("hor_spacing")]
			public int HorisontalSpacing = 1;

			[JsonProperty("ver_spacing")]
			public int VerticalSpacing = 1;
		}

		Config config = new Config();

		public Form1()
		{
			InitializeComponent();
			LoadConfig();

			string filter = "All supported images|";
			for (int i = 0; i < supportedFormats.Count; i++)
			{
				filter += $"*{supportedFormats[i]}";
				if (i != supportedFormats.Count - 1)
					filter += ";";
			}
			filter += "|";

			for (int i = 0; i < supportedFormats.Count; i++)
			{
				filter += $"*{supportedFormats[i]}|*{supportedFormats[i]}";
				if (i != supportedFormats.Count - 1)
					filter += "|";
			}

			openFileDialog1.Filter = filter;
		}

		private void LoadConfig()
		{
			try
			{
				if (File.Exists(ConfigFile))
					config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigFile));
				textBox2.Text = config.OutputPath;
				checkBox1.Checked = config.AddSuffix;
				nud_HorisontalSpacing.Value = config.HorisontalSpacing;
				nud_VerticalSpacing.Value = config.VerticalSpacing;
				nud_width.Value = config.Width;
				nud_height.Value = config.Height;
			}
			catch (Exception ex)
			{

			}
		}

		private void SaveConfig()
		{
			try
			{
				config.OutputPath = textBox2.Text;
				config.AddSuffix = checkBox1.Checked;
				config.HorisontalSpacing = (int)nud_HorisontalSpacing.Value;
				config.VerticalSpacing = (int)nud_VerticalSpacing.Value;
				config.Width = (int)nud_width.Value;
				config.Height = (int)nud_height.Value;

				var str = JsonConvert.SerializeObject(config);
				File.WriteAllText(ConfigFile, str);
			}
			catch (Exception ex)
			{

			}
		}

		private void Form1_DragEnter(object sender, DragEventArgs e)
		{
			string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (data != null && data.Length > 0 && supportedFormats.Contains(Path.GetExtension(data[0])) && File.Exists(data[0]))
				e.Effect = DragDropEffects.Move;
			else
				e.Effect = DragDropEffects.None;
		}

		private void Form1_DragLeave(object sender, EventArgs e)
		{

		}

		private void Form1_DragDrop(object sender, DragEventArgs e)
		{
			string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
			if (data != null && data.Length > 0)
			{
				textBox1.Text = data[0];
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SaveConfig();
			try
			{
				if (File.Exists(textBox1.Text))
				{
					if (!Directory.Exists(textBox2.Text))
						Directory.CreateDirectory(textBox2.Text);

					var name = "";
					var outtex = "";

					if (checkBox1.Checked)
						name = Path.GetFileNameWithoutExtension(textBox1.Text) + "_fixed" + Path.GetExtension(textBox1.Text);
					else
						name = Path.GetFileName(textBox1.Text);
					outtex = Path.Combine(textBox2.Text, name);

					FixTilesetTexture(textBox1.Text, outtex);
				}
				else
				{
					MessageBox.Show($"\"{textBox1.Text}\" does not exists!", "Error");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error!!!\n" + ex.Message, "Error");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				textBox1.Text = openFileDialog1.FileName;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(textBox2.Text))
				folderBrowserDialog1.SelectedPath = textBox2.Text;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox2.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private PixelFormat _fixIamgeFormat(PixelFormat format)
		{
			switch (format)
			{
				case PixelFormat.Format1bppIndexed:
					return PixelFormat.Format32bppRgb;
				case PixelFormat.Format4bppIndexed:
					return PixelFormat.Format32bppRgb;
				case PixelFormat.Format8bppIndexed:
					return PixelFormat.Format32bppRgb;
			}

			return format;
		}

		struct LineAndCopies
		{
			public int line;
			public int start;
			public int end;
		}

		private void FixTilesetTexture(string tex, string outTex)
		{

			var img = Image.FromFile(tex);

			var xSize = (int)Math.Ceiling(img.Width / (float)config.Width);
			var ySize = (int)Math.Ceiling(img.Height / (float)config.Height);
			var xHalfSpace = (int)Math.Ceiling((float)config.HorisontalSpacing / 2);
			var yHalfSpace = (int)Math.Ceiling((float)config.VerticalSpacing / 2);

			var newImg = new Bitmap(
				img.Width + ((xSize - 1) * config.HorisontalSpacing),
				img.Height + ((ySize - 1) * config.VerticalSpacing),
				_fixIamgeFormat(img.PixelFormat));

			List<LineAndCopies> hLines = new List<LineAndCopies>();
			List<LineAndCopies> vLines = new List<LineAndCopies>();

			var newImgDev = Graphics.FromImage(newImg);
			for (int x = 0; x < xSize; x++)
			{
				for (int y = 0; y < ySize; y++)
				{
					var tileStartX = config.Width * x + config.HorisontalSpacing * x;
					var tileStartY = config.Height * y + config.VerticalSpacing * y;

					newImgDev.DrawImage(img,
						new Rectangle(tileStartX, tileStartY, config.Width, config.Height),
						new Rectangle(config.Width * x, config.Height * y, config.Width, config.Height),
						GraphicsUnit.Pixel);
				}
			}

			for (int x = 0; x < xSize; x++)
			{
				var tileStartX = config.Width * x + config.HorisontalSpacing * x;
				var tileEndX = tileStartX + config.Width - 1;

				hLines.Add(new LineAndCopies() { start = tileStartX - xHalfSpace, end = tileStartX - 1, line = tileStartX });
				hLines.Add(new LineAndCopies() { start = tileEndX + 1, end = tileEndX + xHalfSpace, line = tileEndX });
			}

			for (int y = 0; y < ySize; y++)
			{
				var tileStartY = config.Height * y + config.VerticalSpacing * y;
				var tileEndY = tileStartY + config.Height - 1;

				vLines.Add(new LineAndCopies() { start = tileStartY - yHalfSpace, end = tileStartY - 1, line = tileStartY });
				vLines.Add(new LineAndCopies() { start = tileEndY + 1, end = tileEndY + yHalfSpace, line = tileEndY });
			}


			foreach (var l in hLines)
			{
				for (int x = l.start; x <= l.end; x++)
				{
					newImgDev.DrawImage(newImg,
						new Rectangle(x, 0, 1, newImg.Height),
						new Rectangle(l.line, 0, 1, newImg.Height),
						GraphicsUnit.Pixel);
				}
			}

			foreach (var l in vLines)
			{
				for (int y = l.start; y <= l.end; y++)
				{
					newImgDev.DrawImage(newImg,
						new Rectangle(0, y, newImg.Width, 1),
						new Rectangle(0, l.line, newImg.Width, 1),
						GraphicsUnit.Pixel);
				}
			}

			newImg.Save(outTex);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			SaveConfig();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveConfig();
		}
	}
}
