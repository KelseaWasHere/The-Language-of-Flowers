using UnityEngine;

public class ArrangementScorer : MonoBehaviour
{
    public static ArrangementScorer Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ScoreArrangement(ArrangementSelector selection)
    {
        CustomerRequest request = FindObjectOfType<CustomerRequestGenerator>().GetRandomRequest();
        int score = 0;

        // Flower Matching
        Flower[] flowers = new Flower[] {
            selection.selectedGroup1Flower,
            selection.selectedGroup2Flower,
            selection.selectedGroup3Flower
        };

        foreach (var flower in flowers)
        {
            if (flower == null) continue;

            if (request.preferredColors.Contains(flower.color)) score++;
            if (request.preferredTypes.Contains(flower.meaning1)) score++;
            if (request.preferredTypes.Contains(flower.meaning2)) score++;
        }

        // Vase Matching
        if (request.preferredColors.Contains(selection.selectedVase.color)) score++;
        if (request.preferredTypes.Contains(selection.selectedVase.mainType)) score++;
        if (request.vibes.Contains(selection.selectedVase.secondaryType)) score++;

        // Accent Matching
        if (request.preferredColors.Contains(selection.selectedAccent.color)) score++;
        if (request.preferredTypes.Contains(selection.selectedAccent.mainType)) score++;
        if (request.vibes.Contains(selection.selectedAccent.secondaryType)) score++;

        Debug.Log("Arrangement Score: " + score);
        if (score >= 6)
        {
            Debug.Log("Customer LOVED it!");
        }
        else if (score >= 3)
        {
            Debug.Log("Customer thought it was OK.");
        }
        else
        {
            Debug.Log("Customer HATED it.");
        }

    }
}
