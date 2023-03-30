using UnityEngine;
using UnityEngine.UI;

public class CustomTrackerPersist : MonoBehaviour
{
    public int customclicked;
    public Text stattext;

    // Start is called before the first frame update
    private void Start()
    {
        customclicked = PlayerPrefs.GetInt("customclicked");
    }

    public void ButtonClick()
    {
        customclicked++;
        PlayerPrefs.SetInt("customclicked", customclicked);
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        stattext.text = customclicked.ToString() + "X ";
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("customclicked", customclicked);
    }
}