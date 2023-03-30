using UnityEngine;

public class ListManager : MonoBehaviour
{
    private int m_IndexNumber;

    private void Start()
    {
        m_IndexNumber = 9;
    }

    private void Update()
    {
        transform.SetSiblingIndex(m_IndexNumber);

        if (m_IndexNumber <= transform.GetSiblingIndex())
        {
            m_IndexNumber = Random.Range(0, 9);
        }
    }
}