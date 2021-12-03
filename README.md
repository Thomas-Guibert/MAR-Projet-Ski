# MAR TP Projet
###### Guibert Thomas & Koopman Valentin
## But du projet
Le but du projet est de réaliser un jeu ou un skieur descend une pente, accompagné de bots controllés par le jeu
## Mécanique de jeu
Les règle du jeu était a définir par les étudiants, nous avons donc choisi celles-ci :
- Le joueur et les bots commencent tout en haut de la pente
- Le but du joueur est d'arriver le plus rapidement possible à la ligne d'arrivé tout en bas de la pente, un chrono en haut à droite montre le temps déjâ passé
- Toucher un bot donne au joueur un bonus de temps de 3 secondes, la réduction est faites immédiatement. Il y a aussi un compteur de bot touché sur le nombre de bot total.
- Il y a aussi des drapeaux qui prennent la forme de deux barres parallèles rouge, si le joueur passe entre les deux barres, le drapeau est pris et donne un bonus de temps de 1 seconde. Comme pour les bots il y a un compteur de drapeau.
- Au cours d'une partie il y a 18 drapeau et 15 bot durant une partie.
- Une fois la ligne d'arrivée dépassé le chrono et le compteur sont stoppés.
## Element du TP non mis en place
Le TP proposait dans la partie 1.3 de mettre en place un caméra masse-ressort, elle n'a pas été gardé car le terrain utilisé n'est pas parfaitement lisse et donc le joueur fait beaucoup de micro saut ce qui activait l'effet ressort de la caméra pratiquement tout le temps. Cela rendait le jeu injouable.
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
