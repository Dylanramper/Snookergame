using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballfiring : MonoBehaviour {
    public bool moving;
    private Rigidbody Ballrb;
    private float strength;
    public CueBall CueScript;
    public GameObject CueOBJ;
    public bool timerActive;
    private float timer;


    // Use this for initialization
    void Start () {
        Ballrb = GetComponent<Rigidbody>();
        strength = 1000;
        timer = 5;
	}
	
   
    public void FireBall()
    {
        timerActive = true;
        Ballrb.AddForce(CueOBJ.transform.forward *strength);
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            gameObject.transform.Rotate(new Vector3(0, 20, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            gameObject.transform.Rotate(new Vector3(0, -20, 0));
        }



        if (timerActive)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            timerActive = false;
            timer = 5;
            moving = false;
            CueScript.ResetCue();
        }
        if (moving)
        {
            if (moving = false)
            {
                CueScript.ResetCue();
                
            }
        }
    }

}
