using System;
using UnityEngine;
using UnityEngine.Video;

public class VideoPicker : MonoBehaviour
{
    VideoPlayer Player;
    public VideoClip[] VideoBank;
    int CurrentVideo;
    public string Date;

    private void Awake()
    {
        Player = GetComponent<VideoPlayer>();
        VideoBank = Resources.LoadAll<VideoClip>("Video");
    }

    void Start()
    {
        DateTime currentDate = DateTime.Now.Date;
        DayOfWeek currentDay = currentDate.DayOfWeek;

        if (currentDay == DayOfWeek.Saturday || currentDay == DayOfWeek.Sunday)
        {
            DateTime startDate = new DateTime(2022, 10, 9);

            // Calculate the number of weeks passed since the start date
            int weeksPassed = (currentDate - startDate).Days / 7;

            // Calculate the CurrentVideo index using the modulo operator
            CurrentVideo = weeksPassed % VideoBank.Length;

            // Set the Player's clip to this video and play it
            Player.clip = VideoBank[CurrentVideo];
            Player.Play();
        }
    }
}
