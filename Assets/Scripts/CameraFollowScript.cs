using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour
{
    public GameObject target;
    Vector3 position;
    bool targetAcquired;

    void Start()
    {
        position = transform.position;
        targetAcquired = false;
    }

    void Update()
    {
        if (GameObject.FindWithTag("Player") != null && !targetAcquired)
        {
            target = GameObject.FindWithTag("Player");
            targetAcquired = true;
        }
        position.y = target.transform.position.y + 0.5f;
        transform.position = position;
    }
}