using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3_wclist : Form
	{
		private IContainer components;

		private Label label1;

		private ListBox listBox1;

		public MMSF3_wclist()
		{
			this.InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMSF3_wclist));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Mincho", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "White Card List";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "\"01\" Plasma Gun, Plasma Gun, Air Spread 1, Beast Slap 1",
            "\"02\" Wide Sword, Recover+30, GrandWave, Barrier",
            "\"03\" Mad Vulcan 1, Mini Grenade, Long Sword, Canon",
            "\"04\" Plasma Gun, Invisible, Grand Wave 1, Beast Slap 1",
            "\"05\" Divide Line, Long Sword, Mad Vulcan 1, Recover+30",
            "\"06\" Invisible, Grand Wave 1, Sword, Mad Vulcan 1",
            "\"07\" Beast Slap 1, Canon, Plasma gun, Gravity plus",
            "\"08\" Mini Grenade, Long Sword, Long Sword, Recover+30",
            "\"0A\" Air Spread 1, Mad Vulcan 1, Beast Slap 1, Air Spread 1",
            "\"0B\" Flash Strike 1, Flash Strike 1, Mad Vulcan 1, Gravity Plus",
            "\"0C\" Beast Slap 1, Beast Slap 1, Air Spread 1, Attack+10",
            "\"0D\" Grand Wave 1, Mad vulcan 1, Attack+10, Beast slap 1",
            "\"0E\" Air Spread 2, Wide Wave 1, Gravity Plus, Divide Line",
            "\"0F\" Jet Attack 1, Jet Attack 1, Gravity Plus, Recover+50",
            "\"10\" Drill Arm 1, Drill Arm 1, Attack+10, Jet Attack 1",
            "\"11\" Wide Wave 1, Shark Cutter 1, Shark Cutter 1, Wide Wave 1",
            "\"12\" Grand Wave 2, Buzz Saw 1, Buzz Saw 1, Paralyze Plus",
            "\"13\" Ice Spin 1, Attack+10, Wide Wave 1, Wide Wave 1",
            "\"14\" Shark Cutter 1, Paralyze Plus, Gravity Plus, Shark Cutter 1",
            "\"15\" Air Spread 3, Plus Cannon, Buzz Saw 2, Buzz Saw 2",
            "\"16\" Edogiri 1, Edogiri 1, Buzz Saw 2, Paralyze Plus",
            "\"17\" Bubble Hook 1, Wide Wave 2, Paralyze Plus, Bubble Hook 1",
            "\"18\" Beast Slap 2, Beast Slap 2, Drill Arm 1, Plus Cannon",
            "\"19\" Anger Fire 1, Anger Fire 1, Heat Upper 2, Heat Upper 2",
            "\"1A\" Count Bomb 1, Heat Upper 2, Mad Fire 1, Attack+10",
            "\"1B\" Powder Shot 1, Shuriken 2, Rolling Nuts 1, Dummy Spider 1",
            "\"1C\" Rolling Nuts 1, Rolling Nuts 1,Powder Shot 1, Powder Shot 1",
            "\"1D\" Flash Strike 3, Flash Strike 3, Stealth Lazer 2, Thunder Head 1",
            "\"1E\" Stealth Lazer 2, Paralyze Plus, Thunder Head 1, Mummy Hand 1",
            "\"1F\" Drill Arm 3, Buki 1, Heavy Cannon, Typhoon Dance",
            "\"20\" Count Bomb 2, Mech Flame 1, Heat Upper 3, Anger Fire 2",
            "\"21\" Beast Slap 3, Beast Slap 2, Double Eater, Great Axe",
            "\"22\" Wide Wave 3, Shark Cutter 3, Wide Wave 2, Shark Cutter 3",
            "\"23\" Count Bomb 2, Heat Upper 3, Anger Fire 3, Attack Panel",
            "\"24\" Powder Shot 3, Shuriken 2, Rolling Nuts 3, Dummy Spider 3",
            "\"25\" Flash Strike 3, Thunder Head 2, Flash Strike 3, Stealth Lazer 2",
            "\"26\" Drill Arm 3, Drill Arm 2, Paralyze Plus, Buki 3",
            "\"27\" Stealth Lazer 3, Paralyze Plus, Thunder Head 2, Mummy Hand 3",
            "\"28\" Machine Flame 2, Heat Upper 3, Time Bomb 3, Mad Fire 3",
            "\"29\" Bubble Hook 3, Bubble Hook 3, Paralyze Plus, Wide Wave 3",
            "\"2A\" Shuriken 3, Dummy Spider 3, Rolling Nuts 3, Wood Slash",
            "\"2B\" Flash Strike 3, Stealth Lazer 3, Thunder Head 3, Elec Slash",
            "\"2C\" Tornado Dance, Windy Attack 3, Drill Arm 3, Buki 3",
            "\"2D\" Plasma Gun, Stealth Lazer 2, Mummy Hand 2, Thunder Head 1",
            "\"2E\" Green Ink, Dummy Spider 1, Shuriken 1, Powder Shot 2",
            "\"2F\" Whistle, Drill Arm 1, Drill Arm 2, Windy Attack 1",
            "\"30\" Bubble Hook 1, Bubble Hook 1, Flash Strike 2, Thunder Head 2",
            "\"31\" Black Ink, Flash Strike 2, Bubble Hook 1, Mummy Hand 2",
            "\"32\" Windy Attack 1, Windy Attack 1, Noise Wizard 1, Noise Wizard 2",
            "\"33\" Buzz Saw 2, Grand Wave 2, Shuriken 1, Ice Spin 1",
            "\"34\" Heavy Cannon, Drill Arm 2, Heat Upper 2, Big Drop 1",
            "\"35\" Mal Wizard 1, Bubble Hook 1, Elec Slash, Arach Attack 1",
            "\"36\" Barrier, Cannon, Cannon, Cannon",
            "\"37\" Double Eater, Whistle, Beast Slap 3, Great Axe",
            "\"38\" Rolling Nuts 2, Rolling Nuts 1, Machine Flame 1, Count Bomb 3",
            "\"39\" Ice Grenade, Ice Grenade, Shark Cutter 2, Wide Wave 3",
            "\"3A\" Edogiri 3, Edogiri 3, Edogiri 2, Edogiri 1",
            "\"3B\" Synch Hook 1, Freeze Knuckle, Heat Upper 3, Stun knuckle",
            "\"3C\" Fire+30, Mech Flame 3, Anger Fire 3, Ox Fire V2",
            "\"3D\" Aqua+30, Shark Cutter 3, Bubble Hook 3, Dia Ice Burn V2",
            "\"3E\" Shuriken 3, Wide Wave 3, Stealth Lazer 3, Smile Coin 3",
            "\"3F\" Machine Flame 3, Dava Flame 3, Anger Fire 3, Heat Upper 3",
            "\"40\" Ice Spin 3, Wide Wave 2, Shark Cutter 3, Bubble Hook 3",
            "\"41\" Skull Arrow 3, Skull Arrow 3, Jet Attack 3, Buki 3",
            "\"42\" Beast Slap 3, Beast Slap 3, Mal Wizard 3, Death Scythe 1",
            "\"43\" Tornado Dance, Air Spread 3, Vulcan Seed 1, Mad Vulcan 3",
            "\"44\" Panic Cloud, Panic Cloud, Flash Strike 3, Powder Shot 3",
            "\"45\" Elec Slash, Mummy Hand 3, Dummy Spider 3, Earth Thunder 3",
            "\"46\" Machine Flame 3, White Meteor, Heavy Drop 3, Count Bomb 3",
            "\"47\" Mini Grenade 1, Sword, Wide sword, Long Sword",
            "\"48\" Windy attack 3, Tornado Dance, Squall 3, Death Scythe 3",
            "\"49\" Sword Fighter 3, Elec Slash, Wood Slash, Dancing Blade 1",
            "\"4A\" Ice Grenade, Wide Wave 3, Shark Attack 3, Heat Axe",
            "\"4B\" Great Axe, Hammer Weapon, Drill Arm 3, Break Sabre",
            "\"4C\" Anger Fire 3, Count Bomb 3, Bobobomb 3, Bobobomb 3",
            "\"4D\" Elec+30, Flash Strike 3, Thunder of Earth 3, Spade Magnes V3",
            "\"4E\" Wood+30, Squall 3, Vulcan Seed 1, Club Strong V3",
            "\"4F\" Break sabre, Drill Arm 3, Sword Fighter 3, Acid Ace V3",
            "\"50\" Stun Knuckle, Freeze Knuckle, Poison Knuckle, Destroy Upper",
            "\"51\" Flash Strike 2, Shuriken 2, Heat Upper 2, Shark Cutter 2",
            "\"52\" Wood Slash, Dummy Spider 2, Stealth Lazer 2, Shuriken 2",
            "\"53\" Meteorite Barrage (Big bang), Gravity Plus, Wide Wave 1, Beast Slap 1",
            "\"54\" Atomic Blazer (Big bang), Attack+10, Heat Upper 1, Beast Slap 1",
            "\"55\" Beast Slap 1, Gravity Plus, Ice Spin 1, Buzz Saw 1",
            "\"56\" Heat Upper 2, Anger Fire 1, Count Bomb 2, Dava Flame 1",
            "\"57\" Wide Wave 2, Shark Cutter 2, Blue Ink, Ice Grenade",
            "\"58\" Flash Strike 3, Elec Slash, Elec Slash, Thunder Head 2",
            "\"59\" Powder Shot 3, Vulcan Seed 1, Shuriken 3, Vulcan Seed 2",
            "\"5A\" Typhoon Dance, Tornado Dance, Windy Attack 3, Death Scythe 3",
            "\"5B\" Heat Upper 3, Hammer Weapon 3, Break Sabre, Heavy drop 3",
            "\"5C\" Grand Wave 3, Sword Fighter 3, Noise Wizard 2, Drill Arm 3",
            "\"5D\" Double Eater, Mal Wizard 2, Beast Slap 3, Jack Corvus V1",
            "\"5E\" Double Eater, Bubble Hook 3, Wide Wave 3, Queen Virgo V1",
            "\"5F\" Buki 3, Heat Upper 3, Great Axe, Grave Joker V1",
            "\"60\" Break Sabre, Stealth Lazer 3, Buzz Saw 3, Acid Ace V1"});
            this.listBox1.Location = new System.Drawing.Point(55, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(953, 382);
            this.listBox1.TabIndex = 0;
            // 
            // MMSF3_wclist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1030, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MMSF3_wclist";
            this.Text = "White Card";
            this.Load += new System.EventHandler(this.MMSF3_wclist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void MMSF3_wclist_Load(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		private void richTextBox1_TextChanged_2(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
		}
	}
}