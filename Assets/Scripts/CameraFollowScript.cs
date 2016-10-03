using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour
{
    public GameObject target;
    Vector3 position;

    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        position.y = target.transform.position.y;
        transform.position = position;
    }
}