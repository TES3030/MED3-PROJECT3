using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.RANDOM;

public class Addition : MonoBehaviour
{


    bool gameBegun = false;

    public Text targetValueText;
    public Text sqOne;
    public Text sqTwo;
    public Text sqThree;

    int[] numbersAvailable = new int[3];
    int targetValue;

    // Use this for initialization
    void Start()
    {
        gameReset();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            gameReset();

        if (checkAssignment())
        {
            if (checkIfCorrect())
            {
                //call greenBlink
                //gameReset();
            } else {
                //call redBlink
            }
        }
    }


    public bool checkAssignment()
    {
        //if 2 cubes in assignment space
        //return true
        //else
        return false;
    }

    public bool checkIfCorrect()
    {
        //if numbersAvailable[x] + --||-- = targetValue
        //return true
        //else
        return false;
    }

    void gameReset()
    {
        targetValue = (int)Random.Range(1.0f, 10.0f);
        targetValueText.text = targetValue.ToString();
        //generating 3 numbers
        while (!(numbersAvailable[0] + numbersAvailable[1] == targetValue || numbersAvailable[1] + numbersAvailable[2] == targetValue || numbersAvailable[0] + numbersAvailable[2] == targetValue))
        {
            for (int i = 0; i < numbersAvailable.Length; i++)
            {
                int rnd = (int)Random.Range(1.0f, 10.0f);
                numbersAvailable[i] = rnd;
            }
        }
        sqOne.text = numbersAvailable[0].ToString();
        sqTwo.text = numbersAvailable[1].ToString();
        sqThree.text = numbersAvailable[2].ToString();
        Debug.Log(numbersAvailable[0]);
        Debug.Log(numbersAvailable[1]);
        Debug.Log(numbersAvailable[2]);


        //------------------
        if (gameBegun)
        {
            //activate shadows for 4 seconds
            //start "black blink"
            //GameObject.FindWithTag("SquareShadow").transform.GetComponent<Fading>().blackBlink();
            //deactivate shadows
        }
        gameBegun = true;//making sure the black blinking doesnt come on startup

    }

}
