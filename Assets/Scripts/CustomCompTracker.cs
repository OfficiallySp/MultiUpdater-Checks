using UnityEngine;
using UnityEngine.UI;

public class CustomCompTracker : MonoBehaviour
{
    public int compclicked;
    public Text stattext;

    // Start is called before the first frame update
    public void ButtonClick()
    {
        compclicked++;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        stattext.text = compclicked.ToString() + "X ";
    }
}