using UnityEngine;

public class FlowerPicker : MonoBehaviour
{
    void OnMouseDown()
    {
        Flower flower = GetComponent<Flower>();
        ArrangementSelector selection = FindObjectOfType<ArrangementSelector>();

        int groupNumber = 0;
        switch (tag)
        {
            case "Group1": groupNumber = 1; break;
            case "Group2": groupNumber = 2; break;
            case "Group3": groupNumber = 3; break;
            default:
                Debug.LogWarning($"{name} has no valid group tag.");
                return;
        }

        selection.SelectFlower(flower, groupNumber);
        Debug.Log($"Selected {flower.flowerName} from Group {groupNumber}");
    }
}
