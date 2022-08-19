using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3home : Form
	{
		private IContainer components;

		private GroupBox groupBox1;

		private Button button2;

		private Button button4;

		private Button button3;

		private Button button5;

		private Button button6;

		private Button button7;

		private Button button1;

		private Label label1;

		private Label label13;

		private Label label7;

		private ComboBox comboBox2;

		private ComboBox comboBox1;

		private Button button8;

		private TextBox textBox7;

		private ComboBox comboBox13;

		private GroupBox groupBox2;

		private ComboBox comboBox3;

		private ComboBox comboBox4;

		private ComboBox comboBox5;

		private Label label2;

		private Label label3;

		private Label label4;

		private GroupBox groupBox3;

		private ComboBox comboBox6;

		private ComboBox comboBox7;

		private ComboBox comboBox8;

		private Label label5;

		private Label label6;

		private Label label8;

		private GroupBox groupBox4;

		private ComboBox comboBox9;

		private ComboBox comboBox10;

		private ComboBox comboBox11;

		private Label label9;

		private Label label10;

		private Label label11;

		private GroupBox groupBox5;

		private ComboBox comboBox12;

		private ComboBox comboBox14;

		private ComboBox comboBox15;

		private Label label12;

		private Label label14;

		private Label label15;

		private GroupBox groupBox6;

		private ComboBox comboBox16;

		private ComboBox comboBox17;

		private ComboBox comboBox18;

		private Label label16;

		private Label label17;

		private Label label18;

		public MMSF3home()
		{
			this.InitializeComponent();
			Dictionary<string, string> strs = new Dictionary<string, string>()
			{
				{ "00\r\n", "No noise" },
				{ "01\r\n", "Libra" },
				{ "02\r\n", "Corvus" },
				{ "03\r\n", "Cancer" },
				{ "04\r\n", "Gemini" },
				{ "05\r\n", "Ophiucus" },
				{ "06\r\n", "Cygnus" },
				{ "07\r\n", "Ox" },
				{ "08\r\n", "Virgo" },
				{ "09\r\n", "Crown" },
				{ "0A\r\n", "Wolf" },
				{ "0B\r\n", "Burai" }
			};
			this.comboBox1.DataSource = new BindingSource(strs, null);
			this.comboBox1.DisplayMember = "Value";
			this.comboBox1.ValueMember = "Key";
			this.comboBox11.DataSource = new BindingSource(strs, null);
			this.comboBox11.DisplayMember = "Value";
			this.comboBox11.ValueMember = "Key";
			this.comboBox18.DataSource = new BindingSource(strs, null);
			this.comboBox18.DisplayMember = "Value";
			this.comboBox18.ValueMember = "Key";
			this.comboBox5.DataSource = new BindingSource(strs, null);
			this.comboBox5.DisplayMember = "Value";
			this.comboBox5.ValueMember = "Key";
			this.comboBox8.DataSource = new BindingSource(strs, null);
			this.comboBox8.DisplayMember = "Value";
			this.comboBox8.ValueMember = "Key";
			this.comboBox15.DataSource = new BindingSource(strs, null);
			this.comboBox15.DisplayMember = "Value";
			this.comboBox15.ValueMember = "Key";
			Dictionary<string, string> strs1 = new Dictionary<string, string>()
			{
				{ "00\r\n", "NO WC" },
				{ "01\r\n", "01" },
				{ "02\r\n", "02" },
				{ "03\r\n", "03" },
				{ "04\r\n", "04" },
				{ "05\r\n", "05" },
				{ "06\r\n", "06" },
				{ "07\r\n", "07" },
				{ "08\r\n", "08" },
				{ "09\r\n", "09" },
				{ "0A\r\n", "0A" },
				{ "0B\r\n", "0B" },
				{ "0C\r\n", "0C" },
				{ "0D\r\n", "0D" },
				{ "0E\r\n", "0E" },
				{ "0F\r\n", "0F" },
				{ "10\r\n", "10" },
				{ "11\r\n", "11" },
				{ "12\r\n", "12" },
				{ "13\r\n", "13" },
				{ "14\r\n", "14" },
				{ "15\r\n", "15" },
				{ "16\r\n", "16" },
				{ "17\r\n", "17" },
				{ "18\r\n", "18" },
				{ "19\r\n", "19" },
				{ "1A\r\n", "1A" },
				{ "1B\r\n", "1B" },
				{ "1C\r\n", "1C" },
				{ "1D\r\n", "1D" },
				{ "1E\r\n", "1E" },
				{ "1F\r\n", "1F" },
				{ "20\r\n", "20" },
				{ "21\r\n", "21" },
				{ "22\r\n", "22" },
				{ "23\r\n", "23" },
				{ "24\r\n", "24" },
				{ "25\r\n", "25" },
				{ "26\r\n", "26" },
				{ "27\r\n", "27" },
				{ "28\r\n", "28" },
				{ "29\r\n", "29" },
				{ "2A\r\n", "2A" },
				{ "2B\r\n", "2B" },
				{ "2C\r\n", "2C" },
				{ "2D\r\n", "2D" },
				{ "2E\r\n", "2E" },
				{ "2F\r\n", "2F" },
				{ "30\r\n", "30" },
				{ "31\r\n", "31" },
				{ "32\r\n", "32" },
				{ "33\r\n", "33" },
				{ "34\r\n", "34" },
				{ "35\r\n", "35" },
				{ "36\r\n", "36" },
				{ "37\r\n", "37" },
				{ "38\r\n", "38" },
				{ "39\r\n", "39" },
				{ "3A\r\n", "3A" },
				{ "3B\r\n", "3B" },
				{ "3C\r\n", "3C" },
				{ "3D\r\n", "3D" },
				{ "3E\r\n", "3E" },
				{ "3F\r\n", "3F" },
				{ "40\r\n", "40" },
				{ "41\r\n", "41" },
				{ "42\r\n", "42" },
				{ "43\r\n", "43" },
				{ "44\r\n", "44" },
				{ "45\r\n", "45" },
				{ "46\r\n", "46" },
				{ "47\r\n", "47" },
				{ "48\r\n", "48" },
				{ "49\r\n", "49" },
				{ "4A\r\n", "4A" },
				{ "4B\r\n", "4B" },
				{ "4C\r\n", "4C" },
				{ "4D\r\n", "4D" },
				{ "4E\r\n", "4E" },
				{ "4F\r\n", "4F" },
				{ "50\r\n", "50" },
				{ "51\r\n", "51" },
				{ "52\r\n", "52" },
				{ "53\r\n", "53" },
				{ "54\r\n", "54" },
				{ "55\r\n", "55" },
				{ "56\r\n", "56" },
				{ "57\r\n", "57" },
				{ "58\r\n", "58" },
				{ "59\r\n", "59" },
				{ "5A\r\n", "5A" },
				{ "5B\r\n", "5B" },
				{ "5C\r\n", "5C" },
				{ "5D\r\n", "5D" },
				{ "5E\r\n", "5E" },
				{ "5F\r\n", "5F" },
				{ "60\r\n", "60" }
			};
			this.comboBox13.DataSource = new BindingSource(strs1, null);
			this.comboBox13.DisplayMember = "Value";
			this.comboBox13.ValueMember = "Key";
			this.comboBox9.DataSource = new BindingSource(strs1, null);
			this.comboBox9.DisplayMember = "Value";
			this.comboBox9.ValueMember = "Key";
			this.comboBox16.DataSource = new BindingSource(strs1, null);
			this.comboBox16.DisplayMember = "Value";
			this.comboBox16.ValueMember = "Key";
			this.comboBox3.DataSource = new BindingSource(strs1, null);
			this.comboBox3.DisplayMember = "Value";
			this.comboBox3.ValueMember = "Key";
			this.comboBox6.DataSource = new BindingSource(strs1, null);
			this.comboBox6.DisplayMember = "Value";
			this.comboBox6.ValueMember = "Key";
			this.comboBox12.DataSource = new BindingSource(strs1, null);
			this.comboBox12.DisplayMember = "Value";
			this.comboBox12.ValueMember = "Key";
			Dictionary<string, string> strs2 = new Dictionary<string, string>()
			{
				{ "00\r\n", "Battle" },
				{ "01\r\n", "Fire" },
				{ "02\r\n", "Aqua" },
				{ "03\r\n", "Thunder" },
				{ "04\r\n", "Wood" },
				{ "05\r\n", "Sword" },
				{ "06\r\n", "Break" },
				{ "07\r\n", "Guard" },
				{ "08\r\n", "Paralyze" },
				{ "09\r\n", "Finalize" }
			};
			this.comboBox2.DataSource = new BindingSource(strs2, null);
			this.comboBox2.DisplayMember = "Value";
			this.comboBox2.ValueMember = "Key";
			this.comboBox10.DataSource = new BindingSource(strs2, null);
			this.comboBox10.DisplayMember = "Value";
			this.comboBox10.ValueMember = "Key";
			this.comboBox17.DataSource = new BindingSource(strs2, null);
			this.comboBox17.DisplayMember = "Value";
			this.comboBox17.ValueMember = "Key";
			this.comboBox4.DataSource = new BindingSource(strs2, null);
			this.comboBox4.DisplayMember = "Value";
			this.comboBox4.ValueMember = "Key";
			this.comboBox7.DataSource = new BindingSource(strs2, null);
			this.comboBox7.DisplayMember = "Value";
			this.comboBox7.ValueMember = "Key";
			this.comboBox14.DataSource = new BindingSource(strs2, null);
			this.comboBox14.DisplayMember = "Value";
			this.comboBox14.ValueMember = "Key";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new MMSF3_readme()).Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			(new MMSF3_noiselist()).Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			(new MMSF3_rezonlist()).Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			(new MMSF3_wclist()).Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			(new MMSF3_brorl()).Show();
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			(new MMSF3_SSS()).Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
		}

		private void button7_Click_1(object sender, EventArgs e)
		{
			string str = this.comboBox1.SelectedValue.ToString();
			string str1 = this.comboBox2.SelectedValue.ToString();
			string str2 = this.comboBox13.SelectedValue.ToString();
			string str3 = this.comboBox11.SelectedValue.ToString();
			string str4 = this.comboBox10.SelectedValue.ToString();
			string str5 = this.comboBox9.SelectedValue.ToString();
			string str6 = this.comboBox18.SelectedValue.ToString();
			string str7 = this.comboBox17.SelectedValue.ToString();
			string str8 = this.comboBox16.SelectedValue.ToString();
			string str9 = this.comboBox5.SelectedValue.ToString();
			string str10 = this.comboBox4.SelectedValue.ToString();
			string str11 = this.comboBox3.SelectedValue.ToString();
			string str12 = this.comboBox8.SelectedValue.ToString();
			string str13 = this.comboBox7.SelectedValue.ToString();
			string str14 = this.comboBox6.SelectedValue.ToString();
			string str15 = this.comboBox15.SelectedValue.ToString();
			string str16 = this.comboBox14.SelectedValue.ToString();
			string str17 = this.comboBox12.SelectedValue.ToString();
			this.textBox7.Text = string.Concat(new string[] { "220F3FE0 000000", str, "220F3FDE 000000", str1, "220F3FE1 000000", str2, "\r\n220F4620 000000", str3, "220F461E 000000", str4, "220F4621 000000", str5, "\r\n220F4C60 000000", str6, "220F4C5E 000000", str7, "220F4C61 000000", str8, "\r\n220F52A0 000000", str9, "220F529E 000000", str10, "220F52A1 000000", str11, "\r\n220F58E0 000000", str12, "220F58DE 000000", str13, "220F58E1 000000", str14, "\r\n220F5F20 000000", str15, "220F5F1E 000000", str16, "220F5F21 000000", str17, "\r\n".ToString() });
		}

		private void button8_Click(object sender, EventArgs e)
		{
			(new MMSF3_rockman()).Show();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		private void groupBox5_Enter(object sender, EventArgs e)
		{
		}

		private void groupBox6_Enter(object sender, EventArgs e)
		{
		}

		private void groupBox7_Enter(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMSF3home));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox13);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brother 1 (Top Left)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Location = new System.Drawing.Point(96, 68);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(98, 21);
            this.comboBox13.TabIndex = 18;
            this.comboBox13.Text = "       ";
            // 
            // comboBox2
            // 
            this.comboBox2.Location = new System.Drawing.Point(96, 101);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "       ";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "       ";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Rezon Card";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "White Card";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brother\'s Noise";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "How to use";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Noise List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(427, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "White Card List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(427, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 31);
            this.button3.TabIndex = 9;
            this.button3.Text = "Rezon Card List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(427, 203);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(183, 31);
            this.button5.TabIndex = 10;
            this.button5.Text = "SSS Setting";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(427, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(183, 31);
            this.button6.TabIndex = 11;
            this.button6.Text = "Brother Roulette";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(427, 278);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(183, 31);
            this.button7.TabIndex = 12;
            this.button7.Text = "Generate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(427, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(183, 31);
            this.button8.TabIndex = 24;
            this.button8.Text = "Rockman Setting";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(427, 319);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(183, 146);
            this.textBox7.TabIndex = 25;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(215, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 146);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brother 4 (Top Right)";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(96, 68);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(98, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.Text = "       ";
            // 
            // comboBox4
            // 
            this.comboBox4.Location = new System.Drawing.Point(96, 101);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(98, 21);
            this.comboBox4.TabIndex = 17;
            this.comboBox4.Text = "       ";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(96, 35);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(98, 21);
            this.comboBox5.TabIndex = 16;
            this.comboBox5.Text = "       ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rezon Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "White Card";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Brother\'s Noise";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Controls.Add(this.comboBox7);
            this.groupBox3.Controls.Add(this.comboBox8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(215, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 146);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brother 5 (Middle Right)";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(96, 68);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(98, 21);
            this.comboBox6.TabIndex = 18;
            this.comboBox6.Text = "       ";
            // 
            // comboBox7
            // 
            this.comboBox7.Location = new System.Drawing.Point(96, 101);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(98, 21);
            this.comboBox7.TabIndex = 17;
            this.comboBox7.Text = "       ";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(96, 35);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(98, 21);
            this.comboBox8.TabIndex = 16;
            this.comboBox8.Text = "       ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Rezon Card";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "White Card";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Brother\'s Noise";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.comboBox9);
            this.groupBox4.Controls.Add(this.comboBox10);
            this.groupBox4.Controls.Add(this.comboBox11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 146);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Brother 2 (Middle Left)";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(96, 68);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(98, 21);
            this.comboBox9.TabIndex = 18;
            this.comboBox9.Text = "       ";
            // 
            // comboBox10
            // 
            this.comboBox10.Location = new System.Drawing.Point(96, 101);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(98, 21);
            this.comboBox10.TabIndex = 17;
            this.comboBox10.Text = "       ";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(96, 35);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(98, 21);
            this.comboBox11.TabIndex = 16;
            this.comboBox11.Text = "       ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rezon Card";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "White Card";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Brother\'s Noise";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.comboBox12);
            this.groupBox5.Controls.Add(this.comboBox14);
            this.groupBox5.Controls.Add(this.comboBox15);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(215, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 146);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Brother 6  (Bottom Right)";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(96, 68);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(98, 21);
            this.comboBox12.TabIndex = 18;
            this.comboBox12.Text = "       ";
            // 
            // comboBox14
            // 
            this.comboBox14.Location = new System.Drawing.Point(96, 101);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(98, 21);
            this.comboBox14.TabIndex = 17;
            this.comboBox14.Text = "       ";
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(96, 35);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(98, 21);
            this.comboBox15.TabIndex = 16;
            this.comboBox15.Text = "       ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Rezon Card";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "White Card";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Brother\'s Noise";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.comboBox16);
            this.groupBox6.Controls.Add(this.comboBox17);
            this.groupBox6.Controls.Add(this.comboBox18);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(6, 319);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 146);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Brother 3 (Bottom Left)";
            // 
            // comboBox16
            // 
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Location = new System.Drawing.Point(96, 68);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(98, 21);
            this.comboBox16.TabIndex = 18;
            this.comboBox16.Text = "       ";
            // 
            // comboBox17
            // 
            this.comboBox17.Location = new System.Drawing.Point(96, 101);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(98, 21);
            this.comboBox17.TabIndex = 17;
            this.comboBox17.Text = "       ";
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Location = new System.Drawing.Point(96, 35);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(98, 21);
            this.comboBox18.TabIndex = 16;
            this.comboBox18.Text = "       ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Rezon Card";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "White Card";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Brother\'s Noise";
            // 
            // MMSF3home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(629, 493);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MMSF3home";
            this.Text = "SSR3 Editor - ver.BA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void label13_Click(object sender, EventArgs e)
		{
		}

		private void label3_Click(object sender, EventArgs e)
		{
		}

		private void label6_Click(object sender, EventArgs e)
		{
		}

		private void label7_Click(object sender, EventArgs e)
		{
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
		}
	}
}