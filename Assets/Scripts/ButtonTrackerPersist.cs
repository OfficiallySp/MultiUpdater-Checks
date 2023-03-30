using UnityEngine;
using UnityEngine.UI;

public class ButtonTrackerPersist : MonoBehaviour
{
    public int buttonclicked;
    public Text stattext;

    // Start is called before the first frame update
    private void Start()
    {
        buttonclicked = PlayerPrefs.GetInt("buttonclicked");
    }

    public void ButtonClick()
    {
        buttonclicked++;
        PlayerPrefs.SetInt("buttonclicked", buttonclicked);
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        stattext.text = buttonclicked.ToString() + "X ";
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("buttonclicked", buttonclicked);
    }
}