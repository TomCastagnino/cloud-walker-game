using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButtons : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

    [SerializeField]
    private bool isLeftMouseClicked, isRightMouseClicked;
    private PlayerScript player;

	// Use this for initialization
	void Awake () {
        player = GameObject.Find("Player").GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isLeftMouseClicked)
        {
            player.MoveToTheLeft();
        }
        else if (isRightMouseClicked)
        {
            player.MoveToTheRight();
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        if (gameObject.name == "Left Button")
        {
            isLeftMouseClicked = true;
        }
        else if(gameObject.name == "Right Button")
        {
            isRightMouseClicked = true;
        }
    }

    public void OnPointerUp(PointerEventData data)
    {
        isLeftMouseClicked = false;
        isRightMouseClicked = false;
        player.StopMoving();
    }

}

/*
public void RightKey()
{
    if (Input.GetKey("right"))
    {
        isRightKeyPressed = true;
    }
    else
    {
        isRightKeyPressed = false;
    }
}

public void LeftKey()
{
    if (Input.GetKey("left"))
    {
        isLeftKeyPressed = true;
    }
    else
    {
        isLeftKeyPressed = false;
    }
}

if ((!isLeftKeyPressed) & (!isLeftMouseClicked) & (!isRightKeyPressed) & (!isRightMouseClicked))
{
   player.StopMoving();
}
*/
