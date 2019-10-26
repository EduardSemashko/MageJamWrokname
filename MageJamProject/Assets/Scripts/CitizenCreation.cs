using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CitizenCreation : MonoBehaviour
{
    //public Citizen citizen;
    private LawBook lawbook;
    private MadnessAmount madness;
    public Animator animator;
    public Animator choiseAnimator;
    public Text nameText;
    public Text speech;
    private bool citizenAsked = false;

    private int rand;
    public int lawBonusCroud = 1;
    public int lawBonusArmy = 1;
    public int lawBonusMadness = 1;


    private string bookCount_dangers;
    private string bookCount_names;
    private string bookCount_surenames;


    public static string[] names = { "Eduard", "Jack", "Salvador", "Artur", "Adam", "Roland" };
    public static string[] surname = { " Handsome", " Bloody", " Creative", " Unity", " The Goat Lover", " The Lazy", " Stupid" };
    public static string[] danger = { "Bandits", "Dragon", "My wife" };
    public static string[] subject = { "Hat", "Knife", "Wife", "Horse" };
    
    void Start()
    {
        lawbook = GetComponent<LawBook>();
        madness = GetComponent<MadnessAmount>();
    }

    public void StartDialogue (/*Dialogue dialogue*/)
    {
        citizenAsked = false;
        string[] sentences = { $"I want new {subject[Random.Range(0, subject.Length)]}", "You are amazing, my king! Can you give me 5 gold coins?", $"My goat got killed by {bookCount_dangers = danger[Random.Range(0, danger.Length)]}, please, send some help!" };

        animator.SetBool("IsOpen", true);

        rand = Random.Range(0, names.Length);
        nameText.text = names[rand];
        

        rand = Random.Range(0, surname.Length);
        nameText.text += surname[rand];
        

        rand = Random.Range(0, sentences.Length);
        speech.text = sentences[rand];

        DisplaySentence();
       // lawbook.WriteName(bookCount_names,tmp);
        //tmp++;
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
        MakelikeOne(lawBonusMadness, lawBonusCroud, lawBonusArmy);
    }

    public void listenChoise()
    {
        Debug.Log("I'll listen you, say.");
        madness.madness++;
        madness.army -= 3;
        madness.croudLoyalty += 6 ;
    }
    public void kickChoise()
    {
        Debug.Log("Get out of my fortress!");
        madness.madness += 1 * lawBonusMadness;
        madness.croudLoyalty -= 2 * lawBonusCroud;
        madness.army += 1 * lawBonusArmy;
    }
    public void executionChoise()
    {
        Debug.Log("DIE INCERT!");
        madness.madness += 8 * lawBonusMadness;
        madness.croudLoyalty -= 4 * lawBonusCroud;
        madness.army += 6 * lawBonusArmy;
    }
    void MakelikeOne(int i,int k,int s)
    {
        i = 1;
        k = 1;
        s = 1;
    }
}
