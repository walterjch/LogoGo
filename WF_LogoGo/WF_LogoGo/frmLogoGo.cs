using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public partial class frmLogoGo : Form
    {
        Logo MonLogo;

        private int CalqueChoisi { get => Convert.ToInt32(lsbCalques.SelectedItem.ToString().Substring(lsbCalques.SelectedItem.ToString().Length - 1)); }

        #region Constructeur
        public frmLogoGo()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MonLogo = new Logo(this);
        }
        #endregion

        #region Evenements

        /// <summary>
        /// Créé un nouveau objet de txpe Carre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCarre_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Carre(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        /// <summary>
        /// Créé un nouveau objet de txpe Rond
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRond_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Rond(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        /// <summary>
        /// Créé un nouveau objet de txpe Triangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Triangle(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        /// <summary>
        /// Créé un nouveau objet de txpe Texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTexte_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Texte(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        /// <summary>
        /// Créé un nouveau polygone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPolygone_Click(object sender, EventArgs e)
        {
            Polygone p = new Polygone(this, 1);
            frmCreerPolygone frmCreerPolygon = new frmCreerPolygone(p);

            if (frmCreerPolygon.ShowDialog() == DialogResult.OK)
            {
                p.Trace = frmCreerPolygon.Trace;
                MonLogo.SpriteChoisi = p;
                Dessine(MonLogo.SpriteChoisi);
                Invalidate();
            }
        }

        /// <summary>
        /// Affiche les proriétés du sprite sur lequel on a cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProprietesClick(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = (sender as Sprite);
            AfficherProprietes();
        }

        /// <summary>
        /// Au chargement de la fiche, met à jour certains  éléments.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogoGo_Load(object sender, EventArgs e)
        {
            //Par défaut, le premier élément est choisi
            lsbCalques.SelectedIndex = 0;
        }

        /// <summary>
        /// Applique les modifications de hauteur lorsque l'on quitte
        /// la textbox au sprite choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxHauteur_Leave(object sender, EventArgs e)
        {
            Size nouvelleTaille = new Size(Convert.ToInt32(tbxLargeur.Text), Convert.ToInt32(tbxHauteur.Text));
            MonLogo.SpriteChoisi.Size = nouvelleTaille;
            Invalidate();
        }

        /// <summary>
        /// Applique les modifications de taille lorsque l'on quitte
        /// la textbox au sprite choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxLargeur_Leave(object sender, EventArgs e)
        {
            Size nouvelleTaille = new Size(Convert.ToInt32(tbxLargeur.Text), Convert.ToInt32(tbxHauteur.Text));
            MonLogo.SpriteChoisi.Size = nouvelleTaille;
            Invalidate();
        }

        /// <summary>
        /// Appelle Dessine() et change de calque le sprite en question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCalque_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (sender as ComboBox);
            MonLogo.SpriteChoisi.NumeroCalque = Convert.ToInt32(cmb.SelectedItem.ToString().Substring(cmb.SelectedItem.ToString().Length - 1)); // Ici, utilisation d'un sender --> je prévois le texte qui aura une autre cmb mais même event
            Dessine();
        }

        /// <summary>
        /// Change la profondeur par calque du sprite choisi en fonction
        /// de la valeur du numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudProfondeur_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nudProf = (sender as NumericUpDown);
            MonLogo.SpriteChoisi.Profondeur = (int)nudProf.Value;
            MonLogo.TrierSprites();
            Dessine();
            Invalidate();
        }

        /// <summary>
        /// Définit si le sprite sera remplit ou non.
        /// Active/Désactive le champ nudEpaisseur selon le choix.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkRemplir_CheckedChanged(object sender, EventArgs e)
        {
            if (MonLogo.SpriteChoisi != null)
            {
                if (chkRemplir.Checked)
                {
                    MonLogo.SpriteChoisi.Remplir = true;
                    nudEpaisseur.Enabled = false;
                }
                else
                {
                    MonLogo.SpriteChoisi.Remplir = false;
                    nudEpaisseur.Enabled = true;
                }
            }
            Invalidate();
        }

        /// <summary>
        /// Ouvre le colorDialog et applique la couleur choisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCouleur_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            btnCouleur.BackColor = colorDialog.Color;
            MonLogo.SpriteChoisi.Couleur = colorDialog.Color;
            Invalidate();
        }

        /// <summary>
        /// Applique les modifications de position lorsque l'on quitte
        /// la textbox au sprite choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPos_Leave(object sender, EventArgs e)
        {
            Point nouvelleLocation = new Point(Convert.ToInt32(tbxPosX.Text), Convert.ToInt32(tbxPosY.Text));
            MonLogo.SpriteChoisi.Location = nouvelleLocation;
            Invalidate();
        }

        /// <summary>
        /// Applique les modifications de position lorsque l'on quitte
        /// la textbox au sprite choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPosTexte_Leave(object sender, EventArgs e)
        {
            Point nouvelleLocation = new Point(Convert.ToInt32(tbxPosXTexte.Text), Convert.ToInt32(tbxPosYTexte.Text));
            MonLogo.SpriteChoisi.Location = nouvelleLocation;
            Invalidate();
        }

        /// <summary>
        /// Applique le changement d'épaisseur au sprite choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudEpaisseur_ValueChanged(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi.EpaisseurPen = Convert.ToInt32(nudEpaisseur.Value);
            Invalidate();
        }

        /// <summary>
        /// Suprrime le sprite actuellement selectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerSprite_Click(object sender, EventArgs e)
        {
            //Suppression
            Paint -= MonLogo.SpriteChoisi.SpritePaint;
            Controls.Remove(MonLogo.SpriteChoisi);
            MonLogo.SupprimerSprite(MonLogo.SpriteChoisi);
            MonLogo.SpriteChoisi = null;
            //Mise à jour des infos affichées
            ReinitialiserProprietes();
            Invalidate();
        }


        /// <summary>
        /// Change le texte de l'objet Texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxTexte_Leave(object sender, EventArgs e)
        {
            Texte texteAChanger = (Texte)MonLogo.SpriteChoisi;
            if (tbxTexte.Text != string.Empty)
            {
                texteAChanger.ChangerTexte(tbxTexte.Text);
                Invalidate();
            }
        }

        /// <summary>
        /// Change la taille de la police du texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            Texte t = (Texte)MonLogo.SpriteChoisi;
            t.TaillePolice = (int)nudFontSize.Value;
            Invalidate();
        }

        /// <summary>
        /// Valide les modifications des textbox si la touche enter
        /// est appuyée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Proprietes_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = (sender as TextBox);
            if (e.KeyCode == Keys.Enter)
            {
                ProcessTabKey(true);
            }
        }

        /// <summary>
        /// Interdit les lettres dans les textbox en n'autorisant que
        /// les chiffres et les contrôles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Proprietes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Change la transaprence de tous les sprites d'un calque
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudTransparenceCalque_ValueChanged(object sender, EventArgs e)
        {
            foreach (Sprite unSprite in MonLogo.Sprites.ListeDeSprite)
            {
                if (unSprite.NumeroCalque == CalqueChoisi)
                {
                    unSprite.ChangerTransparence((int)(sender as NumericUpDown).Value);
                }
            }

            Invalidate();
        }

        /// <summary>
        /// Mets à jour la transparence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsbCalques_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Sprite unSprite in MonLogo.Sprites.ListeDeSprite)
            {
                if (unSprite.NumeroCalque == CalqueChoisi)
                {
                    nudTransparenceCalque.Value = unSprite.AlphaCouleur;
                    break;
                }
            }
        }

        /// <summary>
        /// Ouvre une form montrant le logo qui sera exporté.
        /// Lorsque l'utilisateur confirme sa volonter de sauver
        /// le logo, un saveFileDialog s'affiche pour qui choisise
        /// où le fichier sera enregistré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msExporter_Click(object sender, EventArgs e)
        {
            frmExporterLogo frmExporter = new frmExporterLogo(MonLogo);

            if (frmExporter.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
                                        + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    frmExporter.LogoFinal.Save(saveFileDialog.FileName);
                }
            }
        }

        /// <summary>
        /// Ouvre un openFileDialog pour que l'utilisateur choisisse
        /// quel fichier il voudrait charger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msOuvrir_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML-File | *.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                MonLogo.Charger(openFileDialog.FileName);

                MonLogo.TrierSprites();
                foreach (Sprite unSprite in MonLogo.Sprites.ListeDeSprite)
                {
                    unSprite.Click += this.ProprietesClick;
                    Paint += unSprite.SpritePaint;
                    this.Controls.Add(unSprite);
                }
                Invalidate();
            }
        }

        /// <summary>
        /// Ouvre un saveFileDialog pour que l'utilisateur choisisse
        /// où le fichier sera enregistré.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void msEnregistrer_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MonLogo.Enregistrer(saveFileDialog.FileName);
            }

        }

        /// <summary>
        /// Ouvre une page web sur la documentation du projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/walterjch/LogoGo/tree/master/Documentation");
        }
        #endregion

        /// <summary>
        /// Gère la création d'un nouveau sprite s'il est spécifié.
        /// Efface et affiche à nouveau les sprites dans le bon ordre
        /// </summary>
        /// <param name="s"></param>
        public void Dessine(Sprite s = null)
        {
            if (s != null)
            {
                MonLogo.AjouterSprite(s);
                s.Click += this.ProprietesClick;
            }

            MonLogo.TrierSprites();

            foreach (Sprite unSprite in MonLogo.Sprites.ListeDeSprite)
            {
                Paint -= unSprite.SpritePaint;
                this.Controls.Remove(unSprite);
                Paint += unSprite.SpritePaint;
                this.Controls.Add(unSprite);
            }

        }


        /// <summary>
        /// Affiche les propriétés du sprite actuellement sélectionné
        /// </summary>
        public void AfficherProprietes()
        {

            if (MonLogo.SpriteChoisi is Texte)
            {
                pnlProprietesStandard.Visible = false;
                pnlProprietesTexte.Visible = true;

                //Affichage de la position du Sprite en question
                tbxPosXTexte.Enabled = true;
                tbxPosYTexte.Enabled = true;
                tbxPosXTexte.Text = MonLogo.SpriteChoisi.Location.X.ToString();
                tbxPosYTexte.Text = MonLogo.SpriteChoisi.Location.Y.ToString();

                //Affichage du texte du Sprite en question
                tbxTexte.Enabled = true;
                tbxTexte.Text = MonLogo.SpriteChoisi.ToString();

                //Affichage de sa couleur
                btnCouleurTexte.BackColor = MonLogo.SpriteChoisi.Couleur;
                btnCouleurTexte.Enabled = true;


                //Affichage de la taille de police
                Texte t = (Texte)MonLogo.SpriteChoisi;
                nudFontSize.Enabled = true;
                nudFontSize.Value = t.TaillePolice;

                //Affichage de la profondeur
                nudProfondeurTexte.Enabled = true;
                nudProfondeurTexte.Value = MonLogo.SpriteChoisi.Profondeur;


                //Affichage du calques dans la combobox
                cmbCalqueTexte.Enabled = true;
                foreach (string calque in cmbCalque.Items)
                {
                    if (calque == "Calque " + MonLogo.SpriteChoisi.NumeroCalque)
                    {
                        cmbCalqueTexte.SelectedIndex = cmbCalqueTexte.FindStringExact(calque);
                    }
                }

                btnSupprimerTexte.Enabled = true;

            }
            else
            {
                pnlProprietesTexte.Visible = false;
                pnlProprietesStandard.Visible = true;
                //Affichage de la position du Sprite en question
                tbxPosX.Enabled = true;
                tbxPosY.Enabled = true;
                tbxPosX.Text = MonLogo.SpriteChoisi.Location.X.ToString();
                tbxPosY.Text = MonLogo.SpriteChoisi.Location.Y.ToString();
                
                
                //Affichage de la taille
                if(!(MonLogo.SpriteChoisi is Polygone))
                {
                    tbxHauteur.Enabled = true;
                    tbxLargeur.Enabled = true;
                }
                else
                {
                    tbxHauteur.Enabled = false;
                    tbxLargeur.Enabled = false;
                }
                tbxHauteur.Text = MonLogo.SpriteChoisi.Height.ToString();
                tbxLargeur.Text = MonLogo.SpriteChoisi.Width.ToString();

                //Affichage de sa couleur
                btnCouleur.BackColor = MonLogo.SpriteChoisi.Couleur;
                btnCouleur.Enabled = true;

                //Affichage de la profondeur
                nudProfondeur.Enabled = true;
                nudProfondeur.Value = MonLogo.SpriteChoisi.Profondeur;


                //Affichage de l'épaisseur
                if (!MonLogo.SpriteChoisi.Remplir)
                {
                    nudEpaisseur.Enabled = true;
                }
                nudEpaisseur.Value = Convert.ToInt32(MonLogo.SpriteChoisi.EpaisseurPen);

                //Affichage du remplissement
                chkRemplir.Enabled = true;
                chkRemplir.Checked = MonLogo.SpriteChoisi.Remplir;

                //Affichage du calques dans la combobox
                cmbCalque.Enabled = true;
                foreach (string calque in cmbCalque.Items)
                {
                    if (calque == "Calque " + MonLogo.SpriteChoisi.NumeroCalque)
                    {
                        cmbCalque.SelectedIndex = cmbCalque.FindStringExact(calque);
                    }
                }

                btnSupprimerSprite.Enabled = true;

            }
        }

        /// <summary>
        /// Réinitialise les propriétés affichées
        /// </summary>
        public void ReinitialiserProprietes()
        {

            // Partie Sprite 
            tbxPosX.Enabled = false;
            tbxPosY.Enabled = false;
            tbxPosX.Text = string.Empty;
            tbxPosY.Text = string.Empty;

            tbxHauteur.Enabled = false;
            tbxLargeur.Enabled = false;
            tbxHauteur.Text = string.Empty;
            tbxLargeur.Text = string.Empty;

            btnCouleur.BackColor = default(Color);
            btnCouleur.Enabled = true;

            chkRemplir.Enabled = false;
            chkRemplir.Checked = false;

            cmbCalque.Enabled = false;

            btnSupprimerSprite.Enabled = false;

            nudProfondeur.Enabled = false;

            nudEpaisseur.Enabled = false;

            //Partie Texte
            tbxTexte.Enabled = false;
            tbxTexte.Text = string.Empty;

            tbxPosXTexte.Enabled = false;
            tbxPosYTexte.Enabled = false;
            tbxPosXTexte.Text = string.Empty;
            tbxPosYTexte.Text = string.Empty;

            btnCouleurTexte.BackColor = default(Color);
            btnCouleurTexte.Enabled = true;

            cmbCalqueTexte.Enabled = false;

            btnSupprimerTexte.Enabled = false;

            nudProfondeurTexte.Enabled = false;
        }

        private void frmLogoGo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MonLogo.Sprites.ListeDeSprite.Count != 0)
            {
                DialogResult resultat = MessageBox.Show("Attention, la fermeture de LogoGo aura pour résultat la perte de votre projet si vous ne l'avez pas enregistré. Si vous êtes sûr de l'avoir sauvegardé, cliquez sur OK.", "Fermeture de l'application", MessageBoxButtons.OKCancel);
                if (resultat == DialogResult.OK)
                {
                    e.Cancel = false;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
