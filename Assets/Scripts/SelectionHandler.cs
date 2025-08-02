using UnityEngine;

public class SelectionHandler : MonoBehaviour
{
    public BouquetManager bouquetManager;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left-click
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                GameObject selected = hit.collider.gameObject;
                string tag = selected.tag;

                if (tag.StartsWith("Group"))
                {
                    switch (tag)
                    {
                        case "Group1":
                            bouquetManager.SetFlower(1, selected.GetComponent<Flower>());
                            break;
                        case "Group2":
                            bouquetManager.SetFlower(2, selected.GetComponent<Flower>());
                            break;
                        case "Group3":
                            bouquetManager.SetFlower(3, selected.GetComponent<Flower>());
                            break;
                        case "Group4":
                            bouquetManager.SetVase(selected.GetComponent<Vase>());
                            break;
                        case "Group5":
                            bouquetManager.SetAccent(selected.GetComponent<Accent>());
                            break;
                    }
                }
            }
        }
    }
}
