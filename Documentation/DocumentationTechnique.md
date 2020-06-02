

# Table des matières

[TOC]



# Résumé

[Résumé en une page à faire à la fin]



# Introduction

Cette documentation contient les détails de la réalisation de mon TPI (Travail Pratique Individuel). Elle a pour but d'expliquer précisément les étapes de ce travail.

Dans le cadre de ce travail de fin de formation, j'ai du réaliser une application nommée LogoGo.

C'est une application Windows Forms réalisée entièrement en C# orienté objet. Elle permet de créer un logo de A à Z en utilisant des formes géométriques ainsi que du texte que l'utilisateur peut modifier. Un certain nombre de propriétés est modifiable pour chaque forme et ces formes se trouvent sur des calques. Les calques servent évidemment à gérer, dans le cas présent, au moins trois plans différents. L'une des fonctionnalités clé de ce projet est bien entendu la possibilité d'exporter le logo en image. Le logo peut également être enregistré dans le but de, par exemple, modifier le logo plus tard.

![Fenêtre principale](/Images/imageIntroduction.png)

# Méthodologie

Pour tout projet conséquent, il faut avoir une méthodologie de travail qui nous aide à raisonner et à organiser le travail. J'ai donc choisi d'appliquer une méthodologie qui nous a été enseignée en cours au CFPT : la Méthode en 6 Étapes.

Comme son nom laisse imaginer, elle contient, en tout, 6 étapes :

1. S'informer

   Ici, la source principale d'information étant l'énoncé, une lecture complète et détaillée du document est nécessaire pour pouvoir cerner le travail à réaliser et savoir où aller.

2. Planifier

   Puisque le planning prévisionnel m'a été fourni, j'ai décidé de garder la structure de ce dernier et de la remplir avec l'avancement réel du projet pour obtenir un planning effectif.

3. Décider

   Il faut souvent choisir une méthode à une autre au cours d'un projet. Figurent dans le journal de bord les décisions importantes que j'ai décidé de prendre.

4. Réaliser

   Faisant suite à la phase de décision, la réalisation est là pour que les décisions prises soient appliquées.

5. Contrôler

   Afin d'éviter toute régression, il est important de contrôler les fonctionnalités qui sont ajoutées à l'application.

6. Évaluer

   L'évaluation est une sorte d'auto-critique qui permet de savoir ce qui aurait pu être amélioré. La conclusion de **ce document** sert d'évaluation. En plus de la conclusion, j'ai réalisé un petit bilan quotidien après chacun des 11 jours.

# Résumé du cahier des charges



## Organisation




| Nom Complet	 |     Adresse e-mail  |  Domaine |
| -------------- | ---------------- | -----------|
| Monet Stéphane | stephane.monet@gmail.com | Expert |
| Fontanini Alain | alain.fontanini@outlook.com  | Expert |
| Bonvin Pascal | edu-bonvinp@eduge.ch | Responsable |
| Jauch Walter | walter.jch@eduge.ch   | Candidat |



## Objectifs

Le but est de concevoir une application C# permettant de créer des logo. Il doit être possible de modifier des formes dans plusieurs calques ainsi que de sauvegarder et d'exporter le logo en plusieurs formats d'images.

Le projet doit être terminé dans les 11 jours durant lesquels se passe le TPI, documentation comprise.



## Matériel

Pour ce travail, j'utilise le matériel suivant :

- Mon ordinateur personnel
- Windows 10 Édition Famille
- Microsoft Visual Studio 2019
- Typora
- Sous-système Debian



## Livrables

À la fin des 11 jours de travail, les livrables du projet doivent être les suivants : 

- Planning
- Rapport de projet
- Manuel utilisateur
- Journal de travail



## Points techniques

Comme chaque projet, celui-ci comporte sept points techniques obligatoires qui sont spécifiques au projet. Ces points correspondent aux points A14 à A20 de la grille d'évaluation du TPI.

