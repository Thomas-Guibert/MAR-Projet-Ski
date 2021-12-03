# MAR TP Projet
###### Guibert Thomas & Koopman Valentin
## But du projet
Le but du projet est de réaliser un jeu ou un skieur decente une pente, accompagné de bot controller par le jeu
## Mécanique de jeu
Les règle du jeux était a définir par les étudiant, nous avons donc choisi celle-ci :
- Le joueur et les bot commence tout en haut de la pente
- Le but du joueur est d'arriver le plus rapidement possible a la ligne d'arrivé tout en bas de la pente, un chrono en haut a droite montre le temps deja passer
- Toucher un bot donne au joueur un bonus de temps de 3 secondes, la réduction est fait immédiatement. Il y a aussi un compteur de bot touché sur le nombre de bot total.
- Il y a aussi des drapeau qui prennent la forme de deux barre parallèles rouge, si le joueur passe entre les deux barres, le drapeau est pris et donne un bonus de temps de 1 seconds. Comme pour les bot il y a un compteur de drapeau.
- Au cours d'une partie il y a 18 drapeau et 15 bot durant une partie.
- Une fois la ligne d'arriver dépasser le chono et compteur sont stopper.
## Element du TP non mis en place
Le TP proposais dans la partie 1.3 de mettre en place un caméra masse-ressort, elle n'a pas été garder car le terrain utiliser n'est pas parfaitement lisse et donc le joueur fait beaucoup de micro saute activais l'effet ressort de la camera pratiquement tout le temps. Cela rendais le jeu injouable.
## Mise en place des different element du TP
#### Le terrain
La pente est constituer de 3 terrains mis a la suite. Les obstacle sont des assets gratuit qui ont été placé manuellement sur le terrain. Les drapeau et les points de depart des bot sont eux aussi defini de base. Aucun système d'aléatoire à été mis en place comme l'indique la partie optionel du TP.
#### Les controls du joueur
Le joueur peut avancer avec Z pour donnée une impulsion qui est toujours la meme. Avec Q et D il peut se deplacer à gauche ou à droite. Avec S il peut ralentir progressivement. Et avec Espace il peut sauté.
#### Les bots et boids
Pour mettre en place boids, 9 zone de detection on été crée.
-Deux zone proche droite et gauche, pour eloigné lesbot quand ils sont trop proche
-Deux zone moyenne droite et gauche, pour faire en sorte qu'ils se rapprochent d'un autre bot quand celui-ci s'éloigne un peu.
-Deux zone loin droite et gauche, pour indiquer au bot d'arreter d'essayer de ce rapprocher de l'autre entité car elle est maintenant trop loin.
-Deux zone de suivi droite et gauche, pour permettre au bots de ce suivrent entre eux quand un autre ce trouve devant eux
-Enfin une zone d'évitement d'obstacles pour evité aléatoirment a droite ou a gauche des obstacle qu'ils rencontrent.
