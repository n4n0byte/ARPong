using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushBallStart : MonoBehaviour {

    public GameObject ball;
    private Rigidbody ballRigidbody;
    public static Vector3 t, pos;
    private static System.Random rand = new System.Random();
    public static float speed = 3;

	// Use this for initialization
	void Start () {
	    ballRigidbody = ball.GetComponent<Rigidbody>();
	    pos = ball.gameObject.transform.position;
        ballRigidbody.AddForce(new Vector3((float)rand.NextDouble() * 5,0, rand.Next(3,5)),ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
