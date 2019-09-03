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
	public partial class frmDict : Form
	{
		public frmDict()
		{
			InitializeComponent();
		}
		int m, n;
		string folderName;
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		bool eda, odiah, pisni, hati;
		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\home2.png");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frmMenu fMenu = new frmMenu();
			fMenu.Show();
			this.Hide();
			axWindowsMediaPlayer1.URL = "";
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\home1.png");
		}

		private void pictureBox5_MouseEnter(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\st2.png");
		}

		private void pictureBox5_MouseLeave(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\st1.png");
		}

		private void pictureBox6_MouseEnter(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\st4.png");
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\st3.png");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "";
			m++;
			pictureBox4.BackgroundImage = Image.FromFile(folderName + m + "\\icon.png");
			webBrowser1.Navigate(Application.StartupPath + "\\" + folderName + m + "\\opis.htm");
			if(axWindowsMediaPlayer1.Visible==true)
				axWindowsMediaPlayer1.URL = folderName + m + "\\zf.mp3";
			pictureBox6.Visible = true;
			if (m == n)
				pictureBox5.Visible = false;
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "";
			m--;
			pictureBox4.BackgroundImage = Image.FromFile(folderName + m + "\\icon.png");
			webBrowser1.Navigate(Application.StartupPath + "\\" + folderName + m + "\\opis.htm");
			if (axWindowsMediaPlayer1.Visible == true)
				axWindowsMediaPlayer1.URL = folderName + m + "\\zf.mp3";
			pictureBox5.Visible = true;
			if (m == 1)
				pictureBox6.Visible = false;
		}

		private void pictureBox7_MouseEnter(object sender, EventArgs e)
		{
			pictureBox7.Location = new Point(0, 225);
		}

		private void pictureBox7_MouseLeave(object sender, EventArgs e)
		{
			if (pisni == false)
			{
				pictureBox7.Location = new Point(32, 225);
			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.URL = "";
			axWindowsMediaPlayer1.Visible = true;
			this.BackgroundImage = Image.FromFile("Images\\Словник\\фонПісні.png");
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Словник\\пісні1.png");
			pisni = true;
			eda = false;
			hati = false;
			odiah = false;
			m = 1;
			n = 17;
			folderName = "Pisni\\";
			pictureBox4.BackgroundImage = Image.FromFile(folderName + m + "\\icon.png");
			webBrowser1.Navigate(Application.StartupPath +"\\"+ folderName + m + "\\opis.htm");
			axWindowsMediaPlayer1.URL= folderName + m + "\\zf.mp3";
			pictureBox5.Visible = true;
			pictureBox6.Visible = false;
			pictureBox2.Location = new Point(32, 50);
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Словник\\їжа.png");
			pictureBox8.Location = new Point(32, 400);
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Словник\\одяг.png");
			pictureBox9.Location = new Point(32, 575);
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Словник\\хати.png");
		}

		private void pictureBox8_MouseEnter(object sender, EventArgs e)
		{
			pictureBox8.Location = new Point(0, 400);
		}

		private void pictureBox8_MouseLeave(object sender, EventArgs e)
		{
			if (odiah == false)
			{
				pictureBox8.Location = new Point(32, 400);
			}
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Visible = false;
			this.BackgroundImage = Image.FromFile("Images\\Словник\\фонОдяг.png");
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Словник\\одяг1.png");
			pisni = false;
			eda = false;
			hati = false;
			odiah = true;
			m = 1;
			n = 33;
			folderName = "Odiah\\";
			pictureBox4.BackgroundImage = Image.FromFile(folderName + m + "\\icon.png");
			webBrowser1.Navigate(Application.StartupPath + "\\" + folderName + m + "\\opis.htm");
			pictureBox5.Visible = true;
			pictureBox6.Visible = false;
			pictureBox2.Location = new Point(32, 50);
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Словник\\їжа.png");
			pictureBox7.Location = new Point(32, 225);
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Словник\\пісні.png");
			pictureBox9.Location = new Point(32, 575);
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Словник\\хати.png");
		}


		private void pictureBox9_MouseLeave(object sender, EventArgs e)
		{
			if (hati == false)
			{
				pictureBox9.Location = new Point(32, 575);
			}
		}

		private void pictureBox9_MouseEnter(object sender, EventArgs e)
		{
			pictureBox9.Location = new Point(0, 575);
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Visible = false;
			this.BackgroundImage = Image.FromFile("Images\\Словник\\фонАрх.png");
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Словник\\хати1.png");
			eda = false;
			pisni = false;
			hati = true;
			odiah = false;
			m = 1;
			n = 9;
			folderName = "Hati\\";
			pictureBox4.BackgroundImage = Image.FromFile(folderName + m + "\\icon.png");
			webBrowser1.Navigate(Application.StartupPath + "\\" + folderName + m + "\\opis.htm");
			pictureBox5.Visible = true;
			pictureBox6.Visible = false;
			pictureBox7.Location = new Point(32, 225);
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Словник\\пісні.png");
			pictureBox8.Location = new Point(32, 400);
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Словник\\одяг.png");
			pictureBox2.Location = new Point(32, 50);
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Словник\\їжа.png");
		}

		private void frmDict_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
			webBrowser1.Navigate(Application.StartupPath + "\\" + "folk.htm");
			hati = false;
			eda = false;
			odiah = false;
			pisni = false;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Visible = false;
			this.BackgroundImage = Image.FromFile("Images\\Словник\\фонЕда.png");
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Словник\\їжа1.png");
			eda = true;
			pisni = false;
			hati = false;
			odiah = false;
			m = 1;
			n = 34;
			folderName = "Stravi\\";
			pictureBox4.BackgroundImage = Image.FromFile(folderName + m + "\\icon.png");
			webBrowser1.Navigate(Application.StartupPath + "\\" + folderName + m + "\\opis.htm");
			pictureBox5.Visible = true;
			pictureBox6.Visible = false;
			pictureBox7.Location = new Point(32, 225);
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Словник\\пісні.png");
			pictureBox8.Location = new Point(32, 400);
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Словник\\одяг.png");
			pictureBox9.Location = new Point(32, 575);
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Словник\\хати.png");
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			pictureBox2.Location = new Point(0, 50);
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			if (eda == false)
			{
				pictureBox2.Location = new Point(32, 50);
			}
		}
	}
}
