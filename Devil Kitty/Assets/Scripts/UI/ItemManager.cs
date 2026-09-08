using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [Header("Item Object References")]
    [SerializeField] ItemController item1;
    [SerializeField] ItemController item2;
    [SerializeField] ItemController item3;

    [Header("Item Images")]
    public Sprite item1Sprite;
    public Sprite item2Sprite;
    public Sprite item3Sprite;
    public Sprite item4Sprite;
    public Sprite item5Sprite;
    public Sprite item6Sprite;
    public Sprite item7Sprite;

    [Header("Script References")]
    [SerializeField] PlayerInventory inv;
    [SerializeField] PlayerHealth hp;
    [SerializeField] GunController gun1;
    [SerializeField] GunController gun2;
    [SerializeField] GunController gun3;
    [SerializeField] BackpackController backpackController;

    [Header("Misc")]
    [SerializeField] List<int> passiveItemTags;
    [SerializeField] int itemQuantity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelUp()
    {
        backpackController.OpenBackpack();
        hp.health += 0.5f;
        if (inv.weaponCount >= 3)
        {
            List<int> itemTags = new List<int>
            {
                gun1.weaponType,
                gun2.weaponType,
                gun3.weaponType
            };
            foreach (int passiveItem in passiveItemTags)
            {
                itemTags.Add(passiveItem);
            }
            int random = Random.Range(0, itemTags.Count);
            item1.itemTag = itemTags[random];

            while (itemTags[random] == item1.itemTag)
            {
                random = Random.Range(0, itemTags.Count);
            }
            item2.itemTag = itemTags[random];

            while (itemTags[random] == item1.itemTag || itemTags[random] == item2.itemTag)
            {
                random = Random.Range(0, itemTags.Count);
            }
            item3.itemTag = itemTags[random];
        }
        else
        {
            int random = Random.Range(1, itemQuantity + 1);
            item1.itemTag = random;

            while (random == item1.itemTag)
            {
                random = Random.Range(1, itemQuantity + 1);
            }
            item2.itemTag = random;

            while (random == item1.itemTag || random == item2.itemTag)
            {
                random = Random.Range(1, itemQuantity + 1);
            }
            item3.itemTag = random;
        }

        switch (item1.itemTag)
        {
            case 1:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item1Sprite;
                break;
            case 2:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item2Sprite;
                break;
            case 3:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item3Sprite;
                break;
            case 4:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item4Sprite;
                break;
            case 5:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item5Sprite;
                break;
            case 6:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item6Sprite;
                break;
            case 7:
                item1.GetComponent<UnityEngine.UI.Image>().sprite = item7Sprite;
                break;
        }
        switch (item2.itemTag)
        {
            case 1:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item1Sprite;
                break;
            case 2:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item2Sprite;
                break;
            case 3:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item3Sprite;
                break;
            case 4:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item4Sprite;
                break;
            case 5:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item5Sprite;
                break;
            case 6:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item6Sprite;
                break;
            case 7:
                item2.GetComponent<UnityEngine.UI.Image>().sprite = item7Sprite;
                break;
        }
        switch (item3.itemTag)
        {
            case 1:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item1Sprite;
                break;
            case 2:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item2Sprite;
                break;
            case 3:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item3Sprite;
                break;
            case 4:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item4Sprite;
                break;
            case 5:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item5Sprite;
                break;
            case 6:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item6Sprite;
                break;
            case 7:
                item3.GetComponent<UnityEngine.UI.Image>().sprite = item7Sprite;
                break;
        }
    }
}
