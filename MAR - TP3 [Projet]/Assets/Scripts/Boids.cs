using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CLASS BOIDS : classe qui genre les deplacement des bots.
public class Boids : MonoBehaviour
{
    private Rigidbody _body;

    private GameObject ZoneEvitObstacle;

    private bool ObstacleDroitDevantBool=false;

    private bool Elancement=false;

    private bool randombool;

    private bool TropPresADroiteDuSkieur=false;

    private bool TropPresAGaucheDuSkieur=false;

    private bool CohesionADroite=false;

    private bool CohesionAGauche=false;
    private bool troploinDroite=false;

    private bool troploinGauche=false;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _body.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        //Evite l'obstacle droit devant lui
        if(ObstacleDroitDevantBool){
            if(randombool){
                transform.Translate(-0.85f,0,0);
            }else{
                transform.Translate(0.85f,0,0); 
            }
        }

        //S'éloigne des autres bots et du joueur, si ils est trop proche
        if(TropPresADroiteDuSkieur){
            transform.Translate(0.25f,0,0);
        }
        if(TropPresAGaucheDuSkieur){
            transform.Translate(-0.25f,0,0);
        }

        //Bot qui etait proche mais qui s'est un peu eloigner, force le bot a se rapporche de celui-ci, si il n'est pas partie trop loin
        if(CohesionADroite && !troploinDroite){
            transform.Translate(-0.25f,0,0);
        }
        if(CohesionAGauche && !troploinGauche){
            transform.Translate(0.25f,0,0);
        }

        //Elance des bot pour qu'ils prennent de la vitesse rapidement
        if(Elancement){
            _body.velocity = new Vector3(0,0,-45);
            Elancement=false;
        }
    }


    ///////////////////////////////////////////////////
    /////////////// Collider Obstacle /////////////////
    ///////////////////////////////////////////////////
    public void ObstacleDroitDevant(Collider c){
        ObstacleDroitDevantBool =true;
        randombool = rndBool();
    }

    public void ObstacleEviter(Collider c){
        ObstacleDroitDevantBool =false;
        Elancement = true;
    }


    ///////////////////////////////////////////////////
    //////////////// Collider Droite //////////////////
    ///////////////////////////////////////////////////
    public void TropPresADroite(Collider c){
        TropPresADroiteDuSkieur=true;
    }

    public void PlusPersonneADroite(Collider c){
        TropPresADroiteDuSkieur=false;
    }

    public void PersonneADroiteARattrapper(Collider c){
        CohesionADroite=true;
    }

    public void BonneDistanceADroite(Collider c){
        CohesionADroite=false;
    }

    public void PersonneADroiteTropLoin(Collider c){
        troploinDroite=true;
        CohesionADroite=false;
    }
    public void PersonneADroiteLoinMaisPasTrop(Collider c){
        troploinDroite=false;
    }
    public void BotSuiviDroite(Collider c){
        transform.Translate(-0.35f,0,0); 
    }


    ///////////////////////////////////////////////////
    //////////////// Collider Gauche //////////////////
    ///////////////////////////////////////////////////

    public void TropPresAGauche(Collider c){
        TropPresAGaucheDuSkieur=true;
    }

    public void PlusPersonneAGauche(Collider c){
        TropPresAGaucheDuSkieur=false;
    }

    public void PersonneAGaucheARattrapper(Collider c){
        CohesionAGauche=true;
        
    }
    public void BonneDistanceAGauche(Collider c){
        CohesionAGauche=false;
    }

    public void PersonneAGaucheTropLoin(Collider c){
        troploinGauche=true;
        CohesionAGauche=false;
    }


    public void PersonneAGaucheLoinMaisPasTrop(Collider c){
        troploinGauche=false;
    }
    public void BotSuiviGauche(Collider c){
        transform.Translate(0.35f,0,0); 
    }
    
    

    ///////////////////////////////////////////////////
    ////////////// Fonction d'Aléatoire ///////////////
    ///////////////////////////////////////////////////

    bool rndBool(){
        return (Random.value>0.5f);
    }


    ///////////////////////////////////////////////////
    /////////////// Trigger Obstacle /////////////////
    ///////////////////////////////////////////////////

    void OnTriggerEnter(Collider col) {
        if(col.tag == "ZoneStop"){
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
        
    }
    void OnTriggerExit(Collider col) {
        if(col.tag == "Obstacle"){
            transform.Translate(-0.85f,0,0);
        }
        
    }

    ///////////////////////////////////////////////////
    /////////// Regle de jeux avec PLayer /////////////
    ///////////////////////////////////////////////////
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }


}
