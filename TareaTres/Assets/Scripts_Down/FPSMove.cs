using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour {

    //Definimos una velocidad
	public float speed = 0.2f;

    InfoHero speedhero;

    
	// Use this for initialization
	void Start () {
        float s = Random.Range(2f, 6f);
        speedhero = new InfoHero(s);
    }
	
	// Update is called once per frame
	void Update () {
        //Definimos los movimientos en el teclado
        if (Input.GetKey(KeyCode.W))
        {
			transform.position += transform.forward* speedhero.speedHero* Time.deltaTime;
        }
		if (Input.GetKey(KeyCode.S)) {
			transform.position -= transform.forward * speedhero.speedHero * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A)) {
			transform.position -= transform.right * speedhero.speedHero * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D)) {
			transform.position += transform.right * speedhero.speedHero * Time.deltaTime;
		}
	}
}
