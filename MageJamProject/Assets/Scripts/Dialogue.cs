using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
    public static string[] names = {"Eduard", "Jack", "Salvador", "Artur", "Adam", "Roland"};
    public static string[] surname = { " Handsome", " Bloody", " Creative", " Unity", " The Goat Lover", " The Lazy", " Stupid" };
    public static string[] situation = { "casual", "quest", "special" };

    public string[] sentences;//= {"My goat got killed, please, send some help from bandits !","I want new hat","You are amazing, my king! Can you give me 5 gold coins?"};
    //[TextArea(3, 10)]
}
