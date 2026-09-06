using System.Collections.Generic;
using UnityEngine;

public class BackpackController : MonoBehaviour
{
    [SerializeField] GameObject itemObject;
    private List<int> createdItems = new List<int>();

    [Header("References")]
    [SerializeField] ItemManager itemManager;
    [SerializeField] PlayerInventory inv;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenBackpack()
    {
        foreach (int item in inv.inventoryTags)
        {
            if (createdItems.Contains(item))
            {

            }
            else
            {
                createdItems.Add(item);
                switch (createdItems.Count)
                {
                    // DEFINE ITEM POSITION IN BACKPACK
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                }
                GameObject createdItem = Instantiate(itemObject);
                BackpackItem backpackItem = createdItem.GetComponent<BackpackItem>();

                backpackItem.itemTag = item;
                switch (item)
                {
                    case 1:
                        backpackItem.itemImage = itemManager.item1Sprite;
                        break;
                    case 2:
                        backpackItem.itemImage = itemManager.item2Sprite;
                        break;
                    case 3:
                        backpackItem.itemImage = itemManager.item3Sprite;
                        break;
                    case 4:
                        backpackItem.itemImage = itemManager.item4Sprite;
                        break;
                    case 5:
                        backpackItem.itemImage = itemManager.item5Sprite;
                        break;
                }
            }
        }
    }
}
