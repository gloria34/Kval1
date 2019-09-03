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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\menu1.png");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			IntPtr cursor = LoadCursorFromFile(curName);
			this.Cursor = new Cursor(cursor);
		}

		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\menu2.png");
		}

		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			
		}

		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			frmMenu fMenu = new frmMenu();
			fMenu.Show();
			this.Hide();
		}
	}
}
