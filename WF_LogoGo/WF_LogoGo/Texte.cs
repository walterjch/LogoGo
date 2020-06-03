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
        #endregion



        #region Constructeurs
        public Texte(Form parent, int calque) : base(parent, calque)
        {
            _nombreCarres++;
            Nom = "Texte " + _nombreCarres.ToString();
            TexteAEcrire = Nom;
            NomPolice = "Times New Roman";
            TaillePolice = 24;
            IdType = 4;
        }

        public Texte(SpriteSerializable s, Form parent) : base(s, parent)
        {
            IdType = 4;
        }
        #endregion

        #region Méthodes

        public override void SpritePaintAvecGraphics(Graphics g)
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
