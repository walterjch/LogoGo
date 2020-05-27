using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    class Logo
    {
        #region Variables d'instance

        private Sprites _sprites;
        private Sprite _spriteChoisi;
        private string _nomFichier;
        private Form _parent;
        #endregion

        #region Constantes

        /// <summary>
        /// Nom du logo s'il n'est pas changé lors de la sauvegarde
        /// </summary>
        const string NOM_PAR_DEFAUT = "Logo.xml";
        #endregion

        #region Propriétés


        /// <summary>
        /// Nom auquel le fichier ets enregistré
        /// </summary>
        private string NomFichier { get => _nomFichier; set => _nomFichier = value; }


        public Sprite SpriteChoisi { get => _spriteChoisi; set => _spriteChoisi = value; }

        public Sprites Sprites { get => _sprites; private set => _sprites = value; }
        #endregion

        #region Constructeurs
        public Logo(Form parent)
        {
            Sprites = new Sprites();
            this._parent = parent;
            NomFichier = NOM_PAR_DEFAUT;

            //AjouterCalque();
        }


        public Logo()
        {
            Sprites = new Sprites();
            NomFichier = NOM_PAR_DEFAUT;

        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Ajoute le Sprite spécifié
        /// </summary>
        /// <param name="s">Sprite à ajouter</param>
        public void AjouterSprite(Sprite s)
        {
            Sprites.Ajouter(s);
        }

        /// <summary>
        /// Trie les Sprites
        /// </summary>
        public void TrierSprites()
        {
            Sprites.Trier();
        }
        #endregion
    }
}
