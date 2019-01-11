using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour {
    public Rigidbody BallRB;
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
        /*
        if (Input.GetMouseButtonDown(0))
        {
            CueBallrb.AddForce(CueParent.transform.forward * strength);
        }
        */
        


    }
    public void ResetCue()
    {
        Debug.Log("Resetti");
        BallRB.velocity = Vector3.zero;
        BallRB.angularVelocity = Vector3.zero;
        transform.position = CueParent.transform.position;
        CueParent.SetActive(true);
        
        //CueBallrb.velocity = Vector3.zero;
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "CueBall")
        {
            gameObject.SetActive(false);
            other.gameObject.GetComponent<Ballfiring>().moving = true;
            other.gameObject.GetComponent<Ballfiring>().FireBall();
        }
       
    }
    */
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "CueBall")
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<Ballfiring>().moving = true;
            
        }
    }
   */
}
