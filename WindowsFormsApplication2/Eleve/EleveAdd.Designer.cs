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
            this.ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomComplet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInscription = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nomCompletErreur = new System.Windows.Forms.Label();
            this.dateDeNaissanceErreur = new System.Windows.Forms.Label();
            this.dateDinscriptionErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(123, 290);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(92, 33);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Complet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomComplet
            // 
            this.nomComplet.Location = new System.Drawing.Point(26, 75);
            this.nomComplet.Name = "nomComplet";
            this.nomComplet.Size = new System.Drawing.Size(290, 22);
            this.nomComplet.TabIndex = 2;
            this.nomComplet.TextChanged += new System.EventHandler(this.nomComplet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date de Naissance";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(27, 147);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(290, 22);
            this.dob.TabIndex = 5;
            this.dob.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date d\'inscription";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateInscription
            // 
            this.dateInscription.Location = new System.Drawing.Point(28, 226);
            this.dateInscription.Name = "dateInscription";
            this.dateInscription.Size = new System.Drawing.Size(290, 22);
            this.dateInscription.TabIndex = 7;
            this.dateInscription.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dateInscription.ValueChanged += new System.EventHandler(this.dateInscription_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Formulaire Eleve";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nomCompletErreur
            // 
            this.nomCompletErreur.AutoSize = true;
            this.nomCompletErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCompletErreur.ForeColor = System.Drawing.Color.Red;
            this.nomCompletErreur.Location = new System.Drawing.Point(30, 100);
            this.nomCompletErreur.Name = "nomCompletErreur";
            this.nomCompletErreur.Size = new System.Drawing.Size(0, 17);
            this.nomCompletErreur.TabIndex = 9;
            this.nomCompletErreur.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateDeNaissanceErreur
            // 
            this.dateDeNaissanceErreur.AutoSize = true;
            this.dateDeNaissanceErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDeNaissanceErreur.ForeColor = System.Drawing.Color.Red;
            this.dateDeNaissanceErreur.Location = new System.Drawing.Point(31, 172);
            this.dateDeNaissanceErreur.Name = "dateDeNaissanceErreur";
            this.dateDeNaissanceErreur.Size = new System.Drawing.Size(0, 17);
            this.dateDeNaissanceErreur.TabIndex = 9;
            this.dateDeNaissanceErreur.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateDinscriptionErreur
            // 
            this.dateDinscriptionErreur.AutoSize = true;
            this.dateDinscriptionErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDinscriptionErreur.ForeColor = System.Drawing.Color.Red;
            this.dateDinscriptionErreur.Location = new System.Drawing.Point(32, 252);
            this.dateDinscriptionErreur.Name = "dateDinscriptionErreur";
            this.dateDinscriptionErreur.Size = new System.Drawing.Size(0, 17);
            this.dateDinscriptionErreur.TabIndex = 10;
            // 
            // EleveAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 347);
            this.Controls.Add(this.dateDinscriptionErreur);
            this.Controls.Add(this.dateDeNaissanceErreur);
            this.Controls.Add(this.nomCompletErreur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateInscription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomComplet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajouter);
            this.MaximumSize = new System.Drawing.Size(360, 392);
            this.MinimumSize = new System.Drawing.Size(360, 392);
            this.Name = "EleveAdd";
            this.Text = "Ajouter Eleve";
            this.Load += new System.EventHandler(this.EleveAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomComplet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateInscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nomCompletErreur;
        private System.Windows.Forms.Label dateDeNaissanceErreur;
        private System.Windows.Forms.Label dateDinscriptionErreur;

    }
}