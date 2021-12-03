using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotZoneGaucheLoin : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PersonneAGaucheLoinMaisPasTrop(c);
        }
    }
    
    void OnTriggerExit(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().PersonneAGaucheTropLoin(c);
        }
    }
}
