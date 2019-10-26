using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
    public static string[] names = { "Eduard", "Jack", "Salvador", "Artur", "Adam", "Roland" };
    public static string[] surname = { " Handsome", " Bloody", " Creative", " Unity", " The Goat Lover", " The Lazy", " Stupid" };
    public static string[] danger = { "Bandits", "Dragon", "My wife" };
    public static string[] subject = { "Hat", "Knife", "Wife", "Horse" };

    public string[] sentences;
    //[TextArea(3, 10)]
}
