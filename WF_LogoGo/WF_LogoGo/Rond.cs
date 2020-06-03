using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Nom = "Rond_" + _nombreCarres.ToString();
            IdType = 2;
        }
        public Rond(SpriteSerializable s, Form parent) : base(s, parent)
        {
            IdType = 2;
        }
        #endregion

        #region Méthodes

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
