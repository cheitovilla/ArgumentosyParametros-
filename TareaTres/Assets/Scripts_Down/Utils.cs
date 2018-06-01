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
    Quieto, Moviendo
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
}

//structura de datos de zombie
public struct InformacionCiudadano {
    public int edadciudadano;
    public NameCiudadanos nameciudadano;
}