Voici les points techniques obligatoires à ce projet :

- Le système de sauvegarde/chargement d'un logo fonctionne
- Un diagramme de classe documente le projet
- Les objets graphiques ont une classe mère commune (héritage)
- Le logiciel de logo permet de composer un logo avec au moins trois formes et du texte
- Le planning réel est comparé au planning prescrit
- Le logiciel comporte au minimum trois plans graphiques
- Le logiciel permet d'exporter un logo au format jpeg ou png

La réalisation de ces 7 points est détaillée dans la suite de ce document.

# Analyse fonctionnelle

Une application se doit d'avoir un certain nombre de fonctionnalités que l'utilisateur peut exploiter pour, ici, créer ce qu'il désire. Ce chapitre de la documentation explique les fonctionnalités disponibles ainsi que les détails graphiques de LogoGo.

## Liste des fonctionnalités

### Sélection du plan de travail

L'utilisateur doit pouvoir choisir sur quel plan les formes sont créées. Les formes doivent donc se positionner sur le calque que l'utilisateur a choisi. Par défaut, le calque "Calque 1" est sélectionné. En ce qui concerne l'ordre d'apparition des calques, j'ai décidé de que le calque 1 serait le premier à apparaître, le calque apparaît ensuite et ainsi de suite. Ainsi, le dernier calque apparaît au-dessus des autres.

### Création d'une forme

L'utilisateur peur créer une forme qui, selon le bouton choisit, varie. La forme apparaît alors sur le calque que l'utilisateur à précédemment eu l'occasion de sélectionner. Toutes les formes ont des propriétés de base qui sont (pour la majorité des formes actuellement disponibles), 100 pixels de hauteur ainsi que 100 pixels de largeur, par exemple.

<img src="/Images/selectionCarre.png" alt="Fenêtre principale" style="zoom:90%;" />

### Sélection d'une forme

L'utilisateur a la possibilité de sélectionner un forme en cliquant dessus avec la souris. Il est désormais possible de voir les propriétés de cette forme. Les formes n'ont pas toutes les mêmes propriétés : un texte n'a pas les mêmes caractéristiques qu'un rond. Pour cela, deux interfaces différentes sont prévues avec les propriétés respectives de chaque objet.

Nous pouvons, ici, cliquer avec la souris sur le rond ou sur le texte.

![Fenêtre principale](/Images/selectionRond.png)

![Fenêtre principale](/Images/selectionTexte.png)

### Voir les propriétés d'une forme

Si l'utilisateur choisit une forme, les propriétés de celle-ci deviennent visible à partir de la section "Propriétés" de la fiche principale. Les propriétés visibles dépendent de la formes sélectionnée.
Une forme standard a des propriétés du genre : Hauteur, Largeur, Épaisseur, etc. Si c'est un texte que l'utilisateur sélectionne, d'autres propriétés sont disponibles. Des propriétés telles que la taille de la police ou le texte à afficher sont affichées.

Cependant, certaines propriétés sont communes. La position (en axe X comme en axe Y) ainsi que la couleur, par exemple, ne dépendent pas du type d'objet choisit.

Dans tous les cas, les propriétés se mettent à jour dès que l'utilisateur sélectionne un autre objet. Elles peuvent également se mettre à jour si l'objet n'existe plus (en cas de suppression par l'utilisateur).

Pour reprendre l'exemple du rond et du texte, voilà ce que l'on devrait voir lorsque nous cliquons sur le rond rouge :

![Fenêtre principale](/Images/selectionRondProps.png)

Voici l'affichage si nous cliquons sur le texte rose :

![Fenêtre principale](/Images/selectionTexteProps.png)

### Modification des propriétés d'une forme

L'utilisateur peut paramétrer une forme comme il le souhaite. Les propriétés visibles sont modifiables et les modifications sont automatiquement appliquées et visibles sur la forme concernée.

#### Modification du calque d'une forme

