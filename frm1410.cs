using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Traditions
{
	public partial class frm1410 : Form
	{
		public frm1410()
		{
			InitializeComponent();
		}
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home2.png");
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home1.png");
		}

		private void frm1410_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmAutumn fAutumn = new frmAutumn();
			fAutumn.Show();
			this.Hide();
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\вышивка2.png");
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\вышивка1.png");
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			frmEmbroidery fEmb = new frmEmbroidery();
			fEmb.Owner = this;
			fEmb.Show();
			this.Hide();
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\книга2.png");
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\книга1.png");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frmTeoria fTeoria = new frmTeoria();
			fTeoria.Owner = this;
			fTeoria.webBrowser1.Navigate(Application.StartupPath + "\\Teoria\\1410.htm");
			fTeoria.Show();
			this.Hide();
		}

		private void pictureBox4_MouseEnter(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\Покрова2.png");
		}

		private void pictureBox4_MouseLeave(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\Покрова1.png");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frmPhoto fPhoto = new frmPhoto();
			fPhoto.Owner = this;
			fPhoto.pictureBox2.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\1.png");
			fPhoto.pictureBox3.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\2.png");
			fPhoto.pictureBox4.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\3.png");
			fPhoto.pictureBox5.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\4.png");
			fPhoto.pictureBox6.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\5.png");
			fPhoto.pictureBox7.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\6.png");
			fPhoto.pictureBox8.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\7.png");
			fPhoto.pictureBox9.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\8.png");
			fPhoto.pictureBox10.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\9.png");
			fPhoto.pictureBox11.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\10.png");
			fPhoto.pictureBox12.BackgroundImage = Image.FromFile("Фотогалерея\\1410\\1.png");
			fPhoto.Show();
			this.Hide();
		}

		private void pictureBox5_MouseEnter(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\видео2.png");
		}

		private void pictureBox5_MouseLeave(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Свята\\14.10\\видео1.png");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frmVideo fVideo = new frmVideo();
			fVideo.axWindowsMediaPlayer1.URL = "Video\\1410.mp4";
			fVideo.Owner = this;
			fVideo.Show();
			this.Hide();
		}
	}
}
