using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

    private float guideTimer;
    private bool showGuide;
    private string guideText;

    void Start()
    {
        guideTimer = 0.0f;
        showGuide = true;
    }

    void Update()
    {
        if(showGuide)
            guideTimer += Time.deltaTime;
    }

    void OnGUI()
    {
        if (guideTimer < 8.0f)
        {
            guideText = "Climb to the top of the platforms!";
        }
        else if(guideTimer >= 8.0f && guideTimer < 17.0f)
        {
            guideText = "Press 'C' for bigger viewpoint.";
        }
        else
        {
            showGuide = false;
        }

        if (showGuide)
        {
            GUI.Label(new Rect(10, 10, 200, 20), guideText);
        }
    }
}
