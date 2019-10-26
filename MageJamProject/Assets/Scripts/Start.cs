using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    
    public Animator transitionAnim;
    public float wait;
    public void PlayGame(){
        StartCoroutine(changer()); 
        
    }
    public void Again(){
        SceneManager.LoadScene("SampleScene");
    }
    public void quit(){
        Application.Quit();
    }
    IEnumerator changer(){
        //transitionAnim.SetTrigger("end");
        yield return new  WaitForSeconds(wait);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}