L'utilisateur peut aisément changer une forme de calque, même après la création de la forme. Il peut le faire en modifiant la propriété correspondante et en choisissant le calque souhaité. On voit alors la forme changer de calque. En passant du calque 1 au calque 3, par exemple, on voit la forme se placer au-dessus de toutes les formes du calque 1 et du calque 2. Étant donné qu'elle serait la dernière ajoutée au calque 3, elle serait également par-dessus des formes qui faisaient déjà partie de ce calque.



#### Modification de profondeur

Deux formes dans un même calques apparaissent dans un certain ordre (ordre de création). Cependant, l'utilisateur peut décider de cet ordre en modifiant la propriété correspondante. Tout comme pour les calques, on voit la forme se mettre au-dessus des formes ayant une profondeur moins élevée.

### Sauvegarde d'un logo

Le projet peut être sauvegardé. En sauvegardant, l'utilisateur doit choisir le chemin (destination) de la sauvegarde. Il peut ensuite choisir le nom du fichier qui sera sauvegarder. L'extension du fichier est fixe (.xml).

Si l'utilisateur ne choisit aucun nom, le fichier prend automatiquement le nom "Logo.xml". En ce qui concerne la destination du fichier, il est impossible de ne choisir aucune destination puisque le SaveFileDialog s'ouvre obligatoirement avec un chemin existant.

### Chargement d'un logo

Les fichiers sauvegardés peuvent être à nouveau ouverts et chargés dans LogoGo. Les formes précédemment sauvegardées se retrouvent alors de nouveau dans l'application avec les bonnes propriétés et sur les bons calques. L'utilisateur choisit donc un fichier à ouvrir (obligatoirement un fichier .xml). Si le fichier ouvert par l'utilisateur ne correspond pas à ce que l'application attend (une structure XML correcte comprenant des objets qui correspondent au projet), un message d'erreur apparaît.

### Exportation d'un logo

Une fois que l'utilisateur estime que son logo est terminé, il peut l'exporter en image. Il est bien entendu possible de choisir où le fichier sera enregistrer. Plusieurs choix d'extensions sont également disponibles. 

Le logo doit, avant tout, avoir la bonne taille. Pour cela, j'ai élaboré une méthode permettant de recadrer l'image finale la où se trouvent les formes créées par l'utilisateur afin de voir couper l'image au bon endroit.

## Interfaces

### Fiche principale

La fiche principale est la première fiche qu'on voit en arrivant sur l'application.



![Fenêtre principale](/Images/fichePincipale.png)



C'est à partir de cette fenêtre qu'on a accès à toutes les fonctionnalités de LogoGo. Elle contient trois parties et chaque partie est documentée ci-dessous :

**1. Formes**

Dans cette partie de la fenêtre, il y a le choix entre plusieurs types de formes. Chaque bouton correspond à une forme différente qui, à l'appui d'un bouton, apparaîtra sur le calque actif. Le fonctionnement est identique pour chaque forme, sauf une, le Polygone.

Lorsque l'utilisateur souhaite créer un polygone quelconque, une fenêtre  (voir **6.2.3 Fiche de création de Polygone**) s'ouvre au permet à l'utilisateur de placer des points dans une PictureBox. Le Polygone s'affiche sur la fiche principale uniquement lorsque l'utilisateur finit de placer les points.

**2. Calques**

Chaque calque est présent dans une ListBox (élément WindowsForm). Lorsqu'on sélectionne un calque, celui-ci devient actif et, pour cela, il faut simplement mémoriser le numéro du calque sélectionné. Le calque actif est  celui sur lequel les formes apparaissent.

**3. Propriétés**

Ce sont les caractéristiques d'une forme (Sprite). Elles sont modifiables via les champs disponibles pour chacune d'elles.

![Fenêtre principale](/Images/panelProprietes.png)

