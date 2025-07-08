using UnityEngine;

public class ArrangementSelector : MonoBehaviour
{
    public Flower selectedGroup1Flower;
    public Flower selectedGroup2Flower;
    public Flower selectedGroup3Flower;

    public Vase selectedVase;
    public Accent selectedAccent;

    // Call this when player picks a flower
    public void SelectFlower(Flower flower, int groupNumber)
    {
        switch (groupNumber)
        {
            case 1: selectedGroup1Flower = flower; break;
            case 2: selectedGroup2Flower = flower; break;
            case 3: selectedGroup3Flower = flower; break;
        }
    }

    public void SelectVase(Vase vase)
    {
        selectedVase = vase;
    }

    public void SelectAccent(Accent accent)
    {
        selectedAccent = accent;
    }

    public bool IsSelectionComplete()
    {
        return (selectedGroup1Flower || selectedGroup2Flower || selectedGroup3Flower)
               && selectedVase != null && selectedAccent != null;
    }

    public void SubmitArrangement()
    {
        if (!IsSelectionComplete())
        {
            Debug.Log("Selection is incomplete!");
            return;
        }

        ArrangementScorer.Instance.ScoreArrangement(this);
    }
}
