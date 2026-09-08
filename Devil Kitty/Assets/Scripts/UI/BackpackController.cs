using System.Collections.Generic;
using UnityEngine;

public class BackpackController : MonoBehaviour
{
    [SerializeField] GameObject itemObject;
    private List<int> createdItems = new List<int>();

    [Header("References")]
    [SerializeField] ItemManager itemManager;
    [SerializeField] PlayerInventory inv;
    [SerializeField] Transform backpackPanel;
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
            Vector3 itemPosition;
            if (createdItems.Contains(item))
            {

            }
            else
            {
                switch (createdItems.Count)
                {
                    // DEFINE ITEM POSITION IN BACKPACK
                    case 0:
                        itemPosition = new Vector3(-200,115,0);
                        break;
                    case 1:
                        itemPosition = new Vector3(0, 115, 0);
                        break;
                    case 2:
                        itemPosition = new Vector3(200, 115, 0);
                        break;
                    case 3:
                        itemPosition = new Vector3(-200, 0, 0);
                        break;
                    case 4:
                        itemPosition = new Vector3(0, 0, 0);
                        break;
                    case 5:
                        itemPosition = new Vector3(200, 0, 0);
                        break;
                    case 6:
                        itemPosition = new Vector3(-200, -115, 0);
                        break;
                    case 7:
                        itemPosition = new Vector3(0, -115, 0);
                        break;
                    case 8:
                        itemPosition = new Vector3(200, -115, 0);
                        break;
                    default:
                        itemPosition = new Vector3(0,0,0);
                        break;
                }
                createdItems.Add(item);
                GameObject createdItem = Instantiate(itemObject, itemPosition, new Quaternion(0, 0, 0, 1), backpackPanel);
                createdItem.transform.localPosition = itemPosition;
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
