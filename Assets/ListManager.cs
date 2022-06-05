//This script demonstrates how to return (GetSiblingIndex) and change (SetSiblingIndex) the sibling index of a GameObject.
//Attach this script to the GameObject you would like to change the sibling index of.
//To see this in action, make this GameObject the child of another GameObject, and create siblings for it.

using System.Collections;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    //Use this to change the hierarchy of the GameObject siblings
    int m_IndexNumber;

    void Start()
    {
        //Initialise the Sibling Index to 0
        m_IndexNumber = 9;
        //Set the Sibling Index
        //Output the Sibling Index to the console
        Debug.Log("Sibling Index : " + transform.GetSiblingIndex());
    }

    void Update()
    {
        transform.SetSiblingIndex(m_IndexNumber);
        Debug.Log("Sibling Index : " + transform.GetSiblingIndex());

        if (m_IndexNumber <= transform.GetSiblingIndex())
        {
            m_IndexNumber = Random.Range(0, 9);
        }
    }
}