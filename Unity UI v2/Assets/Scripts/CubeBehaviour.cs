using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour {
    float temp = 1;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector2(getX(),getY());
        transform.Rotate(0, 0, getRot(), Space.World);

    }

    public float getX()
    {
        //just for testing purposes
        if (Input.GetMouseButtonDown(0))
            temp = Input.mousePosition.x;

        return temp;
    }

    public float getY()
    {
        //just for testing purposes
        if (Input.GetMouseButtonDown(0))
            temp = Input.mousePosition.y;

        return temp;
    }

    public float getRot()
    {
        if (Input.GetMouseButtonDown(0))
            temp +=1;
        return 1;
    }



}
