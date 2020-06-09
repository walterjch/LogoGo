# Introduction

Ce document a pour but d'expliquer comment utiliser l'application LogoGo dans tous ses aspects. Chaque fonctionnalité est expliquée et tous les doutes que vous pourriez avoir seront, après avoir lu et compris ce document, éclaircis et LogoGo n'aura plus aucun mystère pour vous !

## LogoGo, qu'est-ce que c'est ?

LogoGo est une application qui, comme sont nom l'indique, vous permet de créer des logos. Vous pouvez créer, modifier, supprimer du texte, des ronds, des carrés ainsi que d'autres formes géométriques et les assembler pour fabriquer vos propres logos. Les calques vous donnent la possibilité de créer des logos plus ou moins complexes selon vos besoins.

![Fenêtre principale](/Images/IntroManuelUtilisateur.png)

# Installation

Pour installer LogoGo, il vous suffit de télécharger le dossier compressé (.zip) de l'application et de la dézipper. Vous obtiendrez alors un dossier que vous pourrez laisser à l'emplacement de votre choix (cela n'aura aucune influence sur le fonctionnement de l'application).
Pour lancer l'application, il vous suffit de lancer l'exécutable (.exe) qui se trouve dans le dossier. Le projet peut être téléchargé à l'adresse suivant : https://github.com/walterjch/LogoGo

# Désinstallation

Il n'y a rien de plus simple : il vous suffit de supprimer le dossier contenant l'application. Cette action supprimera tous les fichier de l'application et celle-ci n'existera plus sur votre ordinateur.
Ne vous inquiétez pas, la suppression du dossier de LogoGo ne supprimera pas les logos que vous avez créé, à moins qu'ils soient enregistrés dans ce dossier (ce qui n'est pas recommandé).

Si vos logos sont enregistrés dans le dossier LogoGo, il vous est conseillé de les déplacer avant la suppression de l'application.

# Utilisation

L'application est composée de trois fenêtres seulement qui, ensembles, vous donnent accès à tout ce dont vous aurez besoin lors de la création de votre logo.

## Fiche principale

La fiche principale comporte trois parties différentes qui sont destinées aux différentes **formes** que vous pouvez faire apparaître, aux **propriétés** qui peuvent être modifiées ainsi qu'aux **calques** sur les quels les formes vont être dessinées.

![Fenêtre principale](/Images/fichePincipale.png)

**1. Formes**

Dans cette partie de la fenêtre, il y a le choix entre plusieurs types de formes. Chaque bouton correspond à une forme différente qui, à l'appui d'un bouton, apparaîtra sur le calque actif. Le fonctionnement est identique pour chaque forme, sauf une, le Polygone (voir **4.2 Fiche de création de polygone**).

Suite à la création d'une forme, vous pouvez la déplacer avec a souris (quelle que soit la forme).

**2. Calques**

Chaque calque est présent dans une liste. Lorsqu'on sélectionne un calque, celui-ci devient actif. Le calque actif est  celui sur lequel les formes apparaissent.

La sélection d'un calque se fait lorsque vous cliquez dessus. Sur l'image ci-dessous, c'est le premier calque qui est sélectionné.

![Fenêtre principale](/Images/lsbCalques.png)

On voit également la transparence du calque sélectionné. Si on crée un rond sur le premier calque (Calque 1) et un triangle sur le deuxième calque (Calque 2) et que l'on modifie la transparence du Calque 2, voici ce que l'on obtient :

![Fenêtre principale](/Images/exempleTransparence.png)

Voici la transparence du premier calque :

![Fenêtre principale](/Images/nudTransparence.png)

Voici la transparence du deuxième :

![Fenêtre principale](/Images/exempleNudTransparence.png)

Comme vous pouvez le voir, plus la transparence est proche de 0, plus le calque devient transparent.

**3. Propriétés**

Ce sont les caractéristiques d'une forme. Elles sont modifiables via les champs disponibles pour chacune d'elles.

![Fenêtre principale](/Images/panelProprietes.png)