Les propriétés ci-dessus sont celles d'une forme standard (Rond, Carré, Triangle). Si la forme actuellement sélectionnée est un Polygone dessiné par l'utilisateur, les propriétés "Hauteur" et "Largeur" ne sont pas modifiables car cela déformerait la forme que l'utilisateur à créé. La hauteur et la largeur de la picturebox sont calculées automatiquement dans le code.

Pour le texte aussi, la taille n'est pas modifiable car elle dépend complétement de la longueur du texte ainsi que de la taille de la police utilisée.
Voilà à quoi ressemble le panel des propriétés d'un objet Texte :

![Fenêtre principale](/Images/panelProprietesTexte.png)

### Barre de menu

La barre de menu est accessible à tout moment sur le haut de la fiche principale et comporte trois types d'option :

- Fichier
- Aide

Voyons à quoi correspondent chacune de ces options.

**Fichier**

Voilà ce que l'on retrouve sous le menu Fichier :

![Fenêtre principale](/Images/barreMenu_Fichier.png)

Ce sont trois fonctionnalités essentielles à l'application : l'enregistrement et l'ouverture ainsi que l'exportation en image. C'est là que nous avons accès à ces fonctionnalités. Un clic sur chacune de ces options déclenche la fonctionnalité respective mais, avant toute chose, les trois déclenchent l'ouverture d'une boîte de dialogue.

Enregistrer et Exporter ouvrent une boîte de dialogue de type SaveFileDialog puisque ces deux fonctionnalités correspondent à un enregistrement de fichier. Pour "Ouvrir", par contre, c'est un OpenFileDialog qui est ouvert, vu que l'utilisateur doit chercher un fichier à ouvrir.

**Aide**

Un appui sur le bouton "Aide" ouvre une page internet avec le manuel utilisateur. L'utilisateur est redirigé sur le lien GitHub du projet pour qu'il puisse regarder la documentation qui lui est destinée.

### Fiche de création de Polygone

Cette fenêtre s'affiche lorsque l'utilisateur clique sur la bouton "Polygone" de la fiche principale. Elle permet de placer les points d'un polygone comme on le souhaite et, ainsi, créer une forme particulière.

![Fenêtre principale](/Images/ficheCreerPolygone.png)

C'est uniquement à l'intérieur de la PictureBox (délimitée par un rectangle) que l'utilisateur peut placer ses points. La forme n'est créée que si l'utilisateur le décide en validant sa saisie.

Cette forme possède deux boutons : "Annuler" et "OK".
Ces deux boutons ont leur DialogResult configuré sur "Cancel" et "OK", respectivement. À l'appui du bouton "OK", les points placés par l'utilisateur sont validés et la forme apparaît sur la fiche principale. Le bouton "Annuler", lui, annule l'action, ferme la fenêtre et la forme ne se crée pas.



## Le logo

Le logo de l'application a été créé sur LogoGo. Cela m'a permis de vérifier la facilité ou les difficultés que l'on pouvait rencontrer durant la création d'un logo.

[METTRE IMAGE DU LOGO]

# Analyse organique



# Réalisation

## Sauvegarde et chargement
## Diagramme de classe
## Classe mère commune (héritage)

La création d'une classe mère commune à plusieurs autres classes est, même si elle paraît évidente pour ce projet, était nécessaire pour la réalisation de ce projet. 

En effet, l'utilisateur doit pouvoir créer plusieurs types d'objet qui ont tous les propriétés communes. N'importe lequel de mes objets ont besoin, par exemple, d'une hauteur, d'une largeur, d'une position (X, Y), d'une couleur, etc.
J'ai donc procédé de la façon suivante : une classe Sprite sert de classe mère et est une classe abstraite. Toutes les autres formes (Carre.cs, Triangle.cs, Texte.cs, etc.) héritent de cette classe et donc, de ses propriétés. Si une nouvelle classe doit être créée (car nous voulons ajouter un nouveau type de forme), il suffit de créer une nouvelle classe qui hérite de Sprite.

