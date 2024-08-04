using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Screenshot : MonoBehaviour
{

   // public GameObject noiseObject;
    public GameObject uiObject;
    public GameObject captureObject;
  
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = captureObject.GetComponent<Button>();
        btn.onClick.AddListener(Capture);
    }

    public void Capture() {
        uiObject.SetActive(false);
        //print(Time.time);
        string screenshot_name = "Noise Texture " + Time.time + " " + count + ".png";
        ScreenCapture.CaptureScreenshot(screenshot_name, 4);
        print("Saved Screenshoot: " + screenshot_name);
        count++;
       // uiObject.SetActive(true);


    }


}
