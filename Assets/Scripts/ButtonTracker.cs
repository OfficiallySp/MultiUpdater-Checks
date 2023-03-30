using UnityEngine;
using UnityEngine.UI;

public class ButtonTracker : MonoBehaviour
{
    public int buttonclicked;
    public Text stattext;

    // Start is called before the first frame update
    public void ButtonClick()
    {
        buttonclicked++;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        stattext.text = buttonclicked.ToString() + "X ";
    }
}