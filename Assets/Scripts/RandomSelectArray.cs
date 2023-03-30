using UnityEngine;

public class RandomSelectArray : MonoBehaviour
{
    public int Region = 0;
    public GameObject[] Regions; // Declare an array of GameObjects to store the regions

    // Start is called before the first frame update
    public void RollRandom()
    {
        // Deactivate all regions
        for (int i = 0; i < Regions.Length; i++)
        {
            Regions[i].SetActive(false);
        }

        Region = Random.Range(0, Regions.Length); // Generate a random number between 0 and the number of regions

        Regions[Region].SetActive(true); // Activate the chosen region
    }
}