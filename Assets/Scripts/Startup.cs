using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startup : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        Application.backgroundLoadingPriority = ThreadPriority.Low;
        Resources.UnloadUnusedAssets();
        Application.targetFrameRate = 40;
    }
    public void CancelUpdate()
    {
        SceneManager.LoadScene("League");
    }
}