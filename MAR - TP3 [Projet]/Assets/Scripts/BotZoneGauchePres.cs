using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone gauche proche qui a pour but de faire en sorte que le bot s'eloigne quand un bot ou le joueur est trop proche de lui
public class BotZoneGauchePres : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if(c.tag == "Player" || c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().TropPresAGauche(c);
        }
    }
    void OnTriggerExit(Collider c){
        if(c.tag == "Player" || c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PlusPersonneAGauche(c);
        }
}
}
