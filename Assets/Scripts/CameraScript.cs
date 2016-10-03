using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public Camera camera1; //Main camera
    public Camera camera2; //Bigger view -camera
    public Camera camera3; //Winner camera

    void Start ()
    {
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
