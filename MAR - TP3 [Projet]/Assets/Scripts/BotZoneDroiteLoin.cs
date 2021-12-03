using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone droit éloigner qui a pour but d'empecher un bot de continuer a essayer de se rerapprocher d'un autre bot si il est trop loin
public class BotZoneDroiteLoin : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if( c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PersonneADroiteLoinMaisPasTrop(c);
        }
    }
    
    void OnTriggerExit(Collider c){
        if( c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PersonneADroiteTropLoin(c);
        }
    }
}
