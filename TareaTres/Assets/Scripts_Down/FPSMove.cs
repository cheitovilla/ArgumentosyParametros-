using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour {

    //Definimos una velocidad
	public float speed = 0.2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Definimos los movimientos en el teclado
        if (Input.GetKey(KeyCode.W))
        {
			transform.position += transform.forward*speed;
        }
		if (Input.GetKey(KeyCode.S)) {
			transform.position -= transform.forward * speed;
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.position -= transform.right * speed;
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.position += transform.right * speed;
		}
	}
}
