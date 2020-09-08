using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{
    int HighestNumber;
    int LowestNumber;
    int userGuess;
    // Start is called before the first frame update
    void Start()
    {
        HighestNumber = 1000;
        LowestNumber = 1;
        userGuess = HighestNumber / 2;
        Debug.Log("Guess The Number Program");
        Debug.Log("Pick a number.");
        Debug.Log("Highest Number you can pick is " + HighestNumber);
        Debug.Log("Lowest Number you can pick is " + LowestNumber);
        Debug.Log("-------------");
        Debug.log("Higher or lower than..." + userGuess);
        Debug.Log("Up Arrow Key = Higher, Down Arrow Key = Lower, Enter = Correct");
        HighestNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            LowestNumber = userGuess;
            userGuess = ( HighestNumber + LowestNumber) / 2;
            Debug.Log("Higher or lower than... " + userGuess);
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            HighestNumber = userGuess;
            userGuess = (HighestNumber + LowestNumber) / 2;
            Debug.Log("Higher or lower than... " + userGuess);
        } else if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Genius here LUL");
        }
    }
}
