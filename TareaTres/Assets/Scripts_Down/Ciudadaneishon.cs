using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NPC
{

    namespace Ally
    {

        public class Ciudadaneishon : MonoBehaviour
        {

            //definicion variables
            NameCiudadanos nameciu;
            int edadciu;


            // se define el randon de los nombres y edad de ciudadanos
            void Start()
            {
                edadciu = Random.Range(15, 100);
                //  parteFav = (BodyParts)Random.Range(0, 5);
                nameciu = (NameCiudadanos)Random.Range(0, 20);
            }

            // Update is called once per frame
            void Update()
            {

            }


            //se llama la informacion del ciudadano
            public InformacionCiudadano TakeCiudadaneishon()
            {
                InformacionCiudadano info = new InformacionCiudadano();
                info.nameciudadano = nameciu;
                info.edadciudadano = edadciu;
                return info;
            }


        }
    }
}