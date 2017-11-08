using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fading : MonoBehaviour {

    public Image image;

    public float fadeSpeed = 0.3f;
    public int drawDepth = -1000;

    //private float alpha = 1.0f;
    //private float fadeDir = -1;

    private bool shouldBlink = false;
    private Color NumberColor;
    bool correctAnswer;


    // Use this for initialization
    void Start()
        
    {
        
        int i=11;
        correctAnswer = (i>10);
        if (correctAnswer==true) {// correct answer
            ChangeColor(Color.green);// turn green
            shouldBlink = true;
        }

        else {//wrong answer
            ChangeColor(Color.red);//turn red
            shouldBlink = true;
        }
        correctAnswer = false;
        //shouldBlink = false;
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
            tmpColor.a =(float)1 + Mathf.Sin((Time.time)*5);
            print(tmpColor.a);

            tmpColor.a = (float)(tmpColor.a / 2.0) + (float)0.5;

            image.color = tmpColor;
        }

     


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
