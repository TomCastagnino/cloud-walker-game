using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour {

    [Range(0f,2f)]
    public float cloudVelocity = 0.02f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveClouds();
	}

    void MoveClouds()
    {
        Vector3 temp = gameObject.transform.position;
        temp.y += cloudVelocity;
        gameObject.transform.position = temp;
    }
}
