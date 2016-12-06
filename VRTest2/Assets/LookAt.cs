using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {
    public Transform target;
    public float x = 0;
    public float y = 0;
    public float z = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null)
        {
            transform.LookAt(new Vector3(x,y,z));
        }
        else
        {
            transform.LookAt(target);
        }
	}
}
