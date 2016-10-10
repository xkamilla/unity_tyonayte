using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    Camera camera1; //Main camera
    Camera camera2; //Bigger view -camera
    Camera camera3; //Winner camera

    void Start ()
    {
        camera1 = GameObject.Find("Main Camera").GetComponent<Camera>();
        camera2 = GameObject.Find("Help Camera").GetComponent<Camera>();
        camera3 = GameObject.Find("Win Camera").GetComponent<Camera>();

        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }

    public void Winning()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = true;
    }
}
