using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3_NKGlist : Form
	{
		private IContainer components;

		private ListBox listBox1;

		private Label label1;

		public MMSF3_NKGlist()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MMSF3_NKGlist));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "♥1: Leo Kingdom Noise - Fire GA",
            "♥1: Boodach Noise - HP+200",
            "♥2: Scorcher Noise - Machine Flame Charge Shot",
            "♥2: Moaian Noise - Break+10",
            "♥3: Ox Fire Noise - Super Armor",
            "♥3: Bubba Dance Noise - Atk+10 Support",
            "♥4: Raid Noise - HP+250",
            "♥5: Melamander Noise - Fire+10",
            "♥5: Sirius Noise - Break+20",
            "♥6: Koma Noise - Atk Panel Support",
            "♥7: Doom Count Noise - Flash Body",
            "♥7: Boom Noise - Fire+10",
            "♥8: Libra Scales Noise - HP+400",
            "♥8: Ku\'i Noise - Heavy Drop CS",
            "♥9: Mettenna Noise - Reflect",
            "♥9: Musashi Noise - Sword+10",
            "♥10: War-Rock Copy - Double Eater Support",
            "♥10: Bom Noise - Bombalizer Support",
            "♥11: Jack Corvus Noise - Fire+20",
            "♥11: RockyG Noise - Cross Shot Charge Shot",
            "♥12: HarpNote Noise - Normal GA+",
            "♥12: Hot Roader Noise - HP+150",
            "♥13: Grabity Noise - +Poison Panel",
            "♥13: Apollo Flame Noise - First Aura",
            "♦1: Hare Jet Noise - +Ice Panel",
            "♦1: Wibbledee Noise - Aqua+10",
            "♦2: Cancer Bubble Noise - Bubble Body",
            "♦2: Stream Cancer Noise - Ice Support",
            "♦3: Blue Shark Noise - Aqua+10",
            "♦3: Spinguin Noise - Ice Spin Charge Shot",
            "♦4: Junk-O Noise - Break+10",
            "♦4: General Auriga Noise - Whistle Support",
            "♦5: Chakram Noise - BuzzSaw Charge",
            "♦5: Jammer Noise - HP+250",
            "♦6: Yeti Blizzard Noise - Freeze Body",
            "♦6: Sno Roll Noise - First Barrier",
            "♦7: Dia Ice Burn Noise - Aqua+20",
            "♦7: Bone Archer Noise - +Gravity",
            "♦8: Mal Wizard Noise - +ParaPanel",
            "♦9: Octo Ninja Noise - Black Ink Support",
            "♦10: Piran Noise - HP+250",
            "♦10: Cannon Base Noise - HP+150",
            "♦11: Plesio Surf Noise - Paralyze+ Support",
            "♦11: Gooey Noise - Gravity Body",
            "♦12: Lu Pelvis Noise - +Panic",
            "♦12: Queen Virgo Noise - Mega Class+1",
            "♦13: Air Squiggle Noise - HP+250",
            "♦13: Pegasus Magic - Aqua GA+",
            "♠1: McCleaver Noise - HP+200",
            "♠2: Bell Gong Noise - HP+150",
            "♠2: Voltragon Noise - Elec+10",
            "♠3: Moon Destroyer Noise - HP+300",
            "♠3: Smiles Noise - HP+150",
            "♠4: Zapper Noise - Flash Strike Charge Shot",
            "♠4: Boom Bolt Noise - Panic Cloud Support",
            "♠5: Eyez Noise - +Invisible",
            "♠6: Dark Reaper Noise - HP+200",
            "♠6: Crown Thunder Noise - Paralyze Stage Support",
            "♠7: Lampis Noise - Elec+10",
            "♠7: Phantom Black Noise - Under Shirt",
            "♠8: Shock Mummy Noise - HP+150",
            "♠8: Zap Ace Noise - +Paralyze",
            "♠9: Empty Noise - Paralyze Body",
            "♠9: Noise Wizard Noise - GNull Panel",
            "♠10: Base Mortar Noise - Mad Vulcan Charge",
            "♠10: Spade Magnes Noise - Elec+20",
            "♠11: Stealth Noise - HP+150",
            "♠11: Great Axe Noise - HP+250",
            "♠12: Peakaboo Noise - +Blind",
            "♠13: Burai Noise - Sword+20",
            "♠13: Magera Noise - Card Heal",
            "♣1: Gemini Spark Noise - ElecGA+",
            "♣1: Mu Defender Noise - Mu Technology Charge Shot",
            "♣1: Rhino Horn Noise - HP+250",
            "♣2: Condor Geograph Noise - Air Shoes",
            "♣2: Private Mop Noise - Wood+10",
            "♣3: Crowcar Noise - HP+250",
            "♣4: Flit Noise - Wood+20",
            "♣4: Wolf Woods Noise - HP+400",
            "♣5: Mono Sword Noise - Sword+10",
            "♣5: Dragon Sky Noise - Wood GA+",
            "♣6: Storm Noise - +Wind",
            "♣6: Cygnus Wing Noise - Float Shoes",
            "♣7: Grass Pollen Noise - +Wood Panel",
            "♣7: Nutty Noise - Spreader Charge Shot",
            "♣8: Tropi Conga Noise - HP+250",
            "♣8: Kung Foo Kid Noise - Quick Gauge",
            "♣9: Club Strong Noise - Wood+20",
            "♣9: Fokx Noise - Kawarimi",
            "♣10: Murian Noise - Divide Line Support",
            "♣11: Mat Jinn Noise - Grass Support",
            "♣12: Puff Noise - Recover 30 Support",
            "♣12: Queen Ophiucus Noise - HP+400",
            "♣13: Arachnid Noise - HP+250",
            "♣13: ShuriKen Noise - Shuriken Charge Shot",
            "★: Grave Joker Noise - Body Pack (Super Armor, Float Shoes, Air Shoes, Under Shir" +
                "t)",
            "★: Andromeda Noise - Max Buster",
            "★: Acid Ace Noise - Auto Lock",
            "★: Le Mu Noise - Invisible Support",
            "★: Crimson Dragon Noise- HP+500"});
            this.listBox1.Location = new System.Drawing.Point(33, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(819, 403);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Mincho", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(324, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Noise Card List";
            // 
            // MMSF3_NKGlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(885, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MMSF3_NKGlist";
            this.Text = "Noise Card List";
            this.Load += new System.EventHandler(this.MMSF3_NKGlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void MMSF3_NKGlist_Load(object sender, EventArgs e)
		{
		}
	}
}