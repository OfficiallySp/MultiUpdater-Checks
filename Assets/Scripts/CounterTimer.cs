using UnityEngine;
using UnityEngine.UI;

public class CounterTimer : MonoBehaviour
{
    public Text timerText;
    public float daycount;
    public float hourcount;
    public float minuteCount;
    public float secondsCount;
    public float millisecondsCount;
    public bool Stop = false;

    private void Update()
    {
        if (Stop == true)
        {
            return;
        }

        if (Stop == false)
        {
            UpdateTimerUI();
        }
    }

    public void UpdateTimerUI()
    {
        millisecondsCount += Time.deltaTime * 1000;
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}", daycount, hourcount, minuteCount, secondsCount);

        if (millisecondsCount >= 999)
        {
            millisecondsCount = 000;
            secondsCount++;
        }
        else if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourcount++;
            minuteCount = 0;
        }
        else if (hourcount >= 24)
        {
            daycount++;
            hourcount = 0;
        }
    }

    public void Endtimer()
    {
        Stop = true;
    }

    public void Resettimer()
    {
        Stop = false;
        millisecondsCount = 000;
        secondsCount = 0;
        minuteCount = 0;
        hourcount = 0;
    }
}