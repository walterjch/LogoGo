/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Rond.cs
 
 */
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    class Rond : Sprite
    {
        #region Variables d'instance
        private static int _nombreCarres = 0;
        #endregion

        #region Constructeurs
        public Rond(Form parent, int calque) : base(parent, calque)
        {
            _nombreCarres++;
            Name = "Rond_" + _nombreCarres.ToString();
            IdType = 2;
        }
        public Rond(SpriteSerializable s, Form parent) : base(s, parent)
        {
            IdType = 2;
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Dessine un Rond selon la propriété Remplir.
        /// </summary>
        /// <param name="g">Objet Graphics avec lequel la forme sera dessinée</param>
        public override void SpritePaintAvecGraphics(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (Remplir)
            {
                SolidBrush b = new SolidBrush(Couleur);
                g.FillEllipse(b, new Rectangle(Location.X, Location.Y, Size.Width + 1, Size.Height + 1));
            }
            else
            {
                Pen p = new Pen(Couleur, EpaisseurPen);
                g.DrawEllipse(p, new Rectangle(Location.X, Location.Y, Size.Width + 1, Size.Height + 1));
            }
        }

        #endregion
    }
}
