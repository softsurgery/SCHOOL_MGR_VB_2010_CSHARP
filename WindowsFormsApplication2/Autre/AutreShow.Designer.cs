namespace GestionEleve.Autre
{
    partial class AutreShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.section1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.niveau1 = new System.Windows.Forms.ComboBox();
            this.exec1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.matiere1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.exec3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.annee2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.exec2 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label10 = new System.Windows.Forms.Label();
            this.section2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.niveau2 = new System.Windows.Forms.ComboBox();
            this.exec4 = new System.Windows.Forms.Button();
            this.annee1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.windowTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(823, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 346);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quels étudiants ont fait une section";
            // 
            // section1
            // 
            this.section1.FormattingEnabled = true;
            this.section1.Location = new System.Drawing.Point(308, 64);
            this.section1.Name = "section1";
            this.section1.Size = new System.Drawing.Size(121, 24);
            this.section1.TabIndex = 7;
            this.section1.SelectedIndexChanged += new System.EventHandler(this.section1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "en année d\'études";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "en";
            // 
            // niveau1
            // 
            this.niveau1.FormattingEnabled = true;
            this.niveau1.Location = new System.Drawing.Point(65, 88);
            this.niveau1.Name = "niveau1";
            this.niveau1.Size = new System.Drawing.Size(121, 24);
            this.niveau1.TabIndex = 11;
            // 
            // exec1
            // 
            this.exec1.Location = new System.Drawing.Point(308, 110);
            this.exec1.Name = "exec1";
            this.exec1.Size = new System.Drawing.Size(95, 38);
            this.exec1.TabIndex = 12;
            this.exec1.Text = "Executer";
            this.exec1.UseVisualStyleBackColor = true;
            this.exec1.Click += new System.EventHandler(this.exec1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quels sont les instructeurs qui enseignent";
            // 
            // matiere1
            // 
            this.matiere1.FormattingEnabled = true;
            this.matiere1.Location = new System.Drawing.Point(359, 285);
            this.matiere1.Name = "matiere1";
            this.matiere1.Size = new System.Drawing.Size(121, 24);
            this.matiere1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "?";
            // 
            // exec3
            // 
            this.exec3.Location = new System.Drawing.Point(308, 323);
            this.exec3.Name = "exec3";
            this.exec3.Size = new System.Drawing.Size(95, 38);
            this.exec3.TabIndex = 17;
            this.exec3.Text = "Executer";
            this.exec3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Quels étudiants sont nés dans l\'année";
            // 
            // annee2
            // 
            this.annee2.Location = new System.Drawing.Point(329, 172);
            this.annee2.Name = "annee2";
            this.annee2.Size = new System.Drawing.Size(200, 22);
            this.annee2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(535, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "?";
            // 
            // exec2
            // 
            this.exec2.Location = new System.Drawing.Point(308, 213);
            this.exec2.Name = "exec2";
            this.exec2.Size = new System.Drawing.Size(95, 38);
            this.exec2.TabIndex = 21;
            this.exec2.Text = "Executer";
            this.exec2.UseVisualStyleBackColor = true;
            this.exec2.Click += new System.EventHandler(this.exec2_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 524);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Quels sont les matieres des  élèves de la section";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // section2
            // 
            this.section2.FormattingEnabled = true;
            this.section2.Location = new System.Drawing.Point(416, 389);
            this.section2.Name = "section2";
            this.section2.Size = new System.Drawing.Size(121, 24);
            this.section2.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(543, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "du niveau";
            // 
            // niveau2
            // 
            this.niveau2.FormattingEnabled = true;
            this.niveau2.Location = new System.Drawing.Point(629, 389);
            this.niveau2.Name = "niveau2";
            this.niveau2.Size = new System.Drawing.Size(121, 24);
            this.niveau2.TabIndex = 26;
            this.niveau2.SelectedIndexChanged += new System.EventHandler(this.niveau2_SelectedIndexChanged);
            // 
            // exec4
            // 
            this.exec4.Location = new System.Drawing.Point(308, 437);
            this.exec4.Name = "exec4";
            this.exec4.Size = new System.Drawing.Size(95, 38);
            this.exec4.TabIndex = 27;
            this.exec4.Text = "Executer";
            this.exec4.UseVisualStyleBackColor = true;
            this.exec4.Click += new System.EventHandler(this.exec4_Click);
            // 
            // annee1
            // 
            this.annee1.Location = new System.Drawing.Point(586, 64);
            this.annee1.Name = "annee1";
            this.annee1.Size = new System.Drawing.Size(200, 22);
            this.annee1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(756, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "?";
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Cooper Black", 22.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.Location = new System.Drawing.Point(138, 1);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(458, 44);
            this.windowTitle.TabIndex = 30;
            this.windowTitle.Text = "Dashboard Statistique";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(825, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Resultat :";
            // 
            // AutreShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.annee1);
            this.Controls.Add(this.exec4);
            this.Controls.Add(this.niveau2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.section2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.exec2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.annee2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exec3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.matiere1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exec1);
            this.Controls.Add(this.niveau1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.section1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "AutreShow";
            this.Size = new System.Drawing.Size(1180, 524);
            this.Load += new System.EventHandler(this.AutreShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox section1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox niveau1;
        private System.Windows.Forms.Button exec1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox matiere1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exec3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker annee2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exec2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox section2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox niveau2;
        private System.Windows.Forms.Button exec4;
        private System.Windows.Forms.DateTimePicker annee1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.Label label1;
    }
}
