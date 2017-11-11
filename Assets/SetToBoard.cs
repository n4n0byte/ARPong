using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetToBoard : MonoBehaviour {

    public GameObject board;
    public Camera cam;
    private Vector3 offset;

	void Start () {
	    offset = transform.position - board.transform.position;
	}
	
	void Update () {
	    transform.position = board.transform.position + offset;
	    cam.transform.rotation = Quaternion.Euler(45, 90, 0); 
    }



}
