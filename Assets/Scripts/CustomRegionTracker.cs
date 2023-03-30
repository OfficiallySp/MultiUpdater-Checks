using UnityEngine;
using UnityEngine.UI;

public class CustomRegionTracker : MonoBehaviour
{
    public int regionclicked;
    public Text stattext;

    // Start is called before the first frame update
    public void ButtonClick()
    {
        regionclicked++;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        stattext.text = regionclicked.ToString() + "X ";
    }
}