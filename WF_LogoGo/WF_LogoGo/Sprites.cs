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
        /// Trie les Sprites selon leur profondeur
        /// </summary>
        public void Trier()
        {
            ListeDeSprite = ListeDeSprite.OrderBy(s => s.NumeroCalque).ThenBy(s => s.Profondeur).ToList<Sprite>();
        }
        #endregion
    }
}
