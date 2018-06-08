using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC
{
    namespace Enemy
    {
        public class Zombie : MonoBehaviour
        {
            //se definen variables a utilizar llamadas desde el utils
            string colorName = "";
            BodyParts parteFav;
            Behaviour behaviour = Behaviour.Moviendo;
            InformacionZombie infozombi;
            // Se define los randon de colores de los zombies
            void Start()
            {
                int randon = Random.Range(0, 3);
                switch (randon)
                {
                    //Color cyan
                    case 0:
                        colorName = "Cyan";
                        GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                        break;
                    //Color Verde
                    case 1:
                        colorName = "Green";
                        GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                        break;
                    //Color Magenta
                    default:
                        colorName = "Magenta";
                        GetComponent<Renderer>().material.SetColor("_Color", Color.magenta);
                        break;
                }
                //el azar de las diferentes partes del cuerpo
                parteFav = (BodyParts)Random.Range(0, 5);
                StartCoroutine(HazMovimiento());
            }

            //Aqui estan switcheando los diferentes metodos de movimientos 
            void Update()
            {
                switch (behaviour)
                {
                    case Behaviour.Quieto:
                        break;
                    case Behaviour.Moviendo:
                        Mover();
                        break;
                    case Behaviour.Rotando:
                        Rotando();
                        break;
                }
            }

            float velocidad = 5;
            float velocityRotation = 50;

            //metodo de mover
            void Mover()
            {
                transform.Translate(Vector3.forward*velocidad * Time.deltaTime); 
            }

            //Metodo de rotar
            void Rotando()
            {
                transform.eulerAngles += (infozombi.rotacion * velocityRotation * Time.deltaTime);
            }

            //corrutina del tiempo
            WaitForSeconds espera = new WaitForSeconds(3);

            IEnumerator HazMovimiento()
            {
                behaviour = (Behaviour)Random.Range(0, 3);
                infozombi.rotacion.y = Random.Range(-10f, 20f);
                 yield return espera;
                StartCoroutine(HazMovimiento());
            }

            //informacion del utils relacionada con el zombie
            public InformacionZombie TakeZombie()
            {
                InformacionZombie info = new InformacionZombie();
                info.behaviour = behaviour;
                info.color = colorName;
                info.parteFavorita = parteFav;
                return info;
            }


        }
    }
}