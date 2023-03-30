using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defaults : MonoBehaviour
{
    // Start is called before the first frame update

    public void LockToggle()
    {
        PlayerPrefs.SetInt("LockStatus", 1);
    }
    public void LockUnToggle()
    {
        PlayerPrefs.SetInt("LockStatus", 0);
    }
    public void LaneToggle()
    {
        PlayerPrefs.SetInt("LaneStatus", 1);
    }
    public void LaneUnToggle()
    {
        PlayerPrefs.SetInt("LaneStatus", 0);
    }
}
