using UnityEngine;
using System.Collections;

public class WinStarScript : MonoBehaviour {

    public GameObject mainLight;
    public GameObject spotLight;

    GameObject playerObject;
    private CameraScript cs;
    private PlayerScript ps;

    public GameObject confettiPrefab;
    Vector3 confettiPosition;

    void Start()
    {
        spotLight.SetActive(false);

        playerObject = GameObject.Find("SkeletonPlayer");
        cs = playerObject.GetComponent<CameraScript>();
        ps = playerObject.GetComponent<PlayerScript>();

        confettiPosition = new Vector3(0, 16, 0);
    }

    void OnTriggerEnter()
    {
        mainLight.SetActive(false);
        spotLight.SetActive(true);
        ps.allowMoving = false;

        cs.Winning();
        Instantiate(confettiPrefab, confettiPosition, Quaternion.identity);
    }
}
