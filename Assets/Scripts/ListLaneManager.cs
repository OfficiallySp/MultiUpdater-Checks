using UnityEngine;

public class ListLaneManager : MonoBehaviour
{
    private int m_IndexNumber;

    private void Start()
    {
        m_IndexNumber = 4;
    }

    private void Update()
    {
        transform.SetSiblingIndex(m_IndexNumber);

        if (m_IndexNumber <= transform.GetSiblingIndex())
        {
            m_IndexNumber = Random.Range(0, 4);
        }
    }
}