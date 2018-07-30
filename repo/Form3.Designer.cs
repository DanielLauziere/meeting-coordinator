namespace Meeting_Organizer
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxKhmer = new System.Windows.Forms.CheckBox();
            this.checkBoxEspanol = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglish = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSplash = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxUltimate = new System.Windows.Forms.CheckBox();
            this.checkBoxProfessional = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic = new System.Windows.Forms.CheckBox();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxRemote = new System.Windows.Forms.CheckBox();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(573, 377);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = global::Meeting_Organizer.Strings.saveandrestart;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preferences";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 240);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = global::Meeting_Organizer.Strings.languages;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxKhmer);
            this.groupBox1.Controls.Add(this.checkBoxEspanol);
            this.groupBox1.Controls.Add(this.checkBoxEnglish);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Languages";
            // 
            // checkBoxKhmer
            // 
            this.checkBoxKhmer.AutoSize = true;
            this.checkBoxKhmer.Location = new System.Drawing.Point(6, 65);
            this.checkBoxKhmer.Name = "checkBoxKhmer";
            this.checkBoxKhmer.Size = new System.Drawing.Size(43, 17);
            this.checkBoxKhmer.TabIndex = 2;
            this.checkBoxKhmer.Text = "ខ្មែរ";
            this.checkBoxKhmer.UseVisualStyleBackColor = true;
            this.checkBoxKhmer.Click += new System.EventHandler(this.checkBoxKhmer_Click);
            // 
            // checkBoxEspanol
            // 
            this.checkBoxEspanol.AutoSize = true;
            this.checkBoxEspanol.Location = new System.Drawing.Point(6, 42);
            this.checkBoxEspanol.Name = "checkBoxEspanol";
            this.checkBoxEspanol.Size = new System.Drawing.Size(64, 17);
            this.checkBoxEspanol.TabIndex = 1;
            this.checkBoxEspanol.Text = "Español";
            this.checkBoxEspanol.UseVisualStyleBackColor = true;
            this.checkBoxEspanol.Click += new System.EventHandler(this.checkBoxEspanol_Click);
            // 
            // checkBoxEnglish
            // 
            this.checkBoxEnglish.AutoSize = true;
            this.checkBoxEnglish.Location = new System.Drawing.Point(6, 19);
            this.checkBoxEnglish.Name = "checkBoxEnglish";
            this.checkBoxEnglish.Size = new System.Drawing.Size(60, 17);
            this.checkBoxEnglish.TabIndex = 0;
            this.checkBoxEnglish.Text = "English";
            this.checkBoxEnglish.UseVisualStyleBackColor = true;
            this.checkBoxEnglish.Click += new System.EventHandler(this.checkBoxEnglish_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = global::Meeting_Organizer.Strings.general;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxSplash);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup";
            // 
            // checkBoxSplash
            // 
            this.checkBoxSplash.AutoSize = true;
            this.checkBoxSplash.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSplash.Name = "checkBoxSplash";
            this.checkBoxSplash.Size = new System.Drawing.Size(90, 17);
            this.checkBoxSplash.TabIndex = 0;
            this.checkBoxSplash.Text = global::Meeting_Organizer.Strings.blackscreen;
            this.checkBoxSplash.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.checkBoxUltimate);
            this.tabPage3.Controls.Add(this.checkBoxProfessional);
            this.tabPage3.Controls.Add(this.checkBoxBasic);
            this.tabPage3.Controls.Add(this.checkBoxFree);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(550, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = global::Meeting_Organizer.Strings.upgrades;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Purchase Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 4;
            // 
            // checkBoxUltimate
            // 
            this.checkBoxUltimate.AutoSize = true;
            this.checkBoxUltimate.Location = new System.Drawing.Point(6, 75);
            this.checkBoxUltimate.Name = "checkBoxUltimate";
            this.checkBoxUltimate.Size = new System.Drawing.Size(102, 17);
            this.checkBoxUltimate.TabIndex = 3;
            this.checkBoxUltimate.Text = global::Meeting_Organizer.Strings.ultimateversion;
            this.checkBoxUltimate.UseVisualStyleBackColor = true;
            this.checkBoxUltimate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxUltimate_Click);
            // 
            // checkBoxProfessional
            // 
            this.checkBoxProfessional.AutoSize = true;
            this.checkBoxProfessional.Location = new System.Drawing.Point(6, 52);
            this.checkBoxProfessional.Name = "checkBoxProfessional";
            this.checkBoxProfessional.Size = new System.Drawing.Size(121, 17);
            this.checkBoxProfessional.TabIndex = 2;
            this.checkBoxProfessional.Text = global::Meeting_Organizer.Strings.professionalversion;
            this.checkBoxProfessional.UseVisualStyleBackColor = true;
            this.checkBoxProfessional.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxProfessional_Click);
            // 
            // checkBoxBasic
            // 
            this.checkBoxBasic.AutoSize = true;
            this.checkBoxBasic.Location = new System.Drawing.Point(6, 29);
            this.checkBoxBasic.Name = "checkBoxBasic";
            this.checkBoxBasic.Size = new System.Drawing.Size(90, 17);
            this.checkBoxBasic.TabIndex = 1;
            this.checkBoxBasic.Text = global::Meeting_Organizer.Strings.basicversion;
            this.checkBoxBasic.UseVisualStyleBackColor = true;
            this.checkBoxBasic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxBasic_Click);
            // 
            // checkBoxFree
            // 
            this.checkBoxFree.AutoSize = true;
            this.checkBoxFree.Location = new System.Drawing.Point(6, 6);
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Size = new System.Drawing.Size(85, 17);
            this.checkBoxFree.TabIndex = 0;
            this.checkBoxFree.Text = global::Meeting_Organizer.Strings.freeversion;
            this.checkBoxFree.UseVisualStyleBackColor = true;
            this.checkBoxFree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxFree_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBoxRemote);
            this.tabPage4.Controls.Add(this.checkBoxLocal);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(550, 214);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = global::Meeting_Organizer.Strings.location;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemote
            // 
            this.checkBoxRemote.AutoSize = true;
            this.checkBoxRemote.Location = new System.Drawing.Point(282, 136);
            this.checkBoxRemote.Name = "checkBoxRemote";
            this.checkBoxRemote.Size = new System.Drawing.Size(196, 17);
            this.checkBoxRemote.TabIndex = 3;
            this.checkBoxRemote.Text = global::Meeting_Organizer.Strings.remotelocation;
            this.checkBoxRemote.UseVisualStyleBackColor = true;
            this.checkBoxRemote.Click += new System.EventHandler(this.checkBoxRemote_Click);
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(20, 136);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(183, 17);
            this.checkBoxLocal.TabIndex = 2;
            this.checkBoxLocal.Text = global::Meeting_Organizer.Strings.localmeetinglocation;
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            this.checkBoxLocal.Click += new System.EventHandler(this.checkBoxLocal_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(302, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 124);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkBoxRemote_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(38, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 124);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkBoxLocal_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 377);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Preferences";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEspanol;
        private System.Windows.Forms.CheckBox checkBoxEnglish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxSplash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxKhmer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxUltimate;
        private System.Windows.Forms.CheckBox checkBoxProfessional;
        private System.Windows.Forms.CheckBox checkBoxBasic;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxRemote;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}