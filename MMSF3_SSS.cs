using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3_SSS : Form
	{
		private IContainer components;

		private Label label2;

		private GroupBox groupBox1;

		private ComboBox comboBox5;

		private ComboBox comboBox4;

		private ComboBox comboBox3;

		private ComboBox comboBox2;

		private ComboBox comboBox1;

		private ComboBox comboBox6;

		private GroupBox groupBox2;

		private Button button1;

		private Button button4;

		private Label label1;

		private Label label3;

		private Button button7;

		private TextBox textBox1;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;
        private Label label10;
        private Label label4;

		public MMSF3_SSS()
		{
			this.InitializeComponent();
			Dictionary<string, string> strs = new Dictionary<string, string>()
			{
				{ "zz", "Satellite Server" },
				{ "01\r\n", "Lv01" },
				{ "02\r\n", "Lv02" },
				{ "03\r\n", "Lv03" },
				{ "04\r\n", "Lv04" },
				{ "05\r\n", "Lv05" },
				{ "06\r\n", "Lv06" },
				{ "07\r\n", "Lv07" },
				{ "08\r\n", "Lv08" },
				{ "09\r\n", "Lv09" },
				{ "0A\r\n", "Lv10" },
				{ "0B\r\n", "Lv11" },
				{ "0C\r\n", "Lv12" },
				{ "0D\r\n", "Lv13" },
				{ "0E\r\n", "Lv14" },
				{ "0F\r\n", "Lv15" },
				{ "10\r\n", "Lv16" },
				{ "11\r\n", "Lv17" },
				{ "12\r\n", "Lv18" },
				{ "13\r\n", "Lv19" },
				{ "14\r\n", "Lv20" },
				{ "15\r\n", "Lv21" },
				{ "16\r\n", "Lv22" },
				{ "17\r\n", "Lv23" },
				{ "18\r\n", "Lv24" },
				{ "19\r\n", "Lv25" },
				{ "1A\r\n", "Lv26" },
				{ "1B\r\n", "Lv27" },
				{ "1C\r\n", "Lv28" },
				{ "1D\r\n", "Lv29" },
				{ "1E\r\n", "Lv30" },
				{ "1F\r\n", "Lv31" },
				{ "20\r\n", "Lv32" },
				{ "zw", "Meteor Server" },
				{ "21\r\n", "Lv01" },
				{ "22\r\n", "Lv02" },
				{ "23\r\n", "Lv03" },
				{ "24\r\n", "Lv04" },
				{ "25\r\n", "Lv05" },
				{ "26\r\n", "Lv06" },
				{ "27\r\n", "Lv07" },
				{ "28\r\n", "Lv08" },
				{ "29\r\n", "Lv09" },
				{ "2A\r\n", "Lv10" },
				{ "2B\r\n", "Lv11" },
				{ "2C\r\n", "Lv12" },
				{ "2D\r\n", "Lv13" },
				{ "2E\r\n", "Lv14" },
				{ "2F\r\n", "Lv15" },
				{ "30\r\n", "Lv16" },
				{ "31\r\n", "Lv17" },
				{ "32\r\n", "Lv18" },
				{ "33\r\n", "Lv19" },
				{ "34\r\n", "Lv20" },
				{ "35\r\n", "Lv21" },
				{ "36\r\n", "Lv22" },
				{ "37\r\n", "Lv23" },
				{ "38\r\n", "Lv24" }
			};
			this.comboBox1.DataSource = new BindingSource(strs, null);
			this.comboBox1.DisplayMember = "Value";
			this.comboBox1.ValueMember = "Key";
			this.comboBox2.DataSource = new BindingSource(strs, null);
			this.comboBox2.DisplayMember = "Value";
			this.comboBox2.ValueMember = "Key";
			this.comboBox3.DataSource = new BindingSource(strs, null);
			this.comboBox3.DisplayMember = "Value";
			this.comboBox3.ValueMember = "Key";
			this.comboBox4.DataSource = new BindingSource(strs, null);
			this.comboBox4.DisplayMember = "Value";
			this.comboBox4.ValueMember = "Key";
			this.comboBox5.DataSource = new BindingSource(strs, null);
			this.comboBox5.DisplayMember = "Value";
			this.comboBox5.ValueMember = "Key";
			this.comboBox6.DataSource = new BindingSource(strs, null);
			this.comboBox6.DisplayMember = "Value";
			this.comboBox6.ValueMember = "Key";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			(new MMSF3_SSSlistS()).Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
		}

		private void button4_Click(object sender, EventArgs e)
		{
		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			(new MMSF3_SSSlistM()).Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string str = this.comboBox1.SelectedValue.ToString();
			string str1 = this.comboBox2.SelectedValue.ToString();
			string str2 = this.comboBox3.SelectedValue.ToString();
			string str3 = this.comboBox4.SelectedValue.ToString();
			string str4 = this.comboBox5.SelectedValue.ToString();
			string str5 = this.comboBox6.SelectedValue.ToString();
			//this.textBox1.Text = string.Concat(new string[] { /*"220F65E8 00000003\r\n220F391D 00000005\r\n220F65EE 000000", str, *//*"\r\n\r\n220F6604 00000003\r\n220F3921 00000005\r\n220F660A 000000", str1,*/ /*"\r\n\r\n220F6620 00000003\r\n220F3925 00000005\r\n220F6626 000000", str2,*/ /*"\r\n\r\n220F663C 00000003\r\n220F3929 00000005\r\n220F6642 000000", str3,*/ /*"\r\n\r\n220F6658 00000003\r\n220F392D 00000005\r\n220F665E 000000", str4,*/ "\r\n\r\n220F6674 00000003\r\n220F3931 00000005\r\n220F667A 000000", str5.ToString() });

            //Stores the final SSS code. 
            string finalCode = "";

            //Adds each SSS to the final code if the user didn't choose Satellite Server or Meteor server. 
            if (!string.Equals(comboBox1.Text, "Satellite Server") || string.Equals(comboBox1.Text, "Meteor Server"))
            {
                finalCode += string.Concat(new string[] { "220F65E8 00000003\r\n220F391D 00000005\r\n220F65EE 000000", str.ToString() });
            }

            if (!string.Equals(comboBox2.Text, "Satellite Server") || string.Equals(comboBox2.Text, "Meteor Server"))
            {
                finalCode += string.Concat(new string[] { "\r\n\r\n220F6604 00000003\r\n220F3921 00000005\r\n220F660A 000000", str1.ToString() });
            }

            if (!string.Equals(comboBox3.Text, "Satellite Server") || string.Equals(comboBox3.Text, "Meteor Server"))
            {
                finalCode += string.Concat(new string[] { "\r\n\r\n220F6620 00000003\r\n220F3925 00000005\r\n220F6626 000000", str2.ToString() });

            }

            if (!string.Equals(comboBox4.Text, "Satellite Server") || string.Equals(comboBox4.Text, "Meteor Server"))
            {
                finalCode += string.Concat(new string[] { "\r\n\r\n220F663C 00000003\r\n220F3929 00000005\r\n220F6642 000000", str3.ToString() });
            }

            if (!string.Equals(comboBox5.Text, "Satellite Server") || string.Equals(comboBox5.Text, "Meteor Server"))
            {
                finalCode += string.Concat(new string[] { "\r\n\r\n220F6658 00000003\r\n220F392D 00000005\r\n220F665E 000000", str4.ToString() });
            }

            if (!string.Equals(comboBox6.Text, "Satellite Server") || string.Equals(comboBox6.Text, "Meteor Server"))
            {
                finalCode += string.Concat(new string[] { "\r\n\r\n220F6674 00000003\r\n220F3931 00000005\r\n220F667A 000000", str5.ToString() });
            }

            this.textBox1.Text = finalCode;

        }

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
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

		private void groupBox2_Enter(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMSF3_SSS));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Mincho", 24F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 33);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 99);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SSS setting (Up to 3 slots in normal play)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bottom Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Middle Right";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Top Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bottom Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Middle Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Top Left";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "---サテライトサーバー---",
            "Lv.01オックス",
            "Lv.02キャンサー",
            "Lv.03ダイヤ",
            "Lv.04オヒュカス",
            "Lv.05クラウン",
            "Lv.06ブラキオ",
            "Lv.07ゴート",
            "Lv.08キグナス",
            "Lv.09ハープ",
            "Lv.10クラブ",
            "Lv.11アポロン",
            "Lv.12ファントム",
            "Lv.13レオ",
            "Lv.14エンプティー",
            "Lv.15ウルフ",
            "Lv.16ジェミニ",
            "Lv.17リブラ",
            "Lv.18コーヴァス",
            "Lv.19コンドル",
            "Lv.20ムーン",
            "Lv.21スペード",
            "Lv.22オリガ",
            "Lv.23ヴァルゴ",
            "Lv.24ペガサス",
            "Lv.25エース",
            "Lv.26アンドロメダ",
            "Lv.27ブライ",
            "Lv.28ブルース",
            "Lv.29ドラゴン",
            "Lv.30ジョーカー",
            "Lv.31ラ・ムー",
            "Lv.32フォルテ",
            "---流星サーバー---",
            "Lv.01アルファ",
            "Lv.02ベータ",
            "Lv.03ガンマ",
            "Lv.04デルタ",
            "Lv.05イプシロン",
            "Lv.06ゼータ",
            "Lv.07イータ",
            "Lv.08シータ",
            "Lv.09イオタ",
            "Lv.10カッパ",
            "Lv.11ラムダ",
            "Lv.12ミュー",
            "Lv.13ニュー",
            "Lv.14クサイ",
            "Lv.15オミクロン",
            "Lv.16パイ",
            "Lv.17ロー",
            "Lv.18シグマ",
            "Lv.19タウ",
            "Lv.20ユプシロン",
            "Lv.21ファイ",
            "Lv.22カイ",
            "Lv.23プサイ",
            "Lv.24オメガ"});
            this.comboBox6.Location = new System.Drawing.Point(263, 67);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(103, 21);
            this.comboBox6.TabIndex = 14;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "---サテライトサーバー---",
            "Lv.01オックス",
            "Lv.02キャンサー",
            "Lv.03ダイヤ",
            "Lv.04オヒュカス",
            "Lv.05クラウン",
            "Lv.06ブラキオ",
            "Lv.07ゴート",
            "Lv.08キグナス",
            "Lv.09ハープ",
            "Lv.10クラブ",
            "Lv.11アポロン",
            "Lv.12ファントム",
            "Lv.13レオ",
            "Lv.14エンプティー",
            "Lv.15ウルフ",
            "Lv.16ジェミニ",
            "Lv.17リブラ",
            "Lv.18コーヴァス",
            "Lv.19コンドル",
            "Lv.20ムーン",
            "Lv.21スペード",
            "Lv.22オリガ",
            "Lv.23ヴァルゴ",
            "Lv.24ペガサス",
            "Lv.25エース",
            "Lv.26アンドロメダ",
            "Lv.27ブライ",
            "Lv.28ブルース",
            "Lv.29ドラゴン",
            "Lv.30ジョーカー",
            "Lv.31ラ・ムー",
            "Lv.32フォルテ",
            "---流星サーバー---",
            "Lv.01アルファ",
            "Lv.02ベータ",
            "Lv.03ガンマ",
            "Lv.04デルタ",
            "Lv.05イプシロン",
            "Lv.06ゼータ",
            "Lv.07イータ",
            "Lv.08シータ",
            "Lv.09イオタ",
            "Lv.10カッパ",
            "Lv.11ラムダ",
            "Lv.12ミュー",
            "Lv.13ニュー",
            "Lv.14クサイ",
            "Lv.15オミクロン",
            "Lv.16パイ",
            "Lv.17ロー",
            "Lv.18シグマ",
            "Lv.19タウ",
            "Lv.20ユプシロン",
            "Lv.21ファイ",
            "Lv.22カイ",
            "Lv.23プサイ",
            "Lv.24オメガ"});
            this.comboBox5.Location = new System.Drawing.Point(263, 43);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(103, 21);
            this.comboBox5.TabIndex = 13;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "---サテライトサーバー---",
            "Lv.01オックス",
            "Lv.02キャンサー",
            "Lv.03ダイヤ",
            "Lv.04オヒュカス",
            "Lv.05クラウン",
            "Lv.06ブラキオ",
            "Lv.07ゴート",
            "Lv.08キグナス",
            "Lv.09ハープ",
            "Lv.10クラブ",
            "Lv.11アポロン",
            "Lv.12ファントム",
            "Lv.13レオ",
            "Lv.14エンプティー",
            "Lv.15ウルフ",
            "Lv.16ジェミニ",
            "Lv.17リブラ",
            "Lv.18コーヴァス",
            "Lv.19コンドル",
            "Lv.20ムーン",
            "Lv.21スペード",
            "Lv.22オリガ",
            "Lv.23ヴァルゴ",
            "Lv.24ペガサス",
            "Lv.25エース",
            "Lv.26アンドロメダ",
            "Lv.27ブライ",
            "Lv.28ブルース",
            "Lv.29ドラゴン",
            "Lv.30ジョーカー",
            "Lv.31ラ・ムー",
            "Lv.32フォルテ",
            "---流星サーバー---",
            "Lv.01アルファ",
            "Lv.02ベータ",
            "Lv.03ガンマ",
            "Lv.04デルタ",
            "Lv.05イプシロン",
            "Lv.06ゼータ",
            "Lv.07イータ",
            "Lv.08シータ",
            "Lv.09イオタ",
            "Lv.10カッパ",
            "Lv.11ラムダ",
            "Lv.12ミュー",
            "Lv.13ニュー",
            "Lv.14クサイ",
            "Lv.15オミクロン",
            "Lv.16パイ",
            "Lv.17ロー",
            "Lv.18シグマ",
            "Lv.19タウ",
            "Lv.20ユプシロン",
            "Lv.21ファイ",
            "Lv.22カイ",
            "Lv.23プサイ",
            "Lv.24オメガ"});
            this.comboBox3.Location = new System.Drawing.Point(78, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(103, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "---サテライトサーバー---",
            "Lv.01オックス",
            "Lv.02キャンサー",
            "Lv.03ダイヤ",
            "Lv.04オヒュカス",
            "Lv.05クラウン",
            "Lv.06ブラキオ",
            "Lv.07ゴート",
            "Lv.08キグナス",
            "Lv.09ハープ",
            "Lv.10クラブ",
            "Lv.11アポロン",
            "Lv.12ファントム",
            "Lv.13レオ",
            "Lv.14エンプティー",
            "Lv.15ウルフ",
            "Lv.16ジェミニ",
            "Lv.17リブラ",
            "Lv.18コーヴァス",
            "Lv.19コンドル",
            "Lv.20ムーン",
            "Lv.21スペード",
            "Lv.22オリガ",
            "Lv.23ヴァルゴ",
            "Lv.24ペガサス",
            "Lv.25エース",
            "Lv.26アンドロメダ",
            "Lv.27ブライ",
            "Lv.28ブルース",
            "Lv.29ドラゴン",
            "Lv.30ジョーカー",
            "Lv.31ラ・ムー",
            "Lv.32フォルテ",
            "---流星サーバー---",
            "Lv.01アルファ",
            "Lv.02ベータ",
            "Lv.03ガンマ",
            "Lv.04デルタ",
            "Lv.05イプシロン",
            "Lv.06ゼータ",
            "Lv.07イータ",
            "Lv.08シータ",
            "Lv.09イオタ",
            "Lv.10カッパ",
            "Lv.11ラムダ",
            "Lv.12ミュー",
            "Lv.13ニュー",
            "Lv.14クサイ",
            "Lv.15オミクロン",
            "Lv.16パイ",
            "Lv.17ロー",
            "Lv.18シグマ",
            "Lv.19タウ",
            "Lv.20ユプシロン",
            "Lv.21ファイ",
            "Lv.22カイ",
            "Lv.23プサイ",
            "Lv.24オメガ"});
            this.comboBox4.Location = new System.Drawing.Point(263, 20);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(103, 21);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "---サテライトサーバー---",
            "Lv.01オックス",
            "Lv.02キャンサー",
            "Lv.03ダイヤ",
            "Lv.04オヒュカス",
            "Lv.05クラウン",
            "Lv.06ブラキオ",
            "Lv.07ゴート",
            "Lv.08キグナス",
            "Lv.09ハープ",
            "Lv.10クラブ",
            "Lv.11アポロン",
            "Lv.12ファントム",
            "Lv.13レオ",
            "Lv.14エンプティー",
            "Lv.15ウルフ",
            "Lv.16ジェミニ",
            "Lv.17リブラ",
            "Lv.18コーヴァス",
            "Lv.19コンドル",
            "Lv.20ムーン",
            "Lv.21スペード",
            "Lv.22オリガ",
            "Lv.23ヴァルゴ",
            "Lv.24ペガサス",
            "Lv.25エース",
            "Lv.26アンドロメダ",
            "Lv.27ブライ",
            "Lv.28ブルース",
            "Lv.29ドラゴン",
            "Lv.30ジョーカー",
            "Lv.31ラ・ムー",
            "Lv.32フォルテ",
            "---流星サーバー---",
            "Lv.01アルファ",
            "Lv.02ベータ",
            "Lv.03ガンマ",
            "Lv.04デルタ",
            "Lv.05イプシロン",
            "Lv.06ゼータ",
            "Lv.07イータ",
            "Lv.08シータ",
            "Lv.09イオタ",
            "Lv.10カッパ",
            "Lv.11ラムダ",
            "Lv.12ミュー",
            "Lv.13ニュー",
            "Lv.14クサイ",
            "Lv.15オミクロン",
            "Lv.16パイ",
            "Lv.17ロー",
            "Lv.18シグマ",
            "Lv.19タウ",
            "Lv.20ユプシロン",
            "Lv.21ファイ",
            "Lv.22カイ",
            "Lv.23プサイ",
            "Lv.24オメガ"});
            this.comboBox2.Location = new System.Drawing.Point(78, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "---サテライトサーバー---",
            "Lv.01オックス",
            "Lv.02キャンサー",
            "Lv.03ダイヤ",
            "Lv.04オヒュカス",
            "Lv.05クラウン",
            "Lv.06ブラキオ",
            "Lv.07ゴート",
            "Lv.08キグナス",
            "Lv.09ハープ",
            "Lv.10クラブ",
            "Lv.11アポロン",
            "Lv.12ファントム",
            "Lv.13レオ",
            "Lv.14エンプティー",
            "Lv.15ウルフ",
            "Lv.16ジェミニ",
            "Lv.17リブラ",
            "Lv.18コーヴァス",
            "Lv.19コンドル",
            "Lv.20ムーン",
            "Lv.21スペード",
            "Lv.22オリガ",
            "Lv.23ヴァルゴ",
            "Lv.24ペガサス",
            "Lv.25エース",
            "Lv.26アンドロメダ",
            "Lv.27ブライ",
            "Lv.28ブルース",
            "Lv.29ドラゴン",
            "Lv.30ジョーカー",
            "Lv.31ラ・ムー",
            "Lv.32フォルテ",
            "---流星サーバー---",
            "Lv.01アルファ",
            "Lv.02ベータ",
            "Lv.03ガンマ",
            "Lv.04デルタ",
            "Lv.05イプシロン",
            "Lv.06ゼータ",
            "Lv.07イータ",
            "Lv.08シータ",
            "Lv.09イオタ",
            "Lv.10カッパ",
            "Lv.11ラムダ",
            "Lv.12ミュー",
            "Lv.13ニュー",
            "Lv.14クサイ",
            "Lv.15オミクロン",
            "Lv.16パイ",
            "Lv.17ロー",
            "Lv.18シグマ",
            "Lv.19タウ",
            "Lv.20ユプシロン",
            "Lv.21ファイ",
            "Lv.22カイ",
            "Lv.23プサイ",
            "Lv.24オメガ"});
            this.comboBox1.Location = new System.Drawing.Point(78, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SSS card list";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(160, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Meteor Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Satellite Server";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(162, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 111);
            this.button4.TabIndex = 3;
            this.button4.Text = "List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 111);
            this.button1.TabIndex = 0;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(405, 54);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 31);
            this.button7.TabIndex = 13;
            this.button7.Text = "Generate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(405, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(172, 234);
            this.textBox1.TabIndex = 14;
            // 
            // MMSF3_SSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(596, 358);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MMSF3_SSS";
            this.Text = "SSS Settings";
            this.Load += new System.EventHandler(this.MMSF3_SSS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void label4_Click(object sender, EventArgs e)
		{
		}

		private void MMSF3_SSS_Load(object sender, EventArgs e)
		{
		}
	}
}