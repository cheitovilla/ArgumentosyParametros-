using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

    //se definen variables a utilizar llamadas desde el utils
    string colorName = "";
    BodyParts parteFav;
    Behaviour behaviour = Behaviour.Moviendo;

    // Se define los randon de colores de los zombies
    void Start() {
        int randon = Random.Range(0, 3);
        switch (randon) {
            case 0:
                colorName = "Cyan";
                GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                break;
            case 1:
                colorName = "Green";
                GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                break;
            default:
                colorName = "Magenta";
                GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                break;
        }
        //el azar de las diferentes partes del cuerpo
        parteFav = (BodyParts)Random.Range(0, 5);

        
        StartCoroutine(HazMovimiento());
    }

    // Update is called once per frame
    void Update() {
        switch (behaviour) {
            case Behaviour.Moviendo:
                Mover();
                break;
        }
    }

    Vector3 direccion = Vector3.forward;
    float velocidad = 5;

    void Mover() {
        transform.Translate(direccion * velocidad * Time.deltaTime);
    }

    //corrutina del tiempo
    WaitForSeconds espera = new WaitForSeconds(5);

    IEnumerator HazMovimiento() {
        behaviour = (Behaviour)Random.Range(0, 2);
        direccion.x = Random.Range(-1, 2);
        direccion.z = Random.Range(-1, 2);
        yield return espera;
        StartCoroutine(HazMovimiento());
    }

    //informacion del utils relacionada con el zombie
    public InformacionZombie TakeZombie() {
        InformacionZombie info = new InformacionZombie();
        info.behaviour = behaviour;
        info.color = colorName;
        info.parteFavorita = parteFav;
        return info;
    }


}
