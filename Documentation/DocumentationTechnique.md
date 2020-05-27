

# Table des matières

[TOC]



# Résumé

[Résumé en une page à faire à la fin]



# Introduction

Cette documentation contient les détails de la réalisation de mon TPI (Travail Pratique Individuel). Elle a pour but d'expliquer précisément les étapes de ce travail.

Dans le cadre de ce travail de fin de formation, j'ai du réaliser une application nommée LogoGo.

C'est une application Windows Forms réalisée entièrement en C# orienté objet. Elle permet de créer un logo de A à Z en utilisant des formes géométriques ainsi que du texte que l'utilisateur peut modifier. Un certain nombre de propriétés est modifiable pour chaque forme et ces formes se trouvent sur des calques. Les calques servent évidemment à gérer, dans le cas présent, trois plans différents. L'une des fonctionnalités clé de ce projet est bien entendu la possibilité d'exporter le logo en image. Le logo peut également être enregistré dans le but de, par exemple, modifier le logo plus tard.

# Méthodologie

Pour tout projet conséquent, il faut avoir une méthodologie de travail qui nous aide à raisonner et à organiser le travail. J'ai donc choisi d'appliquer une méthodologie qui nous a été enseignée en cours au CFPT : la Méthode en 6 Étapes.

Comme son nom laisse imaginer, elle contient, en tout, 6 étapes :

1. S'informe

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

   L'évaluation est une sorte d'auto-critique qui permet de savoir ce qui aurait pu être amélioré. La conclusion de **ce document** sert d'évaluation.

# Résumé du cahier des charges



## Organisation




| Nom Complet	 |     Adresse e-mail  |  Domaine |
| -------------- | ---------------- | -----------|
| Monet Stéphane | stephane.monet@gmail.com | Expert |
| Fontanini Alain | alain.fontanini@outlook.com  | Expert |
| Bonvin Pascal | edu-bonvinp@eduge.ch | Professeur |
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
- Le logiciel comporte au minimum trois plans graphiques :
  - Arrière-plan
  - Plan intermédiaire
  - Premier plan
- Le logiciel permet d'exporter un logo au format jpeg ou png



# Analyse fonctionnelle

Une application se doit d'avoir un certain nombre de fonctionnalités que l'utilisateur peut exploiter pour, ici, créer ce qu'il désire. Ce chapitre de la documentation explique les fonctionnalités disponibles ainsi que les détails graphiques de LogoGo.

## Liste des fonctionnalités

### Sélection du plan de travail

L'utilisateur doit pouvoir choisir sur quel plan les formes sont créées. Les formes doivent donc se positionner sur le calque que l'utilisateur a choisi.

### Création d'une forme

L'utilisateur peur créer une forme qui, selon le bouton choisit, varie. La forme apparaît alors sur le calque que l'utilisateur à précédemment eu l'occasion de sélectionner.

### Sélection d'une forme

L'utilisateur a la possibilité de sélectionner un forme en cliquant dessus avec la souris. Il est désormais possible de voir les propriétés de cette forme.

### Voir les propriétés d'une forme

Si l'utilisateur choisit une forme, les propriétés de celle-ci deviennent visible à partir de la section "Propriétés" de la fiche principale. Les propriétés visibles dépendent de la formes sélectionnée.
Une forme standard a des propriétés du genre : Hauteur, Largeur, Épaisseur, etc. Si c'est un texte que l'utilisateur sélectionne, d'autres propriétés sont disponibles. Des propriétés telles que la taille de la police ou le texte à afficher sont affichées.

Cependant, certaines propriétés sont communes. La position (en axe X comme en axe Y) ainsi que la couleur, par exemple, ne dépendent pas du type d'objet choisit.

### Modification des propriétés d'une forme

L'utilisateur peut paramétrer une forme comme il le souhaite. Les propriétés visibles sont modifiables et les modifications sont automatiquement appliquées et visibles sur la forme concernée.

#### Modification du calque d'une forme

L'utilisateur peut aisément changer une forme de calque, même après la création de la forme. Il peut le faire en modifiant la propriété correspondante et en choisissant le calque souhaité.

#### Modification de profondeur

Deux formes dans un même calques apparaissent dans un certain ordre (ordre de création). Cependant, l'utilisateur peut décider de cet ordre en modifiant la propriété correspondante.

### Sauvegarde d'un logo

Le projet peut être sauvegardé. En sauvegardant, l'utilisateur doit choisir le chemin (destination) de la sauvegarde. Il peut ensuite choisir le nom du fichier qui sera sauvegarder. L'extension du fichier est fixe (.xml).

### Chargement d'un logo

Les fichiers sauvegardés peuvent être à nouveau ouverts et chargés dans LogoGo. Les formes précédemment sauvegardées se retrouvent alors de nouveau dans l'application avec les bonnes propriétés et sur les bons calques. L'utilisateur choisit donc un fichier à ouvrir (obligatoirement un fichier .xml).

### Exportation d'un logo

Une fois que l'utilisateur estime que son logo est terminé, il peut l'exporter en image. Il est bien entendu possible de choisir où le fichier sera enregistrer. Plusieurs choix d'extensions sont possibles.

## Interfaces

### Fiche principale

La fiche principale est la première fiche qu'on voit en arrivant sur l'application.



![Fenêtre principale](/Images/fichePincipale.png)



C'est à partir de cette fenêtre qu'on a accès à toutes les fonctionnalités de LogoGo. Elle contient plusieurs parties et chaque partie est documentée ci-dessous :

**Formes**

Dans cette partie de la fenêtre, il y a le choix entre plusieurs types de formes. Chaque bouton correspond à une forme différente qui, à l'appui d'un bouton, apparaîtra sur le calque actif.



**Calques**

Chaque calque est présent dans une ListBox (élément WindowsForm). Lorsqu'on sélectionne un calque, celui-ci devient actif. Le calque actif est  celui sur lequel les formes apparaissent.

**Propriétés**





## Le logo



# Analyse organique

# Réalisation

# Tests unitaires

# Plan de test

# Rapports de test

# Conclusion

