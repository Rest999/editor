using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3_rockman : Form
	{
		private IContainer components;

		private Label label1;

		private ComboBox comboBox1;

		private ComboBox comboBox2;

		private Label label2;

		private ComboBox comboBox3;

		private Label label3;

		private GroupBox groupBox1;

		private GroupBox groupBox2;

		private Label label8;

		private ComboBox comboBox8;

		private ComboBox comboBox9;

		private Label label9;

		private Label label4;

		private ComboBox comboBox4;

		private Label label5;

		private ComboBox comboBox5;

		private ComboBox comboBox6;

		private Label label6;

		private TextBox textBox1;

		private Button button2;

		private Button button1;

		public MMSF3_rockman()
		{
			this.InitializeComponent();
			Dictionary<string, string> strs = new Dictionary<string, string>()
			{
				{ "00\r\n", "No Noise" },
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
			Dictionary<string, string> strs1 = new Dictionary<string, string>()
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
			this.comboBox2.DataSource = new BindingSource(strs1, null);
			this.comboBox2.DisplayMember = "Value";
			this.comboBox2.ValueMember = "Key";
			Dictionary<string, string> strs2 = new Dictionary<string, string>()
			{
				{ "00\r\n", "No WC" },
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
			this.comboBox3.DataSource = new BindingSource(strs2, null);
			this.comboBox3.DisplayMember = "Value";
			this.comboBox3.ValueMember = "Key";
			Dictionary<string, string> strs3 = new Dictionary<string, string>()
			{
				{ "64\r\n", "No Noise Card" },
				{ "00\r\n", "Leo Kingdom N" },
				{ "01\r\n", "Moaian N" },
				{ "02\r\n", "Ox Fire N" },
				{ "03\r\n", "Raid Noise N" },
				{ "04\r\n", "Melamander N" },
				{ "05\r\n", "Koma N" },
				{ "06\r\n", "Doom Count N" },
				{ "07\r\n", "Ku'i N" },
				{ "08\r\n", "Mettenna N" },
				{ "09\r\n", "Bom N" },
				{ "0A\r\n", "Jack Corvus N" },
				{ "0B\r\n", "Hot Roader N" },
				{ "0C\r\n", "Boodach N" },
				{ "0D\r\n", "Scorcher N" },
				{ "0E\r\n", "Bubba Dance N" },
				{ "0F\r\n", "Sirius N" },
				{ "10\r\n", "Boom N" },
				{ "11\r\n", "Libra Scales N" },
				{ "12\r\n", "Musashi N" },
				{ "13\r\n", "War-Rock Copy N" },
				{ "14\r\n", "RockyG N" },
				{ "15\r\n", "HarpNote " },
				{ "16\r\n", "Grabity N" },
				{ "17\r\n", "Apollo Flame N" },
				{ "18\r\n", "Hare Jet N" },
				{ "19\r\n", "Blue Shark N" },
				{ "1A\r\n", "General Auriga N" },
				{ "1B\r\n", "Chakram N" },
				{ "1C\r\n", "Sno Roll N" },
				{ "1D\r\n", "Dia Ice Burn N" },
				{ "1E\r\n", "Octo Ninja N" },
				{ "1F\r\n", "Piran N" },
				{ "20\r\n", "Gooey N(" },
				{ "21\r\n", "Lu Pelvis N" },
				{ "22\r\n", "Pegasus Magic N" },
				{ "23\r\n", "Wibbledee N" },
				{ "24\r\n", "Stream Cancer N" },
				{ "25\r\n", "Spinguin N" },
				{ "26\r\n", "Junk-O N" },
				{ "27\r\n", "Jammer N" },
				{ "28\r\n", "Yeti Blizzard N" },
				{ "29\r\n", "Bone Archer N" },
				{ "2A\r\n", "Mal Wizard N" },
				{ "2B\r\n", "Cannon Base N" },
				{ "2C\r\n", "Brachio Wave N" },
				{ "2D\r\n", "Queen Virgo N" },
				{ "2E\r\n", "Air Squiggle N" },
				{ "2F\r\n", "Cancer Bubble N" },
				{ "30\r\n", "Voltragon N" },
				{ "31\r\n", "Moon Disaster N" },
				{ "32\r\n", "Boom Bolt N" },
				{ "33\r\n", "Eyez Noise N" },
				{ "34\r\n", "Dark Reaper N" },
				{ "35\r\n", "Phantom Black N" },
				{ "36\r\n", "Shock Mummy N" },
				{ "37\r\n", "Noise Wizard N" },
				{ "38\r\n", "Base Mortar N" },
				{ "39\r\n", "Great Axe N" },
				{ "3A\r\n", "Peakaboo N" },
				{ "3B\r\n", "Burai N" },
				{ "3C\r\n", "McCleaver N" },
				{ "3D\r\n", "Bell Gong N" },
				{ "3E\r\n", "Smiles N" },
				{ "3F\r\n", "Zapper N" },
				{ "40\r\n", "Crown Thunder N" },
				{ "41\r\n", "Lampis N" },
				{ "42\r\n", "Zap Ace N" },
				{ "43\r\n", "Hollow N" },
				{ "44\r\n", "Spade N" },
				{ "45\r\n", "Stealth N" },
				{ "46\r\n", "Magera N" },
				{ "47\r\n", "Gemini Spark N" },
				{ "48\r\n", "Mu Defender N" },
				{ "49\r\n", "Private Mop N" },
				{ "4A\r\n", "Wolf Woods N" },
				{ "4B\r\n", "Mono Sword N" },
				{ "4C\r\n", "Storm N" },
				{ "4D\r\n", "Grass N" },
				{ "4E\r\n", "Kung Foo N" },
				{ "4F\r\n", "Club Strong N" },
				{ "50\r\n", "Mat Jinn N" },
				{ "51\r\n", "Puff N" },
				{ "52\r\n", "Arachnid N" },
				{ "53\r\n", "Rhino Horn N" },
				{ "54\r\n", "Condor Geograph N" },
				{ "55\r\n", "Crowcar N" },
				{ "56\r\n", "Flit N" },
				{ "57\r\n", "Dragon Sky N" },
				{ "58\r\n", "Nutty N" },
				{ "59\r\n", "Tropi N" },
				{ "5A\r\n", "Fokx N" },
				{ "5B\r\n", "Murian N" },
				{ "5C\r\n", "Queen Ophiucus N" },
				{ "5D\r\n", "ShuriKen N" },
				{ "5E\r\n", "Cygnus WingN" },
				{ "5F\r\n", "Grave Joker N" },
				{ "60\r\n", "Andromeda N" },
				{ "61\r\n", "Acid Ace N" },
				{ "62\r\n", "Le Mu N" },
				{ "63\r\n", "Crimson Dragon N" }
			};
			this.comboBox6.DataSource = new BindingSource(strs3, null);
			this.comboBox6.DisplayMember = "Value";
			this.comboBox6.ValueMember = "Key";
			this.comboBox5.DataSource = new BindingSource(strs3, null);
			this.comboBox5.DisplayMember = "Value";
			this.comboBox5.ValueMember = "Key";
			this.comboBox4.DataSource = new BindingSource(strs3, null);
			this.comboBox4.DisplayMember = "Value";
			this.comboBox4.ValueMember = "Key";
			this.comboBox9.DataSource = new BindingSource(strs3, null);
			this.comboBox9.DisplayMember = "Value";
			this.comboBox9.ValueMember = "Key";
			this.comboBox8.DataSource = new BindingSource(strs3, null);
			this.comboBox8.DisplayMember = "Value";
			this.comboBox8.ValueMember = "Key";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new MMSF3_NKGlist()).Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string str = this.comboBox1.SelectedValue.ToString();
			string str1 = this.comboBox2.SelectedValue.ToString();
			string str2 = this.comboBox3.SelectedValue.ToString();
			string str3 = this.comboBox6.SelectedValue.ToString();
			string str4 = this.comboBox5.SelectedValue.ToString();
			string str5 = this.comboBox4.SelectedValue.ToString();
			string str6 = this.comboBox9.SelectedValue.ToString();
			string str7 = this.comboBox8.SelectedValue.ToString();
			this.textBox1.Text = string.Concat(new string[] { "220F39A0 000000", str, "220F399E 000000", str1, "220F39A1 000000", str2, "220FA0F4 000000", str3, "220FA0F6 000000", str4, "220FA0F8 000000", str5, "220FA0FA 000000", str6, "220FA0FC 000000", str7.ToString() });
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMSF3_rockman));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noise";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(73, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rezon";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(73, 76);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "White Card";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rockman Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.comboBox9);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(30, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 174);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Noise Card";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "No.05";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(60, 138);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 14;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(60, 109);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "No.04";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "No.03";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(60, 81);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "No.02";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(60, 53);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 8;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(60, 25);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "No.01";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 222);
            this.textBox1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Noise Card List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MMSF3_rockman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(433, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MMSF3_rockman";
            this.Text = "Rockman Settings";
            this.Load += new System.EventHandler(this.MMSF3_rockman_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void label5_Click(object sender, EventArgs e)
		{
		}

		private void MMSF3_rockman_Load(object sender, EventArgs e)
		{
		}
	}
}