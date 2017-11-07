using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBullet : MonoBehaviour {

    public float Bulletspeed;
    private Rigidbody2D mybody;
    

    // Use this for initialization
    void Awake () {
        mybody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        mybody.velocity = new  Vector2(0f, Bulletspeed);      
    }
  
}
