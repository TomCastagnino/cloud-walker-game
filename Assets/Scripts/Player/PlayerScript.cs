using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    [SerializeField]
    private float speed = 8f, maxVelocity = 4f;
    [SerializeField]
    private Rigidbody2D myBody;
    [SerializeField]
    private Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {

	}

    public void MoveToTheLeft()
    {
        float vel = Mathf.Abs(myBody.velocity.x);
        if (vel < maxVelocity)
        {
            myBody.AddForce(new Vector2(-speed, 0));
        }
        transform.localScale = new Vector3(-0.3f, 0.3f, 0f);
        anim.SetBool("walk", true);
    }

    public void MoveToTheRight()
    {
        float vel = Mathf.Abs(myBody.velocity.x);
        if (vel < maxVelocity)
        {
            myBody.AddForce(new Vector2(speed, 0));
        }
        anim.SetBool("walk", true);
        //Girar al personaje
        transform.localScale = new Vector3(0.3f, 0.3f, 0f);
    }

    public void StopMoving()
    {
        anim.SetBool("walk", false);
    }

}
