using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    class Carre : Sprite
    {
        #region Variables d'instance
        private static int _nombreCarres = 0;
        #endregion

        #region Constructeurs
        public Carre(Form parent, int calque) : base(parent, calque)
        {
            _nombreCarres++;
            Nom = "Carré_" + _nombreCarres.ToString();
        }

        
        #endregion

        #region Méthodes

        public override void SpritePaintAvecGraphics(Graphics g)
        {
            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (Remplir)
            {
                SolidBrush b = new SolidBrush(Couleur);
                g.FillRectangle(b, new Rectangle(Location.X, Location.Y, Size.Width, Size.Height));
            }
            else
            {
                Pen p = new Pen(Couleur, EpaisseurPen);
                g.DrawRectangle(p, new Rectangle(Location.X, Location.Y, Size.Width, Size.Height));
            }

        }

        #endregion
    }
}
