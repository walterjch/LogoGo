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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogoGo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nudTransparenceCalque = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPolygone = new System.Windows.Forms.Button();
            this.btnTexte = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRond = new System.Windows.Forms.Button();
            this.btnCarre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsbCalques = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlProprietesTexte = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbCalqueTexte = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnSupprimerTexte = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.btnCouleurTexte = new System.Windows.Forms.Button();
            this.tbxTexte = new System.Windows.Forms.TextBox();
            this.tbxPosXTexte = new System.Windows.Forms.TextBox();
            this.tbxPosYTexte = new System.Windows.Forms.TextBox();
            this.nudProfondeurTexte = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pnlProprietesStandard = new System.Windows.Forms.Panel();
            this.btnSupprimerSprite = new System.Windows.Forms.Button();
            this.nudEpaisseur = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.chkRemplir = new System.Windows.Forms.CheckBox();
            this.nudProfondeur = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCalque = new System.Windows.Forms.ComboBox();
            this.btnCouleur = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxPosY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxPosX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxLargeur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxHauteur = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.msEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.msOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.msExporter = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparenceCalque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlProprietesTexte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfondeurTexte)).BeginInit();
            this.pnlProprietesStandard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpaisseur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfondeur)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.nudTransparenceCalque);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lsbCalques);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(532, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 589);
            this.panel1.TabIndex = 0;
            // 
            // nudTransparenceCalque
            // 
            this.nudTransparenceCalque.Location = new System.Drawing.Point(128, 534);
            this.nudTransparenceCalque.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTransparenceCalque.Name = "nudTransparenceCalque";
            this.nudTransparenceCalque.Size = new System.Drawing.Size(57, 22);
            this.nudTransparenceCalque.TabIndex = 72;
            this.nudTransparenceCalque.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTransparenceCalque.ValueChanged += new System.EventHandler(this.nudTransparenceCalque_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPolygone);
            this.groupBox1.Controls.Add(this.btnTexte);
            this.groupBox1.Controls.Add(this.btnTriangle);
            this.groupBox1.Controls.Add(this.btnRond);
            this.groupBox1.Controls.Add(this.btnCarre);
            this.groupBox1.Location = new System.Drawing.Point(17, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 220);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formes";
            // 
            // btnPolygone
            // 
            this.btnPolygone.Location = new System.Drawing.Point(15, 115);
            this.btnPolygone.Name = "btnPolygone";
            this.btnPolygone.Size = new System.Drawing.Size(92, 32);
            this.btnPolygone.TabIndex = 26;
            this.btnPolygone.Text = "Polygone";
            this.btnPolygone.UseVisualStyleBackColor = true;
            this.btnPolygone.Click += new System.EventHandler(this.btnPolygone_Click);
            // 
            // btnTexte
            // 
            this.btnTexte.Location = new System.Drawing.Point(126, 77);
            this.btnTexte.Name = "btnTexte";
            this.btnTexte.Size = new System.Drawing.Size(92, 32);
            this.btnTexte.TabIndex = 25;
            this.btnTexte.Text = "Texte";
            this.btnTexte.UseVisualStyleBackColor = true;
            this.btnTexte.Click += new System.EventHandler(this.btnTexte_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(15, 77);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(92, 32);
            this.btnTriangle.TabIndex = 23;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRond
            // 
            this.btnRond.Location = new System.Drawing.Point(126, 37);
            this.btnRond.Name = "btnRond";
            this.btnRond.Size = new System.Drawing.Size(92, 32);
            this.btnRond.TabIndex = 22;
            this.btnRond.Text = "Rond";
            this.btnRond.UseVisualStyleBackColor = true;
            this.btnRond.Click += new System.EventHandler(this.btnRond_Click);
            // 
            // btnCarre
            // 
            this.btnCarre.Location = new System.Drawing.Point(15, 37);
            this.btnCarre.Name = "btnCarre";
            this.btnCarre.Size = new System.Drawing.Size(92, 32);
            this.btnCarre.TabIndex = 21;
            this.btnCarre.Text = "Carré";
            this.btnCarre.UseVisualStyleBackColor = true;
            this.btnCarre.Click += new System.EventHandler(this.btnCarre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(17, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "Transparence :";
            // 
            // lsbCalques
            // 
            this.lsbCalques.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbCalques.FormattingEnabled = true;
            this.lsbCalques.ItemHeight = 22;
            this.lsbCalques.Items.AddRange(new object[] {
            "Calque 1",
            "Calque 2",
            "Calque 3"});
            this.lsbCalques.Location = new System.Drawing.Point(17, 311);
            this.lsbCalques.Name = "lsbCalques";
            this.lsbCalques.Size = new System.Drawing.Size(243, 202);
            this.lsbCalques.TabIndex = 18;
            this.lsbCalques.SelectedIndexChanged += new System.EventHandler(this.lsbCalques_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Calques :";
            // 
            // pnlProprietesTexte
            // 
            this.pnlProprietesTexte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlProprietesTexte.Controls.Add(this.label32);
            this.pnlProprietesTexte.Controls.Add(this.label23);
            this.pnlProprietesTexte.Controls.Add(this.cmbCalqueTexte);
            this.pnlProprietesTexte.Controls.Add(this.label26);
            this.pnlProprietesTexte.Controls.Add(this.btnSupprimerTexte);
            this.pnlProprietesTexte.Controls.Add(this.label20);
            this.pnlProprietesTexte.Controls.Add(this.label21);
            this.pnlProprietesTexte.Controls.Add(this.nudFontSize);
            this.pnlProprietesTexte.Controls.Add(this.btnCouleurTexte);
            this.pnlProprietesTexte.Controls.Add(this.tbxTexte);
            this.pnlProprietesTexte.Controls.Add(this.tbxPosXTexte);
            this.pnlProprietesTexte.Controls.Add(this.tbxPosYTexte);
            this.pnlProprietesTexte.Controls.Add(this.nudProfondeurTexte);
            this.pnlProprietesTexte.Controls.Add(this.label19);
            this.pnlProprietesTexte.Controls.Add(this.label25);
            this.pnlProprietesTexte.Controls.Add(this.label22);
            this.pnlProprietesTexte.Controls.Add(this.label18);
            this.pnlProprietesTexte.Controls.Add(this.label24);
            this.pnlProprietesTexte.Location = new System.Drawing.Point(0, 384);
            this.pnlProprietesTexte.Name = "pnlProprietesTexte";
            this.pnlProprietesTexte.Size = new System.Drawing.Size(530, 236);
            this.pnlProprietesTexte.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(12, 4);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(96, 18);
            this.label32.TabIndex = 46;
            this.label32.Text = "Propriétés :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Enabled = false;
            this.label23.Location = new System.Drawing.Point(402, 118);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 17);
            this.label23.TabIndex = 66;
            this.label23.Text = "px";
            // 
            // cmbCalqueTexte
            // 
            this.cmbCalqueTexte.Enabled = false;
            this.cmbCalqueTexte.FormattingEnabled = true;
            this.cmbCalqueTexte.Items.AddRange(new object[] {
            "Calque 1",
            "Calque 2",
            "Calque 3"});
            this.cmbCalqueTexte.Location = new System.Drawing.Point(128, 88);
            this.cmbCalqueTexte.Name = "cmbCalqueTexte";
            this.cmbCalqueTexte.Size = new System.Drawing.Size(90, 24);
            this.cmbCalqueTexte.TabIndex = 54;
            this.cmbCalqueTexte.SelectedIndexChanged += new System.EventHandler(this.cmbCalque_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Enabled = false;
            this.label26.Location = new System.Drawing.Point(267, 85);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 17);
            this.label26.TabIndex = 61;
            this.label26.Text = "CoordX :";
            // 
            // btnSupprimerTexte
            // 
            this.btnSupprimerTexte.Enabled = false;
            this.btnSupprimerTexte.Location = new System.Drawing.Point(422, 178);
            this.btnSupprimerTexte.Name = "btnSupprimerTexte";
            this.btnSupprimerTexte.Size = new System.Drawing.Size(104, 35);
            this.btnSupprimerTexte.TabIndex = 48;
            this.btnSupprimerTexte.Text = "Supprimer";
            this.btnSupprimerTexte.UseVisualStyleBackColor = true;
            this.btnSupprimerTexte.Click += new System.EventHandler(this.btnSupprimerSprite_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Enabled = false;
            this.label20.Location = new System.Drawing.Point(32, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 17);
            this.label20.TabIndex = 57;
            this.label20.Text = "Calque :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Enabled = false;
            this.label21.Location = new System.Drawing.Point(32, 121);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 17);
            this.label21.TabIndex = 60;
            this.label21.Text = "Profondeur :";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Enabled = false;
            this.nudFontSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFontSize.Location = new System.Drawing.Point(128, 152);
            this.nudFontSize.Maximum = new decimal(new int[] {
            46,
            0,
            0,
            0});
            this.nudFontSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(57, 22);
            this.nudFontSize.TabIndex = 63;
            this.nudFontSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // btnCouleurTexte
            // 
            this.btnCouleurTexte.BackColor = System.Drawing.Color.Black;
            this.btnCouleurTexte.Enabled = false;
            this.btnCouleurTexte.Location = new System.Drawing.Point(344, 51);
            this.btnCouleurTexte.Name = "btnCouleurTexte";
            this.btnCouleurTexte.Size = new System.Drawing.Size(43, 25);
            this.btnCouleurTexte.TabIndex = 49;
            this.btnCouleurTexte.UseVisualStyleBackColor = false;
            this.btnCouleurTexte.Click += new System.EventHandler(this.btnCouleur_Click);
            // 
            // tbxTexte
            // 
            this.tbxTexte.Enabled = false;
            this.tbxTexte.Location = new System.Drawing.Point(128, 54);
            this.tbxTexte.Name = "tbxTexte";
            this.tbxTexte.Size = new System.Drawing.Size(98, 22);
            this.tbxTexte.TabIndex = 47;
            this.tbxTexte.TextChanged += new System.EventHandler(this.tbxTexte_Leave);
            this.tbxTexte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            // 
            // tbxPosXTexte
            // 
            this.tbxPosXTexte.Enabled = false;
            this.tbxPosXTexte.Location = new System.Drawing.Point(343, 85);
            this.tbxPosXTexte.Name = "tbxPosXTexte";
            this.tbxPosXTexte.Size = new System.Drawing.Size(57, 22);
            this.tbxPosXTexte.TabIndex = 50;
            this.tbxPosXTexte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            this.tbxPosXTexte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proprietes_KeyPress);
            this.tbxPosXTexte.Leave += new System.EventHandler(this.tbxPosTexte_Leave);
            // 
            // tbxPosYTexte
            // 
            this.tbxPosYTexte.Enabled = false;
            this.tbxPosYTexte.Location = new System.Drawing.Point(343, 118);
            this.tbxPosYTexte.Name = "tbxPosYTexte";
            this.tbxPosYTexte.Size = new System.Drawing.Size(57, 22);
            this.tbxPosYTexte.TabIndex = 53;
            this.tbxPosYTexte.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            this.tbxPosYTexte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proprietes_KeyPress);
            this.tbxPosYTexte.Leave += new System.EventHandler(this.tbxPosTexte_Leave);
            // 
            // nudProfondeurTexte
            // 
            this.nudProfondeurTexte.Enabled = false;
            this.nudProfondeurTexte.Location = new System.Drawing.Point(128, 121);
            this.nudProfondeurTexte.Name = "nudProfondeurTexte";
            this.nudProfondeurTexte.Size = new System.Drawing.Size(57, 22);
            this.nudProfondeurTexte.TabIndex = 58;
            this.nudProfondeurTexte.ValueChanged += new System.EventHandler(this.nudProfondeur_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(32, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 51;
            this.label19.Text = "Texte :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Enabled = false;
            this.label25.Location = new System.Drawing.Point(402, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 17);
            this.label25.TabIndex = 62;
            this.label25.Text = "px";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Enabled = false;
            this.label22.Location = new System.Drawing.Point(32, 152);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 17);
            this.label22.TabIndex = 65;
            this.label22.Text = "FontSize :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(267, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 17);
            this.label18.TabIndex = 52;
            this.label18.Text = "Couleur :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Location = new System.Drawing.Point(267, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 17);
            this.label24.TabIndex = 64;
            this.label24.Text = "CoordY :";
            // 
            // pnlProprietesStandard
            // 
            this.pnlProprietesStandard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlProprietesStandard.Controls.Add(this.btnSupprimerSprite);
            this.pnlProprietesStandard.Controls.Add(this.nudEpaisseur);
            this.pnlProprietesStandard.Controls.Add(this.label11);
            this.pnlProprietesStandard.Controls.Add(this.chkRemplir);
            this.pnlProprietesStandard.Controls.Add(this.nudProfondeur);
            this.pnlProprietesStandard.Controls.Add(this.label4);
            this.pnlProprietesStandard.Controls.Add(this.cmbCalque);
            this.pnlProprietesStandard.Controls.Add(this.btnCouleur);
            this.pnlProprietesStandard.Controls.Add(this.label12);
            this.pnlProprietesStandard.Controls.Add(this.label13);
            this.pnlProprietesStandard.Controls.Add(this.tbxPosY);
            this.pnlProprietesStandard.Controls.Add(this.label14);
            this.pnlProprietesStandard.Controls.Add(this.label15);
            this.pnlProprietesStandard.Controls.Add(this.tbxPosX);
            this.pnlProprietesStandard.Controls.Add(this.label16);
            this.pnlProprietesStandard.Controls.Add(this.label17);
            this.pnlProprietesStandard.Controls.Add(this.label7);
            this.pnlProprietesStandard.Controls.Add(this.tbxLargeur);
            this.pnlProprietesStandard.Controls.Add(this.label8);
            this.pnlProprietesStandard.Controls.Add(this.label6);
            this.pnlProprietesStandard.Controls.Add(this.tbxHauteur);
            this.pnlProprietesStandard.Controls.Add(this.label5);
            this.pnlProprietesStandard.Controls.Add(this.label1);
            this.pnlProprietesStandard.Location = new System.Drawing.Point(0, 384);
            this.pnlProprietesStandard.Name = "pnlProprietesStandard";
            this.pnlProprietesStandard.Size = new System.Drawing.Size(530, 231);
            this.pnlProprietesStandard.TabIndex = 67;
            // 
            // btnSupprimerSprite
            // 
            this.btnSupprimerSprite.Enabled = false;
            this.btnSupprimerSprite.Location = new System.Drawing.Point(422, 177);
            this.btnSupprimerSprite.Name = "btnSupprimerSprite";
            this.btnSupprimerSprite.Size = new System.Drawing.Size(104, 35);
            this.btnSupprimerSprite.TabIndex = 71;
            this.btnSupprimerSprite.Text = "Supprimer";
            this.btnSupprimerSprite.UseVisualStyleBackColor = true;
            this.btnSupprimerSprite.Click += new System.EventHandler(this.btnSupprimerSprite_Click);
            // 
            // nudEpaisseur
            // 
            this.nudEpaisseur.Enabled = false;
            this.nudEpaisseur.Location = new System.Drawing.Point(378, 138);
            this.nudEpaisseur.Name = "nudEpaisseur";
            this.nudEpaisseur.Size = new System.Drawing.Size(57, 22);
            this.nudEpaisseur.TabIndex = 57;
            this.nudEpaisseur.ValueChanged += new System.EventHandler(this.nudEpaisseur_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(301, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 69;
            this.label11.Text = "Épaisseur :";
            // 
            // chkRemplir
            // 
            this.chkRemplir.AutoSize = true;
            this.chkRemplir.Enabled = false;
            this.chkRemplir.Location = new System.Drawing.Point(36, 185);
            this.chkRemplir.Name = "chkRemplir";
            this.chkRemplir.Size = new System.Drawing.Size(78, 21);
            this.chkRemplir.TabIndex = 51;
            this.chkRemplir.Text = "Remplir";
            this.chkRemplir.UseVisualStyleBackColor = true;
            this.chkRemplir.CheckedChanged += new System.EventHandler(this.chkRemplir_CheckedChanged);
            // 
            // nudProfondeur
            // 
            this.nudProfondeur.Enabled = false;
            this.nudProfondeur.Location = new System.Drawing.Point(129, 145);
            this.nudProfondeur.Name = "nudProfondeur";
            this.nudProfondeur.Size = new System.Drawing.Size(57, 22);
            this.nudProfondeur.TabIndex = 50;
            this.nudProfondeur.ValueChanged += new System.EventHandler(this.nudProfondeur_ValueChanged);
            this.nudProfondeur.Click += new System.EventHandler(this.nudProfondeur_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(33, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Profondeur :";
            // 
            // cmbCalque
            // 
            this.cmbCalque.Enabled = false;
            this.cmbCalque.FormattingEnabled = true;
            this.cmbCalque.Items.AddRange(new object[] {
            "Calque 1",
            "Calque 2",
            "Calque 3"});
            this.cmbCalque.Location = new System.Drawing.Point(129, 113);
            this.cmbCalque.Name = "cmbCalque";
            this.cmbCalque.Size = new System.Drawing.Size(90, 24);
            this.cmbCalque.TabIndex = 49;
            this.cmbCalque.SelectedIndexChanged += new System.EventHandler(this.cmbCalque_SelectedIndexChanged);
            // 
            // btnCouleur
            // 
            this.btnCouleur.BackColor = System.Drawing.Color.Black;
            this.btnCouleur.Enabled = false;
            this.btnCouleur.Location = new System.Drawing.Point(372, 38);
            this.btnCouleur.Name = "btnCouleur";
            this.btnCouleur.Size = new System.Drawing.Size(43, 25);
            this.btnCouleur.TabIndex = 52;
            this.btnCouleur.UseVisualStyleBackColor = false;
            this.btnCouleur.Click += new System.EventHandler(this.btnCouleur_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(33, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 67;
            this.label12.Text = "Calque :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(431, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 66;
            this.label13.Text = "px";
            // 
            // tbxPosY
            // 
            this.tbxPosY.Enabled = false;
            this.tbxPosY.Location = new System.Drawing.Point(372, 104);
            this.tbxPosY.Name = "tbxPosY";
            this.tbxPosY.Size = new System.Drawing.Size(57, 22);
            this.tbxPosY.TabIndex = 54;
            this.tbxPosY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            this.tbxPosY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proprietes_KeyPress);
            this.tbxPosY.Leave += new System.EventHandler(this.tbxPos_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(296, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 17);
            this.label14.TabIndex = 65;
            this.label14.Text = "CoordY :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(431, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 17);
            this.label15.TabIndex = 64;
            this.label15.Text = "px";
            // 
            // tbxPosX
            // 
            this.tbxPosX.Enabled = false;
            this.tbxPosX.Location = new System.Drawing.Point(372, 74);
            this.tbxPosX.Name = "tbxPosX";
            this.tbxPosX.Size = new System.Drawing.Size(57, 22);
            this.tbxPosX.TabIndex = 53;
            this.tbxPosX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            this.tbxPosX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proprietes_KeyPress);
            this.tbxPosX.Leave += new System.EventHandler(this.tbxPos_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(296, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 63;
            this.label16.Text = "CoordX :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Enabled = false;
            this.label17.Location = new System.Drawing.Point(296, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 62;
            this.label17.Text = "Couleur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(193, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "px";
            // 
            // tbxLargeur
            // 
            this.tbxLargeur.Enabled = false;
            this.tbxLargeur.Location = new System.Drawing.Point(129, 80);
            this.tbxLargeur.Name = "tbxLargeur";
            this.tbxLargeur.Size = new System.Drawing.Size(57, 22);
            this.tbxLargeur.TabIndex = 48;
            this.tbxLargeur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            this.tbxLargeur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proprietes_KeyPress);
            this.tbxLargeur.Leave += new System.EventHandler(this.tbxLargeur_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(33, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Largeur :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(193, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "px";
            // 
            // tbxHauteur
            // 
            this.tbxHauteur.Enabled = false;
            this.tbxHauteur.Location = new System.Drawing.Point(129, 49);
            this.tbxHauteur.Name = "tbxHauteur";
            this.tbxHauteur.Size = new System.Drawing.Size(57, 22);
            this.tbxHauteur.TabIndex = 47;
            this.tbxHauteur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Proprietes_KeyDown);
            this.tbxHauteur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Proprietes_KeyPress);
            this.tbxHauteur.Leave += new System.EventHandler(this.tbxHauteur_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(33, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "Hauteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 46;
            this.label1.Text = "Propriétés :";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFichier,
            this.aideToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(804, 28);
            this.menuStrip.TabIndex = 68;
            this.menuStrip.Text = "menuStrip1";
            // 
            // msFichier
            // 
            this.msFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msEnregistrer,
            this.msOuvrir,
            this.msExporter});
            this.msFichier.Name = "msFichier";
            this.msFichier.Size = new System.Drawing.Size(64, 24);
            this.msFichier.Text = "Fichier";
            // 
            // msEnregistrer
            // 
            this.msEnregistrer.Name = "msEnregistrer";
            this.msEnregistrer.Size = new System.Drawing.Size(155, 26);
            this.msEnregistrer.Text = "Enregistrer";
            this.msEnregistrer.Click += new System.EventHandler(this.msEnregistrer_Click);
            // 
            // msOuvrir
            // 
            this.msOuvrir.Name = "msOuvrir";
            this.msOuvrir.Size = new System.Drawing.Size(155, 26);
            this.msOuvrir.Text = "Ouvrir";
            this.msOuvrir.Click += new System.EventHandler(this.msOuvrir_Click);
            // 
            // msExporter
            // 
            this.msExporter.Name = "msExporter";
            this.msExporter.Size = new System.Drawing.Size(155, 26);
            this.msExporter.Text = "Exporter";
            this.msExporter.Click += new System.EventHandler(this.msExporter_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmLogoGo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 611);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnlProprietesStandard);
            this.Controls.Add(this.pnlProprietesTexte);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogoGo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogoGo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogoGo_FormClosing);
            this.Load += new System.EventHandler(this.frmLogoGo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransparenceCalque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlProprietesTexte.ResumeLayout(false);
            this.pnlProprietesTexte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfondeurTexte)).EndInit();
            this.pnlProprietesStandard.ResumeLayout(false);
            this.pnlProprietesStandard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpaisseur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfondeur)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ListBox lsbCalques;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlProprietesTexte;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbCalqueTexte;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnSupprimerTexte;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Button btnCouleurTexte;
        private System.Windows.Forms.TextBox tbxTexte;
        private System.Windows.Forms.TextBox tbxPosXTexte;
        private System.Windows.Forms.TextBox tbxPosYTexte;
        private System.Windows.Forms.NumericUpDown nudProfondeurTexte;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel pnlProprietesStandard;
        private System.Windows.Forms.Button btnSupprimerSprite;
        private System.Windows.Forms.NumericUpDown nudEpaisseur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkRemplir;
        private System.Windows.Forms.NumericUpDown nudProfondeur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCalque;
        private System.Windows.Forms.Button btnCouleur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxPosY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxPosX;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxLargeur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxHauteur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msFichier;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem msOuvrir;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnPolygone;
        private System.Windows.Forms.ToolStripMenuItem msExporter;
        private System.Windows.Forms.NumericUpDown nudTransparenceCalque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

