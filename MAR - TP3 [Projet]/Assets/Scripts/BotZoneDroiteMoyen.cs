using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone droit moyenne qui a pour but de faire en sorte que le bot essaye de se rapporcher d'un bot qui vient de s'éloigner
public class BotZoneDroiteMoyen : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().BonneDistanceADroite(c);
        }
    }
    void OnTriggerExit(Collider c){
        if( c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PersonneADroiteARattrapper(c);
        }
    }
}
