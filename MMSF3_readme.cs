using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace WindowsFormsMMSF
{
	public class MMSF3_readme : Form
	{
		private IContainer components;

		private Label label1;

		private Label label2;

		private Label label5;

		private Label label6;

		private TextBox textBox1;

		private Label label7;

		private Label label8;

		private Label label9;

		private Label label10;

		private Label label11;

		private Label label12;

		private TextBox textBox2;

		private TextBox textBox3;

		private TextBox textBox4;

		private TextBox textBox5;

		private TextBox textBox6;

		public MMSF3_readme()
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
            this.Icon = Properties.Resources.icon_Xpo_icon;
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MMSF3_readme));
			this.label1 = new Label();
			this.label2 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.textBox1 = new TextBox();
			this.label7 = new Label();
			this.label8 = new Label();
			this.label9 = new Label();
			this.label10 = new Label();
			this.label11 = new Label();
			this.label12 = new Label();
			this.textBox2 = new TextBox();
			this.textBox3 = new TextBox();
			this.textBox4 = new TextBox();
			this.textBox5 = new TextBox();
			this.textBox6 = new TextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 128);
			this.label1.Location = new Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "How to use";
			this.label1.Click += new EventHandler(this.label1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(12, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(511, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = componentResourceManager.GetString("label2.Text");
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12f, FontStyle.Regular, GraphicsUnit.Point, 128);
			this.label5.Location = new Point(12, 78);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Fake brother setting";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(13, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(457, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "To make a fake brother, You have to enable SSS access port then click the red colored \r\nwhich part you want to make a fake brother.";
			this.textBox1.Location = new Point(14, 148);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(94, 141);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new EventHandler(this.textBox1_TextChanged);
			this.label7.AutoSize = true;
			this.label7.ForeColor = Color.Brown;
			this.label7.Location = new Point(13, 133);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 12);
			this.label7.TabIndex = 7;
			this.label7.Text = "Top Left";
			this.label7.Click += new EventHandler(this.label7_Click);
			this.label8.AutoSize = true;
			this.label8.ForeColor = Color.Brown;
			this.label8.Location = new Point(112, 133);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 12);
			this.label8.TabIndex = 8;
			this.label8.Text = "Middle Left";
			this.label8.Click += new EventHandler(this.label8_Click);
			this.label9.AutoSize = true;
			this.label9.ForeColor = Color.Brown;
			this.label9.Location = new Point(212, 133);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 12);
			this.label9.TabIndex = 9;
			this.label9.Text = "Bottom Left";
			this.label9.Click += new EventHandler(this.label9_Click);
			this.label10.AutoSize = true;
			this.label10.ForeColor = Color.Brown;
			this.label10.Location = new Point(312, 133);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(55, 12);
			this.label10.TabIndex = 10;
			this.label10.Text = "Top Right";
			this.label10.Click += new EventHandler(this.label10_Click);
			this.label11.AutoSize = true;
			this.label11.ForeColor = Color.Brown;
			this.label11.Location = new Point(412, 133);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label11.Size = new System.Drawing.Size(69, 12);
			this.label11.TabIndex = 11;
			this.label11.Text = "Middle Right";
			this.label11.Click += new EventHandler(this.label11_Click);
			this.label12.AutoSize = true;
			this.label12.ForeColor = Color.Brown;
			this.label12.Location = new Point(514, 133);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 12);
			this.label12.TabIndex = 12;
			this.label12.Text = "Bottom Right";
			this.label12.Click += new EventHandler(this.label12_Click);
			this.textBox2.Location = new Point(114, 148);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(94, 141);
			this.textBox2.TabIndex = 13;
			this.textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);
			this.textBox3.Location = new Point(214, 148);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ScrollBars = ScrollBars.Vertical;
			this.textBox3.Size = new System.Drawing.Size(94, 141);
			this.textBox3.TabIndex = 14;
			this.textBox4.Location = new Point(314, 148);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.ScrollBars = ScrollBars.Vertical;
			this.textBox4.Size = new System.Drawing.Size(94, 141);
			this.textBox4.TabIndex = 15;
			this.textBox5.Location = new Point(414, 148);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ScrollBars = ScrollBars.Vertical;
			this.textBox5.Size = new System.Drawing.Size(94, 141);
			this.textBox5.TabIndex = 16;
			this.textBox6.Location = new Point(514, 148);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.ScrollBars = ScrollBars.Vertical;
			this.textBox6.Size = new System.Drawing.Size(94, 141);
			this.textBox6.TabIndex = 17;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(734, 308);
			base.Controls.Add(this.textBox6);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Name = "MMSF3_readme";
			this.Text = "read me";
			base.Load += new EventHandler(this.MMSF3_readme_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void label10_Click(object sender, EventArgs e)
		{
			this.textBox4.Text = string.Concat("220F663C 00000003\n220F663C 00000002\n220F52A5 00000001\n220F9EC2 00000001\n220F5252 00000001\n220F529A 00000082\n220F3929 00000005", "\r\n".ToString());
		}

		private void label11_Click(object sender, EventArgs e)
		{
			this.textBox5.Text = string.Concat("220F6658 00000003\n220F6658 00000002\n220F58E5 00000001\n220F9EC3 00000004\n220F5892 00000001\n220F58DA 00000082\n220F392D 00000005", "\r\n".ToString());
		}

		private void label12_Click(object sender, EventArgs e)
		{
			this.textBox6.Text = string.Concat("220F6674 00000003\n220F6674 00000002\n220F5F25 00000001\n220F9EC4 00000006\n220F5ED2 00000001\n220F5F1A 00000082\n220F3931 00000005", "\r\n".ToString());
		}

		private void label7_Click(object sender, EventArgs e)
		{
			this.textBox1.Text = string.Concat("220F65E8 00000003\n220F65E8 00000002\n220F3FE5 00000001\n220F9EBF 00000002\n220F3F92 00000001\n220F3FDA 00000082\n220F391D 00000005", "\r\n".ToString());
		}

		private void label8_Click(object sender, EventArgs e)
		{
			this.textBox2.Text = string.Concat("220F6604 00000003\n220F6604 00000002\n220F4625 00000001\n220F9EC0 00000005\n220F45D2 00000001\n220F461A 00000082\n220F3921 00000005", "\r\n".ToString());
		}

		private void label9_Click(object sender, EventArgs e)
		{
			this.textBox3.Text = string.Concat("220F6620 00000003\n220F6620 00000002\n220F4C65 00000001\n220F9EC1 00000001\n220F4C12 00000001\n220F4C5A 00000082\n220F3925 00000005", "\r\n".ToString());
		}

		private void MMSF3_readme_Load(object sender, EventArgs e)
		{
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}
	}
}