using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class AppManager : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;
    public GameObject Menu3;
    public VideoPlayer Video;
    public int LockByDefault;
    public int LaneByDefault;
    public GameObject Lock0;
    public GameObject Lock1;
    public GameObject Lock2;
    public GameObject Lock3;
    public GameObject Lock4;
    public GameObject Lock5;
    public GameObject Lock6;
    public GameObject Lock7;
    public GameObject Lock8;
    public GameObject Lock9;
    public GameObject Lock10;
    public GameObject Lane0;
    public GameObject Lane1;
    public GameObject Lane2;
    public GameObject Lane3;
    private void Start()
    {
        Application.backgroundLoadingPriority = ThreadPriority.Low;
        Application.targetFrameRate = 40;
        Resources.UnloadUnusedAssets();
        LockByDefault = PlayerPrefs.GetInt("LockStatus");
        LaneByDefault = PlayerPrefs.GetInt("LaneStatus");
        {
            if (LockByDefault == 1)
            {
                Lock0.SetActive(false);
                Lock1.SetActive(false);
                Lock2.SetActive(true);
                Lock3.SetActive(true);
                Lock4.SetActive(true);
                Lock5.SetActive(true);
                Lock6.SetActive(true);
                Lock7.SetActive(true);
                Lock8.SetActive(true);
                Lock9.SetActive(true);
                Lock10.SetActive(false);
            }
            if (LaneByDefault == 1)
            {
                Lane0.SetActive(false);
                Lane1.SetActive(false);
                Lane2.SetActive(false);
                Lane3.SetActive(true);
            }
        }
    }
    //public void OnApplicationFocus()
    //{
    //    if (Application.isFocused == false)
    //    {
    //        Resources.UnloadUnusedAssets();
    //        Video.Pause();
    //        Menu1.SetActive(false);
    //        Menu2.SetActive(false);
    //        Menu3.SetActive(false);
    //    }
    //    else
    //    {
    //        Video.Play();
    //        Menu1.SetActive(true);
    //        Menu2.SetActive(true);
    //        Menu3.SetActive(true);
    //    }
    //}

    public void NameSelect()
    {
        _ = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

    public void OpenDiscord()
    {
        Application.OpenURL("https://www.discord.com/invite/5ENk5F8YsH");
    }

    public void OpenTwitch()
    {
        Application.OpenURL("https://twitch.tv/bigcheesegames");
    }
    public void LockDefault()
    {

    }
}