namespace week10
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
            this.comboHome = new System.Windows.Forms.ComboBox();
            this.comboAway = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.homeMan = new System.Windows.Forms.Label();
            this.awayMan = new System.Windows.Forms.Label();
            this.homeCap = new System.Windows.Forms.Label();
            this.awayCap = new System.Windows.Forms.Label();
            this.stadium = new System.Windows.Forms.Label();
            this.capacity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.skor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboHome
            // 
            this.comboHome.FormattingEnabled = true;
            this.comboHome.Location = new System.Drawing.Point(72, 74);
            this.comboHome.Name = "comboHome";
            this.comboHome.Size = new System.Drawing.Size(198, 28);
            this.comboHome.TabIndex = 0;
            this.comboHome.SelectedIndexChanged += new System.EventHandler(this.comboHome_SelectedIndexChanged);
            // 
            // comboAway
            // 
            this.comboAway.FormattingEnabled = true;
            this.comboAway.Location = new System.Drawing.Point(510, 74);
            this.comboAway.Name = "comboAway";
            this.comboAway.Size = new System.Drawing.Size(198, 28);
            this.comboAway.TabIndex = 1;
            this.comboAway.SelectedIndexChanged += new System.EventHandler(this.comboAway_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Captain :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(506, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Manager :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Captain :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stadium :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Capacity :";
            // 
            // homeMan
            // 
            this.homeMan.AutoSize = true;
            this.homeMan.Location = new System.Drawing.Point(154, 129);
            this.homeMan.Name = "homeMan";
            this.homeMan.Size = new System.Drawing.Size(39, 20);
            this.homeMan.TabIndex = 9;
            this.homeMan.Text = "------";
            // 
            // awayMan
            // 
            this.awayMan.AutoSize = true;
            this.awayMan.Location = new System.Drawing.Point(592, 129);
            this.awayMan.Name = "awayMan";
            this.awayMan.Size = new System.Drawing.Size(39, 20);
            this.awayMan.TabIndex = 10;
            this.awayMan.Text = "------";
            // 
            // homeCap
            // 
            this.homeCap.AutoSize = true;
            this.homeCap.Location = new System.Drawing.Point(154, 158);
            this.homeCap.Name = "homeCap";
            this.homeCap.Size = new System.Drawing.Size(39, 20);
            this.homeCap.TabIndex = 11;
            this.homeCap.Text = "------";
            // 
            // awayCap
            // 
            this.awayCap.AutoSize = true;
            this.awayCap.Location = new System.Drawing.Point(592, 158);
            this.awayCap.Name = "awayCap";
            this.awayCap.Size = new System.Drawing.Size(39, 20);
            this.awayCap.TabIndex = 12;
            this.awayCap.Text = "------";
            // 
            // stadium
            // 
            this.stadium.AutoSize = true;
            this.stadium.Location = new System.Drawing.Point(382, 239);
            this.stadium.Name = "stadium";
            this.stadium.Size = new System.Drawing.Size(39, 20);
            this.stadium.TabIndex = 13;
            this.stadium.Text = "------";
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Location = new System.Drawing.Point(382, 279);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(39, 20);
            this.capacity.TabIndex = 14;
            this.capacity.Text = "------";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Tanggal :";
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Location = new System.Drawing.Point(399, 394);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(39, 20);
            this.tanggal.TabIndex = 17;
            this.tanggal.Text = "------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(343, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Skor :";
            // 
            // skor
            // 
            this.skor.AutoSize = true;
            this.skor.Location = new System.Drawing.Point(399, 428);
            this.skor.Name = "skor";
            this.skor.Size = new System.Drawing.Size(39, 20);
            this.skor.TabIndex = 19;
            this.skor.Text = "------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 715);
            this.Controls.Add(this.skor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.capacity);
            this.Controls.Add(this.stadium);
            this.Controls.Add(this.awayCap);
            this.Controls.Add(this.homeCap);
            this.Controls.Add(this.awayMan);
            this.Controls.Add(this.homeMan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboAway);
            this.Controls.Add(this.comboHome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboHome;
        private System.Windows.Forms.ComboBox comboAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label homeMan;
        private System.Windows.Forms.Label awayMan;
        private System.Windows.Forms.Label homeCap;
        private System.Windows.Forms.Label awayCap;
        private System.Windows.Forms.Label stadium;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label skor;
    }
}

