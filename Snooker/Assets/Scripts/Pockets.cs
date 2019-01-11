using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pockets : MonoBehaviour {
    public ScoreManager scoreManager;
    public GameObject Spawn;
    public CueBall CueScript;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedBall")
        {
            other.gameObject.SetActive(false);
            if (scoreManager.playeroneturn)
            {
                scoreManager.AddScorePlayerOne(1);
            }
            else
            {
                scoreManager.AddScorePlayerTwo(1);
            }
        }
        if (other.gameObject.tag == "CueBall")
        {
            other.gameObject.transform.position = Spawn.transform.position;
            other.gameObject.transform.rotation = Spawn.transform.rotation;
            

        }
    }

}
