using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CitizenCreation : MonoBehaviour
{
    //public Citizen citizen;
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

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }

    public void answerChoise()
    {
        choiseAnimator.SetBool("IsOpen", true);
    }
}
