using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LawBook : MonoBehaviour
{
    CitizenCreation citznCreatn;
    private string[] appriciateLaws;
    private string[] forbidLaws;
    private string[] namesIncome;

    public static string[] lawLoyalty = { "From this day, every person in the city gets free slice of bread", "From this day, taxes are reduced from 1000 gold to 999 gold per week", "From this day, your king promise you, you will live the better life!" };
    public static string[] lawMadness = { "From this day, every person in the city must walk by hands!", "From this day, your clothes are crown property!", "From this day,GOAT is a holy animal!" };
    public static string[] lawArmy = { "From this day,every blacksmith in the town making weapon only for the crown!", "From this day,is strictly forbidden to talk with the royal guard !" };
    public Text law;
   

    void Start()
    {
        citznCreatn = GetComponent<CitizenCreation>();
    }
    
    public void RandomLaw()
    {
        int rand = Random.Range(1, 3);
        if(rand == 1)
        {
            LawBonusLoyalty();
        }
        else if(rand == 2)
        {
            LawBonusMadness();
        }
        else
        {
            LawBonusArmy();
        }
    }

    public void LawBonusLoyalty()
    {
        law.text = lawLoyalty[Random.Range(0, lawLoyalty.Length)];
        citznCreatn.lawBonusCroud = 2;
    }

    public void LawBonusMadness()
    {
        law.text = lawMadness[Random.Range(0, lawMadness.Length)];
        citznCreatn.lawBonusMadness = 2;
    }

    public void LawBonusArmy()
    {
        law.text = lawArmy[Random.Range(0, lawArmy.Length)];
        citznCreatn.lawBonusArmy = 2;
    }
/*
    public void WriteName(string name,int k)
    {
        name = namesIncome[k];
    }

    private string SearchPopularName(string[] array)
    {
        var mf = 1;//default maximum frequency
        var m = 0;//counter
        string item ="";
        for(var i=0; i < array.Length; i++)
        {
            for(var j = i; j < array.Length; j++)
            {
                if(array[i] == array[j])
                {
                    m++;
                }
                if(mf < m)
                {
                    mf = m;
                    item = array[i];
                }
            }
            m = 0;
        }
        return item;
        //Debug.Log($"{item}");
    }

    public void ShowLaws()
    {
       
    }
   */
}
