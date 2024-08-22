using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PersistTimer : MonoBehaviour
{
    public int playtime;
    public int seconds = 0;
    public int minutes = 0;
    public int hours = 0;
    public int days = 0;
    public Text timertext;

    private void Start()
    {
        playtime = PlayerPrefs.GetInt("playtime");
        _ = StartCoroutine(nameof(Playtimer));
    }

    private IEnumerator Playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = playtime % 60;
            minutes = (playtime / 60) % 60;
            hours = (playtime / 3600) % 24;
            days = (playtime / 86400) % 365;
        }
    }

    private void LateUpdate()
    {
        timertext.text = days.ToString() + "D " + hours.ToString() + "H " + minutes.ToString() + "M " + seconds.ToString() + "S ";
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("playtime", playtime);
    }
}