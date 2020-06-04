using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public class Polygone : Sprite
    {
        #region Variables d'instance
        private static int _nombrePolygones = 0;
        private PointF CoinSuperieurGauche;
        private PointF CoinSuperieurDroit;
        private PointF CoinInferieurDroit;
        private PointF CoinInferieurGauche;
        #endregion

        #region Constructeurs
        public Polygone(Form parent, int calque) : base(parent, calque)
        {
            _nombrePolygones++;
            Name = "Polygone_" + _nombrePolygones.ToString();
            Width = 50;
            Height = 50;
            IdType = 5;
        }

        public Polygone(SpriteSerializable s, Form parent) : base(s, parent)
        {
            IdType = 5;
        }
        #endregion

        #region Méthodes

        public override void SpritePaintAvecGraphics(Graphics g)
        {
            PointF[] nouveauTrace = new PointF[Trace.Length];
            for (int i = 0; i < Trace.Length; i++)
            {
                nouveauTrace[i] = new PointF(Location.X + Trace[i].X, Location.Y + Trace[i].Y);
            }

            RedimensionnerPictureBox(nouveauTrace);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (Remplir)
            {
                SolidBrush b = new SolidBrush(Couleur);
                g.FillPolygon(b, nouveauTrace);
            }
            else
            {
                Pen p = new Pen(Couleur, EpaisseurPen);
                g.DrawPolygon(p, nouveauTrace);
            }
        }


        private void RedimensionnerPictureBox(PointF[] pointsPolygone)
        {
            CalculerCoins(pointsPolygone);
            Size = new Size((int)(CoinSuperieurDroit.X - CoinSuperieurGauche.X), (int)(CoinInferieurDroit.Y - CoinSuperieurDroit.Y));
        }

        private void CalculerCoins(PointF[] pointsPolygone)
        {
            bool premierTour = true;
            foreach (PointF unPoint in pointsPolygone)
            {
                if (premierTour)
                {
                    CoinSuperieurGauche = Location;
                    CoinSuperieurDroit = new PointF(Location.X + Width, Location.Y);
                    CoinInferieurDroit = new PointF(Location.X + Width, Location.Y + Height);
                    CoinInferieurGauche = new PointF(Location.X, Location.Y + Height);

                    premierTour = false;
                }

                //Vérification coin supérieur droit
                if (unPoint.X > CoinSuperieurDroit.X)
                {
                    CoinSuperieurDroit = new PointF(unPoint.X, CoinSuperieurDroit.Y);
                }

                //vérification coin inférieur droit
                if (unPoint.X > CoinInferieurDroit.X)
                {
                    CoinInferieurDroit = new PointF(unPoint.X, CoinInferieurDroit.Y);
                }
                if (unPoint.Y > CoinInferieurDroit.Y)
                {
                    CoinInferieurDroit = new PointF(CoinInferieurDroit.X, unPoint.Y);
                }

                //vérification coin inférieur gauche
                if (unPoint.Y > CoinInferieurGauche.Y)
                {
                    CoinInferieurGauche = new PointF(CoinInferieurGauche.X, unPoint.Y);
                }
                if (unPoint.Y > CoinInferieurDroit.Y)
                {
                    CoinInferieurDroit = new PointF(CoinInferieurDroit.X, unPoint.Y);
                }
            }
        }

        #endregion
    }
}
