using UnityEngine;
using UnityEngine.UI;

public class CustomSkinTracker : MonoBehaviour
{
    public int skinclicked;
    public Text stattext;

    // Start is called before the first frame update
    public void ButtonClick()
    {
        skinclicked++;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        stattext.text = skinclicked.ToString() + "X ";
    }
}