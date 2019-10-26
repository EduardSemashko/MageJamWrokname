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
        //speech = Dialogue.sentences
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        //Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
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
