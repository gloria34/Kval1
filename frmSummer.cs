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
	public partial class frmSummer : Form
	{
		public frmSummer()
		{
			InitializeComponent();
		}
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		int k;
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home2.png");
		}

		private void frmSummer_Load(object sender, EventArgs e)
		{
			k = 1;
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
			frmMenu fMenu = new frmMenu();
			fMenu.Show();
			this.Hide();
		}

		private void pictureBox6_MouseEnter(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\7сsc.png");
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\7сs.png");
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\10сsc.png");
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\10сs.png");
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frm0707 f0707 = new frm0707();
			f0707.Show();
			this.Hide();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			frm1007 f1007 = new frm1007();
			f1007.Show();
			this.Hide();
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\14сsc.png");
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\14сs.png");
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frm1408 f1408 = new frm1408();
			f1408.Show();
			this.Hide();
		}

		private void pictureBox4_MouseEnter(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\19сsc.png");
		}

		private void pictureBox4_MouseLeave(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Calendar\\summer\\19сs.png");
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frm1908 f1908 = new frm1908();
			f1908.Show();
			this.Hide();
		}


		private void pictureBox7_MouseEnter(object sender, EventArgs e)
		{
			pictureBox7.BackgroundImage = Image.FromFile("Images\\st2.png");
		}

		private void pictureBox7_MouseLeave(object sender, EventArgs e)
		{
			pictureBox7.BackgroundImage = Image.FromFile("Images\\st1.png");
		}

		private void pictureBox8_MouseEnter(object sender, EventArgs e)
		{
			pictureBox8.BackgroundImage = Image.FromFile("Images\\st4.png");
		}

		private void pictureBox8_MouseLeave(object sender, EventArgs e)
		{
			pictureBox8.BackgroundImage = Image.FromFile("Images\\st3.png");
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			if (k < 3)
				k++;
			pictureBox8.Visible = true;
			if (k == 3)
				pictureBox7.Visible = false;
			if (k == 1)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\черв.png");
				pictureBox2.Visible = true;
				pictureBox6.Visible = false;
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
			}
			if (k == 2)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\лип.png");
				pictureBox6.Visible = true;
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
			}
			if (k == 3)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\серп.png");
				pictureBox6.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = true;
				pictureBox4.Visible = true;
			}
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			if(k>1)
				k--;
			pictureBox7.Visible = true;
			if (k == 1)
				pictureBox8.Visible = false;
			if (k == 1)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\черв.png");
				pictureBox2.Visible = true;
				pictureBox6.Visible = false;
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
			}
			if (k == 2)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\лип.png");
				pictureBox6.Visible = true;
				pictureBox2.Visible = false;
				pictureBox3.Visible = false;
				pictureBox4.Visible = false;
			}
			if (k == 3)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\серп.png");
				pictureBox6.Visible = false;
				pictureBox2.Visible = false;
				pictureBox3.Visible = true;
				pictureBox4.Visible = true;
			}
		}
	}
}
