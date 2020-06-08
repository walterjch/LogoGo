/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Triangle.cs
 
 */
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    class Triangle : Sprite
    {
        #region Variables d'instance
        private static int _nombreTriangles = 0;
        #endregion

        #region Constructeurs
        public Triangle(Form parent, int calque) : base(parent, calque)
        {
            _nombreTriangles++;
            Name = "Triangle_" + _nombreTriangles.ToString();
            IdType = 3;
        }

        public Triangle(SpriteSerializable s, Form parent) : base(s, parent)
        {
            IdType = 3;
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Dessine un Troangle selon la propriété Remplir.
        /// </summary>
        /// <param name="g">Objet Graphics avec lequel la forme sera dessinée</param>
        public override void SpritePaintAvecGraphics(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Point[] Trace =
            {
                new Point(Location.X, Location.Y + Height),
                new Point(Location.X + Width / 2, Location.Y),
                new Point(Location.X + Width, Location.Y + Height),
                new Point(Location.X, Location.Y + Height)
            };
            if (Remplir)
            {
                SolidBrush b = new SolidBrush(Couleur);
                g.FillPolygon(b, Trace);
            }
            else
            {
                Pen p = new Pen(Couleur, EpaisseurPen);
                g.DrawPolygon(p, Trace);
            }
        }
        #endregion
    }
}
