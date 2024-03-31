namespace GestionEleve.Eleve
{
    partial class EleveAdd
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomComplet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInscription = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Complet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomComplet
            // 
            this.nomComplet.Location = new System.Drawing.Point(26, 51);
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.Size = new System.Drawing.Size(229, 22);
            this.nomComplet.TabIndex = 2;
            this.nomComplet.TextChanged += new System.EventHandler(this.nomComplet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de Naissance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(26, 110);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(229, 22);
            this.dob.TabIndex = 5;
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date d\'inscription";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateInscription
            // 
            this.dateInscription.Location = new System.Drawing.Point(26, 180);
            this.dateInscription.Name = "dateInscription";
            this.dateInscription.Size = new System.Drawing.Size(229, 22);
            this.dateInscription.TabIndex = 7;
            this.dateInscription.ValueChanged += new System.EventHandler(this.dateInscription_ValueChanged);
            // 
            // EleveAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 291);
            this.Controls.Add(this.dateInscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomComplet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "EleveAdd";
            this.Text = "Ajouter Eleve";
            this.Load += new System.EventHandler(this.EleveAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomComplet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateInscription;

    }
}