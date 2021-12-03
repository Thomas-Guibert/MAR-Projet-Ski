using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class non utiliser dans le projet final, il s'agit d'une tentative de generation des obstacle de maniere aléatoire sur le terrain
public class GenerationObstacle : MonoBehaviour
{
    public GameObject arbre;
    private Color couleur;
    public int nbArbres = 100;


	// Use this for initialization
	void Start ()
    {
        for (int i = 0; i < nbArbres; i++)
        {
            Vector3 position = new Vector3(Random.Range(500, 600), transform.position.y, Random.Range(500, 600));  

            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(position, Vector3.down, out hit))
            {
                print("touche");
                GameObject go = (GameObject)Instantiate(arbre, hit.point, Quaternion.identity);
                go.transform.Rotate(new Vector3(0, Random.Range(-15, 15), 0));

                foreach (Transform child in go.transform)
                {
                    child.transform.Rotate(new Vector3(0, Random.Range(-15, 15), 0));

                    couleur = new Color(Random.Range(.0f, .3f), Random.Range(.4f, .8f), Random.Range(.0f, .3f));
                    child.GetComponent<Renderer>().material.color = couleur;
                }
            }
            

            
        }
	}
}
