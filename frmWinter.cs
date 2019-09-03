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
	public partial class frmWinter : Form
	{
		public frmWinter()
		{
			InitializeComponent();
		}
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		int k;
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmMenu fMenu = new frmMenu();
			fMenu.Show();
			this.Hide();
		}

		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home2.png");
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home1.png");
		}

		private void frmWinter_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
			k = 1;
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\19сsc.png");
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\19сs.png");
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			frmSviato fSviato = new frmSviato();
			fSviato.Show();
			this.Hide();
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			
		}

		private void pictureBox4_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void pictureBox4_MouseLeave(object sender, EventArgs e)
		{
			
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox5_MouseEnter(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\6сsc.png");
		}

		private void pictureBox5_MouseLeave(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\6сs.png");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			frm06 f06 = new frm06();
			f06.Show();
			this.Hide();
		}

		private void pictureBox6_MouseEnter(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\7сsc.png");
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\7сs.png");
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frm0701 f0701 = new frm0701();
			f0701.Show();
			this.Hide();
		}

		private void pictureBox7_MouseEnter(object sender, EventArgs e)
		{
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\13сsс.png");
		}

		private void pictureBox7_MouseLeave(object sender, EventArgs e)
		{
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\13сs.png");
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			frm1301 f1301 = new frm1301();
			f1301.Show();
			this.Hide();
		}

		private void pictureBox3_MouseEnter_1(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\19сsc.png");
		}

		private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Calendar\\winter\\19сs.png");
		}

		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			frm1901 f1901 = new frm1901();
			f1901.Show();
			this.Hide();
		}

		private void pictureBox8_MouseEnter(object sender, EventArgs e)
		{
			pictureBox8.BackgroundImage = Image.FromFile("Images\\st2.png");
		}

		private void pictureBox8_MouseLeave(object sender, EventArgs e)
		{
			pictureBox8.BackgroundImage = Image.FromFile("Images\\st1.png");
		}

		private void pictureBox9_MouseEnter(object sender, EventArgs e)
		{
			pictureBox9.BackgroundImage = Image.FromFile("Images\\st4.png");
		}

		private void pictureBox9_MouseLeave(object sender, EventArgs e)
		{
			pictureBox9.BackgroundImage = Image.FromFile("Images\\st3.png");
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Calendar\\січ.png");
			pictureBox9.Visible = true;
			pictureBox8.Visible = false;
			pictureBox2.Visible = false;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			pictureBox7.Visible = true;
			pictureBox3.Visible = true;
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Calendar\\гру.png");
			pictureBox8.Visible = true;
			pictureBox9.Visible = false;
			pictureBox2.Visible = true;
			pictureBox5.Visible = false;
			pictureBox6.Visible = false;
			pictureBox7.Visible = false;
			pictureBox3.Visible = false;
		}
	}
}
