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
	public partial class frmEmbroidery : Form
	{
		public frmEmbroidery()
		{
			InitializeComponent();
		}
		string s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24, s25, s26, s27, s28, s29, s30, s31, s32, s33, s34, s35, s36, s37, s38;
		string curName = "mycur.cur";
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		static extern IntPtr LoadCursorFromFile(string curName);
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			pictureBox1.BackgroundImage = Image.FromFile("Images\\home2.png");
		}

		private void frmEmbroidery_Load(object sender, EventArgs e)
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

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox41.Visible = false;
			pictureBox39.Visible = true;
			pictureBox43.Visible = false;
			pictureBox45.Visible = false;
			s3 = ""; s4 = ""; s5 = ""; s6 = ""; s7 = ""; s8 = ""; s9 = ""; s10 = ""; s11 = ""; s12 = ""; s13 = ""; s14 = ""; s15 = ""; s16 = ""; s17 = ""; s18 = ""; s19 = ""; s20 = ""; s21 = ""; s22 = ""; s23 = ""; s24 = ""; s25 = ""; s26 = ""; s27 = ""; s28 = ""; s29 = ""; s30 = ""; s31 = ""; s32 = ""; s33 = ""; s34 = ""; s35 = ""; s36 = ""; s37 = ""; s38 = ""; 
			this.BackgroundImage = Image.FromFile("Images\\Вышивка\\фон1.png");
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			pictureBox9.Visible = true;
			pictureBox10.Visible = true;
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox18.Visible = true;
			pictureBox13.Visible = true;
			pictureBox14.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			pictureBox17.Visible = true;
			pictureBox24.Visible = true;
			pictureBox27.Visible = true;
			pictureBox28.Visible = true;
			pictureBox30.Visible = true;
			pictureBox35.Visible = true;
			pictureBox38.Visible = true;
			pictureBox19.Visible = true;
			pictureBox20.Visible = true;
			pictureBox25.Visible = true;
			pictureBox26.Visible = true;
			pictureBox36.Visible = true;
			pictureBox32.Visible = true;
			pictureBox34.Visible = true;
			pictureBox37.Visible = true;
			pictureBox29.Visible = true;
			pictureBox31.Visible = true;
			pictureBox33.Visible = true;
			pictureBox21.Visible = true;
			pictureBox22.Visible = true;
			pictureBox23.Visible = true;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s3 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s3 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s3 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s3 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s3 = "";
			}
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s4 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s4 = "blue";
				pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s4 = "black";
			}
			if (radioButton4.Checked == true)
			{
				s4 = "green";
				pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s4 = "";
			}
		}

		private void pictureBox39_MouseEnter(object sender, EventArgs e)
		{
			pictureBox39.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка1.png");
		}

		private void pictureBox39_MouseLeave(object sender, EventArgs e)
		{
			pictureBox39.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка.png");
		}

		private void pictureBox39_Click(object sender, EventArgs e)
		{
			if (s6 == "red" && s12 == "red" && s18 == "red" && s19 == "red" && s20 == "red" && s13 == "red" && s25 == "red" && s26 == "red" && s36 == "red" && s32 == "red" && s34 == "red" && s37 == "red" && s29 == "red" && s31 == "red" && s33 == "red" && s21 == "red" && s22 == "red" && s23 == "red" && s3 == "" && s4 == "" && s5 == "" && s7 == "" && s8 == "" && s9 == "" && s10 == "" && s11 == "" && s14 == "" && s15 == "" && s16 == "" && s17 == "" && s24 == "" && s27 == "" && s28 == "" && s30 == "" && s35 == "" && s38 == "")
				MessageBox.Show("Вірний візерунок!");
			else
				MessageBox.Show("Перевірте ваш візерунок ще раз!");
		}

		private void pictureBox40_Click(object sender, EventArgs e)
		{
			pictureBox41.Visible = true;
			pictureBox39.Visible = false;
			pictureBox43.Visible = false;
			pictureBox45.Visible = false;
			s3 = ""; s4 = ""; s5 = ""; s6 = ""; s7 = ""; s8 = ""; s9 = ""; s10 = ""; s11 = ""; s12 = ""; s13 = ""; s14 = ""; s15 = ""; s16 = ""; s17 = ""; s18 = ""; s19 = ""; s20 = ""; s21 = ""; s22 = ""; s23 = ""; s24 = ""; s25 = ""; s26 = ""; s27 = ""; s28 = ""; s29 = ""; s30 = ""; s31 = ""; s32 = ""; s33 = ""; s34 = ""; s35 = ""; s36 = ""; s37 = ""; s38 = "";
			this.BackgroundImage = Image.FromFile("Images\\Вышивка\\фон1.png");
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			pictureBox9.Visible = true;
			pictureBox10.Visible = true;
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox18.Visible = true;
			pictureBox13.Visible = true;
			pictureBox14.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			pictureBox17.Visible = true;
			pictureBox24.Visible = true;
			pictureBox27.Visible = true;
			pictureBox28.Visible = true;
			pictureBox30.Visible = true;
			pictureBox35.Visible = true;
			pictureBox38.Visible = true;
			pictureBox19.Visible = true;
			pictureBox20.Visible = true;
			pictureBox25.Visible = true;
			pictureBox26.Visible = true;
			pictureBox36.Visible = true;
			pictureBox32.Visible = true;
			pictureBox34.Visible = true;
			pictureBox37.Visible = true;
			pictureBox29.Visible = true;
			pictureBox31.Visible = true;
			pictureBox33.Visible = true;
			pictureBox21.Visible = true;
			pictureBox22.Visible = true;
			pictureBox23.Visible = true;
		}

		private void pictureBox41_MouseEnter(object sender, EventArgs e)
		{
			pictureBox41.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка1.png");
		}

		private void pictureBox41_MouseLeave(object sender, EventArgs e)
		{
			pictureBox41.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка.png");
		}

		private void pictureBox43_MouseEnter(object sender, EventArgs e)
		{
			pictureBox43.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка1.png");
		}

		private void pictureBox43_MouseLeave(object sender, EventArgs e)
		{
			pictureBox43.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка.png");
		}

		private void pictureBox42_Click(object sender, EventArgs e)
		{
			pictureBox41.Visible = false;
			pictureBox43.Visible = true;
			pictureBox39.Visible = false;
			pictureBox45.Visible = false;
			s3 = ""; s4 = ""; s5 = ""; s6 = ""; s7 = ""; s8 = ""; s9 = ""; s10 = ""; s11 = ""; s12 = ""; s13 = ""; s14 = ""; s15 = ""; s16 = ""; s17 = ""; s18 = ""; s19 = ""; s20 = ""; s21 = ""; s22 = ""; s23 = ""; s24 = ""; s25 = ""; s26 = ""; s27 = ""; s28 = ""; s29 = ""; s30 = ""; s31 = ""; s32 = ""; s33 = ""; s34 = ""; s35 = ""; s36 = ""; s37 = ""; s38 = "";
			this.BackgroundImage = Image.FromFile("Images\\Вышивка\\фон1.png");
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			pictureBox9.Visible = true;
			pictureBox10.Visible = true;
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox18.Visible = true;
			pictureBox13.Visible = true;
			pictureBox14.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			pictureBox17.Visible = true;
			pictureBox24.Visible = true;
			pictureBox27.Visible = true;
			pictureBox28.Visible = true;
			pictureBox30.Visible = true;
			pictureBox35.Visible = true;
			pictureBox38.Visible = true;
			pictureBox19.Visible = true;
			pictureBox20.Visible = true;
			pictureBox25.Visible = true;
			pictureBox26.Visible = true;
			pictureBox36.Visible = true;
			pictureBox32.Visible = true;
			pictureBox34.Visible = true;
			pictureBox37.Visible = true;
			pictureBox29.Visible = true;
			pictureBox31.Visible = true;
			pictureBox33.Visible = true;
			pictureBox21.Visible = true;
			pictureBox22.Visible = true;
			pictureBox23.Visible = true;
		}

		private void pictureBox43_Click(object sender, EventArgs e)
		{
			if (s5=="black"&& s6 == "black"&& s10 == "black" && s13 == "black" && s19 == "black" && s25 == "black" && s26 == "black" && s35 == "black" && s37 == "black" &&s15=="blue"&& s17 == "blue" && s21 == "blue" && s23 == "blue" && s29 == "blue"&&s3 == "" && s4 == "" && s7 == "" && s8 == "" && s9 == "" && s11 == "" && s12 == "" && s14 == "" && s16 == "" && s18 == "" && s20 == "" && s22 == "" && s24 == "" && s27 == "" && s28 == "" && s30 == "" && s31 == "" && s32 == "" && s33 == "" && s34 == "" && s36 == "" && s38 == "")
				MessageBox.Show("Вірний візерунок!");
			else
				MessageBox.Show("Перевірте ваш візерунок ще раз!");
		}

		private void pictureBox45_MouseEnter(object sender, EventArgs e)
		{
			pictureBox45.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка1.png");
		}

		private void pictureBox45_MouseLeave(object sender, EventArgs e)
		{
			pictureBox45.BackgroundImage = Image.FromFile("Images\\Вышивка\\перевірка.png");
		}

		private void pictureBox44_Click(object sender, EventArgs e)
		{
			pictureBox41.Visible = false;
			pictureBox45.Visible = true;
			pictureBox43.Visible = false;
			pictureBox39.Visible = false;
			s3 = ""; s4 = ""; s5 = ""; s6 = ""; s7 = ""; s8 = ""; s9 = ""; s10 = ""; s11 = ""; s12 = ""; s13 = ""; s14 = ""; s15 = ""; s16 = ""; s17 = ""; s18 = ""; s19 = ""; s20 = ""; s21 = ""; s22 = ""; s23 = ""; s24 = ""; s25 = ""; s26 = ""; s27 = ""; s28 = ""; s29 = ""; s30 = ""; s31 = ""; s32 = ""; s33 = ""; s34 = ""; s35 = ""; s36 = ""; s37 = ""; s38 = "";
			this.BackgroundImage = Image.FromFile("Images\\Вышивка\\фон1.png");
			pictureBox3.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox4.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			pictureBox7.Visible = true;
			pictureBox8.Visible = true;
			pictureBox9.Visible = true;
			pictureBox10.Visible = true;
			pictureBox11.Visible = true;
			pictureBox12.Visible = true;
			pictureBox18.Visible = true;
			pictureBox13.Visible = true;
			pictureBox14.Visible = true;
			pictureBox15.Visible = true;
			pictureBox16.Visible = true;
			pictureBox17.Visible = true;
			pictureBox24.Visible = true;
			pictureBox27.Visible = true;
			pictureBox28.Visible = true;
			pictureBox30.Visible = true;
			pictureBox35.Visible = true;
			pictureBox38.Visible = true;
			pictureBox19.Visible = true;
			pictureBox20.Visible = true;
			pictureBox25.Visible = true;
			pictureBox26.Visible = true;
			pictureBox36.Visible = true;
			pictureBox32.Visible = true;
			pictureBox34.Visible = true;
			pictureBox37.Visible = true;
			pictureBox29.Visible = true;
			pictureBox31.Visible = true;
			pictureBox33.Visible = true;
			pictureBox21.Visible = true;
			pictureBox22.Visible = true;
			pictureBox23.Visible = true;
		}

		private void pictureBox45_Click(object sender, EventArgs e)
		{
			if (s4=="black"&& s7 == "black" && s9 == "black" && s14 == "black" && s27 == "black" && s36 == "black" && s30 == "black" && s37 == "black" &&s10=="red"&& s13 == "red" && s17 == "red" && s18 == "red" && s23 == "red" && s24 == "red" && s29 == "red" && s35 == "red" && s3=="" && s5 == "" && s6 == "" && s8 == "" && s11 == "" && s12 == "" && s15 == "" && s16 == "" && s19 == "" && s20 == "" && s21 == "" && s22 == "" && s25 == "" && s26 == "" && s28 == "" && s31 == "" && s32 == "" && s33 == "" && s34 == "" && s38 == "")
				MessageBox.Show("Вірний візерунок!");
			else
				MessageBox.Show("Перевірте ваш візерунок ще раз!");
		}

		private void pictureBox41_Click(object sender, EventArgs e)
		{
			if (s5 == "green"&&s6 == "green" &&s10=="black"&& s13 == "black" && s15 == "black" && s20 == "black" &&s23=="red"&& s24 == "red" && s29 == "red" && s31 == "red" && s33 == "red" && s35 == "red" && s32 == "red" && s34 == "red" && s3 == "" && s4 == "" && s7 == "" && s8 == "" && s9 == "" && s11 == "" && s12 == "" && s14 == "" && s16 == "" && s17 == "" && s18 == "" && s19 == "" && s21 == "" && s22 == "" && s25 == "" && s26 == "" && s27 == "" && s28 == "" && s30 == "" && s36 == "" && s37 == "" && s38 == "")
				MessageBox.Show("Вірний візерунок!");
			else
				MessageBox.Show("Перевірте ваш візерунок ще раз!");
		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s5 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s5 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				s5 = "black";
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s5 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox5.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s5 = "";
			}
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s6 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s6 = "blue";
				pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s6 = "black";
				pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s6 = "green";
				pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox6.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s6 = "";
			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s7 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s7 = "blue";
				pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s7 = "black";
				pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s7 = "green";
				pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox7.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s7 = "";
			}
		}

		private void pictureBox8_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s8 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s8 = "blue";
				pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s8 = "black";
				pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s8 = "green";
				pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox8.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s8 = "";
			}
		}

		private void pictureBox9_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s9 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s9 = "blue";
				pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s9 = "black";
				pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s9 = "green";
				pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox9.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s9 = "";
			}
		}

		private void pictureBox10_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s10 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s10 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				s10 = "black";
				pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s10 = "green";
				pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox10.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s10 = "";
			}
		}

		private void pictureBox11_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s11 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s11 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s11 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s11 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox11.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s11 = "";
			}
		}

		private void pictureBox12_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s12 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s12 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s12 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s12 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox12.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s12 = "";
			}
		}

		private void pictureBox13_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s13 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s13 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s13 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s13 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox13.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s13 = "";
			}
		}

		private void pictureBox14_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s14 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s14 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s14 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s14 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox14.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s14 = "";
			}
		}

		private void pictureBox15_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s15 = "red";
				pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s15 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s15 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s15 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox15.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s15 = "";
			}
		}

		private void pictureBox16_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s16 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s16 = "blue";
				pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s16 = "black";
				pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s16 = "green";
				pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox16.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s16 = "";
			}
		}

		private void pictureBox17_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s17 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s17 = "blue";
				pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s17 = "black";
				pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s17 = "green";
				pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox17.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s17 = "";
			}
		}

		private void pictureBox18_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s18 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s18 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s18 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s18 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox18.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s18 = "";
			}
		}

		private void pictureBox19_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s19 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s19 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s19 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s19 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox19.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s19 = "";
			}
		}

		private void pictureBox20_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s20 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s20 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s20 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s20 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox20.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s20 = "";
			}
		}

		private void pictureBox21_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s21 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s21 = "blue";
				pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s21 = "black";
				pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s21 = "green";
				pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox21.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s21 = "";
			}
		}

		private void pictureBox22_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s22 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s22 = "blue";
				pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s22 = "black";
				pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s22 = "green";
				pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox22.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s22 = "";
			}
		}

		private void pictureBox23_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s23 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s23 = "blue";
				pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s23 = "black";
				pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s23 = "green";
				pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox23.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s23 = "";
			}
		}

		private void pictureBox24_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s24 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s24 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s24 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s24 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox24.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s24 = "";
			}
		}

		private void pictureBox25_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s25 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s25 = "blue";
				pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s25 = "black";
				pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s25 = "green";
				pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox25.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s25 = "";
			}
		}

		private void pictureBox26_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s26 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s26 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s26 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s26 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox26.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s26 = "";
			}
		}

		private void pictureBox27_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s27 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s27 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s27 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s27 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox27.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s27 = "";
			}
		}

		private void pictureBox29_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s29 = "red";
			}
			if (radioButton2.Checked == true)
			{
				s29 = "blue";
				pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s29 = "black";
				pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s29 = "green";
				pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox29.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s29 = "";
			}
		}

		private void pictureBox31_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
				s31 = "red";
			}
			if (radioButton2.Checked == true)
			{
				pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s31 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s31 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s31 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox31.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s31 = "";
			}
		}

		private void pictureBox33_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s33 = "red";
				pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s33 = "blue";
				pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s33 = "black";
				pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s33 = "green";
				pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox33.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s33 = "";
			}
		}

		private void pictureBox35_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s35 = "red";
				pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
				s35 = "blue";
			}
			if (radioButton3.Checked == true)
			{
				pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
				s35 = "black";
			}
			if (radioButton4.Checked == true)
			{
				pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
				s35 = "green";
			}
			if (radioButton5.Checked == true)
			{
				pictureBox35.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s35 = "";
			}
		}

		private void pictureBox36_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s36 = "red";
				pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s36 = "blue";
				pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s36 = "black";
				pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s36 = "green";
				pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox36.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s36 = "";
			}
		}

		private void pictureBox28_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s28 = "red";
				pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s28 = "blue";
				pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s28 = "black";
				pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s28 = "green";
				pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox28.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s28 = "";
			}
		}

		private void pictureBox30_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s30 = "red";
				pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s30 = "blue";
				pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s30 = "black";
				pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s30 = "green";
				pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox30.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s30 = "";
			}
		}

		private void pictureBox32_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s32 = "red";
				pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s32 = "blue";
				pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s32 = "black";
				pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s32 = "green";
				pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox32.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s32 = "";
			}
		}

		private void pictureBox34_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s34 = "red";
				pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s34 = "blue";
				pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s34 = "black";
				pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s34 = "green";
				pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox34.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s34 = "";
			}
		}

		private void pictureBox37_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s37 = "red";
				pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s37 = "blue";
				pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s37 = "black";
				pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s37 = "green";
				pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox37.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s37 = "";
			}
		}

		private void pictureBox38_Click(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				s38 = "red";
				pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\red.png");
			}
			if (radioButton2.Checked == true)
			{
				s38 = "blue";
				pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\blue.png");
			}
			if (radioButton3.Checked == true)
			{
				s38 = "black";
				pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\black.png");
			}
			if (radioButton4.Checked == true)
			{
				s38 = "green";
				pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\green.png");
			}
			if (radioButton5.Checked == true)
			{
				pictureBox38.BackgroundImage = Image.FromFile("Images\\Вышивка\\ex.png");
				s38 = "";
			}
		}
	}
}
