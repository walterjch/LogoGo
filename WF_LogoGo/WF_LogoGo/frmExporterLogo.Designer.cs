namespace WF_LogoGo
{
    partial class frmExporterLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExporterLogo));
            this.btnOK = new System.Windows.Forms.Button();
            this.pbxResultatFinal = new System.Windows.Forms.PictureBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultatFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(428, 397);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 50);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Exporter";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // pbxResultatFinal
            // 
            this.pbxResultatFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxResultatFinal.Location = new System.Drawing.Point(12, 12);
            this.pbxResultatFinal.Name = "pbxResultatFinal";
            this.pbxResultatFinal.Size = new System.Drawing.Size(535, 372);
            this.pbxResultatFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxResultatFinal.TabIndex = 1;
            this.pbxResultatFinal.TabStop = false;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnnuler.Location = new System.Drawing.Point(303, 397);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(119, 50);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmExporterLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 459);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.pbxResultatFinal);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExporterLogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exportation du logo";
            this.Load += new System.EventHandler(this.ExporterLogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxResultatFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox pbxResultatFinal;
        private System.Windows.Forms.Button btnAnnuler;
    }
}