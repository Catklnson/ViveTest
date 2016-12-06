using UnityEngine;
using System.Collections;
using System;

public class Rotate : MonoBehaviour {
    public double startingDegree;
    double oneDegree = (2 * Math.PI)/360;
    public int radius;
    public double currentLocation = 0;
    public int speedModifier = 50000;
    public enum axis { xAxis,yAxis,zAxis};
    public axis rotationAxis;

	// Use this for initialization
	void Start () {
        currentLocation = (2 * Math.PI) * (startingDegree / 360);
	}
	
	// Update is called once per frame
	void Update () {
        RotateObject();
	}

    public void RotateObject()
    {
        currentLocation += oneDegree/speedModifier;
        if (currentLocation > 2*Math.PI)
        {
            currentLocation = 0;
        }
        float x = (float)(radius * Math.Cos(currentLocation));
        float y = (float)(radius * Math.Sin(currentLocation));
        switch (rotationAxis.ToString())
        {
            case "xAxis":
                this.transform.localPosition = new Vector3(0, x, y);
                break;
            case "yAxis":
                this.transform.localPosition = new Vector3(x, 0, y);
                break;
            case "zAxis":
                this.transform.localPosition = new Vector3(x, y, 0);
                break;
        }
    }
}
