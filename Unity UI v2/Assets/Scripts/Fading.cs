using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fading : MonoBehaviour
{

    public Image image;

    public float fadeSpeed = 0.3f;
    public int drawDepth = -1000;


    // Use this for initialization
    void Start()

    {

    }

    

    // Update is called once per frame
    void Update()
    {
        blinkActive();
        
    }

    public bool blinkActive()
    {
        /*
        //test
        switch (Input.inputString)
        {
            case "1":
                Debug.Log("1 pressed, red");
                ChangeColor(Color.red);//turn red
                blinkFunction();
                return true;

            case "2":
                Debug.Log("2 pressed, green");
                ChangeColor(Color.green);//turn green
                blinkFunction();
                return true;

            case "3":
                Debug.Log("3 pressed, black");
                ChangeColor(Color.black);//turn black
                blinkFunction();
                return true;

            default:
                //ChangeColor(Color.clear);//turn clear
                return false;

        }
        */
        return false;
    }

    void ChangeColor(Color color)
    {
        image.color = color;
    }

    public void blinkRed()
    {
        ChangeColor(Color.red);//turn red
        blinkFunction();
        ChangeColor(Color.clear);
    }

    public void blinkGreen()
    {
        ChangeColor(Color.green);//turn green
        blinkFunction();
        ChangeColor(Color.clear);
    }

    public void blinkBlack()
    {
        //set alpha to 1
        //then fade
        ChangeColor(Color.black);//turn black
        blinkFunction();
        ChangeColor(Color.clear);
    }

    public void blinkFunction()
    {
        Debug.Log(blinkActive());

        Color tmpColor = image.color;
        tmpColor.a = (float)1 + Mathf.Sin((Time.time) * 5);
        //print(tmpColor.a);

        tmpColor.a = (float)(tmpColor.a / 2.0) + (float)0.5;

        image.color = tmpColor;
    }



    /*void fadeOut()
    {
        fadeDir = 1;
    }

    void fadeIn()
    {
        fadeDir = -1;
    }

    void startFade() {
        alpha = 1;
        fadeIn();
    }*/


}
