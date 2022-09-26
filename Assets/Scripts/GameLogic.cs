using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class GameLogic : MonoBehaviour
{
    // declaring a variables
    public int randomNum;
    public TMP_InputField userInput;
    public TMP_Text textView;
    public int cnt;
    public int minVal;
    public int maxVal;
    public Button ButtonGuess;
    public Button ButtonReset;

    // Start is called before the first frame update
    void Start()
    {
        textView.text = "";
        cnt = 0;
        randomNum = Random.Range(minVal, maxVal);
        textView.text = "Welcome! \nGuess a number between " + minVal + " and " + maxVal;
    }

    public void Reset()
    {
        Start();
        ButtonReset.gameObject.SetActive(false);
        ButtonGuess.gameObject.SetActive(true);

    }

    public void onButtonClick()
    {
        if (userInput.text != "")
        {
            cnt++;
            if (int.Parse(userInput.text) < randomNum)
            {
                textView.text = "Try Higher!";
            }
            else if (int.Parse(userInput.text) > randomNum)
            {
                textView.text = "Try Lower!";
            }
            else
            {
                textView.text = "You Won! \nYou did it in " + cnt + " tries!";
                ButtonReset.gameObject.SetActive(true);
                ButtonGuess.gameObject.SetActive(false);
            }
        }
        else
        {
            textView.text = "Please enter a number!";
        }

    }

}