Les propriétés ci-dessus sont celles d'une forme standard (Rond, Carré, Triangle). Si la forme actuellement sélectionnée est un polygone dessiné par l'utilisateur, les propriétés "Hauteur" et "Largeur" ne sont pas modifiables :

![Fenêtre principale](/Images/panelProprietesPolygone.png)

La propriété "Épaisseur" n'est disponible que si la case "Remplir" n'est pas cochée car une forme peut, soit être remplie, soit avoir une bordure d'une certaine épaisseur. Un appui sur le bouton de couleur ouvrira cette fenêtre permettant de choisir la couleur que l'on veut :

![Fenêtre principale](/Images/colorDialog.png)

Pour le texte aussi, la taille n'est pas modifiable. Certaines propriétés sont, comme vous le verrez ci-dessous, communes avec les autres formes.
Voilà à quoi ressemble le panel des propriétés d'un objet Texte :

![Fenêtre principale](/Images/panelProprietesTexte.png)

Pour la propriété "Profondeur", il sagit de la profondeur au sein d'un même calque. Lorsque vous créez deux formes sur un seul calque, la forme créée en dernier apparaitra au-dessus mais, vous pouvez changer cet ordre d'affichage. Voici un exemple concret et illustré : 

![Fenêtre principale](/Images/exempleProfondeur1.png)

Sur l'image ci-dessus, vous pouvez voir que  le carré est sous le rond. En sachant qu'ils sont tous deux sur le même calque, il suffit de modifier la profondeur du carré comme suit :

![Fenêtre principale](/Images/exempleProfondeur3.png)

La profondeur du carré est maintenant supérieure à celle du rond. Voici le résultat :

![Fenêtre principale](/Images/exempleProfondeur2.png)

On voit que le carré est bien passé au-dessus du rond.

La propriété "Calque" fonctionne de la même manière mais à plus grande échelle : les formes se trouvant sur le calque 2 se trouveront toujours au-dessus des formes sur le calque 1 et ce, indépendamment de leur profondeur. Voici un exemple concret :

![Fenêtre principale](/Images/exempleOrdreCalques1.png)

Sur l'image ci-dessus, on distingue trois forme : un triangle vert, un polygone rouge, ainsi qu'un carré saumon. Le carré est sur la calque 2 et les deux autres sont sur le calque 1. En cliquant sur le triangle, nous pouvons voir sur quel calque il est et modifier la propriété calque. Comme l'image le montre, il suffit, ici, de cliquer sur "Calque 3" pour changer le triangle de calque :

![Fenêtre principale](/Images/exempleOrdreCalques2.png)

Comme vous pouvvez le remarquer, le triangle passe au dessus des formes des calques 1 et 2. Voilà à quoi ressemblera la disposition des formes :

![Fenêtre principale](/Images/exempleOrdreCalques3.png)

## Fiche de création de polygone

Lorsque vous cliquez sur le bouton "Polygone" de la fenêtre principale, vous serez confrontés à cette interface :

![Fenêtre principale](/Images/ficheCreerPolygone.png)

Pour la quitter, vous pouvez cliquer sur "Annuler" (ce qui fermera la fenêtre sans autre) ou sur "OK" (qui validera votre forme avant de fermer la fenêtre).

Pour créer votre polygone, il vous suffit de cliquer à plusieurs endroit dans l'encadré puis de cliquer sur "OK". La fenêtre disparaîtra et vous pourrez voir la forme que vous venez de créer.

Voici un exemple des formes pouvant être créées :

![Fenêtre principale](/Images/exemplesPolygones.png)

## Exporter un logo

Si vous avez terminé de créer votre logo et que vous désirez l'exporter en image, vous pouvez le faire en trois cliques :

1. Cliquez sur "Fichier" en haut à gauche de votre écran.

   ![Fenêtre principale](/Images/barreMenu_fichier.png)

2. Cliquez sur "Exporter".

3. Vous verrez un aperçu de votre logo. Cliquez sur "Exporter".*

   ![Fenêtre principale](/Images/ficheExporter.png)

