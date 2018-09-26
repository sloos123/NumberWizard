using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int min = 1;
    int max = 1000;
    int guess = 500;

	// Use this for initialization

	void Start () {

        Debug.Log("Hello! Think of a number and don't tell me which one it is...my guess is " + guess);
    }
	

	// Update is called once per frame
	void Update () {
       
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("So your number is lower, huh..");
            max = guess;
            calcGuess();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So your number is higher, huh..");
            min = guess;
            calcGuess();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I got your number right...I am the best wizard in the universe!!!");
        }
    }

    void calcGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("My guess is " + guess);
    }
}
