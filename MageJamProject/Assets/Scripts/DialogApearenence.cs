using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogApearenence : MonoBehaviour
{
    public Dialogue dialogue;
    
    public void TriggerDialogue()
    {
        FindObjectOfType<CitizenCreation>().StartDialogue();
    }
}
