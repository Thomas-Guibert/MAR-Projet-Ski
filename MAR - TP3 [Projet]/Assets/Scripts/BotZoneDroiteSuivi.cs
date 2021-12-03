using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Zone droit de suivie qui a pour but de faire en sorte que le bot se place derrière un autre bot ce trouvant devant a droit
public class BotZoneDroiteSuivi : MonoBehaviour
{
    void OnTriggerStay(Collider c){
        if(c.tag == "OtherSkieur"){
            gameObject.GetComponentInParent<Boids>().BotSuiviDroite(c);
        }
    }
}
