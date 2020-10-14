namespace RPG_char_gen
{
    partial class Main_window
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Tbox_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Tbox_char_name = new System.Windows.Forms.TextBox();
            this.Tbox_race = new System.Windows.Forms.TextBox();
            this.Tbox_origin = new System.Windows.Forms.TextBox();
            this.Tbox_age = new System.Windows.Forms.TextBox();
            this.Cbox_gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Your name";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tbox_name
            // 
            this.Tbox_name.AccessibleDescription = "Name of your character";
            this.Tbox_name.AccessibleName = "Enter the name of your character";
            this.Tbox_name.Location = new System.Drawing.Point(12, 26);
            this.Tbox_name.MaxLength = 255;
            this.Tbox_name.Name = "Tbox_name";
            this.Tbox_name.Size = new System.Drawing.Size(301, 20);
            this.Tbox_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tbox_char_name
            // 
            this.Tbox_char_name.Location = new System.Drawing.Point(12, 66);
            this.Tbox_char_name.Name = "Tbox_char_name";
            this.Tbox_char_name.Size = new System.Drawing.Size(301, 20);
            this.Tbox_char_name.TabIndex = 3;
            // 
            // Tbox_race
            // 
            this.Tbox_race.Location = new System.Drawing.Point(12, 107);
            this.Tbox_race.Name = "Tbox_race";
            this.Tbox_race.Size = new System.Drawing.Size(244, 20);
            this.Tbox_race.TabIndex = 4;
            // 
            // Tbox_origin
            // 
            this.Tbox_origin.Location = new System.Drawing.Point(12, 146);
            this.Tbox_origin.Name = "Tbox_origin";
            this.Tbox_origin.Size = new System.Drawing.Size(244, 20);
            this.Tbox_origin.TabIndex = 5;
            // 
            // Tbox_age
            // 
            this.Tbox_age.Location = new System.Drawing.Point(12, 195);
            this.Tbox_age.Name = "Tbox_age";
            this.Tbox_age.Size = new System.Drawing.Size(100, 20);
            this.Tbox_age.TabIndex = 6;
            // 
            // Cbox_gender
            // 
            this.Cbox_gender.FormattingEnabled = true;
            this.Cbox_gender.Items.AddRange(new object[] {
            "M",
            "F",
            "Other"});
            this.Cbox_gender.Location = new System.Drawing.Point(181, 195);
            this.Cbox_gender.Name = "Cbox_gender";
            this.Cbox_gender.Size = new System.Drawing.Size(43, 22);
            this.Cbox_gender.TabIndex = 7;
            this.Cbox_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your character Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Race";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Origin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";
            // 
            // Main_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(441, 290);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbox_gender);
            this.Controls.Add(this.Tbox_age);
            this.Controls.Add(this.Tbox_origin);
            this.Controls.Add(this.Tbox_race);
            this.Controls.Add(this.Tbox_char_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tbox_name);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Main_window";
            this.Text = "RPG character generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tbox_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tbox_char_name;
        private System.Windows.Forms.TextBox Tbox_race;
        private System.Windows.Forms.TextBox Tbox_origin;
        private System.Windows.Forms.TextBox Tbox_age;
        private System.Windows.Forms.ComboBox Cbox_gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

