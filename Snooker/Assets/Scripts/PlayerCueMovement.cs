using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCueMovement : MonoBehaviour {
	private Vector3 mousePos;
	private Vector2 direction;
    public Transform CueB;
    
	
	// Use this for initialization
	void Start () {
		//Debug.Log(Camera.main);
        transform.parent = CueB.transform;
	}
	
	// Update is called once per frame
	void Update () {
        

       mousePos = Input.mousePosition;

       Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
       mousePos.x = mousePos.x - objectPos.x;
       mousePos.y = mousePos.y - objectPos.y;

       float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
       CueB.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
    }
}
