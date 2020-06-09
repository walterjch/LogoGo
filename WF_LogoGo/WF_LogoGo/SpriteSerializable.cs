/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : SpriteSerializable.cs
 
 */
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public class SpriteSerializable
    {
        #region Variables d'instance

        private int _couleur;
        private Point _location;
        private Size _size;
        private float _epaisseurPen;
        private bool _remplir;
        private int _numeroCalque;
        private int _profondeurParCalque;
        private string _nom;
        private int _idType;
        private PointF[] _trace;
        private string _texte;
        private string _nomPolice;
        private int _taillePolice;


        private enum Types { Carre = 1, Rond = 2, Triangle = 3, Texte = 4, Polygone = 5 };
        #endregion

        #region Propriétés

        /// <summary>
        /// Couleur du pinceau / crayon du sprite
        /// </summary>
        public int Couleur { get => _couleur; set => _couleur = value; }

        /// <summary>
        /// Position à laquelle le sprite doit être
        /// </summary>
        public Point Location { get => _location; set => _location = value; }

        /// <summary>
        /// Épaisseur du crayon
        /// </summary>
        public float EpaisseurPen { get => _epaisseurPen; set => _epaisseurPen = value; }

        /// <summary>
        /// Bool permettant de savoir s'il faut remplir ou non un sprite
        /// </summary>
        public bool Remplir { get => _remplir; set => _remplir = value; }

        /// <summary>
        /// Calque sur lequel le sprite est dessiné
        /// </summary>
        public int NumeroCalque { get => _numeroCalque; set => _numeroCalque = value; }

        /// <summary>
        /// Profondeur qui définit l'ordre d'apparition des sprites dans un même calque
        /// </summary>
        public int ProfondeurParCalque { get => _profondeurParCalque; set => _profondeurParCalque = value; }

        /// <summary>
        /// Nom du sprite
        /// </summary>
        public string Nom { get => _nom; set => _nom = value; }

        /// <summary>
        /// Identdifiant permettant de savoir quel type de sprite nous avons
        /// </summary>
        public int IdType { get => _idType; set => _idType = value; }

        /// <summary>
        /// Certains sprites on besoin d'un tracé pour ce dessiner
        /// </summary>
        public PointF[] Trace { get => _trace; set => _trace = value; }


        /// <summary>
        /// Certains sprites ont besoin d'un texte
        /// </summary>
        public string TexteAEcrire { get => _texte; set => _texte = value; }

        /// <summary>
        /// Certains sprites ont besoin d'un nom de police
        /// </summary>
        public string NomPolice { get => _nomPolice; set => _nomPolice = value; }

        /// <summary>
        /// Certains sprites ont besoin d'une taille de police
        /// </summary>
        public int TaillePolice { get => _taillePolice; set => _taillePolice = value; }

        /// <summary>
        /// Taille du sprite
        /// </summary>
        public Size Size { get => _size; set => _size = value; }
        #endregion

        #region Constructeurs

        public SpriteSerializable()
        {
            //La copie se fait dans le méthode AttribuerValeursProprietes
            //qui est appellée de l'extérieur.
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Crée le bon type de Sprite en fonction de Type
        /// </summary>
        /// <param name="parent"></param>
        /// <returns>Un objet Sprite</returns>
        public Sprite EnSprite(Form parent)
        {
            switch (IdType)
            {
                case (int)Types.Carre:
                    return new Carre(this, parent);
                case (int)Types.Rond:
                    return new Rond(this, parent);
                case (int)Types.Triangle:
                    return new Triangle(this, parent);
                case (int)Types.Texte:
                    return new Texte(this, parent);
                case (int)Types.Polygone:
                    return new Polygone(this, parent);
                default:
                    return new Carre(this, parent);
            }
        }

        /// <summary>
        /// Attribue les valeur d'un objet Sprite au SpriteSerializable
        /// </summary>
        /// <param name="s">Sprite à "copier"</param>
        public void AttribuerValeursProprietes(Sprite s)
        {
            Couleur = s.Couleur.ToArgb();
            Location = s.Location;
            Size = s.Size;
            EpaisseurPen = s.EpaisseurPen;
            Remplir = s.Remplir;
            NumeroCalque = s.NumeroCalque;
            ProfondeurParCalque = s.Profondeur;
            Nom = s.Name;
            IdType = s.IdType;
            Trace = s.Trace;
            TexteAEcrire = s.TexteAEcrire;
            TaillePolice = s.TaillePolice;
            NomPolice = s.NomPolice;
        }
        #endregion
    }
}
