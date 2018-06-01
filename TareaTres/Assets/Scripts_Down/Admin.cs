using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin : MonoBehaviour {

   // public GameObject player;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
      //  se crea el heroey todos sus componentes
        player.AddComponent<Hero>();
        player.tag = "Hero";
        player.AddComponent<Camera>();
        player.AddComponent<FPSMove>();
        player.AddComponent<FPSAim>();
        player.AddComponent<Rigidbody>();
        player.GetComponent<Rigidbody>().freezeRotation = true;

        //el rango entre los diferentes zombies y ciudadanos
        int x = Random.Range(10, 20);


        //el zar de aparicion de ciudadanos y zombies
        for (int i = 0; i < x; i++)
        {
            GameObject npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            npc.transform.position = new Vector3(Random.Range(-45, 45), 0.5f, Random.Range(-45, 45));

            //ciudadano
            int tipe = Random.Range(0, 2);
            if (tipe == 0)
            {
                npc.name = "Ciudadano";
                npc.tag = "Ciudadano";
                npc.AddComponent<Ciudadaneishon>();
            }
            else
            {
               //Zombie
                npc.name = "Zombie";
                npc.tag = "Zombie";
                npc.AddComponent<Zombie>();
                npc.AddComponent<Rigidbody>();
                npc.GetComponent<Rigidbody>().freezeRotation = true;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
