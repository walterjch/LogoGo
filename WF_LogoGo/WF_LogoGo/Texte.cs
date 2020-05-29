using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    class Texte : Sprite
    {
        #region Variables d'instance
        private static int _nombreCarres = 0;
        private string _nomPolice;
        private int _taillePolice;
        private string _texte;
        #endregion

        #region Constantes
        #endregion

        #region Propriétés
        public string TexteAEcrire { get => _texte; set => _texte = value; }
        public string NomPolice { get => _nomPolice; set => _nomPolice = value; }
        public int TaillePolice { get => _taillePolice; set => _taillePolice = value; }
        #endregion

        #region Constructeurs
        public Texte(Form parent, int calque) : base(parent, calque)
        {
            _nombreCarres++;
            Nom = "Texte " + _nombreCarres.ToString();
            TexteAEcrire = Nom;
            NomPolice = "Times New Roman";
            TaillePolice = 24;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Dessine le carré remplis ou pas, selon la propriété Remplir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void SpritePaint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
        }

        public override void Draw(Graphics g)
        {
            SolidBrush b = new SolidBrush(Couleur);
            Font maPolice = new Font(NomPolice, TaillePolice, FontStyle.Bold, GraphicsUnit.Pixel);
            RedimensionnerPictureBox(maPolice, g);
            g.DrawString(TexteAEcrire, maPolice, b, Location);
        }

        private void RedimensionnerPictureBox(Font uneFonte, Graphics g)
        {
            Width = (int)g.MeasureString(TexteAEcrire, uneFonte).Width;
            Height = (int)g.MeasureString(TexteAEcrire, uneFonte).Height;
        }
        public void ChangerTexte(string nouveauTexte)
        {
            TexteAEcrire = nouveauTexte;
        }

        public override string ToString()
        {
            return TexteAEcrire;
        }
        #endregion
    }
}