Il suffit de surcharger les méthodes de la classe Sprite si les classes filles en ont besoin. C'est notamment le cas pour la méthode SpritePaintAvecGraphics qui doit dessiner quelque chose de différent pour chaque type de forme (FillEllipse pour un rond, FillRectangle pour un carré, etc).

Il est bon de noter que la classe mère (Sprite.cs) hérite elle même de la classe PictureBox car, dans le cadre de ce projet, plusieurs aspects de la Picturebox sont nécessaires. De ce fait, je n'ai pas eu besoin de créer de propriétés pour la taille ou pour la position des sprites puisqu'ils utilisent les propriétés "Location" et "Size" de PictureBox.

## Formes disponibles

L'énoncé dit que l'utilisateur doit pouvoir créer un logo avec "au moins trois formes et du texte". Dans la dernière version de LogoGo, il y a la possibilité d'ajouter quatre type de formes ainsi que du texte.

On peut ajouter des carrés, des ronds, des triangles, des polygones quelconques, et du texte.
Les carrés et les ronds sont les moins complexes puisque l'objet Graphics contient déjà des méthodes pour ces deux formes (DrawEllipse/DrawRectangle et FillEllipse/FillRectangle). Pour ce qui est du texte, la méthode DrawString est idéale.
Pour les triangles et autres types de polygone, par contre, il a fallu utilisé les méthodes DrawPolygon et FillPolygon qui nous donnent la possibilité de dessiner des formes plus complexes en donnant des points à la méthodes. Pour faire simple, ces méthodes relient les points qu'on leur donne en paramètres. Il m'a donc fallu, pour ce qui est du triangle, calculer la position des sommets d'un triangles à partir de sa taille puisque la position des sommets dépendent directement de la taille que l'utilisateur choisit.

Pour les polygones plus complexes, c'est l'utilisateur qui place les points. Ces points sont récoltés dans un tableau qui est donné aux méthodes FillPolygon et DrawPolygon.

## Planning réel / Planning prescrit

Le planning prévisionnel m'a été donné dès le début, ce qui m'a facilité la tâche. Cela ma permit de reprendre la structure du planning prescrit et, ainsi, de le remplir en fonction de mon avancement.

Voici le planning que l'on m'a fourni au début du travail :

![Fenêtre principale](/Images/planningPrevisionnel.png)

En remplissant une copie de ce planning pendant mon travail, voilà ce que j'ai obtenu :

[METTRE IMAGE DU PLANNING EFFECTIF A LA FIN]

Il y a beaucoup de différences mais on observe également quelques similitudes. J'ai, par exemple, une certaine continuité au niveau de la documentation, des tests et du journal de bord qui correspond au planning prévu.

En ce qui concerne les différences, il a des choses qui m'ont pris plus longtemps que prévu et, pour d'autres, moins que prévu. La conception de l'interface, par exemple, m'a pris quelques heures en plus ce que le planning prévisionnel indiquait alors que la mise en place n'a duré que quelques minutes. Le fait d'être chez moi m'a aidé au niveau de la tâche "Installation, mise en place" car je n'ai pas eu besoin de préparer grand chose, à part une mise à jour de VisualStudio.

La réalisation des classes de base m'ont pris nettement moins de temps que les classes filles de Sprite. Les classes telles que Texte.cs ainsi que Polygone.cs m'ont pris plus de temps que les autres classes et plus de temps que ce qui était prévu.

## Plans graphiques

La conception des différents plans de travail, ou calques, m'a demandé un moment de réflexion. J'ai commencé par imaginer une classe Calque qui aurait une propriété ListeSprites (List<Sprite>) qui nous aiderait à savoir quels sprites sont contenus dans chaque calques.

