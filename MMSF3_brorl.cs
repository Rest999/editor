using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3_brorl : Form
	{
		private IContainer components;

		private Button button7;

		private Label label1;

		private GroupBox groupBox1;

		private Label label3;

		private Label label2;

		private ComboBox comboBox2;

		private ComboBox comboBox1;

		private GroupBox groupBox2;

		private Label label4;

		private Label label5;

		private ComboBox comboBox3;

		private ComboBox comboBox4;

		private GroupBox groupBox3;

		private Label label6;

		private Label label7;

		private ComboBox comboBox5;

		private ComboBox comboBox6;

		private GroupBox groupBox4;

		private Label label8;

		private Label label9;

		private ComboBox comboBox7;

		private ComboBox comboBox8;

		private GroupBox groupBox5;

		private Label label10;

		private Label label11;

		private ComboBox comboBox9;

		private ComboBox comboBox10;

		private GroupBox groupBox6;

		private Label label12;

		private Label label13;

		private ComboBox comboBox11;

		private ComboBox comboBox12;

		private TextBox textBox1;

		public MMSF3_brorl()
		{
			this.InitializeComponent();
			Dictionary<string, string> strs = new Dictionary<string, string>()
			{
				{ "0C4\r\n", "Wing Blade" },
				{ "0C5\r\n", "Darkness Hole" },
				{ "0C6\r\n", "Thousand Kick" },
				{ "0C7\r\n", "Break Count Bomb" },
				{ "0C8\r\n", "Mu Rejection" },
				{ "0C9\r\n", "G-Meteor Lazer" },
				{ "0CA\r\n", "Destroy Missile" },
				{ "0CB\r\n", "Buster MAX" },
				{ "0CC\r\n", "Ox Tackle" },
				{ "0CD\r\n", "Dopple Mirror" },
				{ "0CE\r\n", "Meteor of Crimson" },
				{ "183\r\n", "Pegasus Magic GX" },
				{ "184\r\n", "Leo Kingdom GX" },
				{ "185\r\n", "Dragon Sky GX" },
				{ "186\r\n", "Gorgon Eye" },
				{ "187\r\n", "Gemini Thunder" },
				{ "188\r\n", "Burai Break" },
				{ "189\r\n", "Avalanche" },
				{ "18A\r\n", "Flying Impact" },
				{ "18B\r\n", "Torrent Wave" },
				{ "18C\r\n", "Light of Saint" },
				{ "18D\r\n", "Hell Painflame" }
			};
			this.comboBox1.DataSource = new BindingSource(strs, null);
			this.comboBox1.DisplayMember = "Value";
			this.comboBox1.ValueMember = "Key";
			this.comboBox4.DataSource = new BindingSource(strs, null);
			this.comboBox4.DisplayMember = "Value";
			this.comboBox4.ValueMember = "Key";
			this.comboBox6.DataSource = new BindingSource(strs, null);
			this.comboBox6.DisplayMember = "Value";
			this.comboBox6.ValueMember = "Key";
			this.comboBox8.DataSource = new BindingSource(strs, null);
			this.comboBox8.DisplayMember = "Value";
			this.comboBox8.ValueMember = "Key";
			this.comboBox10.DataSource = new BindingSource(strs, null);
			this.comboBox10.DisplayMember = "Value";
			this.comboBox10.ValueMember = "Key";
			this.comboBox12.DataSource = new BindingSource(strs, null);
			this.comboBox12.DisplayMember = "Value";
			this.comboBox12.ValueMember = "Key";
			Dictionary<string, string> strs1 = new Dictionary<string, string>()
			{
				{ "097\r\n", "Spade Magnes" },
				{ "098\r\n", "Spade MagnesV2" },
				{ "099\r\n", "Spade MagnesV3" },
				{ "168\r\n", "Spade MagnesX" },
				{ "09A\r\n", "Dia Ice Burn" },
				{ "09B\r\n", "Dia Ice BurnV2" },
				{ "09C\r\n", "Dia Ice BurnV3" },
				{ "169\r\n", "Dia Ice BurnX" },
				{ "09D\r\n", "Club Strong" },
				{ "09E\r\n", "Club StrongV2" },
				{ "09F\r\n", "Club StrongV3" },
				{ "16A\r\n", "Club StrongX" },
				{ "0A0\r\n", "Queen Virgo" },
				{ "0A1\r\n", "Queen VirgoV2" },
				{ "0A2\r\n", "Queen VirgoV3" },
				{ "16B\r\n", "Queen VirgoX" },
				{ "0A3\r\n", "Jack Corvus" },
				{ "0A4\r\n", "Jack CorvusV2" },
				{ "0A5\r\n", "Jack CorvusV3" },
				{ "16C\r\n", "Jack CorvusX" },
				{ "0A6\r\n", "Grave Joker" },
				{ "0A7\r\n", "Grave JokerV2" },
				{ "0A8\r\n", "Grave JokerV3" },
				{ "16D\r\n", "Grave JokerX" },
				{ "0A9\r\n", "Acid Ace" },
				{ "0AA\r\n", "Acid AceV2" },
				{ "0AB\r\n", "Acid AceV3" },
				{ "16E\r\n", "Acid AceX" },
				{ "0AC\r\n", "Ox Fire" },
				{ "0AD\r\n", "Ox FireV2" },
				{ "0AE\r\n", "Ox FireV3" },
				{ "16F\r\n", "Ox FireX" },
				{ "0AF\r\n", "Cygnus Wing" },
				{ "0B0\r\n", "Cygnus WingV2" },
				{ "0B1\r\n", "Cygnus WingV3" },
				{ "170\r\n", "Cygnus WingX" },
				{ "0B2\r\n", "Wolf Wood" },
				{ "0B3\r\n", "Wolf WoodV2" },
				{ "0B4\r\n", "Wolf WoodV3" },
				{ "171\r\n", "Wolf WoodX" },
				{ "0B5\r\n", "Phantom Black" },
				{ "0B6\r\n", "Phantom BlackV2" },
				{ "0B7\r\n", "Phantom BlackV3" },
				{ "172\r\n", "Phantom BlackX" },
				{ "0B8\r\n", "Burai" },
				{ "0B9\r\n", "BuraiV2" },
				{ "0BA\r\n", "BuraiV3" },
				{ "173\r\n", "BuraiX" },
				{ "0BB\r\n", "Moon Disaster" },
				{ "0BC\r\n", "Moon DisasterV2" },
				{ "0BD\r\n", "Moon DisasterV3" },
				{ "174\r\n", "Moon DisasterX" },
				{ "0BE\r\n", "Apollo Flame" },
				{ "0BF\r\n", "Apollo FlameV2" },
				{ "0C0\r\n", "Apollo FlameV3" },
				{ "175\r\n", "Apollo FlameX" },
				{ "0C1\r\n", "Sirius" },
				{ "0C2\r\n", "SiriusV2" },
				{ "0C3\r\n", "SiriusV3" },
				{ "176\r\n", "SiriusX" },
				{ "159\r\n", "Libra Scales" },
				{ "15A\r\n", "Libra ScalesV2" },
				{ "15B\r\n", "Libra ScalesV3" },
				{ "17E\r\n", "Libra ScalesX" },
				{ "14D\r\n", "Queen Ophiucus" },
				{ "14E\r\n", "Queen OphiucusV2" },
				{ "14F\r\n", "Queen OphiucusV3" },
				{ "17A\r\n", "Queen OphiucusX" },
				{ "150\r\n", "Gemini Spark" },
				{ "151\r\n", "Gemini SparkV2" },
				{ "152\r\n", "Gemini SparkV3" },
				{ "17B\r\n", "Gemini SparkX" },
				{ "153\r\n", "Cancer Bubble" },
				{ "154\r\n", "Cancer BubbleV2" },
				{ "155\r\n", "Cancer BubbleV3" },
				{ "17C\r\n", "Cancer BubbleX" },
				{ "15C\r\n", "Crown Thunder" },
				{ "15D\r\n", "Crown ThunderV2" },
				{ "15E\r\n", "Crown ThunderV3" },
				{ "17F\r\n", "Crown ThunderX" },
				{ "144\r\n", "Yeti Blizzard" },
				{ "145\r\n", "Yeti BlizzardV2" },
				{ "146\r\n", "Yeti BlizzardV3" },
				{ "177\r\n", "Yeti BlizzardX" },
				{ "147\r\n", "Brachio Wave" },
				{ "148\r\n", "Brachio WaveV2" },
				{ "149\r\n", "Brachio WaveV3" },
				{ "178\r\n", "Brachio WaveX" },
				{ "14A\r\n", "Condor Geograph" },
				{ "14B\r\n", "Condor GeographV2" },
				{ "14C\r\n", "Condor GeographV3" },
				{ "179\r\n", "Condor GeographX" },
				{ "156\r\n", "General Auriga" },
				{ "157\r\n", "General AurigaV2" },
				{ "158\r\n", "General Auriga#" },
				{ "17D\r\n", "General AurigaX" },
				{ "15F\r\n", "Axis Jet" },
				{ "160\r\n", "Axis JetV2" },
				{ "161\r\n", "Axis JetV3" },
				{ "180\r\n", "RAxis JetX" },
				{ "162\r\n", "Ice Hammer Break" },
				{ "163\r\n", "Ice Hammer BreakV2" },
				{ "164\r\n", "Ice Hammer BreakV3" },
				{ "181\r\n", "Ice Hammer BreakX" },
				{ "165\r\n", "Strong Swing" },
				{ "166\r\n", "Strong SwingV2" },
				{ "167\r\n", "Strong SwingV3" },
				{ "182\r\n", "Strong SwingX" },
				{ "0CF\r\n", "Acid Illegal" }
			};
			this.comboBox2.DataSource = new BindingSource(strs1, null);
			this.comboBox2.DisplayMember = "Value";
			this.comboBox2.ValueMember = "Key";
			this.comboBox3.DataSource = new BindingSource(strs1, null);
			this.comboBox3.DisplayMember = "Value";
			this.comboBox3.ValueMember = "Key";
			this.comboBox5.DataSource = new BindingSource(strs1, null);
			this.comboBox5.DisplayMember = "Value";
			this.comboBox5.ValueMember = "Key";
			this.comboBox7.DataSource = new BindingSource(strs1, null);
			this.comboBox7.DisplayMember = "Value";
			this.comboBox7.ValueMember = "Key";
			this.comboBox9.DataSource = new BindingSource(strs1, null);
			this.comboBox9.DisplayMember = "Value";
			this.comboBox9.ValueMember = "Key";
			this.comboBox11.DataSource = new BindingSource(strs1, null);
			this.comboBox11.DisplayMember = "Value";
			this.comboBox11.ValueMember = "Key";
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string str = this.comboBox1.SelectedValue.ToString();
			string str1 = this.comboBox2.SelectedValue.ToString();
			string str2 = this.comboBox4.SelectedValue.ToString();
			string str3 = this.comboBox3.SelectedValue.ToString();
			string str4 = this.comboBox6.SelectedValue.ToString();
			string str5 = this.comboBox5.SelectedValue.ToString();
			string str6 = this.comboBox8.SelectedValue.ToString();
			string str7 = this.comboBox7.SelectedValue.ToString();
			string str8 = this.comboBox10.SelectedValue.ToString();
			string str9 = this.comboBox9.SelectedValue.ToString();
			string str10 = this.comboBox12.SelectedValue.ToString();
			string str11 = this.comboBox11.SelectedValue.ToString();
			this.textBox1.Text = string.Concat(new string[] { "120F457E 00000", str, "120F457C 00000", str1, "\r\n120F4BBE 00000", str2, "120F4BBC 00000", str3, "\r\n120F51FE 00000", str4, "120F51FC 00000", str5, "\r\n120F583E 00000", str6, "120F583C 00000", str7, "\r\n120F5E7E 00000", str8, "120F5E7C 00000", str9, "\r\n120F64BE 00000", str10, "120F64BC 00000", str11.ToString() });
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

		private void groupBox7_Enter(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMSF3_brorl));
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(470, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 63);
            this.button7.TabIndex = 18;
            this.button7.Text = "Generate";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Mincho", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Brother roulette setting";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 108);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top Left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giga";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "スペードマグネッツ",
            "スペードマグネッツV2",
            "スペードマグネッツV3",
            "スペードマグネッツX",
            "ダイヤモンドアイス",
            "ダイヤモンドアイスV2",
            "ダイヤモンドアイスV3",
            "ダイヤモンドアイスX",
            "クラブストロング",
            "クラブストロングV2",
            "クラブストロングV3",
            "クラブストロングX",
            "クイーンヴァルゴ",
            "クイーンヴァルゴV2",
            "クイーンヴァルゴV3",
            "クイーンヴァルゴX",
            "ジャックコーヴァス",
            "ジャックコーヴァスV2",
            "ジャックコーヴァスV3",
            "ジャックコーヴァスX",
            "グレイブジョーカー",
            "グレイブジョーカーV2",
            "グレイブジョーカーV3",
            "グレイブジョーカーX",
            "アシッドエース",
            "アシッドエースV2",
            "アシッドエースV3",
            "アシッドエースX",
            "オックスファイア",
            "オックスファイアV2",
            "オックスファイアV3",
            "オックスファイアX",
            "キグナスウィング",
            "キグナスウィングV2",
            "キグナスウィングV3",
            "キグナスウィングX",
            "ウルフフォレスト",
            "ウルフフォレストV2",
            "ウルフフォレストV3",
            "ウルフフォレストX",
            "ファントムブラック",
            "ファントムブラックV2",
            "ファントムブラックV3",
            "ファントムブラックX",
            "ブライ",
            "ブライV2",
            "ブライV3",
            "ブライX",
            "ムーンディザスター",
            "ムーンディザスターV2",
            "ムーンディザスターV3",
            "ムーンディザスターX",
            "アポロンフレイム",
            "アポロンフレイムV2",
            "アポロンフレイムV3",
            "アポロンフレイムX",
            "シリウス",
            "シリウスV2",
            "シリウスV3",
            "シリウスX",
            "リブラバランス",
            "リブラバランスV2",
            "リブラバランスV3",
            "リブラバランスX",
            "オヒュカスクイーン",
            "オヒュカスクイーンV2",
            "オヒュカスクイーンV3",
            "オヒュカスクイーンX",
            "ジェミニスパーク",
            "ジェミニスパークV2",
            "ジェミニスパークV3",
            "ジェミニスパークX",
            "キャンサーバブル",
            "キャンサーバブルV2",
            "キャンサーバブルV3",
            "キャンサーバブルX",
            "クラウンサンダー",
            "クラウンサンダーV2",
            "クラウンサンダーV3",
            "クラウンサンダーX",
            "イエティブリザード",
            "イエティブリザードV2",
            "イエティブリザードV3",
            "イエティブリザードX",
            "ブラキオウェーブ",
            "ブラキオウェーブV2",
            "ブラキオウェーブV3",
            "ブラキオウェーブX",
            "コンドルジオグラフ",
            "コンドルジオグラフV2",
            "コンドルジオグラフV3",
            "コンドルジオグラフX",
            "オリガジェネラル",
            "オリガジェネラルV2",
            "オリガジェネラルV3",
            "オリガジェネラルX",
            "アクシスジェット",
            "アクシスジェットV2",
            "アクシスジェットV3",
            "アクシスジェットX",
            "Bアイスハンマー",
            "BアイスハンマーV2",
            "BアイスハンマーV3",
            "BアイスハンマーX",
            "ストロングスイング",
            "ストロングスイングV2",
            "ストロングスイングV3",
            "ストロングスイングX",
            "アシッドイリーガル"});
            this.comboBox2.Location = new System.Drawing.Point(56, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ウィングブレード",
            "ダークネスホール",
            "サウザンドキック",
            "ブレイクカウントボム",
            "ムーリジェクション",
            "Gメテオレイザー",
            "デストロイミサイル",
            "バスターマックス",
            "オックスタックル",
            "ドッペルミラー",
            "メテオオブクリムゾン",
            "ペガサスマジックGX",
            "レオキングダムGX",
            "ドラゴンスカイGX",
            "ゴルゴンアイ",
            "ジェミニサンダー",
            "ブライブレイク",
            "ナダレダイコ",
            "フライングインパクト",
            "ゲキリュウウェーブ",
            "ライトオブセイント",
            "ペインフレイム"});
            this.comboBox1.Location = new System.Drawing.Point(56, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 108);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Middle Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giga";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "スペードマグネッツ",
            "スペードマグネッツV2",
            "スペードマグネッツV3",
            "スペードマグネッツX",
            "ダイヤモンドアイス",
            "ダイヤモンドアイスV2",
            "ダイヤモンドアイスV3",
            "ダイヤモンドアイスX",
            "クラブストロング",
            "クラブストロングV2",
            "クラブストロングV3",
            "クラブストロングX",
            "クイーンヴァルゴ",
            "クイーンヴァルゴV2",
            "クイーンヴァルゴV3",
            "クイーンヴァルゴX",
            "ジャックコーヴァス",
            "ジャックコーヴァスV2",
            "ジャックコーヴァスV3",
            "ジャックコーヴァスX",
            "グレイブジョーカー",
            "グレイブジョーカーV2",
            "グレイブジョーカーV3",
            "グレイブジョーカーX",
            "アシッドエース",
            "アシッドエースV2",
            "アシッドエースV3",
            "アシッドエースX",
            "オックスファイア",
            "オックスファイアV2",
            "オックスファイアV3",
            "オックスファイアX",
            "キグナスウィング",
            "キグナスウィングV2",
            "キグナスウィングV3",
            "キグナスウィングX",
            "ウルフフォレスト",
            "ウルフフォレストV2",
            "ウルフフォレストV3",
            "ウルフフォレストX",
            "ファントムブラック",
            "ファントムブラックV2",
            "ファントムブラックV3",
            "ファントムブラックX",
            "ブライ",
            "ブライV2",
            "ブライV3",
            "ブライX",
            "ムーンディザスター",
            "ムーンディザスターV2",
            "ムーンディザスターV3",
            "ムーンディザスターX",
            "アポロンフレイム",
            "アポロンフレイムV2",
            "アポロンフレイムV3",
            "アポロンフレイムX",
            "シリウス",
            "シリウスV2",
            "シリウスV3",
            "シリウスX",
            "リブラバランス",
            "リブラバランスV2",
            "リブラバランスV3",
            "リブラバランスX",
            "オヒュカスクイーン",
            "オヒュカスクイーンV2",
            "オヒュカスクイーンV3",
            "オヒュカスクイーンX",
            "ジェミニスパーク",
            "ジェミニスパークV2",
            "ジェミニスパークV3",
            "ジェミニスパークX",
            "キャンサーバブル",
            "キャンサーバブルV2",
            "キャンサーバブルV3",
            "キャンサーバブルX",
            "クラウンサンダー",
            "クラウンサンダーV2",
            "クラウンサンダーV3",
            "クラウンサンダーX",
            "イエティブリザード",
            "イエティブリザードV2",
            "イエティブリザードV3",
            "イエティブリザードX",
            "ブラキオウェーブ",
            "ブラキオウェーブV2",
            "ブラキオウェーブV3",
            "ブラキオウェーブX",
            "コンドルジオグラフ",
            "コンドルジオグラフV2",
            "コンドルジオグラフV3",
            "コンドルジオグラフX",
            "オリガジェネラル",
            "オリガジェネラルV2",
            "オリガジェネラルV3",
            "オリガジェネラルX",
            "アクシスジェット",
            "アクシスジェットV2",
            "アクシスジェットV3",
            "アクシスジェットX",
            "Bアイスハンマー",
            "BアイスハンマーV2",
            "BアイスハンマーV3",
            "BアイスハンマーX",
            "ストロングスイング",
            "ストロングスイングV2",
            "ストロングスイングV3",
            "ストロングスイングX",
            "アシッドイリーガル"});
            this.comboBox3.Location = new System.Drawing.Point(56, 67);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "ウィングブレード",
            "ダークネスホール",
            "サウザンドキック",
            "ブレイクカウントボム",
            "ムーリジェクション",
            "Gメテオレイザー",
            "デストロイミサイル",
            "バスターマックス",
            "オックスタックル",
            "ドッペルミラー",
            "メテオオブクリムゾン",
            "ペガサスマジックGX",
            "レオキングダムGX",
            "ドラゴンスカイGX",
            "ゴルゴンアイ",
            "ジェミニサンダー",
            "ブライブレイク",
            "ナダレダイコ",
            "フライングインパクト",
            "ゲキリュウウェーブ",
            "ライトオブセイント",
            "ペインフレイム"});
            this.comboBox4.Location = new System.Drawing.Point(56, 26);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox5);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 108);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bottom Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mega";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Giga";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "スペードマグネッツ",
            "スペードマグネッツV2",
            "スペードマグネッツV3",
            "スペードマグネッツX",
            "ダイヤモンドアイス",
            "ダイヤモンドアイスV2",
            "ダイヤモンドアイスV3",
            "ダイヤモンドアイスX",
            "クラブストロング",
            "クラブストロングV2",
            "クラブストロングV3",
            "クラブストロングX",
            "クイーンヴァルゴ",
            "クイーンヴァルゴV2",
            "クイーンヴァルゴV3",
            "クイーンヴァルゴX",
            "ジャックコーヴァス",
            "ジャックコーヴァスV2",
            "ジャックコーヴァスV3",
            "ジャックコーヴァスX",
            "グレイブジョーカー",
            "グレイブジョーカーV2",
            "グレイブジョーカーV3",
            "グレイブジョーカーX",
            "アシッドエース",
            "アシッドエースV2",
            "アシッドエースV3",
            "アシッドエースX",
            "オックスファイア",
            "オックスファイアV2",
            "オックスファイアV3",
            "オックスファイアX",
            "キグナスウィング",
            "キグナスウィングV2",
            "キグナスウィングV3",
            "キグナスウィングX",
            "ウルフフォレスト",
            "ウルフフォレストV2",
            "ウルフフォレストV3",
            "ウルフフォレストX",
            "ファントムブラック",
            "ファントムブラックV2",
            "ファントムブラックV3",
            "ファントムブラックX",
            "ブライ",
            "ブライV2",
            "ブライV3",
            "ブライX",
            "ムーンディザスター",
            "ムーンディザスターV2",
            "ムーンディザスターV3",
            "ムーンディザスターX",
            "アポロンフレイム",
            "アポロンフレイムV2",
            "アポロンフレイムV3",
            "アポロンフレイムX",
            "シリウス",
            "シリウスV2",
            "シリウスV3",
            "シリウスX",
            "リブラバランス",
            "リブラバランスV2",
            "リブラバランスV3",
            "リブラバランスX",
            "オヒュカスクイーン",
            "オヒュカスクイーンV2",
            "オヒュカスクイーンV3",
            "オヒュカスクイーンX",
            "ジェミニスパーク",
            "ジェミニスパークV2",
            "ジェミニスパークV3",
            "ジェミニスパークX",
            "キャンサーバブル",
            "キャンサーバブルV2",
            "キャンサーバブルV3",
            "キャンサーバブルX",
            "クラウンサンダー",
            "クラウンサンダーV2",
            "クラウンサンダーV3",
            "クラウンサンダーX",
            "イエティブリザード",
            "イエティブリザードV2",
            "イエティブリザードV3",
            "イエティブリザードX",
            "ブラキオウェーブ",
            "ブラキオウェーブV2",
            "ブラキオウェーブV3",
            "ブラキオウェーブX",
            "コンドルジオグラフ",
            "コンドルジオグラフV2",
            "コンドルジオグラフV3",
            "コンドルジオグラフX",
            "オリガジェネラル",
            "オリガジェネラルV2",
            "オリガジェネラルV3",
            "オリガジェネラルX",
            "アクシスジェット",
            "アクシスジェットV2",
            "アクシスジェットV3",
            "アクシスジェットX",
            "Bアイスハンマー",
            "BアイスハンマーV2",
            "BアイスハンマーV3",
            "BアイスハンマーX",
            "ストロングスイング",
            "ストロングスイングV2",
            "ストロングスイングV3",
            "ストロングスイングX",
            "アシッドイリーガル"});
            this.comboBox5.Location = new System.Drawing.Point(56, 67);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 1;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "ウィングブレード",
            "ダークネスホール",
            "サウザンドキック",
            "ブレイクカウントボム",
            "ムーリジェクション",
            "Gメテオレイザー",
            "デストロイミサイル",
            "バスターマックス",
            "オックスタックル",
            "ドッペルミラー",
            "メテオオブクリムゾン",
            "ペガサスマジックGX",
            "レオキングダムGX",
            "ドラゴンスカイGX",
            "ゴルゴンアイ",
            "ジェミニサンダー",
            "ブライブレイク",
            "ナダレダイコ",
            "フライングインパクト",
            "ゲキリュウウェーブ",
            "ライトオブセイント",
            "ペインフレイム"});
            this.comboBox6.Location = new System.Drawing.Point(56, 26);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.comboBox7);
            this.groupBox4.Controls.Add(this.comboBox8);
            this.groupBox4.Location = new System.Drawing.Point(245, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 108);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Top Right";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mega";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Giga";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "スペードマグネッツ",
            "スペードマグネッツV2",
            "スペードマグネッツV3",
            "スペードマグネッツX",
            "ダイヤモンドアイス",
            "ダイヤモンドアイスV2",
            "ダイヤモンドアイスV3",
            "ダイヤモンドアイスX",
            "クラブストロング",
            "クラブストロングV2",
            "クラブストロングV3",
            "クラブストロングX",
            "クイーンヴァルゴ",
            "クイーンヴァルゴV2",
            "クイーンヴァルゴV3",
            "クイーンヴァルゴX",
            "ジャックコーヴァス",
            "ジャックコーヴァスV2",
            "ジャックコーヴァスV3",
            "ジャックコーヴァスX",
            "グレイブジョーカー",
            "グレイブジョーカーV2",
            "グレイブジョーカーV3",
            "グレイブジョーカーX",
            "アシッドエース",
            "アシッドエースV2",
            "アシッドエースV3",
            "アシッドエースX",
            "オックスファイア",
            "オックスファイアV2",
            "オックスファイアV3",
            "オックスファイアX",
            "キグナスウィング",
            "キグナスウィングV2",
            "キグナスウィングV3",
            "キグナスウィングX",
            "ウルフフォレスト",
            "ウルフフォレストV2",
            "ウルフフォレストV3",
            "ウルフフォレストX",
            "ファントムブラック",
            "ファントムブラックV2",
            "ファントムブラックV3",
            "ファントムブラックX",
            "ブライ",
            "ブライV2",
            "ブライV3",
            "ブライX",
            "ムーンディザスター",
            "ムーンディザスターV2",
            "ムーンディザスターV3",
            "ムーンディザスターX",
            "アポロンフレイム",
            "アポロンフレイムV2",
            "アポロンフレイムV3",
            "アポロンフレイムX",
            "シリウス",
            "シリウスV2",
            "シリウスV3",
            "シリウスX",
            "リブラバランス",
            "リブラバランスV2",
            "リブラバランスV3",
            "リブラバランスX",
            "オヒュカスクイーン",
            "オヒュカスクイーンV2",
            "オヒュカスクイーンV3",
            "オヒュカスクイーンX",
            "ジェミニスパーク",
            "ジェミニスパークV2",
            "ジェミニスパークV3",
            "ジェミニスパークX",
            "キャンサーバブル",
            "キャンサーバブルV2",
            "キャンサーバブルV3",
            "キャンサーバブルX",
            "クラウンサンダー",
            "クラウンサンダーV2",
            "クラウンサンダーV3",
            "クラウンサンダーX",
            "イエティブリザード",
            "イエティブリザードV2",
            "イエティブリザードV3",
            "イエティブリザードX",
            "ブラキオウェーブ",
            "ブラキオウェーブV2",
            "ブラキオウェーブV3",
            "ブラキオウェーブX",
            "コンドルジオグラフ",
            "コンドルジオグラフV2",
            "コンドルジオグラフV3",
            "コンドルジオグラフX",
            "オリガジェネラル",
            "オリガジェネラルV2",
            "オリガジェネラルV3",
            "オリガジェネラルX",
            "アクシスジェット",
            "アクシスジェットV2",
            "アクシスジェットV3",
            "アクシスジェットX",
            "Bアイスハンマー",
            "BアイスハンマーV2",
            "BアイスハンマーV3",
            "BアイスハンマーX",
            "ストロングスイング",
            "ストロングスイングV2",
            "ストロングスイングV3",
            "ストロングスイングX",
            "アシッドイリーガル"});
            this.comboBox7.Location = new System.Drawing.Point(56, 67);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 1;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "ウィングブレード",
            "ダークネスホール",
            "サウザンドキック",
            "ブレイクカウントボム",
            "ムーリジェクション",
            "Gメテオレイザー",
            "デストロイミサイル",
            "バスターマックス",
            "オックスタックル",
            "ドッペルミラー",
            "メテオオブクリムゾン",
            "ペガサスマジックGX",
            "レオキングダムGX",
            "ドラゴンスカイGX",
            "ゴルゴンアイ",
            "ジェミニサンダー",
            "ブライブレイク",
            "ナダレダイコ",
            "フライングインパクト",
            "ゲキリュウウェーブ",
            "ライトオブセイント",
            "ペインフレイム"});
            this.comboBox8.Location = new System.Drawing.Point(56, 26);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 21);
            this.comboBox8.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.comboBox9);
            this.groupBox5.Controls.Add(this.comboBox10);
            this.groupBox5.Location = new System.Drawing.Point(245, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 108);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Middle Right";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mega";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giga";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "スペードマグネッツ",
            "スペードマグネッツV2",
            "スペードマグネッツV3",
            "スペードマグネッツX",
            "ダイヤモンドアイス",
            "ダイヤモンドアイスV2",
            "ダイヤモンドアイスV3",
            "ダイヤモンドアイスX",
            "クラブストロング",
            "クラブストロングV2",
            "クラブストロングV3",
            "クラブストロングX",
            "クイーンヴァルゴ",
            "クイーンヴァルゴV2",
            "クイーンヴァルゴV3",
            "クイーンヴァルゴX",
            "ジャックコーヴァス",
            "ジャックコーヴァスV2",
            "ジャックコーヴァスV3",
            "ジャックコーヴァスX",
            "グレイブジョーカー",
            "グレイブジョーカーV2",
            "グレイブジョーカーV3",
            "グレイブジョーカーX",
            "アシッドエース",
            "アシッドエースV2",
            "アシッドエースV3",
            "アシッドエースX",
            "オックスファイア",
            "オックスファイアV2",
            "オックスファイアV3",
            "オックスファイアX",
            "キグナスウィング",
            "キグナスウィングV2",
            "キグナスウィングV3",
            "キグナスウィングX",
            "ウルフフォレスト",
            "ウルフフォレストV2",
            "ウルフフォレストV3",
            "ウルフフォレストX",
            "ファントムブラック",
            "ファントムブラックV2",
            "ファントムブラックV3",
            "ファントムブラックX",
            "ブライ",
            "ブライV2",
            "ブライV3",
            "ブライX",
            "ムーンディザスター",
            "ムーンディザスターV2",
            "ムーンディザスターV3",
            "ムーンディザスターX",
            "アポロンフレイム",
            "アポロンフレイムV2",
            "アポロンフレイムV3",
            "アポロンフレイムX",
            "シリウス",
            "シリウスV2",
            "シリウスV3",
            "シリウスX",
            "リブラバランス",
            "リブラバランスV2",
            "リブラバランスV3",
            "リブラバランスX",
            "オヒュカスクイーン",
            "オヒュカスクイーンV2",
            "オヒュカスクイーンV3",
            "オヒュカスクイーンX",
            "ジェミニスパーク",
            "ジェミニスパークV2",
            "ジェミニスパークV3",
            "ジェミニスパークX",
            "キャンサーバブル",
            "キャンサーバブルV2",
            "キャンサーバブルV3",
            "キャンサーバブルX",
            "クラウンサンダー",
            "クラウンサンダーV2",
            "クラウンサンダーV3",
            "クラウンサンダーX",
            "イエティブリザード",
            "イエティブリザードV2",
            "イエティブリザードV3",
            "イエティブリザードX",
            "ブラキオウェーブ",
            "ブラキオウェーブV2",
            "ブラキオウェーブV3",
            "ブラキオウェーブX",
            "コンドルジオグラフ",
            "コンドルジオグラフV2",
            "コンドルジオグラフV3",
            "コンドルジオグラフX",
            "オリガジェネラル",
            "オリガジェネラルV2",
            "オリガジェネラルV3",
            "オリガジェネラルX",
            "アクシスジェット",
            "アクシスジェットV2",
            "アクシスジェットV3",
            "アクシスジェットX",
            "Bアイスハンマー",
            "BアイスハンマーV2",
            "BアイスハンマーV3",
            "BアイスハンマーX",
            "ストロングスイング",
            "ストロングスイングV2",
            "ストロングスイングV3",
            "ストロングスイングX",
            "アシッドイリーガル"});
            this.comboBox9.Location = new System.Drawing.Point(56, 67);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(121, 21);
            this.comboBox9.TabIndex = 1;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "ウィングブレード",
            "ダークネスホール",
            "サウザンドキック",
            "ブレイクカウントボム",
            "ムーリジェクション",
            "Gメテオレイザー",
            "デストロイミサイル",
            "バスターマックス",
            "オックスタックル",
            "ドッペルミラー",
            "メテオオブクリムゾン",
            "ペガサスマジックGX",
            "レオキングダムGX",
            "ドラゴンスカイGX",
            "ゴルゴンアイ",
            "ジェミニサンダー",
            "ブライブレイク",
            "ナダレダイコ",
            "フライングインパクト",
            "ゲキリュウウェーブ",
            "ライトオブセイント",
            "ペインフレイム"});
            this.comboBox10.Location = new System.Drawing.Point(56, 26);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(121, 21);
            this.comboBox10.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.comboBox11);
            this.groupBox6.Controls.Add(this.comboBox12);
            this.groupBox6.Location = new System.Drawing.Point(245, 275);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 108);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bottom right";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Mega";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Giga";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "スペードマグネッツ",
            "スペードマグネッツV2",
            "スペードマグネッツV3",
            "スペードマグネッツX",
            "ダイヤモンドアイス",
            "ダイヤモンドアイスV2",
            "ダイヤモンドアイスV3",
            "ダイヤモンドアイスX",
            "クラブストロング",
            "クラブストロングV2",
            "クラブストロングV3",
            "クラブストロングX",
            "クイーンヴァルゴ",
            "クイーンヴァルゴV2",
            "クイーンヴァルゴV3",
            "クイーンヴァルゴX",
            "ジャックコーヴァス",
            "ジャックコーヴァスV2",
            "ジャックコーヴァスV3",
            "ジャックコーヴァスX",
            "グレイブジョーカー",
            "グレイブジョーカーV2",
            "グレイブジョーカーV3",
            "グレイブジョーカーX",
            "アシッドエース",
            "アシッドエースV2",
            "アシッドエースV3",
            "アシッドエースX",
            "オックスファイア",
            "オックスファイアV2",
            "オックスファイアV3",
            "オックスファイアX",
            "キグナスウィング",
            "キグナスウィングV2",
            "キグナスウィングV3",
            "キグナスウィングX",
            "ウルフフォレスト",
            "ウルフフォレストV2",
            "ウルフフォレストV3",
            "ウルフフォレストX",
            "ファントムブラック",
            "ファントムブラックV2",
            "ファントムブラックV3",
            "ファントムブラックX",
            "ブライ",
            "ブライV2",
            "ブライV3",
            "ブライX",
            "ムーンディザスター",
            "ムーンディザスターV2",
            "ムーンディザスターV3",
            "ムーンディザスターX",
            "アポロンフレイム",
            "アポロンフレイムV2",
            "アポロンフレイムV3",
            "アポロンフレイムX",
            "シリウス",
            "シリウスV2",
            "シリウスV3",
            "シリウスX",
            "リブラバランス",
            "リブラバランスV2",
            "リブラバランスV3",
            "リブラバランスX",
            "オヒュカスクイーン",
            "オヒュカスクイーンV2",
            "オヒュカスクイーンV3",
            "オヒュカスクイーンX",
            "ジェミニスパーク",
            "ジェミニスパークV2",
            "ジェミニスパークV3",
            "ジェミニスパークX",
            "キャンサーバブル",
            "キャンサーバブルV2",
            "キャンサーバブルV3",
            "キャンサーバブルX",
            "クラウンサンダー",
            "クラウンサンダーV2",
            "クラウンサンダーV3",
            "クラウンサンダーX",
            "イエティブリザード",
            "イエティブリザードV2",
            "イエティブリザードV3",
            "イエティブリザードX",
            "ブラキオウェーブ",
            "ブラキオウェーブV2",
            "ブラキオウェーブV3",
            "ブラキオウェーブX",
            "コンドルジオグラフ",
            "コンドルジオグラフV2",
            "コンドルジオグラフV3",
            "コンドルジオグラフX",
            "オリガジェネラル",
            "オリガジェネラルV2",
            "オリガジェネラルV3",
            "オリガジェネラルX",
            "アクシスジェット",
            "アクシスジェットV2",
            "アクシスジェットV3",
            "アクシスジェットX",
            "Bアイスハンマー",
            "BアイスハンマーV2",
            "BアイスハンマーV3",
            "BアイスハンマーX",
            "ストロングスイング",
            "ストロングスイングV2",
            "ストロングスイングV3",
            "ストロングスイングX",
            "アシッドイリーガル"});
            this.comboBox11.Location = new System.Drawing.Point(56, 67);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(121, 21);
            this.comboBox11.TabIndex = 1;
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "ウィングブレード",
            "ダークネスホール",
            "サウザンドキック",
            "ブレイクカウントボム",
            "ムーリジェクション",
            "Gメテオレイザー",
            "デストロイミサイル",
            "バスターマックス",
            "オックスタックル",
            "ドッペルミラー",
            "メテオオブクリムゾン",
            "ペガサスマジックGX",
            "レオキングダムGX",
            "ドラゴンスカイGX",
            "ゴルゴンアイ",
            "ジェミニサンダー",
            "ブライブレイク",
            "ナダレダイコ",
            "フライングインパクト",
            "ゲキリュウウェーブ",
            "ライトオブセイント",
            "ペインフレイム"});
            this.comboBox12.Location = new System.Drawing.Point(56, 26);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(121, 21);
            this.comboBox12.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 245);
            this.textBox1.TabIndex = 28;
            // 
            // MMSF3_brorl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(699, 419);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MMSF3_brorl";
            this.Text = "Brother Roulette ";
            this.Load += new System.EventHandler(this.MMSF3_brorl_Load);
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

		private void MMSF3_brorl_Load(object sender, EventArgs e)
		{
		}
	}
}