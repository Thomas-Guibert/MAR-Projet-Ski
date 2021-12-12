using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    private Rigidbody _body;

    private bool finish = false;

    public Camera camera;
    private Rigidbody _camRiBody;

    public GameObject RotatorCam;

    public Transform target; 
    private Vector3 offset;

    private bool perdu = false;

    private bool canJump=true;

    private bool useZ=false;


    // Start is called before the first frame update
    void Start()
    {
        _body = GetComponent<Rigidbody>();
        _camRiBody=camera.GetComponent<Rigidbody>();
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(perdu){
            GetComponent<Rigidbody>().AddForce (Vector3.forward * 500);
            transform.Translate(0,30,0);
        }

         _body.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        if(!finish){
            //Touche de controlle du joueur
        if(Input.GetKey(KeyCode.Q)){
            transform.Translate(0.85f,0,0);
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(-0.85f,0,0);
        }
        if(Input.GetKey(KeyCode.S)){
                if(_body.transform.forward.z>0){
                    _body.AddForce(transform.forward * 8000);
                }
        }

        if(Input.GetKeyDown(KeyCode.Space) && canJump){
            _body.AddForce(new Vector3(0,17000,0),ForceMode.Impulse);
            canJump=false;
            RotatorCam.transform.Rotate(-2, 0,0);
        }


        if(Input.GetKeyDown(KeyCode.Z) && !useZ){
            _body.velocity = new Vector3(0,-6,-45);
            useZ=true;
        }
       
        }
    }

    void OnTriggerStay(Collider col) {
        if(col.tag == "ZoneStop"){
            finish = true;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Field"){
            if(!canJump){
                //Tantative de mise en place de la caméra masse-ressort
                RotatorCam.transform.Rotate(2, 0,0);
            }
            canJump =true;

            useZ=false;
            }
    }
    void OnCollisionExit(Collision collision){
        if(collision.gameObject.tag == "Field"){
            if(!canJump){
                //Tantative de mise en place de la caméra masse-ressort
                // RotatorCam.transform.Rotate(-1, 0,0);
            }
                
        }
    }

}
