using UnityEngine;
using System.Collections;

public class WinStarScript : MonoBehaviour {

    GameObject mainLight;
    GameObject spotLight;

    GameObject playerObject;
    private CameraScript cs;
    private PlayerScript ps;

    public GameObject confettiPrefab;

    void Start()
    {
        mainLight = GameObject.Find("Main Light");
        spotLight = GameObject.Find("Spotlight");

        spotLight.SetActive(false);

        playerObject = GameObject.FindWithTag("Player");
        cs = playerObject.GetComponent<CameraScript>();
        ps = playerObject.GetComponent<PlayerScript>();
    }

    void OnTriggerEnter()
    {
        mainLight.SetActive(false);
        spotLight.SetActive(true);
        ps.allowMoving = false;

        cs.Winning();
        Instantiate(confettiPrefab, new Vector3(playerObject.transform.position.x, playerObject.transform.position.y + 2, playerObject.transform.position.z), Quaternion.identity);
    }
}
