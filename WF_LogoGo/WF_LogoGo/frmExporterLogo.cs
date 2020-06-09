/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : frmExporterLogo.cs
 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public partial class frmExporterLogo : Form
    {
        private Logo LogoAExporter;
        public Image LogoFinal;
        private Bitmap dessin;

        const int BORDURE_OFFSET = 25;

        //Cela sert à identifier les quatre coins de la picturebox afin
        //de pouvoir la recadrer à la bonne taille du logo en entier.
        private Point CoinSuperieurGauche;
        private Point CoinSuperieurDroit;
        private Point CoinInferieurDroit;
        private Point CoinInferieurGauche;

        public frmExporterLogo(Logo logoAExporer)
        {
            InitializeComponent();
            LogoAExporter = logoAExporer;
            dessin = new Bitmap(pbxResultatFinal.Width, pbxResultatFinal.Height);
        }

        private void ExporterLogo_Load(object sender, EventArgs e)
        {
            bool premierSprite = true;
            Graphics g = Graphics.FromImage(dessin);
            foreach (Sprite unSprite in LogoAExporter.Sprites.ListeDeSprite)
            {
                //Repérage des extrémités du logo//
                //Pour le premier sprite, les coins du logo équivalent aux coins du sprite
                if (premierSprite)
                {
                    CoinSuperieurGauche = unSprite.Location;
                    CoinSuperieurDroit = new Point(unSprite.Location.X + unSprite.Width, +unSprite.Location.Y);
                    CoinInferieurDroit = new Point(unSprite.Location.X + unSprite.Width, +unSprite.Location.Y + unSprite.Height);
                    CoinInferieurGauche = new Point(unSprite.Location.X, +unSprite.Location.Y + unSprite.Height);
                    premierSprite = false;
                }
                else
                {
                    //Vérifie si le coin supérieur gauche doit changer
                    if (unSprite.Location.X < CoinSuperieurGauche.X)
                    {
                        CoinSuperieurGauche = new Point(unSprite.Location.X, CoinSuperieurGauche.Y);
                    }
                    if (unSprite.Location.Y < CoinSuperieurGauche.Y)
                    {
                        CoinSuperieurGauche = new Point(CoinSuperieurGauche.X, unSprite.Location.Y);
                    }

                    //Vérifie si le coin supérieur droit doit changer
                    if (unSprite.Location.X + unSprite.Width > CoinSuperieurDroit.X)
                    {
                        CoinSuperieurDroit = new Point(unSprite.Location.X + unSprite.Width, CoinSuperieurDroit.Y);
                    }
                    if (unSprite.Location.Y < CoinSuperieurDroit.Y)
                    {
                        CoinSuperieurDroit = new Point(CoinSuperieurDroit.X, unSprite.Location.Y - (unSprite.Location.Y - CoinSuperieurGauche.Y));
                    }

                    //Vérifie si le coin inférieur droit doit changer
                    if (unSprite.Location.X + unSprite.Width > CoinInferieurDroit.X)
                    {
                        CoinInferieurDroit = new Point(unSprite.Location.X + unSprite.Width, CoinInferieurDroit.Y);
                    }
                    if (unSprite.Location.Y + unSprite.Height > CoinInferieurDroit.Y)
                    {
                        CoinInferieurDroit = new Point(CoinInferieurDroit.X, unSprite.Location.Y + unSprite.Height);
                    }

                    //Vérifie si le coin inférieur gauche doit changer
                    if (unSprite.Location.X < CoinInferieurGauche.X)
                    {
                        CoinInferieurGauche = new Point(unSprite.Location.X, CoinInferieurGauche.Y);
                    }
                    if (unSprite.Location.Y + unSprite.Height > CoinInferieurGauche.Y)
                    {
                        CoinInferieurGauche = new Point(CoinInferieurGauche.X, unSprite.Location.Y + unSprite.Height);
                    }
                }

                // On dessine le sprite
                unSprite.SpritePaintAvecGraphics(g);
            }
            //On resize la picturebox pour qu'elle fasse la même dimension que le logo

            g.Dispose();
            pbxResultatFinal.Image = dessin;
            LogoFinal = RedimensionnerLogo(dessin, CoinSuperieurGauche.X, CoinSuperieurGauche.Y, CoinSuperieurDroit.X - CoinSuperieurGauche.X, CoinInferieurDroit.Y - CoinSuperieurDroit.Y);
        }

        //Trouvé sur : https://stackoverflow.com/questions/13217156/cropping-picture-getting-rectangle-from-x-y
        /// <summary>
        /// Rogne une image donnée en une zone qu'on doit spécifier.
        /// </summary>
        /// <param name="original_image">Image que l'on veut rogner</param>
        /// <param name="x">Position X de là où on veut rogner l'image</param>
        /// <param name="y">Position Y de là où on veut rogner l'image</param>
        /// <param name="width">Largeur voulue</param>
        /// <param name="height">Hauteur voulue</param>
        /// <returns>Retourne l'image finale</returns>
        public Bitmap RedimensionnerLogo(Bitmap original_image, int x, int y, int width, int height)
        {
            Rectangle crop = new Rectangle(x - BORDURE_OFFSET, y - BORDURE_OFFSET, width + 2 * BORDURE_OFFSET, height + 2 * BORDURE_OFFSET);

            var bmp = new Bitmap(crop.Width, crop.Height);
            using (var gr = Graphics.FromImage(bmp))
            {
                gr.DrawImage(original_image, new Rectangle(0, 0, bmp.Width, bmp.Height), crop, GraphicsUnit.Pixel);
            }
            return bmp;
        }
    }
}
