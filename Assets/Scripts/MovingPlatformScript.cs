using UnityEngine;
using System.Collections;

public class MovingPlatformScript : MonoBehaviour {

    public bool vertical;
    public bool goingUpOrRight;
    public float speed;

    float platformTimer;

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

        if (platformTimer >= 3.0f)
        {
            goingUpOrRight = !goingUpOrRight;
            platformTimer = 0.0f;
        }
    }
}
