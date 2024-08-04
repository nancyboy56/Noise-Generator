using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shortcuts : MonoBehaviour
{

    public GameObject uIObject;
    public int count;
    public int resolution = 10;
    public string screenshotName = "Noise Texture";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space key was pressed. screenshot time.");
            Capture();

        } else if (Input.GetKeyDown("z")) {
            UIToggle();
        }
    }

    private void UIToggle()
    {
        if (uIObject.activeSelf)
        {
            uIObject.SetActive(false);
        }
        else
        {
            uIObject.SetActive(true);
        }

    }

    private void Capture()
    {
        //string screenshot_name = screenshotName + DateTime.Now.ToString("dd-MM-yyyy HH_mm.ss") + " " + count + ".png";

        string screenshot_name = screenshotName + Time.time + ".png";
        ScreenCapture.CaptureScreenshot(screenshot_name, resolution);
        print("Saved Screenshot: " + screenshot_name);
        count++;

        Debug.Log("Saving!");
    }
}
