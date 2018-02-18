using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundController : MonoBehaviour {

    [SerializeField]
    private RawImage background;
    [SerializeField]//[Range(0f, 0.7f)]
    private float speed = 1f;
    private float acceleration = 0.02f;
    private float maxSpeed = 2f;
    private float easySpeed = 3.2f;
    private float mediumSpeed = 3.7f;
    private float hardSpeed = 4.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBackground();
	}

    private void MoveBackground()
    {
        float finalSpeed = speed * Time.deltaTime;
        speed += acceleration * Time.deltaTime;
        Rect temp = background.uvRect;
        float oldY = temp.y;
        float newY = oldY - (speed * Time.deltaTime);
        background.uvRect = new Rect(0f, newY - finalSpeed, 1f, 1f);
        if (speed > maxSpeed)
        {
            speed = maxSpeed;
        }
    }

}
