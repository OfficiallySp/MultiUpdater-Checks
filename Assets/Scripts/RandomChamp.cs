using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class RandomChamp : MonoBehaviour
{
    // URL of the JSON file
    public string jsonFileUrl;

    // Dictionary to store champion data
    public Dictionary<string, ChampionData> championData;

    // Reference to a Text component to display the name
    public Text displayText;
    // Reference to an Image component to display the image
    public Image displayImage;

    // Champion data classes
    [System.Serializable]
    public class ChampionDataWrapper
    {
        public string type;
        public string format;
        public string version;
        public Dictionary<string, ChampionData> data;
    }

    [System.Serializable]
    public class ChampionData
    {
        public string version;
        public string id;
        public string key;
        public string name;
        public string title;
        public string blurb;
        public ChampionImage image;
    }

    [System.Serializable]
    public class ChampionImage
    {
        public string full;
        public string sprite;
        public string group;
        public int x;
        public int y;
        public int w;
        public int h;
    }

    public void PickChamp()
    {
        StartCoroutine(LoadChampionsFromJson());
    }

    IEnumerator LoadChampionsFromJson()
    {
        using (UnityWebRequest www = UnityWebRequest.Get(jsonFileUrl))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Failed to load JSON: " + www.error);
            }
            else
            {
                ChampionDataWrapper championDataWrapper = JsonConvert.DeserializeObject<ChampionDataWrapper>(www.downloadHandler.text);
                championData = championDataWrapper.data;
                ShowRandomChampion();
            }
        }
    }

    // Function to show a random champion and image
    public void ShowRandomChampion()
    {
        // Pick a random champion from the dictionary
        ChampionData randomChampionData = GetRandomChampion();

        // Display the champion name
        displayText.text = randomChampionData.name;

        // Load and display the image for the champion
        StartCoroutine(LoadImageFromUrl("https://ddragon.leagueoflegends.com/cdn/13.5.1/img/champion/" + randomChampionData.image.full));
    }

    private ChampionData GetRandomChampion()
    {
        List<string> championKeys = new List<string>(championData.Keys);
        int randomIndex = Random.Range(0, championKeys.Count);
        return championData[championKeys[randomIndex]];
    }

    // Coroutine to load an image from a URL
    IEnumerator LoadImageFromUrl(string imageUrl)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(imageUrl);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.LogError("Failed to load image: " + www.error);
        }
        else
        {
            Texture2D texture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            displayImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        }
    }
}
