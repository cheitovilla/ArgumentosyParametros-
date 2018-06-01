using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Aqui se definen los enums y las estructuras que se utilizan los scripts

    //Partes del cuerpo
public enum BodyParts {
    Cabeza, Brazos, Piernas, Nalgas, Abdomen
}

//el movimiento
public enum Behaviour { 
    Quieto, Moviendo, Rotando
}

//Enumeracion de nombres de ciudadanos
public enum NameCiudadanos {
    mateo, juan, lucas, marcos, fredy, abraham, elkin, krillin, hitler, maria, judas, el_pirilo, vegeta77, elrubiosomg, justin, magia_nrega, josejuaquin, willian, jhon, mario, 
    Lenght
}

// estructura de datos de zombie
public struct InformacionZombie {
    public string color;
    public BodyParts parteFavorita;
    public Behaviour behaviour;
    public Vector3 rotacion;
}

//structura de datos de zombie
public struct InformacionCiudadano {
    public int edadciudadano;
    public NameCiudadanos nameciudadano;
}


// del randon del mini randon al maximo constante
public struct Person 
{
public readonly int rndIni;
    public Person(int rnd) {
        rndIni = rnd;
    }
}

//Velocidad randon del hero
public struct InfoHero {
    public readonly float speedHero;

    public InfoHero(float speed) {
        speedHero = speed;
    }
   
}


