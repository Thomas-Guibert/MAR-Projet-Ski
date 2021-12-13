# MAR TP Projet
###### Guibert Thomas & Koopman Valentin
## But du projet
Le but du projet est de réaliser un jeu ou un skieur descend une pente, accompagné de bots controllés par le jeu

## Git du projet :

Git : https://github.com/Thomas-Guibert/MAR-Projet-Ski

## Lancement du jeu

Le projet peut être éxecuté de deux manières :

- Décompresser l'archive et ouvrir le projet directement dans unity (conseillé pour redémarrer rapidement la partie car il n'y a pas de touche de restart rapide).
- La seconde option est d'aller dans le dossier nommer Executable et de lancer "ProjectMAR.x86_64".

## Touche de jeux

- Z : S'élancer vers l'avant
- S : Ralentir (Maintenir appuyer)
- Q : Se diriger vers la gauche
- D : Se diriger vers la droite
- Espace : Sauter

## Mécanique de jeu
Les règle du jeu était a définir par les étudiants, nous avons donc choisi celles-ci :
- Le joueur et les bots commencent tout en haut de la pente
- Le but du joueur est d'arriver le plus rapidement possible à la ligne d'arrivé tout en bas de la pente, un chrono en haut à droite montre le temps déjâ passé
- Toucher un bot donne au joueur un bonus de temps de 3 secondes, la réduction est faites immédiatement. Il y a aussi un compteur de bot touché sur le nombre de bot total.
- Il y a aussi des drapeaux qui prennent la forme de deux barres parallèles rouge, si le joueur passe entre les deux barres, le drapeau est pris et donne un bonus de temps de 1 seconde. Comme pour les bots il y a un compteur de drapeau.
- Au cours d'une partie il y a 18 drapeau et 15 bot durant une partie.
- Une fois la ligne d'arrivée dépassé le chrono et le compteur sont stoppés.

Le but du jeu est donc de finir à l'arrivée avec le temps le plus petit possible, voir même avec un temps négatif.

## Element du TP partiellement mis en place
Le TP proposait dans la partie 1.3 de mettre en place un caméra masse-ressort, elle à été implementé de manière très simple. Elle ne consiste qu'a faire une retation vers le haut quand le joueur saut grace a la touche de saut (ici la touhe "Espace"), et a faire une rotation vers le bas quand le joueur touche le sol. c'est rotation sont plus des teleportation de la camera plutot qu'un deplacement, on ne peut donc pas vraiment appeler cela une réel caméra masse-ressort.
## Mise en place des differents element du TP
#### Le terrain
La pente est constituée de 3 terrains mis a la suite. Les obstacles sont des assets gratuits qui ont été placés manuellement sur le terrain. Les drapeaux et les points de depart des bots sont eux aussi definis de base. Aucun système d'aléatoire à été mis en place comme l'indique la partie optionelle du TP.
#### Les controls du joueur
Le joueur peut avancer avec Z pour donner une impulsion qui est toujours la même. Avec Q et D il peut se deplacer à gauche ou à droite, avec S il peut ralentir progressivement et avec Espace il peut sauter.
#### Les bots et boids
Pour mettre en place boids, 9 zones de detection on été crées.
-Deux zones proche droite et gauche, pour eloigner les bots quand ils sont trop proches.
-Deux zones moyenne droite et gauche, pour faire en sorte qu'ils se rapprochent d'un autre bot quand celui-ci s'éloigne un peu.
-Deux zones loin droite et gauche, pour indiquer au bot d'arreter d'essayer de ce rapprocher de l'autre entité car elle est maintenant trop loin.
-Deux zones de suivi droite et gauche, pour permettre aux bots de ce suivre entre eux quand un autre ce trouve devant eux.
-Enfin une zone d'évitement d'obstacles pour eviter aléatoirement à droite ou à gauche des obstacles qu'ils rencontrent.

