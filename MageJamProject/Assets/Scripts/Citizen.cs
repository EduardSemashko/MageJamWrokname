using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New citizen", menuName = "Citizen")]
public class Citizen : ScriptableObject
{
    public string citizenName;
    public string citizenSurname;
    public string speech;

    /*public static string[] names = { "Eduard", "Jack", "Salvador", "Artur", "Adam", "Roland" };
    public static string[] surname = { " Handsome", " Bloody", " Creative", " Unity", " The Goat Lover", " The Lazy", " Stupid" };
    public static string[] danger = { "Bandits", "Dragon", "My wife" };
    public string[] sentences = { "My goat got killed by {}, please, send some help from bandits !", "I want new {}", "You are amazing, my king! Can you give me 5 gold coins?" };*/

}
