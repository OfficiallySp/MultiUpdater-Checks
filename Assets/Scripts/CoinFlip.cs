using UnityEngine;

public class CoinFlip : MonoBehaviour
{
    public GameObject Heads;
    public GameObject Tails;

    private void Update()
    {
        int coinState = Random.Range(0, 2);
        if (coinState == 0)
        {
            Heads.SetActive(true);
            Tails.SetActive(false);
        }
        else
        {
            Tails.SetActive(true);
            Heads.SetActive(false);
        }
    }
}