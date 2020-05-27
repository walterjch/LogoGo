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
        public frmLogoGo()
        {
            InitializeComponent();
            MonLogo = new Logo(this);
        }

        private void btnCarre_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Carre(this, 1);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
        }

        private void btnRond_Click(object sender, EventArgs e)
        {
            MonLogo.SpriteChoisi = new Rond(this, 1);
            Dessine(MonLogo.SpriteChoisi);
            Invalidate();
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

        public void Dessine(Sprite s = null)
        {
            if (s != null)
            {
                MonLogo.AjouterSprite(s);
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

    }
}
