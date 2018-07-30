namespace Meeting_Organizer
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxUltimate = new System.Windows.Forms.CheckBox();
            this.checkBoxProfessional = new System.Windows.Forms.CheckBox();
            this.checkBoxBasic = new System.Windows.Forms.CheckBox();
            this.checkBoxFree = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Text = Strings.purchasecode;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // checkBoxUltimate
            // 
            resources.ApplyResources(this.checkBoxUltimate, "checkBoxUltimate");
            this.checkBoxUltimate.Name = "checkBoxUltimate";
            this.checkBoxUltimate.Text = global::Meeting_Organizer.Strings.ultimateversion;
            this.checkBoxUltimate.UseVisualStyleBackColor = true;
            this.checkBoxUltimate.Click += new System.EventHandler(this.checkBoxUltimate_Click);
            // 
            // checkBoxProfessional
            // 
            resources.ApplyResources(this.checkBoxProfessional, "checkBoxProfessional");
            this.checkBoxProfessional.Name = "checkBoxProfessional";
            this.checkBoxProfessional.Text = global::Meeting_Organizer.Strings.professionalversion;
            this.checkBoxProfessional.UseVisualStyleBackColor = true;
            this.checkBoxProfessional.Click += new System.EventHandler(this.checkBoxProfessional_Click);
            // 
            // checkBoxBasic
            // 
            resources.ApplyResources(this.checkBoxBasic, "checkBoxBasic");
            this.checkBoxBasic.Name = "checkBoxBasic";
            this.checkBoxBasic.Text = global::Meeting_Organizer.Strings.basicversion;
            this.checkBoxBasic.UseVisualStyleBackColor = true;
            this.checkBoxBasic.Click += new System.EventHandler(this.checkBoxBasic_Click);
            // 
            // checkBoxFree
            // 
            resources.ApplyResources(this.checkBoxFree, "checkBoxFree");
            this.checkBoxFree.Name = "checkBoxFree";
            this.checkBoxFree.Text = global::Meeting_Organizer.Strings.freeversion;
            this.checkBoxFree.UseVisualStyleBackColor = true;
            this.checkBoxFree.Click += new System.EventHandler(this.checkBoxFree_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Text = global::Meeting_Organizer.Strings.saveandrestart;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Text = Strings.back;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form7
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxUltimate);
            this.Controls.Add(this.checkBoxProfessional);
            this.Controls.Add(this.checkBoxBasic);
            this.Controls.Add(this.checkBoxFree);
            this.Name = "Form7";
            this.Text = Strings.upgrades;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxUltimate;
        private System.Windows.Forms.CheckBox checkBoxProfessional;
        private System.Windows.Forms.CheckBox checkBoxBasic;
        private System.Windows.Forms.CheckBox checkBoxFree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}