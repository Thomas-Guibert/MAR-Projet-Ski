using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone gauche moyenne qui a pour but de faire en sorte que le bot essaye de se rapporcher d'un bot qui vient de s'éloigner
public class BotZoneGaucheMoyen : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().BonneDistanceAGauche(c);
        }
    }
    void OnTriggerExit(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PersonneAGaucheARattrapper(c);
        }
    }
}
