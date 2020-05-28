using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Nom = "Triangle_" + _nombreTriangles.ToString();
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Point[] trace =
            {
                new Point(Location.X, Location.Y + Height),
                new Point(Location.X + Width / 2, Location.Y),
                new Point(Location.X + Width, Location.Y + Height),
                new Point(Location.X, Location.Y + Height)
            };
            if (Remplir)
            {
                SolidBrush b = new SolidBrush(Couleur);
                g.FillPolygon(b, trace);
            }
            else
            {
                Pen p = new Pen(Couleur, EpaisseurPen);
                g.DrawPolygon(p, trace);
            }
        }
        #endregion
    }
}
