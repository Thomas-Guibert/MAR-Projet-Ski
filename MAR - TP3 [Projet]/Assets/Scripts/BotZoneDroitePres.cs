using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone droit proche qui a pour but de faire en sorte que le bot s'eloigne quand un bot ou le joueur est trop proche de lui
public class BotZoneDroitePres : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if(c.tag == "Player" || c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().TropPresADroite(c);
        }
    }
    void OnTriggerExit(Collider c){
        if(c.tag == "Player" || c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PlusPersonneADroite(c);
        }
    }
}
