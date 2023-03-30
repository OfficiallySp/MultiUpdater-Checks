using UnityEngine;
using UnityEngine.UI;

public class SpeedSlider : MonoBehaviour
{
    public Slider slider;
    public Text text;

    // Start is called before the first frame update

    // Update is called once per frame
    private void LateUpdate()
    {
        text.text = "SPEED = " + slider.value.ToString("F2") + "X";
    }
}