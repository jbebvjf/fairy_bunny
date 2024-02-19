using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrin : MonoBehaviour
{
    void Start()
    {
        ScreenCapture.CaptureScreenshot("Scene.png");
    }
}
