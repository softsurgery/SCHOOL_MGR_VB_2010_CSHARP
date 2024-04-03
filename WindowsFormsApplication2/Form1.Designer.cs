namespace GestionEleve
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
            this.windowTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ajouter_annee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.annee = new System.Windows.Forms.ComboBox();
            this.autresMenu = new System.Windows.Forms.Button();
            this.InstructeurMenu = new System.Windows.Forms.Button();
            this.EleveMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.effacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowTitle
            // 
            this.windowTitle.AutoSize = true;
            this.windowTitle.Font = new System.Drawing.Font("Cooper Black", 22.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowTitle.Location = new System.Drawing.Point(7, 62);
            this.windowTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(281, 44);
            this.windowTitle.TabIndex = 0;
            this.windowTitle.Text = "Gestion Ecole";
            this.windowTitle.Click += new System.EventHandler(this.windowTitle_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 16);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.effacer);
            this.splitContainer1.Panel1.Controls.Add(this.ajouter_annee);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.annee);
            this.splitContainer1.Panel1.Controls.Add(this.windowTitle);
            this.splitContainer1.Panel1.Controls.Add(this.autresMenu);
            this.splitContainer1.Panel1.Controls.Add(this.InstructeurMenu);
            this.splitContainer1.Panel1.Controls.Add(this.EleveMenu);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1488, 493);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // ajouter_annee
            // 
            this.ajouter_annee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter_annee.Location = new System.Drawing.Point(31, 417);
            this.ajouter_annee.Name = "ajouter_annee";
            this.ajouter_annee.Size = new System.Drawing.Size(101, 36);
            this.ajouter_annee.TabIndex = 17;
            this.ajouter_annee.Text = "Enregistrer";
            this.ajouter_annee.UseVisualStyleBackColor = true;
            this.ajouter_annee.Click += new System.EventHandler(this.ajouter_annee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Annee Scolaire :";
            // 
            // annee
            // 
            this.annee.FormattingEnabled = true;
            this.annee.Location = new System.Drawing.Point(17, 375);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(263, 24);
            this.annee.TabIndex = 8;
            this.annee.SelectedIndexChanged += new System.EventHandler(this.annee_SelectedIndexChanged);
            // 
            // autresMenu
            // 
            this.autresMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.autresMenu.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autresMenu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.autresMenu.Location = new System.Drawing.Point(17, 259);
            this.autresMenu.Margin = new System.Windows.Forms.Padding(4);
            this.autresMenu.Name = "autresMenu";
            this.autresMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.autresMenu.Size = new System.Drawing.Size(263, 64);
            this.autresMenu.TabIndex = 7;
            this.autresMenu.Text = "Autres";
            this.autresMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autresMenu.UseVisualStyleBackColor = false;
            this.autresMenu.Click += new System.EventHandler(this.autres_Click);
            // 
            // InstructeurMenu
            // 
            this.InstructeurMenu.Font = new System.Drawing.Font("Cooper Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructeurMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.InstructeurMenu.Location = new System.Drawing.Point(17, 194);
            this.InstructeurMenu.Margin = new System.Windows.Forms.Padding(4);
            this.InstructeurMenu.Name = "InstructeurMenu";
            this.InstructeurMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InstructeurMenu.Size = new System.Drawing.Size(263, 64);
            this.InstructeurMenu.TabIndex = 1;
            this.InstructeurMenu.Text = "Instructeurs";
            this.InstructeurMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InstructeurMenu.UseVisualStyleBackColor = false;
            this.InstructeurMenu.Click += new System.EventHandler(this.instructeurMenu_Click);
            // 
            // EleveMenu
            // 
            this.EleveMenu.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EleveMenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EleveMenu.Location = new System.Drawing.Point(17, 122);
            this.EleveMenu.Margin = new System.Windows.Forms.Padding(4);
            this.EleveMenu.Name = "EleveMenu";
            this.EleveMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EleveMenu.Size = new System.Drawing.Size(263, 72);
            this.EleveMenu.TabIndex = 0;
            this.EleveMenu.Text = "Eleves";
            this.EleveMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EleveMenu.UseVisualStyleBackColor = false;
            this.EleveMenu.Click += new System.EventHandler(this.eleveMenu_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 480);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // effacer
            // 
            this.effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effacer.Location = new System.Drawing.Point(154, 417);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(101, 36);
            this.effacer.TabIndex = 18;
            this.effacer.Text = "Effacer";
            this.effacer.UseVisualStyleBackColor = true;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 515);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1120, 465);
            this.Name = "Form1";
            this.Text = "Gestion Ecole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button EleveMenu;
        private System.Windows.Forms.Button InstructeurMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button autresMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox annee;
        private System.Windows.Forms.Button ajouter_annee;
        private System.Windows.Forms.Button effacer;



    }
}

