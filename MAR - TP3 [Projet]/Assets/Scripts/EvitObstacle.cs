using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class de Bot : Fait en sorte que les bot evite les obstacle droit devant
public class EvitObstacle : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        if(c.tag == "Obstacle"){
            gameObject.GetComponentInParent<Boids>().ObstacleDroitDevant(c);
        }
    }
    void OnTriggerExit(Collider c){
        if(c.tag == "Obstacle"){
            gameObject.GetComponentInParent<Boids>().ObstacleEviter(c);
        }
    }
}
