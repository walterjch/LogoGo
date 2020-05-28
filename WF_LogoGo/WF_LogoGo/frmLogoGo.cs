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

        public int CalqueChoisi { get => Convert.ToInt32(lsbCalques.SelectedItem.ToString().Substring(lsbCalques.SelectedItem.ToString().Length - 1)); }

        #region Constructeur
        public frmLogoGo()
        {
            InitializeComponent();
            DoubleBuffered = true;
            MonLogo = new Logo(this);
        }
        #endregion

        #region Evenements
        private void btnCarre_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Carre(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        private void btnRond_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Rond(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Triangle(this, CalqueChoisi);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
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
            MonLogo.SpriteChoisi.ProfondeurParCalque = (int)nudProf.Value;
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
            
                pnlProprietesTexte.Visible = false;
                pnlProprietesStandard.Visible = true;
                //Affichage de la position du Sprite en question
                tbxPosX.Enabled = true;
                tbxPosY.Enabled = true;
                tbxPosX.Text = MonLogo.SpriteChoisi.Location.X.ToString();
                tbxPosY.Text = MonLogo.SpriteChoisi.Location.Y.ToString();

                //Affichage de la taille
                tbxHauteur.Enabled = true;
                tbxLargeur.Enabled = true;
                tbxHauteur.Text = MonLogo.SpriteChoisi.Height.ToString();
                tbxLargeur.Text = MonLogo.SpriteChoisi.Width.ToString();

                //Affichage de sa couleur
                btnCouleur.BackColor = MonLogo.SpriteChoisi.Couleur;
                btnCouleur.Enabled = true;

                //Affichage de la profondeur
                nudProfondeur.Enabled = true;
                nudProfondeur.Value = MonLogo.SpriteChoisi.ProfondeurParCalque;


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

        /// <summary>
        /// Réinitialise les propriétés affichées
        /// TODO : Reinitialiser propriétés de pnlTexte
        /// </summary>
        public void ReinitialiserProprietes()
        {
            //Affichage de la position du carré en question
            tbxPosX.Enabled = false;
            tbxPosY.Enabled = false;
            tbxPosX.Text = string.Empty;
            tbxPosY.Text = string.Empty;

            //Affichage de la taille
            tbxHauteur.Enabled = false;
            tbxLargeur.Enabled = false;
            tbxHauteur.Text = string.Empty;
            tbxLargeur.Text = string.Empty;

            //Affichage de sa couleur
            btnCouleur.BackColor = default(Color);
            btnCouleur.Enabled = true;



            //Affichage du remplissement
            chkRemplir.Enabled = false;
            chkRemplir.Checked = false;

            //Affichage du calques
            cmbCalque.Enabled = false;

            //Affichage du bouton de suppression
            btnSupprimerSprite.Enabled = false;

            //Affichage du numericUpDown de profondeur
            nudProfondeur.Enabled = false;

            //Affichage du numericUpDown d'épaisseur
            nudEpaisseur.Enabled = false;

        }

    }
}
