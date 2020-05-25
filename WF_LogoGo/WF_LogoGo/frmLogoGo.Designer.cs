namespace WF_LogoGo
{
    partial class frmLogoGo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsbElementsLogo = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTexte = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRond = new System.Windows.Forms.Button();
            this.btnCarre = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lsbElementsLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(514, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 506);
            this.panel1.TabIndex = 0;
            // 
            // lsbElementsLogo
            // 
            this.lsbElementsLogo.Enabled = false;
            this.lsbElementsLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbElementsLogo.FormattingEnabled = true;
            this.lsbElementsLogo.ItemHeight = 22;
            this.lsbElementsLogo.Items.AddRange(new object[] {
            "Calque 1",
            "Calque 2",
            "Calque 3"});
            this.lsbElementsLogo.Location = new System.Drawing.Point(31, 314);
            this.lsbElementsLogo.Name = "lsbElementsLogo";
            this.lsbElementsLogo.ScrollAlwaysVisible = true;
            this.lsbElementsLogo.Size = new System.Drawing.Size(213, 136);
            this.lsbElementsLogo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calques :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTexte);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btnRond);
            this.groupBox1.Controls.Add(this.btnCarre);
            this.groupBox1.Location = new System.Drawing.Point(27, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 213);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formes";
            // 
            // btnTexte
            // 
            this.btnTexte.Location = new System.Drawing.Point(121, 77);
            this.btnTexte.Name = "btnTexte";
            this.btnTexte.Size = new System.Drawing.Size(79, 32);
            this.btnTexte.TabIndex = 25;
            this.btnTexte.Text = "Texte";
            this.btnTexte.UseVisualStyleBackColor = true;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(10, 77);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(79, 32);
            this.btnTriangle.TabIndex = 23;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            // 
            // btnRond
            // 
            this.btnRond.Location = new System.Drawing.Point(121, 37);
            this.btnRond.Name = "btnRond";
            this.btnRond.Size = new System.Drawing.Size(79, 32);
            this.btnRond.TabIndex = 22;
            this.btnRond.Text = "Rond";
            this.btnRond.UseVisualStyleBackColor = true;
            // 
            // btnCarre
            // 
            this.btnCarre.Location = new System.Drawing.Point(10, 37);
            this.btnCarre.Name = "btnCarre";
            this.btnCarre.Size = new System.Drawing.Size(79, 32);
            this.btnCarre.TabIndex = 21;
            this.btnCarre.Text = "Carré";
            this.btnCarre.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.affichageToolStripMenuItem.Text = "Affichage";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // frmLogoGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLogoGo";
            this.Text = "LogoGo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTexte;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnRond;
        private System.Windows.Forms.Button btnCarre;
        private System.Windows.Forms.ListBox lsbElementsLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    }
}

