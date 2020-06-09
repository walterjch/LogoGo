/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : SpritesSerializables.cs
 
 */
using System.Collections.Generic;
using System.Windows.Forms;

namespace WF_LogoGo
{
    public class SpritesSerializables
    {
        #region Variables d'instance

        private List<SpriteSerializable> _listeDeSpriteSerializable;
        #endregion

        #region Propriétés
        /// <summary>
        /// Liste de tous les objets SpritesSerializables.
        /// </summary>
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
        /// <param name="s">le SpriteSerializable à ajouter</param>
        public void Ajouter(SpriteSerializable s)
        {
            ListeDeSpriteSerializable.Add(s);
        }

        /// <summary>
        /// Crée un objet Sprites à partir de ListeDeSpriteSerializable
        /// </summary>
        /// <param name="parent">Form servant de parent</param>
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
