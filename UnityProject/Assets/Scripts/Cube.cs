using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public float moveSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float move_x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float move_z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(move_x, 0, move_z);
	}
}
