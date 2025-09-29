using UnityEngine;

public class TagPrinter : MonoBehaviour
{
    private void Awake()
    {
        PrintAllTags();
    }

    private void PrintAllTags()
    {
        var objects = FindObjectsByType<GameObject>(FindObjectsSortMode.None);
        foreach (var obj in objects)
        {
            if (!string.IsNullOrEmpty(obj.tag) && !obj.CompareTag("Untagged"))
            {
                Debug.Log($"Found object with name '{obj.name}' and tag '{obj.tag}' at position {obj.transform.position}");
            }
        }
    }
}
