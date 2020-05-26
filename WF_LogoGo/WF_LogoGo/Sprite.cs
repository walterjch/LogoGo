using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public abstract class Sprite : PictureBox
    {
        #region Variables d'instance
        private Color _couleur;
        private float _epaisseurPen;
        private bool _remplir;
        private int _profondeurParCalque;
        private string _nom;
        private int _numeroCalque;
        private Form _parent;
        private float _angle;
        private PointF _centreDeRotation;


        private int _idType;
        private bool _aSupprimer;

        private bool _dragging;
        private Point _posSouris;
        private Bitmap _dessin;
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
        /// Nom du sprite
        /// </summary>
        public string Nom { get => _nom; set => _nom = value; }

        /// <summary>
        /// Profondeur qui définit l'ordre d'apparition des sprites dans un même calque
        /// </summary>
        public int ProfondeurParCalque { get => _profondeurParCalque; set => _profondeurParCalque = value; }

        /// <summary>
        /// Identdifiant permettant de savoir quel type de sprite nous avons
        /// </summary>
        public int IdType { get => _idType; set => _idType = value; }

        /// <summary>
        /// Bool permettant de savoir s'il faut supprimer ou non un sprite
        /// </summary>
        public bool ASupprimer { get => _aSupprimer; set => _aSupprimer = value; }

        /// <summary>
        /// Calque sur lequel est se trouve le sprite
        /// </summary>
        public int NumeroCalque { get => _numeroCalque; set => _numeroCalque = value; }

        /// <summary>
        /// Angle de rotation du sprite
        /// </summary>
        public float Angle { get => _angle; set => _angle = value; }

        /// <summary>
        /// Centre du Sprite
        /// </summary>
        private PointF CentreDeRotation { get => new PointF((float)Width / 2, (float)Height / 2); }

        #endregion

        #region Constructeurs
        public Sprite(Form parent, int calque)
        {
            Couleur = Color.Black;
            EpaisseurPen = 1;
            ProfondeurParCalque = 1;
            NumeroCalque = calque;
            Remplir = false;
            ASupprimer = false;
            _parent = parent;


            Location = new Point(100, 100);
            Size = new Size(LARGEUR_INIT, HAUTEUR_INIT);
            BackColor = Color.Transparent;

            base.MouseDown += SpriteMouseDown;
            base.MouseUp += SpriteMouseUp;
            base.MouseMove += SpriteMouseMove;
        }

        //public Sprite(SpriteSerializable s, Form parent)
        //{
        //    //Devrait récupérer la bonne couleur
        //    Couleur = Color.FromArgb(s.Couleur);
        //    NumeroCalque = s.NumeroCalque;
        //    EpaisseurPen = s.EpaisseurPen;
        //    ProfondeurParCalque = s.ProfondeurParCalque;
        //    Remplir = s.Remplir;
        //    ASupprimer = false;
        //    _parent = parent;

        //    Nom = s.Nom;
        //    Location = s.Location;
        //    Size = s.Size;
        //    BackColor = Color.Transparent;

        //    MouseDown += new MouseEventHandler(SpriteMouseDown);
        //    MouseUp += new MouseEventHandler(SpriteMouseUp);
        //    base.MouseMove += new MouseEventHandler(SpriteMouseMove);
        //}

        #endregion

        #region Méthodes

        /// <summary>
        /// Méthode qui dessine le sprite. La méthode est différente selon
        /// le type du sprite (rond, carré, ...)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public abstract void SpritePaint(object sender, PaintEventArgs e);

        public abstract void Draw(Graphics g);

        //Convertir en spriteSerializable
        //public SpriteSerializable EnSpriteSerializable()
        //{
        //    SpriteSerializable s = new SpriteSerializable();
        //    s.AttribuerValeursProprietes(this);
        //    return s;
        //}

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
        /// Surcharge de la méthode ToString() de object
        /// </summary>
        /// <returns>Nom du sprite (" - Rond_1")</returns>
        public override string ToString()
        {
            return " - " + Nom;
        }
        #endregion
    }
}

