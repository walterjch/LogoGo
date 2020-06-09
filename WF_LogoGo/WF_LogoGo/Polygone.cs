/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Polygone.cs
 
 */
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public class Polygone : Sprite
    {
        #region Variables d'instance
        private static int _nombrePolygones = 0;

        /// <summary>
        /// Coin de la pictureBox se situant en haut à gauche.
        /// </summary>
        private PointF CoinSuperieurGauche;

        /// <summary>
        /// Coin de la pictureBox se situant en haut à droite.
        /// </summary>
        private PointF CoinSuperieurDroit;

        /// <summary>
        /// Coin de la pictureBox se situant en bas à droite.
        /// </summary>
        private PointF CoinInferieurDroit;

        /// <summary>
        /// Coin de la pictureBox se situant en bas à gauche.
        /// </summary>
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

        /// <summary>
        /// Dessine un polygone selon la propriété Remplir.
        /// </summary>
        /// <param name="g">Objet Graphics avec lequel la forme sera dessinée</param>
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


        /// <summary>
        /// Définit une nouvelle taille pour le polygone en fonction de la position des différents points
        /// </summary>
        /// <param name="pointsPolygone">Tracé à utiliser pour calculer la taille</param>
        private void RedimensionnerPictureBox(PointF[] pointsPolygone)
        {
            CalculerCoins(pointsPolygone);
            Size = new Size((int)(CoinSuperieurDroit.X - CoinSuperieurGauche.X), (int)(CoinInferieurDroit.Y - CoinSuperieurDroit.Y));
        }

        /// <summary>
        /// Calcule les coins de la picturebox en utilisant les points du tracé du polygone
        /// </summary>
        /// <param name="pointsPolygone">Tracé à utiliser pour calculer les coins</param>
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
