using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;

public class Hero : MonoBehaviour {

    //se definen las coliciones con los diferentes scripts, ciudadano y zombies
    void OnCollisionEnter(Collision col)
    {
        //la colision del zombie
        if (col.gameObject.GetComponent<Zombie>())
        {
            InformacionZombie z = col.gameObject.GetComponent<Zombie>().TakeZombie();
            print("Warrrr soy un Zombie y quiero comer " + z.parteFavorita.ToString());
        }

      // la colision del ciudadano
        if (col.gameObject.GetComponent<Ciudadaneishon>())
        {
            InformacionCiudadano c = col.gameObject.GetComponent<Ciudadaneishon>().TakeCiudadaneishon();
            print("Hola soy " + c.nameciudadano + " y tengo " + c.edadciudadano + " años. ");
        }
        
    }


}
