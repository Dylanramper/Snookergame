using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballfiring : MonoBehaviour {
    public bool moving;
    private Rigidbody Ballrb;
    public CueBall CueScript;

    // Use this for initialization
    void Start () {
        Ballrb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Ball" + Ballrb.velocity);

        if (moving && Ballrb.velocity == Vector3.zero)
        {
           
            Ballrb.velocity = Vector3.zero;
            moving = false;
            CueScript.ResetCue();
        }
	}
}
