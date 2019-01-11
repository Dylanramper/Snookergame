using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballfiring : MonoBehaviour {
    public bool moving;
    private Rigidbody Ballrb;
    private float strength;
    public CueBall CueScript;
    public GameObject CueOBJ;
    public bool timerActive;
    private float timer;
    public Slider powerSlider;
    public ScoreManager scoreMgr;
    public Text playeronetext;
    public Text playertwotext;


    // Use this for initialization
    void Start () {
        Ballrb = GetComponent<Rigidbody>();
        strength = 7000;
        timer = 5;
	}
	
   
    public void FireBall()
    {
        timerActive = true;
        //Ballrb.AddForce(CueOBJ.transform.forward *strength);
    }

	// Update is called once per frame
	void Update () {

        playeronetext.text = scoreMgr.playeronescore.ToString();
        playertwotext.text = scoreMgr.playertwoscore.ToString();

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            gameObject.transform.Rotate(new Vector3(0, 10, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            gameObject.transform.Rotate(new Vector3(0, -10, 0));
        }
        if (Input.GetKeyDown(KeyCode.Space) && !moving)
        {
            Debug.Log("Space");
            Ballrb.AddForce(CueOBJ.transform.forward * strength * powerSlider.value);
            
            CueOBJ.SetActive(false);
            timerActive = true;
            moving = true;
           
        }



        if (timerActive)
        {
            Debug.Log("Timing");
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timerActive = false;
            timer = 5;
            moving = false;
            if (scoreMgr.playeroneturn)
            {
                scoreMgr.playeroneturn = false;
            }
            else
            {
                scoreMgr.playeroneturn = true;
            }
            CueScript.ResetCue();
        }
    
    }

}