4. Choisissez le nom, l'extension ainsi que la destination du logo.

   ![Fenêtre principale](/Images/saveFileDialogLogo.png)

5. Cliquez sur "Enregistrer".

Le logo sera donc enregistré dans un fichier image (le type de fichier dépendra de ce que vous aurez choisi) et vous pourrez utiliser cette image comme bon vous semble.

*Si vous n'êtes pas content de votre logo, cliquez sur "Annuler" pour retourner à la fiche principale.

## Enregistrer un logo

Si vous désirez sauvegarder votre logo pour, peut-être, le continuer plus tard, voilà comment vous devez vous y prendre :

1. Cliquez sur "Fichier" en haut à gauche de votre écran.

   ![Fenêtre principale](/Images/barreMenu_fichier.png)

2. Cliquez sur "Enregistrer".

3. Choisissez le nom et la destination du logo.

   ![Fenêtre principale](/Images/saveFileDialogXML.png)

4. Cliquez sur "Enregistrer".

Le logo sera enregistré sous la forme d'un fichier XML (VotreFichier.xml) et vous pourrez le rouvrir avec LogoGo quand vous voudrez.

## Ouvrir un logo

Vous pouvez charger un logo que vous avez sauvegardé pour continuer à le modifier. Pour ce faire, suivez ces instructions :

1. Cliquez sur "Fichier" en haut à gauche de votre écran.

   ![Fenêtre principale](/Images/barreMenu_fichier.png)

2. Cliquez sur "Ouvrir".

3. Choisissez le fichier que vous désirer ouvrir.

   ![Fenêtre principale](/Images/openFileDialogXML.png)

4. Cliquez sur "Ouvrir".

Les formes que vous avez précédemment enregistré apparaîtront alors et vous pourrez continuer à travailler sur votre logo, comme dans l'image ci-dessous :

![Fenêtre principale](/Images/exempleOuvrirFichier.png)

## Aide

Cliquer sur "Aide" (sur la barre de menu) vous dirigera dossier "Documentation" du projet. C'est, sans aucun doute, la manière la plus rapide d'obtenir des informations sur le fonctionnement de l'application.

![Fenêtre principale](/Images/barreMenuAide.png)

# Les différents messages

Pendant l'utilisation de l'application LogoGo, il est possible que vous rencontriez certains messages... Voyons dans quelles circonstances ces messages peuvent apparaître.

## Fermeture de l'application

Avez-vous bien enregistré votre logo avant de quitter l'application ?
Lorsque vous tentez de quitter LogoGo, une fenêtre vous avertit que, si vous n'avez pas sauvegardé votre logo, vous perdrez toute progression dans la création de votre image. Voici à quoi ressemble cette fenêtre d'avertissement :

![Fenêtre principale](/Images/MessageBoxFermeture.png)

Ce message est la pour vous aider. Il vous suffit de cliquer sur OK si vous avez bien enregistré votre projet ou si vous ne souhaitez pas sauvegarder les dernières modifications. Si vous voulez retourner sur LogoGo pour continuer ou pour sauvegarder votre logo, appuyez sur Annuler, cela annulera la fermeture de LogoGo.

## Enregistrement

Comme vous venez de le voir, si vous tentez de quitter l'application, un message vous avertira que vous devez enregistrer votre projet à part si votre projet est vide. À l'inverse, si vous tentez d'enregistrer un projet qui ne contient aucun forme, cette fenêtre s'ouvrira :

![Fenêtre principale](/Images/MessageBoxEnregistrement.png)

Vous devez ajouter au moins une forme pour pouvoir enregistrer le logo.

## Exportation

Il est possible de vous retrouver face à ce message si vous tentez d'exporter un projet vide. Vous ne pouvez pas exporter en image un projet qui ne contient rien du tout.

![Fenêtre principale](/Images/MessageBoxExportation.png)

Vous devez ajouter au moins une forme pour pouvoir exporter le logo.