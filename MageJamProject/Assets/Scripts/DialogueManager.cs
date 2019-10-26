using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;
    public int rand;
    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        //Debug.Log("Starting conversation with " + dialogue.name);
        rand = Random.Range(0, Dialogue.names.Length);
        animator.SetBool("IsOpen", true);

        nameText.text = Dialogue.names[rand];
        rand = Random.Range(0, Dialogue.surname.Length);
        nameText.text += Dialogue.surname[rand];
        
        rand = Random.Range(0, Dialogue.situation.Length);
        string sitizenRequest = Dialogue.situation[rand];

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
       // RequestBuilder(sitizenRequest);
        DisplayNextSentence();
    }

    public void RequestBuilder(string n)
    {
        if (n == "casual")
        {
            
        }
        else if (n == "special")
        {

        }
        else
        {

        }        
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        //dialogueText.text = sentence;
    }
    
    IEnumerator TypeSentence (string sentence)
    {
        //show all the text by a single letter 
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        //Debug.Log("End of conversation");
    }
}
