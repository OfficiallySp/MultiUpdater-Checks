using System.Linq;
using UnityEngine;

public class FisherYatesShuffle : MonoBehaviour
{
    public void ShuffleSiblings()
    {
        var siblings = GetComponentsInChildren<Transform>().ToList();
        siblings.RemoveAt(0); // Remove the parent object from the list
        int n = siblings.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            var value = siblings[k];
            siblings[k] = siblings[n];
            siblings[n] = value;
        }
        siblings.ForEach(sibling => sibling.SetSiblingIndex(siblings.IndexOf(sibling)));
    }
}