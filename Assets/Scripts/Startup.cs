using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Startup : MonoBehaviour
{
    public string versionurl = "";
    public string currentver;
    public string latestver;
    public GameObject Update;

    public string Date;
    public string DateLong;
    public int CurrTime;

    // Start is called before the first frame update
    private void Start()
    {
        Application.backgroundLoadingPriority = ThreadPriority.Low;
        Resources.UnloadUnusedAssets();
        Application.targetFrameRate = 40;
        StartCoroutine(LoadtxtData(versionurl));
        Date = DateTime.Now.ToShortDateString();
        DateLong = DateTime.Now.ToLongDateString();
        CurrTime = DateTime.Now.Hour;
    }
    IEnumerator LoadtxtData(string url)
    {
        UnityWebRequest loaded = new UnityWebRequest(url);
        loaded.downloadHandler = new DownloadHandlerBuffer();
        yield return loaded.SendWebRequest();

        latestver = loaded.downloadHandler.text;
    }
    private void CheckVersion()
    {
        Debug.Log("Version = " + currentver);
        Debug.Log("Latest = " + latestver);

        Version versionLocal = new Version(currentver);
        Version versionremote = new Version(latestver);
        int result = versionLocal.CompareTo(versionremote);

        if ((latestver != "") && result < 0)
        {
            Update.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void UpdateApp()
    {
        Application.Quit();
    }
    public void CancelUpdate()
    {
        Update.SetActive(false);
        SceneManager.LoadScene("League");
    }
}