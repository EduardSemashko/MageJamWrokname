using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CitizenCreation : MonoBehaviour
{
    //public Citizen citizen;
    private MadnessAmount madness;
    public Animator animator;
    public Animator choiseAnimator;
    public Text nameText;
    public Text speech;
    private bool citizenAsked = false;

    private int rand;
    public static string[] names = { "Eduard", "Jack", "Salvador", "Artur", "Adam", "Roland" };
    public static string[] surname = { " Handsome", " Bloody", " Creative", " Unity", " The Goat Lover", " The Lazy", " Stupid" };
    public static string[] danger = { "Bandits", "Dragon", "My wife" };
    public static string[] subject = { "Hat", "Knife", "Wife", "Horse" };
    
    void Start()
    {
        madness = GetComponent<MadnessAmount>();
    }

    public void StartDialogue (/*Dialogue dialogue*/)
    {
        citizenAsked = false;
        string[] sentences = { $"My goat got killed by {danger[Random.Range(0, danger.Length)]}, please, send some help!", $"I want new {subject[Random.Range(0, subject.Length)]}", "You are amazing, my king! Can you give me 5 gold coins?" };
        animator.SetBool("IsOpen", true);

        rand = Random.Range(0, names.Length);
        nameText.text = names[rand];
        rand = Random.Range(0, surname.Length);
        nameText.text += surname[rand];
        rand = Random.Range(0, sentences.Length);
        speech.text = sentences[rand];

        DisplaySentence();
    }
    public void DisplaySentence()
    {
       if(citizenAsked)
       {
            EndDialogue();
            return;
       }
        StopAllCoroutines();
        StartCoroutine(TypeSentence(speech.text));
        citizenAsked = true;
    }

    IEnumerator TypeSentence(string sentence)
    {
        //show all the text by a single letter 
        speech.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            speech.text += letter;
            yield return null;
        }
        citizenAsked = true;
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        choiseAnimator.SetBool("IsOpen", true);
    }

    public void listenChoise()
    {
        Debug.Log("I'll listen you, say.");
        madness.madness++;
        madness.army -= 2;
        madness.croudLoyalty += 5;
    }
    public void kickChoise()
    {
        Debug.Log("Get out of my fortress!");
        madness.madness--;
        madness.croudLoyalty -= 2;

    }
    public void executionChoise()
    {
        Debug.Log("DIE INCERT!");
        madness.madness += 4;
        madness.croudLoyalty -= 4;
        madness.army += 2;
    }
}
