using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

    public bool allowMoving;
    public float speed;
    public float force;

    private bool isMoving;
    private bool isJumping;

    Rigidbody rb;
    Animator animator;

    void Start ()
    {
        allowMoving = true;
        speed = 2.0f;
        force = 300.0f;

        isMoving = false;
        isJumping = false;

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        animator.SetBool("moving", isMoving);
        animator.SetBool("jumping", isJumping);

        //Moving the player
        if (allowMoving)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 90, 0);
                isMoving = true;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 270, 0);
                isMoving = true;
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                isMoving = false;
            }
            if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
            {
                rb.AddForce(Vector3.up * force);
            }
        }
        else
        {
            isMoving = false;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        isJumping = false;
    }
    void OnCollisionExit(Collision other)
    {
        isJumping = true;
    }
}
