/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Carre.cs
 
 */
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
            Name = "Carré_" + _nombreCarres.ToString();
            IdType = 1;
        }

        public Carre(SpriteSerializable s, Form parent) : base(s, parent)
        {
            IdType = 1;
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Dessine un carré selon la propriété Remplir.
        /// </summary>
        /// <param name="g">Objet Graphics avec lequel la forme sera dessinée</param>
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
