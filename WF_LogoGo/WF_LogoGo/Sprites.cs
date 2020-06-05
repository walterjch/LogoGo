using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_LogoGo
{
    public class Sprites
    {
        #region Variables d'instance
        private List<Sprite> _listeDeSprite;
        #endregion

        #region Propriétés

        /// <summary>
        /// Liste dans laquelle sont stockés tous les sprites existants
        /// </summary>
        public List<Sprite> ListeDeSprite { get => _listeDeSprite; private set => _listeDeSprite = value; }
        /// <summary>
        /// Permet de savoir si la liste de sprites est vide.
        /// </summary>
        public bool EstVide { get => ListeDeSprite.Count == 0; }
        #endregion

        #region Constructeurs
        public Sprites()
        {
            ListeDeSprite = new List<Sprite>();
        }
        #endregion

        #region Méthodes

        /// <summary>
        /// Ajoute à la liste le sprite spécifié
        /// /// </summary>
        /// <param name="unSprite">le Sprite à ajouter</param>
        public void Ajouter(Sprite unSprite)
        {
            ListeDeSprite.Add(unSprite);

        }

        /// <summary>
        /// Supprime de la liste le sprite spécifié
        /// </summary>
        /// <param name="unSprite">le Sprite à supprimer</param>
        public void Supprimer(Sprite unSprite)
        {
            ListeDeSprite.Remove(unSprite);
        }

        /// <summary>
        /// Trie les Sprites selon leur calque et leur profondeur
        /// </summary>
        public void Trier()
        {
            ListeDeSprite = ListeDeSprite.OrderBy(s => s.NumeroCalque).ThenBy(s => s.Profondeur).ToList<Sprite>();
        }

        /// <summary>
        /// S'occupe de convertir la liste de Sprite pour quelle soit serializable
        /// </summary>
        /// <returns>Une liste de SpriteSerializable</returns>
        public SpritesSerializables EnListeSerializable()
        {
            SpritesSerializables ListeSerializable = new SpritesSerializables();
            foreach (Sprite unSprite in ListeDeSprite)
            {
                ListeSerializable.Ajouter(unSprite.EnSpriteSerializable());
            }
            return ListeSerializable;
        }
        #endregion
    }
}
