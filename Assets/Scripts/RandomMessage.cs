using UnityEngine;

public class RandomMessage : MonoBehaviour
{
    public GameObject[] messages;

    // Start is called before the first frame update
    public void Randommessage()
    {
        // Deactivate all messages
        foreach (GameObject message in messages)
        {
            message.SetActive(false);
        }

        // Select a random message and activate it
        int randomIndex = Random.Range(0, messages.Length);
        messages[randomIndex].SetActive(true);
    }
}
