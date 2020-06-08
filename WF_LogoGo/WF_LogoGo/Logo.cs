/*
 
 Auteur      : JAUCH Walter

 Date        : 09.06.2020
 
 Version     : 1.0

 Description : LogoGo est une application permettant de créer des logos
               à partir de certaines formes (carré, rond, texte, etc.).
               L'utilisateur peut modfifier ces formes et il dipsose de calques.

               Il est possible d'exporter, enregistrer, et ouvir un logo.

 Fichier     : Logo.cs
 
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WF_LogoGo
{
    [Serializable()]
    public class Logo
    {
        #region Variables d'instance

        private Sprites _sprites;
        private SpritesSerializables _spritesSerializables;
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

        /// <summary>
        /// Sprite sur lequel l'utilisateur a cliqué pour la dernière fois
        /// </summary>
        [XmlIgnore]
        public Sprite SpriteChoisi { get => _spriteChoisi; set => _spriteChoisi = value; }

        /// <summary>
        /// Liste de sprites serializables
        /// </summary>
        public SpritesSerializables SpritesSerializables { get => _spritesSerializables; set => _spritesSerializables = value; }

        /// <summary>
        /// Liste qui contient tous les sprites créés par l'utilisateur
        /// </summary>
        [XmlIgnore]
        public Sprites Sprites { get => _sprites; private set => _sprites = value; }
        #endregion

        #region Constructeurs
        public Logo(Form parent)
        {
            Sprites = new Sprites();
            this._parent = parent;
            NomFichier = NOM_PAR_DEFAUT;
        }

        public Logo()
        {
            SpritesSerializables = new SpritesSerializables();
            Sprites = new Sprites();
            NomFichier = NOM_PAR_DEFAUT;

        }
        #endregion

        #region Méthodes


        /// <summary>
        /// Sauvegarde de Logo dans l'état
        /// </summary>
        public void Enregistrer(string nomFichier)
        {
            NomFichier = nomFichier;
            XMLSerialize();
        }


        /// <summary>
        /// Récupère un projet sauvegardé
        /// </summary>
        public void Charger(string nomFichier)
        {
            if (nomFichier != null)
            {
                NomFichier = nomFichier;
            }            
            Sprites = null;
            XMLDeserialize();
        }

        /// <summary>
        /// Serialise le Logo en un fichier XML
        /// </summary>
        private void XMLSerialize()
        {
            SpritesSerializables = Sprites.EnListeSerializable();
            Stream stream = File.Open(NomFichier, FileMode.Create);
            XmlSerializer formatter = new XmlSerializer(typeof(Logo));
            formatter.Serialize(stream, this);
            stream.Close();
        }

        /// <summary>
        /// Deserialise un fichier XML
        /// </summary>
        public void XMLDeserialize()
        {
            Stream stream = File.Open(NomFichier, FileMode.Open);
            XmlSerializer formatter = new XmlSerializer(typeof(Logo));
            Logo obj = (Logo)formatter.Deserialize(stream);
            stream.Close();

            this.Sprites = new Sprites();
            Sprites = obj.SpritesSerializables.EnSprites(_parent);
            NomFichier = obj.NomFichier;
        }


        /// <summary>
        /// Ajoute le Sprite spécifié
        /// </summary>
        /// <param name="s">Sprite à ajouter</param>
        public void AjouterSprite(Sprite s)
        {
            Sprites.Ajouter(s);
        }

        /// <summary>
        /// Supprime le Sprite spécifié
        /// </summary>
        /// <param name="s">Sprite à supprimer</param>
        public void SupprimerSprite(Sprite s)
        {
            Sprites.Supprimer(s);
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
