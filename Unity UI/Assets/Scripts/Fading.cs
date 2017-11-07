using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fading : MonoBehaviour {

    public Image image;

    public float fadeSpeed = 0.3f;
    public int drawDepth = -1000;

    private float alpha = 1.0f;
    private float fadeDir = -1;

    private bool shouldBlink = false;
    private Color NumberColor;


    // Use this for initialization
    void Start()
        
    {
        bool correctAnswer;
        if (correctAnswer==true) {// correct answer
            ChangeColor(Color.green);// turn green
        }

        else {//wrong answer
            ChangeColor(Color.red);//turn red
        }
        correctAnswer = false;
    }

    void ChangeColor(Color color)
    {
        image.color = color;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (shouldBlink)
        {
            //Fade in
            Color tmpColor = image.color;

            tmpColor.a += fadeSpeed * Time.deltaTime;
            tmpColor.a -= fadeSpeed * Time.deltaTime;

            image.color = tmpColor;
        }

     


    }



    void _ ()
    {
        
    }

    void fadeOut()
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
    }


}
