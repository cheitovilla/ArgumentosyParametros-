using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NPC.Ally;
using NPC.Enemy;
using UnityEngine.UI;

public class Admin : MonoBehaviour {
    // se definen variables a utilizar
    int zom = 0;
    int ciu = 0;
    public GameObject[] cubos;
    public Text enemies;
    public Text ciudadaneishons;
    public Person per;
    public const int max = 25;

	void Start ()
    {
        //variables del randon a utilizar
        int p = Random.Range(5, 16);
        per = new Person(p);
        int rnd2 = Random.Range(p, max);
        cubos = new GameObject[rnd2];
        GameObject player = GameObject.CreatePrimitive(PrimitiveType.Capsule);

      //  se crea el heroe y todos sus componentes
        player.AddComponent<Hero>();
        player.tag = "Hero";
        player.AddComponent<Camera>();
        player.AddComponent<FPSMove>();
        player.AddComponent<FPSAim>();
        player.AddComponent<Rigidbody>();
        player.GetComponent<Rigidbody>().freezeRotation = true;

        //el azar de aparicion de ciudadanos y zombies
        for (int i = 0; i < rnd2; i++)
        {
            GameObject npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            npc.transform.position = new Vector3(Random.Range(-45, 45), 0.5f, Random.Range(-45, 45));
            int tipe = Random.Range(0, 2);
            if (tipe == 0)
            {
              //Ciudadano
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
            cubos[i] = npc;
            
        }
        //el foreach que piden utilizar en el documento para el conteo de ciudadanos y zombies
        foreach (GameObject pri in cubos)
        {
            GameObject go = pri as GameObject;
            if (go.tag == "Ciudadano")
            {
                ciu += 1;
            }
            else if (go.tag == "Zombie")
            {
                zom += 1;
            }
        }
    }
	
    //Aqui se muestran en el canvas la cantidad de zombies y ciudadanos
	void Update ()
    {
        ciudadaneishons.text = "Enemys: " + zom.ToString();
        enemies.text = "Ciudadaneishons: " + ciu.ToString();
    }
}
