using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BackpackController : MonoBehaviour
{
    [SerializeField] GameObject itemObject;
    private List<int> createdItems = new List<int>();
    int itemCount;

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
        createdItems.Clear();
        foreach (Transform child in backpackPanel.transform)
        {
            Destroy(child.gameObject);
        }
        foreach (int item in inv.inventoryTags)
        {
            Vector3 itemPosition;

            if (!createdItems.Contains(item)) {
                
                switch (createdItems.Count)
                {
                    // DEFINE ITEM POSITION IN BACKPACK
                    case 0:
                        itemPosition = new Vector3(-200,125,0);
                        break;
                    case 1:
                        itemPosition = new Vector3(0, 125, 0);
                        break;
                    case 2:
                        itemPosition = new Vector3(200, 125, 0);
                        break;
                    case 3:
                        itemPosition = new Vector3(-200, -20, 0);
                        break;
                    case 4:
                        itemPosition = new Vector3(0, -20, 0);
                        break;
                    case 5:
                        itemPosition = new Vector3(200, -20, 0);
                        break;
                    case 6:
                        itemPosition = new Vector3(-200, -145, 0);
                        break;
                    case 7:
                        itemPosition = new Vector3(0, -145, 0);
                        break;
                    case 8:
                        itemPosition = new Vector3(200, -145, 0);
                        break;
                    default:
                        itemPosition = new Vector3(0,0,0);
                        break;
                }
                
                GameObject createdItem = Instantiate(itemObject, itemPosition, new Quaternion(0, 0, 0, 1), backpackPanel);
                createdItem.transform.localPosition = itemPosition;
                BackpackItem backpackItem = createdItem.GetComponent<BackpackItem>();
                backpackItem.itemTag = item;

                // GETS THE ITEM COUNT FROM INVENTORY
                itemCount = 0;
                foreach (int itemTaggy in inv.inventoryTags)
                {
                    if (itemTaggy == item)
                    {
                        ++itemCount;
                    }
                }
                backpackItem.itemQuantity = itemCount;
                

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
                    case 6:
                        backpackItem.itemImage = itemManager.item6Sprite;
                        break;
                    case 7:
                        backpackItem.itemImage = itemManager.item7Sprite;
                        break;
                }
                createdItems.Add(item);
            }
        }
    }
}
