/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Sprite.cs
 
 */
using System.Drawing;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public abstract class Sprite : PictureBox
    {
        #region Variables d'instance
        private Color _couleur;
        private float _epaisseurPen;
        private bool _remplir;
        private int _profondeur;
        private int _numeroCalque;
        private int _idType;
        private PointF[] _trace;
        private string _texte;
        private string _nomPolice;
        private int _taillePolice;

        private Form _parent;



        private bool _dragging;
        private Point _posSouris;
        #endregion

        #region Constantes
        const int HAUTEUR_INIT = 100;
        const int LARGEUR_INIT = 100;
        #endregion

        #region Propriétés
        /// <summary>
        /// Couleur du pinceau / crayon du sprite
        /// </summary>
        public Color Couleur { get => _couleur; set => _couleur = value; }

        /// <summary>
        /// Épaisseur du crayon
        /// </summary>
        public float EpaisseurPen { get => _epaisseurPen; set => _epaisseurPen = value; }

        /// <summary>
        /// Bool permettant de savoir s'il faut remplir ou non un sprite
        /// </summary>
        public bool Remplir { get => _remplir; set => _remplir = value; }


        /// <summary>
        /// Profondeur qui définit l'ordre d'apparition des sprites dans un même calque
        /// </summary>
        public int Profondeur { get => _profondeur; set => _profondeur = value; }

        /// <summary>
        /// Calque sur lequel est se trouve le sprite
        /// </summary>
        public int NumeroCalque { get => _numeroCalque; set => _numeroCalque = value; }

        /// <summary>
        /// Identdifiant permettant de savoir quel type de sprite nous avons
        /// </summary>
        public int IdType { get => _idType; set => _idType = value; }

        /// <summary>
        /// Retourne la 
        /// </summary>
        public int AlphaCouleur { get => Couleur.A; }

        /// <summary>
        /// Certains sprites ont besoin d'un tracé pour se dessiner
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


        #endregion

        #region Constructeurs
        public Sprite(Form parent, int calque)
        {
            Couleur = Color.Black;
            EpaisseurPen = 1;
            Profondeur = 1;
            NumeroCalque = calque;
            Remplir = false;
            _parent = parent;


            Location = new Point(100, 100);
            Size = new Size(LARGEUR_INIT, HAUTEUR_INIT);
            BackColor = Color.Transparent;

            base.MouseDown += SpriteMouseDown;
            base.MouseUp += SpriteMouseUp;
            base.MouseMove += SpriteMouseMove;
        }

        public Sprite(SpriteSerializable s, Form parent)
        {
            Couleur = Color.FromArgb(s.Couleur);
            NumeroCalque = s.NumeroCalque;
            EpaisseurPen = s.EpaisseurPen;
            Profondeur = s.ProfondeurParCalque;
            Remplir = s.Remplir;
            if (this is Polygone)
            {
                Trace = s.Trace;
            }
            if (this is Texte)
            {
                TexteAEcrire = s.TexteAEcrire;
                TaillePolice = s.TaillePolice;
                NomPolice = s.NomPolice;
            }
            _parent = parent;

            Name = s.Nom;
            Location = s.Location;
            Size = s.Size;
            BackColor = Color.Transparent;

            MouseDown += new MouseEventHandler(SpriteMouseDown);
            MouseUp += new MouseEventHandler(SpriteMouseUp);
            base.MouseMove += new MouseEventHandler(SpriteMouseMove);
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Applique une transparence à la couleur
        /// </summary>
        /// <param name="transparence"></param>
        public void ChangerTransparence(int transparence)
        {
            Couleur = Color.FromArgb(transparence, Couleur);
        }

        /// <summary>
        /// Méthode qui dessine le sprite. La méthode est différente selon
        /// le type du sprite (rond, carré, ...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SpritePaint(object sender, PaintEventArgs e)
        {
            SpritePaintAvecGraphics(e.Graphics);
        }

        /// <summary>
        /// Dessine une forme (différent pour chaque classe fille).
        /// </summary>
        /// <param name="g">Objet Graphics avec lequel la forme sera dessinée</param>
        public abstract void SpritePaintAvecGraphics(Graphics g);


        /// <summary>
        /// Déplace la picturebox du sprite en fonction de la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpriteMouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!_dragging || null == c) return;
            c.Top = e.Y + c.Top - _posSouris.Y;
            c.Left = e.X + c.Left - _posSouris.X;
            Parent.Invalidate();
        }

        /// <summary>
        /// Cesse le déplacement de la picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpriteMouseUp(object sender, MouseEventArgs e)
        {
            var pbx = sender as PictureBox;
            if (null == pbx) return;
            pbx.BackColor = Color.Transparent;
            _dragging = false;
        }

        /// <summary>
        /// Commence le déplacement de la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpriteMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            (sender as PictureBox).BackColor = Color.FromArgb(100, Color.Silver);
            _dragging = true;
            _posSouris = new Point(e.X, e.Y);
        }

        /// <summary>
        /// Retourne un sprite serializable
        /// </summary>
        /// <returns></returns>
        public SpriteSerializable EnSpriteSerializable()
        {
            SpriteSerializable s = new SpriteSerializable();
            s.AttribuerValeursProprietes(this);
            return s;
        }

        /// <summary>
        /// Surcharge de la méthode ToString() de object
        /// </summary>
        /// <returns>Nom du sprite (" - Rond_1")</returns>
        public override string ToString()
        {
            return " - " + Name;
        }
        #endregion
    }
}

