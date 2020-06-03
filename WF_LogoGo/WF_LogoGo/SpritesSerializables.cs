using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public class SpritesSerializables
    {
        #region Variables d'instance

        private List<SpriteSerializable> _listeDeSpriteSerializable;
        #endregion

        #region Propriétés
        public List<SpriteSerializable> ListeDeSpriteSerializable { get => _listeDeSpriteSerializable; private set => _listeDeSpriteSerializable = value; }
        #endregion

        #region Contructeurs
        public SpritesSerializables()
        {
            ListeDeSpriteSerializable = new List<SpriteSerializable>();
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Ajoute à la liste le SpriteSerializable spécifié
        /// /// </summary>
        /// <param name="unSprite">le SpriteSerializable à ajouter</param>
        public void Ajouter(SpriteSerializable s)
        {
            ListeDeSpriteSerializable.Add(s);
        }

        /// <summary>
        /// Crée un objet Sprites à partir de ListeDeSpriteSerializable
        /// </summary>
        /// <param name="parent"></param>
        /// <returns>Un objet Sprites</returns>
        public Sprites EnSprites(Form parent)
        {
            Sprites ListeDeSprite = new Sprites();
            foreach (SpriteSerializable unSpriteSerializable in ListeDeSpriteSerializable)
            {
                ListeDeSprite.Ajouter(unSpriteSerializable.EnSprite(parent));
            }
            return ListeDeSprite;
        }
        #endregion
    }
}
