using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour
{
    GameObject target;
    Vector3 position;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        position = transform.position;
    }

    void Update()
    {
        position.y = target.transform.position.y + 0.5f;
        transform.position = position;
    }
}