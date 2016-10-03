using UnityEngine;
using System.Collections;

public class MovingPlatformScript : MonoBehaviour {

    //Variables that specify how the platforms move
    public bool vertical;
    public bool goingUpOrRight;
    public float speed;

    private float platformTimer;

	void Start ()
    {
        speed = 1.0f;
        platformTimer = 0.0f;
	}
	
	void Update ()
    {
        platformTimer += Time.deltaTime;

        if (vertical)
        {
            if (goingUpOrRight)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            else if (!goingUpOrRight)
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
            }
        }
        else
        {
            if (goingUpOrRight)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }
            else if (!goingUpOrRight)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
        }
        //Changing direction
        if (platformTimer >= 3.0f)
        {
            goingUpOrRight = !goingUpOrRight;
            platformTimer = 0.0f;
        }
    }
}
