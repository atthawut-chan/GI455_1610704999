using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInput : MonoBehaviour
{
    public string word;
    public GameObject inputField;
    public GameObject Display;
    // Use this for initialization
    public void displayWord()
    {
        word = inputField.GetComponent<Text>().text;
        if (word == "Apple")
        {  
            Display.GetComponent<Text>().text = "[ <color=green>" + word + "</color> ] is found";
        }
        else if (word == "SamSung")
        {
            Display.GetComponent<Text>().text = "[ <color=green>" + word + "</color> ] is found";
        }
        else if (word == "FaceBook")
        {
            Display.GetComponent<Text>().text = "[ <color=green>" + word + "</color> ] is found";
        }
        else if (word == "Google")
        {
            Display.GetComponent<Text>().text = "[ <color=green>" + word + "</color> ] is found";
        }
        else if (word == "Youtube")
        {
            Display.GetComponent<Text>().text = "[ <color=green>" + word + "</color> ] is found";
        }
        else
        {
            Display.GetComponent<Text>().text = "[ <color=red>" + word + "</color> ] not found";
        }
    }
}
