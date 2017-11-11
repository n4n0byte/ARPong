using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class map : MonoBehaviour {
    public GameObject paddle;
    public Text text;

	// Use this for initialization
	void Start () {}

    // Update is called once per frame
    void Update () {
        text.text = "Left Paddle: " + paddle.transform.localPosition.ToString();
	    text.enabled = true;
	}
}
