using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour {
    //Definimos variables
    float mouseX;
    float mouseY;
    public bool IntervedMouse;


    // Update is called once per frame
    void Update() {

        //Movimiento del mouse
        mouseX += Input.GetAxis("Mouse X");
        if (IntervedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
       //la rotacion
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);

    }
}
