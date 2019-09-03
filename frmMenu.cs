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
	public partial class frmMenu : Form
	{
		public frmMenu()
		{
			InitializeComponent();
		}
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		private void frmMenu_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox5_MouseEnter(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\exit5.png");
		}

		private void pictureBox5_MouseLeave(object sender, EventArgs e)
		{
			pictureBox5.BackgroundImage = Image.FromFile("Images\\exit3.png");
		}

		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\осень5.png");
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\осень6.png");
		}

		private void pictureBox4_MouseEnter(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\лето5.png");
		}

		private void pictureBox4_MouseLeave(object sender, EventArgs e)
		{
			pictureBox4.BackgroundImage = Image.FromFile("Images\\лето6.png");
		}

		private void pictureBox3_MouseEnter(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\весна5.png");
		}

		private void pictureBox3_MouseLeave(object sender, EventArgs e)
		{
			pictureBox3.BackgroundImage = Image.FromFile("Images\\весна6.png");
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\зима5.png");
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			pictureBox2.BackgroundImage = Image.FromFile("Images\\зима6.png");
		}

		private void pictureBox6_MouseEnter(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\dict2.png");
			toolTip1.Active = true;
			toolTip1.Show("Словник", pictureBox6);
		}

		private void pictureBox6_MouseLeave(object sender, EventArgs e)
		{
			pictureBox6.BackgroundImage = Image.FromFile("Images\\dict1.png");
			toolTip1.Active = false;
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			frmWinter fWinter = new frmWinter();
			fWinter.Show();
			this.Hide();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			frmDict fDict = new frmDict();
			fDict.Show();
			this.Hide();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			frmSpring fSpring = new frmSpring();
			fSpring.Show();
			this.Hide();
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			frmSummer fSummmer = new frmSummer();
			fSummmer.Show();
			this.Hide();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmAutumn fAutumn = new frmAutumn();
			fAutumn.Show();
			this.Hide();

		}
	}
}
