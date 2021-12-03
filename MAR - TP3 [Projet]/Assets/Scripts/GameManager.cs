using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Manager;
    private GameObject _player;
    private Rigidbody _playerBody;

    //private bool _isStarted = true;
    DateTime timer = DateTime.Now;
    TimeSpan score;

    //public Text TimerDisplay;
    public Text TimerDisplay;

    public Text FlagDisplay;
    public Text BotDisplay;

    public Text FinishDisplay;

    private bool debutChrono= false;
    private bool finish= false;
    private bool setdebut = false;

    private int FlagNb; 

    private int FlagNbTotal = 18;

    private int BotNb;

    private int BotNbTotal = 15;

    private bool touchBot=false;

    // Start is called before the first frame update
    void Start()
    {
        Manager = this;
        TimerDisplay.text = "Temps : 0:0:000";
        FlagDisplay.text = "Nombre de drapeau : 0 / "+FlagNbTotal;
        BotDisplay.text = "Nombre de bots : 0 / "+BotNbTotal;
        timer = DateTime.Now;
        FinishDisplay.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        System.TimeSpan date = new System.TimeSpan(0,0,-2);
        if (debutChrono && !finish){
            if(!setdebut){
                timer = DateTime.Now;
                setdebut = true;
            }
            score = DateTime.Now - timer;
            TimerDisplay.text = "Temps : " + score.Minutes +":"+score.Seconds+":"+ score.Milliseconds.ToString("00");
            
            if(Input.GetKeyDown(KeyCode.T)){
                timer = timer.Subtract(date);
            }
            
        }else if(finish){

        }
    }


    void OnTriggerEnter(Collider col) {
       
       //Le joueur passe la ligne d'arriver, le chrono et les compteur ne sont plus mis a jour
        if(col.tag == "Arriver"){
            finish = true;
            FinishDisplay.enabled = true;
        }

        //Le joueur est arriver et s'arrete 
        if(col.tag == "ZoneStop"){
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        }

        //Le joueur passe dans un drapeau, bonus contablilisé et compteur mis a jour
        if(col.tag == "FlagIn"){
            System.TimeSpan date = new System.TimeSpan(0,0,-1);
            timer = timer.Subtract(date);
            FlagNb++;
            FlagDisplay.text = "Nombre de drapeau : "+ FlagNb +" / "+FlagNbTotal;
            
        }

        //Le joueur touche un bot, le bonnus de temps est contabilisé
        if(touchBot){
            System.TimeSpan date = new System.TimeSpan(0,0,-3);
            timer = timer.Subtract(date);

            touchBot=false;
        }
        
    }


    //Trigger le joueur sorte de la zone de depart
    void OnTriggerExit(Collider col) {
        if(col.tag == "Debut"){
            debutChrono = true;
        }
        
    }
     
    //Le joueur touche un bot, le bot est detruit et le compteur est mis a jour
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "OtherSkieur"){
            if(!finish){
            BotNb++;
            BotDisplay.text = "Nombre de bots : "+BotNb+" / "+BotNbTotal;
            touchBot=true;
            }
        }
    }
}
