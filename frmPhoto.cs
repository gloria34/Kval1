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
	public partial class frmPhoto : Form
	{
		public frmPhoto()
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

		private void frmPhoto_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home1.png");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Owner.Show();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox3.BackgroundImage;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox2.BackgroundImage;
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox4.BackgroundImage;
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox5.BackgroundImage;
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox6.BackgroundImage;
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox11.BackgroundImage;
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox10.BackgroundImage;
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox9.BackgroundImage;
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox8.BackgroundImage;
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			pictureBox12.BackgroundImage = pictureBox7.BackgroundImage;
		}
	}
}
