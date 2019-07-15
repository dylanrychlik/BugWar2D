using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour {


	public TextMeshPro textDisplay;
    public string[] sentences;
    private int index;
    public float Typingspeed;

    public GameObject continueButton; 
   void Start()
    {
        StartCoroutine(Type());
    }
   void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
     foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter; 
            yield return new WaitForSeconds(Typingspeed);
        }
    }
    public void NextSentence() {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text= "";
            continueButton.SetActive(false);
        }
    }
}



