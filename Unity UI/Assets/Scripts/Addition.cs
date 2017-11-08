using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.RANDOM;

public class Addition : MonoBehaviour {


    public Text txt;

    int[] numbersAvailable = new int[10];
    Random rnd = new Random();
    int targetValue;

    // Use this for initialization
    void Start () {
        targetValue = rnd.Next(1, 10);
        txt.text = targetValue.ToString();
        //generating 3 numbers
        for (int i; i<numbersAvailable.Length;i++)
        {
            rnd.Next();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
