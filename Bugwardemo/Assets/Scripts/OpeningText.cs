using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningText : StateMachineBehaviour {
    public Text text;
   
    public Animator AnimRefObj;

    void Start()
    {
        AnimRefObj = text.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider Other)
    {
        AnimRefObj.Play("Opening");   //use the name of your animation clip in the quotes.
    }
}
