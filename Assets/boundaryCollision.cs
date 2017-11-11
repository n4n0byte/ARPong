using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryCollision : MonoBehaviour {

    private GameObject ball;
    private System.Random rand;

	// Use this for initialization
	void Start () {
		ball = GameObject.Find("ball");
        rand = new System.Random();
	}

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject == ball) {
            pushBallStart.speed += .1f;
            ball.transform.position = pushBallStart.pos;
            ball.GetComponent<Rigidbody>().AddForce(new Vector3(pushBallStart.speed - 3,0,pushBallStart.speed+3), ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
