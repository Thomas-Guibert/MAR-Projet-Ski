using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone gauche de suivie qui a pour but de faire en sorte que le bot se place derrière un autre bot ce trouvant devant a gauche
public class BotZoneGaucheSuivi : MonoBehaviour
{
    void OnTriggerStay(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().BotSuiviGauche(c);
        }
    }
}
