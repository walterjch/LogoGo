/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Texte.cs
 
 */
using System.Drawing;
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
            Name = "Texte " + _nombreCarres.ToString();
            TexteAEcrire = Name;
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

        /// <summary>
        /// Dessine le texte.
        /// </summary>
        /// <param name="g">Objet Graphics sur lequel le texte est dessiné</param>
        public override void SpritePaintAvecGraphics(Graphics g)
        {
            SolidBrush b = new SolidBrush(Couleur);
            Font maPolice = new Font(NomPolice, TaillePolice, FontStyle.Bold, GraphicsUnit.Pixel);
            RedimensionnerPictureBox(maPolice, g);
            g.DrawString(TexteAEcrire, maPolice, b, Location);
        }

        /// <summary>
        /// Redimensionne la pictureBox en fonction de la police et du texte à écrire.
        /// </summary>
        /// <param name="uneFonte">Police utilisée</param>
        /// <param name="g">Objet Graphics utilisé</param>
        private void RedimensionnerPictureBox(Font uneFonte, Graphics g)
        {
            Width = (int)g.MeasureString(TexteAEcrire, uneFonte).Width;
            Height = (int)g.MeasureString(TexteAEcrire, uneFonte).Height;
        }

        /// <summary>
        /// Change le texte à afficher par le texte spécifié.
        /// </summary>
        /// <param name="nouveauTexte">nouvelle chaîne de caratère à afficher</param>
        public void ChangerTexte(string nouveauTexte)
        {
            TexteAEcrire = nouveauTexte;
        }

        /// <summary>
        /// Surcharge du ToString de Sprite.
        /// </summary>
        /// <returns>Retourne le texte</returns>
        public override string ToString()
        {
            return TexteAEcrire;
        }
        #endregion
    }
}
