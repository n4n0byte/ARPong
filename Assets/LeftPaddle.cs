using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddle : MonoBehaviour {

    public GameObject board, paddle, sphere;
    public Rigidbody sphereRB;
    private Vector3 pos;

	// Use this for initialization
	void Start () {
        sphere = GameObject.Find("ball");
        board = GameObject.Find("board");
	    sphereRB = sphere.GetComponent<Rigidbody>();
	    this.pos = this.transform.position;

	}

    void OnCollisionEnter(Collision ball) {
        if (ball.gameObject.tag == "ball") {            
            Debug.Log("Triggered");
        }

    }



    //calculates the angle the ball hits the paddle at
    float launchAngle(Vector3 ball, Vector3 paddle,
        float paddleHeight)
    {
        return (ball.y - paddle.y) / paddleHeight;
    }

    // Update is called once per frame
    void Update () {

        var z = Input.GetAxis("Horizontal") * Time.deltaTime * 3.0f;
	    transform.Translate(z, 0f, 0f);



    }
}