Cependant, en partant sur cette idée, je me suis rendu compte que ce ne serait pas pratique. À chaque fois que je voudrait rafraîchir l'ordre d'affichage (lorsqu'un Sprite passe d'un calque à l'autre, par exemple), il aurait alors fallu parcourir la liste de sprites contenue dans chaque calque pour, ainsi, les afficher dans le bon ordre. En comprenant que cela ne serait pas la manière la plus optimisée, j'ai remarqué que meilleure possibilité que j'avais était simplement de ne pas faire de classe calque.

Voilà comment j'ai procédé : dans la classe Sprite, il existe une propriété nommée "NumeroCalque". Ce numéro de calque sert tout simplement à identifier la priorité d'affichage d'un sprite.
Lors de la création d'un sprite, cette propriété (NumeroCalque) prend la valeur du numéro de calque actuellement sélectionné par l'utilisateur. Au moment de l'affichage, je trie simplement la liste de tous les calques (liste qui est contenue dans la classe Sprites) par la propriété "NumeroCalque". Le code parcourt ensuite la liste triée et affiche les formes une par une.

Dans l'application, il est également possible de modifier la propriété "Profondeur" d'une forme. Cela correspond à un niveau de profondeur dans un même calque et, ainsi, un carré ayant une profondeur plus élevée qu'un autre carré appartenant au même calque apparaîtra au-dessus de ce dernier. Pour ce faire, j'ai fait en sorte que la liste de sprites soit triée par, non pas une, mais deux propriétés : d'abord par le numéro de calque, puis par la profondeur. 

```
ListeDeSprite = ListeDeSprite.OrderBy(s => s.NumeroCalque).ThenBy(s => s.Profondeur).ToList<Sprite>();
```

De cette façon, tous les sprites sont toujours dessinés dans le bon ordre.

Dans l'énoncé, il était également question de transparence des plans. Pour menez à bien cette tâche, j'ai changé, pour être précis, la transparence de tous les sprites qui sont sur le calque concerné. En fait, un calque n'a pas vraiment de transparence, ce sont les formes sur ce calques qui doivent se dessiner d'une couleur plus ou moins transparente. Pour modifier la transparence d'un couleur est déterminée par la valeur de son alpha. Dans acronyme RGBA, le A correspond à la transparence (alpha) de la couleur. Il suffit donc de dessiner les sprites en utilisant une couleur avec la transparence du calque choisie par l'utilisateur.

## Exportation en image

L'exportation d'image est, globalement, assez simple. Étant donné que nous pouvons facilement récupérer l'image d'une PictureBox, il est possible sauvegarder cette image de la méthode suivante :

```
maPictureBox.Image.Save(@"C:\Images\monImage",ImageFormat.Jpeg);
```



# Tests unitaires

# Plan de test

Afin de vérifier qu'aucune régression et aucune erreur ne survienne au cours du développement, il est pratique d'avoir un certain scénario qui, étant testé chaque jour, permet de s'assurer que tout fonctionne.

Voilà le plan de test que j'ai utilisé :

|  Id  |                         Description                          |                       Résultat attendu                       |
| :--: | :----------------------------------------------------------: | :----------------------------------------------------------: |
|  1   |                 Lancement de l'application.                  | Impossible de modifier les propriétés. Calque 1 choisi par défaut. |
|  2   |             Création d'une forme de chaque type.             | Chaque forme se crée correctement et apparaît avec les propriétés par défaut. On peut modifier les propriétés. |
|  3   |         Modification des propriétés de chaque forme.         | Chaque forme est modifiée comme prévu et les modifications sont bien visibles. |
|  4   | Changement de la propriété "Calque" pour avoir au moins une forme sur chaque calque. | Les formes se mettent sur le bon calque et on voit les formes se mettre dans le bon ordre. |
|  5   |                   Enregistrement du logo.                    | L'explorateur de fichier s'ouvre et on peut enregistrer le logo sans problème. Si aucun nom de fichier n'est choisit, un nom par défaut est utilisé. |
|  6   |              Suppression de toutes les formes.               | Les formes se suppriment les unes après les autres comme on le souhaite. La partie "Propriétés" se met à jour. |
|  7   |                   Ouverture d'un fichier.                    | Charge le logo correctement. Les formes ont les bonnes propriétés et sont sur les bons calques. |
|  8   |                   Modification des formes.                   | Les modifications fonctionnent et aucune erreur ne survient. |
|  9   |                     Exportation du logo.                     | L'explorateur de fichier s'ouvre et nous permet de sauvegarder le logo en divers formats d'image. Si aucun nom de fichier n'est choisit, un nom par défaut est utilisé. |
|  10  |                   Vérification de l'image.                   | L'image enregistrée contient bien le logo et fait le bonne taille. |



# Rapports de tests

Voici trois rapports de test qui montrent l'évolution des fonctionnalités avec le temps.

## Rapport de tests du 28 Mai :

|  Id  |    Date    | Réussi |                         Description                          |                           Résultat                           |
| :--: | :--------: | :----: | :----------------------------------------------------------: | :----------------------------------------------------------: |
|  1   | 28.05.2020 |  OUI   |                 Lancement de l'application.                  | Impossible de modifier les propriétés. Calque 1 choisi par défaut. |
|  2   | 28.05.2020 |  NON   |             Création d'une forme de chaque type.             |                       Manque le texte                        |
|  3   | 28.05.2020 |  OUI   |         Modification des propriétés de chaque forme.         |                    Impossible pour texte.                    |
|  4   | 28.05.2020 |  OUI   | Changement de la propriété "Calque" pour avoir au moins une forme sur chaque calque. |        Fonctionne pour toutes les formes disponibles.        |
|  5   | 28.05.2020 |  NON   |                   Enregistrement du logo.                    |                        Pas implémenté                        |
|  6   | 28.05.2020 |  NON   |              Suppression de toutes les formes.               |                       Pas implémenté.                        |
|  7   | 28.05.2020 |  NON   |                   Ouverture d'un fichier.                    |                       Pas implémenté.                        |
|  8   | 28.05.2020 |  NON   |                   Modification des formes.                   |                       Pas implémenté.                        |
|  9   | 28.05.2020 |  NON   |                     Exportation du logo.                     |                       Pas implémenté.                        |
|  10  | 28.05.2020 |  NON   |                   Vérification de l'image.                   |                Ne peut pas encore être crée.                 |

## Rapport du tests du 2 juin :

|  Id  |    Date    | Réussi |                         Description                          |                           Résultat                           |
| :--: | :--------: | :----: | :----------------------------------------------------------: | :----------------------------------------------------------: |
|  1   | 02.06.2020 |  OUI   |                 Lancement de l'application.                  | Impossible de modifier les propriétés. Calque 1 choisi par défaut. |
|  2   | 02.06.2020 |  OUI   |             Création d'une forme de chaque type.             | Les formes se créent et les propriétés se mettent à jour comme prévu. |
|  3   | 02.06.2020 |  OUI   |         Modification des propriétés de chaque forme.         | La modification marche pour toutes les formes et on le voit. |
|  4   | 02.06.2020 |  OUI   | Changement de la propriété "Calque" pour avoir au moins une forme sur chaque calque. |        Fonctionne pour toutes les formes disponibles.        |
|  5   | 02.06.2020 |  NON   |                   Enregistrement du logo.                    |                        Pas implémenté                        |
|  6   | 02.06.2020 |  OUI   |              Suppression de toutes les formes.               | Il est possible de supprimer les formes que l'on a créé. Les propriétés s'actualisent correctement. |
|  7   | 02.06.2020 |  NON   |                   Ouverture d'un fichier.                    |                       Pas implémenté.                        |
|  8   | 02.06.2020 |  NON   |                   Modification des formes.                   | Ne peut pas essayer tant que le chargement de fichier n'est pas implémenté. |
|  9   | 02.06.2020 |  NON   |                     Exportation du logo.                     |                       Pas implémenté.                        |
|  10  | 02.06.2020 |  NON   |                   Vérification de l'image.                   |                Ne peut pas encore être crée.                 |

# Conclusion

