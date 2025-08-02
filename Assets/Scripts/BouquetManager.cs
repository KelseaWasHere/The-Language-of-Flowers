using UnityEngine;

public class BouquetManager : MonoBehaviour
{
    public Flower flower1;
    public Flower flower2;
    public Flower flower3;
    public Vase vase;
    public Accent accent;

    public void SetFlower(int groupIndex, Flower flower)
    {
        switch (groupIndex)
        {
            case 1:
                flower1 = flower;
                break;
            case 2:
                flower2 = flower;
                break;
            case 3:
                flower3 = flower;
                break;
        }
    }

    public void SetVase(Vase selectedVase)
    {
        vase = selectedVase;
    }

    public void SetAccent(Accent selectedAccent)
    {
        accent = selectedAccent;
    }

    public bool IsBouquetComplete()
    {
        return flower1 != null && flower2 != null && flower3 != null &&
               vase != null && accent != null;
    }

    public void TryPrintBouquetInfo()
    {
        if (!IsBouquetComplete())
        {
            Debug.LogWarning("Cannot display bouquet info: selections are incomplete.");
            return;
        }

        Debug.Log($"Flower 1: {flower1.flowerName}, {flower1.color}, {flower1.meaning1}/{flower1.meaning2}");
        Debug.Log($"Flower 2: {flower2.flowerName}, {flower2.color}, {flower2.meaning1}/{flower2.meaning2}");
        Debug.Log($"Flower 3: {flower3.flowerName}, {flower3.color}, {flower3.meaning1}/{flower3.meaning2}");
        Debug.Log($"Vase: {vase.vaseName}, {vase.color}, {vase.mainType}/{vase.secondaryType}");
        Debug.Log($"Accent: {accent.accentName}, {accent.color}, {accent.mainType}/{accent.secondaryType}");
    }

    public void ClearBouquet()
    {
        flower1 = null;
        flower2 = null;
        flower3 = null;
        vase = null;
        accent = null;

        Debug.Log("Bouquet has been cleared.");
    }
}
