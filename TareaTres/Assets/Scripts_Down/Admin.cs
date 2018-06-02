using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;
using UnityEngine.UI;

public class Admin : MonoBehaviour {
    int zom = 0;
    int ciu = 0;
    // public GameObject player;
    public GameObject[] cubos;
    public Text enemies;
    public Text ciudadaneishons;

    public Person per;
    public const int max = 25;
	// Use this for initialization
	void Start () {
        
        int p = Random.Range(5, 16);
        per = new Person(p);
        int rnd2 = Random.Range(p, max);
        cubos = new GameObject[rnd2];
        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
      //  se crea el heroey todos sus componentes
        player.AddComponent<Hero>();
        player.tag = "Hero";
        player.AddComponent<Camera>();
      //  Camera cam = new Camera();
      //  cam.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, 0);
        player.AddComponent<FPSMove>();
        player.AddComponent<FPSAim>();
        player.AddComponent<Rigidbody>();
        player.GetComponent<Rigidbody>().freezeRotation = true;

        //el rango entre los diferentes zombies y ciudadanos
       // int x = Random.Range(10, 20);


        //el zar de aparicion de ciudadanos y zombies
        for (int i = 0; i < rnd2; i++)
        {
            GameObject npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            npc.transform.position = new Vector3(Random.Range(-45, 45), 0.5f, Random.Range(-45, 45));

            //ciudadano
            int tipe = Random.Range(0, 2);
            if (tipe == 0)
            {
                ciu = ciu + 1;
                npc.name = "Ciudadano";
                npc.tag = "Ciudadano";
                npc.AddComponent<Ciudadaneishon>();
            }
            else
            {
                zom = zom + 1;
                //Zombie
                npc.name = "Zombie";
                npc.tag = "Zombie";
                npc.AddComponent<Zombie>();
                npc.AddComponent<Rigidbody>();
                npc.GetComponent<Rigidbody>().freezeRotation = true;
            }
            cubos[i] = npc;
            foreach (GameObject go in cubos)
            {

                
                if (tipe == 0)
                {
                    ciudadaneishons.text = "Enemys: " + ciu.ToString();
                }
                else
                {
                    enemies.text = "Ciudadaneishons: " + zom.ToString();
                }
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
