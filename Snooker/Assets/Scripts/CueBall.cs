using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour {
    private Rigidbody CueBallrb;
    public GameObject CueParent;
    private float strength;
	// Use this for initialization
	void Start () {
        CueBallrb = GetComponent<Rigidbody>();
        strength = 1000000;
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Cue" + CueBallrb.velocity);
        if (Input.GetMouseButtonDown(0))
        {
            CueBallrb.AddForce(CueParent.transform.forward * strength);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            CueBallrb.velocity = Vector3.zero;
        }
        
	}
    public void ResetCue()
    {
        transform.position = CueParent.transform.position;
        gameObject.SetActive(true);
        CueBallrb.velocity = Vector3.zero;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "CueBall")
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<Ballfiring>().moving = true;
            
        }
    }
   
}
