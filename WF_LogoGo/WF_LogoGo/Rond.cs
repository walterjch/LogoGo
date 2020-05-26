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
        }


        #endregion

        #region Méthodes

        /// <summary>
        /// Dessine le rond remplis ou non, en fonction de la propriété Remplir
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
