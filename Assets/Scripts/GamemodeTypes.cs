using UnityEngine;
using UnityEngine.UI;

public class GamemodeTypes : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject[] gameObjects;

    private void Start()
    {
        dropdown.onValueChanged.AddListener(ShowSelectedGameObject);
    }

    private void ShowSelectedGameObject(int index)
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if (i == index)
            {
                gameObjects[i].SetActive(true);
            }
            else
            {
                gameObjects[i].SetActive(false);
            }
        }
    }
}