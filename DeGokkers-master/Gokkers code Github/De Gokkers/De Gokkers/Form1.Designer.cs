namespace De_Gokkers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startRace = new System.Windows.Forms.Button();
            this.textBoxFer = new System.Windows.Forms.TextBox();
            this.textBoxLidy = new System.Windows.Forms.TextBox();
            this.textBoxSietse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericHorseSelect = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericInzet = new System.Windows.Forms.NumericUpDown();
            this.buttonWedt = new System.Windows.Forms.Button();
            this.radioFer = new System.Windows.Forms.RadioButton();
            this.radioLidy = new System.Windows.Forms.RadioButton();
            this.radioSietse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorseSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInzet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startRace);
            this.groupBox1.Controls.Add(this.textBoxFer);
            this.groupBox1.Controls.Add(this.textBoxLidy);
            this.groupBox1.Controls.Add(this.textBoxSietse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericHorseSelect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericInzet);
            this.groupBox1.Controls.Add(this.buttonWedt);
            this.groupBox1.Controls.Add(this.radioFer);
            this.groupBox1.Controls.Add(this.radioLidy);
            this.groupBox1.Controls.Add(this.radioSietse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 215);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "wedbureau";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // startRace
            // 
            this.startRace.Location = new System.Drawing.Point(485, 147);
            this.startRace.Name = "startRace";
            this.startRace.Size = new System.Drawing.Size(75, 23);
            this.startRace.TabIndex = 12;
            this.startRace.Text = "Go!";
            this.startRace.UseVisualStyleBackColor = true;
            this.startRace.Click += new System.EventHandler(this.startRace_Click);
            // 
            // textBoxFer
            // 
            this.textBoxFer.AcceptsReturn = true;
            this.textBoxFer.Location = new System.Drawing.Point(278, 116);
            this.textBoxFer.Name = "textBoxFer";
            this.textBoxFer.ReadOnly = true;
            this.textBoxFer.Size = new System.Drawing.Size(294, 20);
            this.textBoxFer.TabIndex = 11;
            this.textBoxFer.TextChanged += new System.EventHandler(this.textBoxFer_TextChanged);
            // 
            // textBoxLidy
            // 
            this.textBoxLidy.Location = new System.Drawing.Point(278, 93);
            this.textBoxLidy.Name = "textBoxLidy";
            this.textBoxLidy.ReadOnly = true;
            this.textBoxLidy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLidy.Size = new System.Drawing.Size(294, 20);
            this.textBoxLidy.TabIndex = 10;
            this.textBoxLidy.TextChanged += new System.EventHandler(this.textBoxLidy_TextChanged);
            // 
            // textBoxSietse
            // 
            this.textBoxSietse.AcceptsReturn = true;
            this.textBoxSietse.Location = new System.Drawing.Point(278, 70);
            this.textBoxSietse.Name = "textBoxSietse";
            this.textBoxSietse.ReadOnly = true;
            this.textBoxSietse.Size = new System.Drawing.Size(294, 20);
            this.textBoxSietse.TabIndex = 9;
            this.textBoxSietse.TextChanged += new System.EventHandler(this.textBoxSietse_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weddeschappen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericHorseSelect
            // 
            this.numericHorseSelect.Location = new System.Drawing.Point(278, 150);
            this.numericHorseSelect.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericHorseSelect.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHorseSelect.Name = "numericHorseSelect";
            this.numericHorseSelect.Size = new System.Drawing.Size(54, 20);
            this.numericHorseSelect.TabIndex = 7;
            this.numericHorseSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericHorseSelect.ValueChanged += new System.EventHandler(this.numericHorseSelect_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "op paard nummer:";
            // 
            // numericInzet
            // 
            this.numericInzet.Location = new System.Drawing.Point(123, 150);
            this.numericInzet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericInzet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericInzet.Name = "numericInzet";
            this.numericInzet.Size = new System.Drawing.Size(54, 20);
            this.numericInzet.TabIndex = 5;
            this.numericInzet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericInzet.ValueChanged += new System.EventHandler(this.numericInzet_ValueChanged);
            // 
            // buttonWedt
            // 
            this.buttonWedt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWedt.Location = new System.Drawing.Point(50, 150);
            this.buttonWedt.Name = "buttonWedt";
            this.buttonWedt.Size = new System.Drawing.Size(67, 20);
            this.buttonWedt.TabIndex = 4;
            this.buttonWedt.Text = "wedt";
            this.buttonWedt.UseVisualStyleBackColor = true;
            this.buttonWedt.Click += new System.EventHandler(this.buttonWedt_Click);
            // 
            // radioFer
            // 
            this.radioFer.AutoSize = true;
            this.radioFer.Location = new System.Drawing.Point(9, 116);
            this.radioFer.Name = "radioFer";
            this.radioFer.Size = new System.Drawing.Size(14, 13);
            this.radioFer.TabIndex = 3;
            this.radioFer.TabStop = true;
            this.radioFer.UseVisualStyleBackColor = true;
            this.radioFer.CheckedChanged += new System.EventHandler(this.radioFer_CheckedChanged);
            // 
            // radioLidy
            // 
            this.radioLidy.AutoSize = true;
            this.radioLidy.Location = new System.Drawing.Point(9, 93);
            this.radioLidy.Name = "radioLidy";
            this.radioLidy.Size = new System.Drawing.Size(14, 13);
            this.radioLidy.TabIndex = 2;
            this.radioLidy.TabStop = true;
            this.radioLidy.UseVisualStyleBackColor = true;
            this.radioLidy.CheckedChanged += new System.EventHandler(this.radioLidy_CheckedChanged);
            // 
            // radioSietse
            // 
            this.radioSietse.AutoSize = true;
            this.radioSietse.Location = new System.Drawing.Point(9, 70);
            this.radioSietse.Name = "radioSietse";
            this.radioSietse.Size = new System.Drawing.Size(14, 13);
            this.radioSietse.TabIndex = 1;
            this.radioSietse.TabStop = true;
            this.radioSietse.UseVisualStyleBackColor = true;
            this.radioSietse.CheckedChanged += new System.EventHandler(this.radioSietse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min: €5,- Max: €15,-";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(601, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 422);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(163, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 150);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(163, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(163, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::De_Gokkers.Properties.Resources.racebaan_600x2001;
            this.ClientSize = new System.Drawing.Size(774, 414);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(790, 453);
            this.MinimumSize = new System.Drawing.Size(790, 453);
            this.Name = "Form1";
            this.Text = "Gokker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHorseSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInzet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericInzet;
        private System.Windows.Forms.Button buttonWedt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericHorseSelect;
        private System.Windows.Forms.Button startRace;
        private System.Windows.Forms.TextBox textBoxLidy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBoxFer;
        public System.Windows.Forms.RadioButton radioFer;
        public System.Windows.Forms.RadioButton radioLidy;
        public System.Windows.Forms.RadioButton radioSietse;
        public System.Windows.Forms.TextBox textBoxSietse;
    }
}

