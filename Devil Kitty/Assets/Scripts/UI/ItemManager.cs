using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] ItemController item1;
    [SerializeField] ItemController item2;
    [SerializeField] ItemController item3;

    [SerializeField] Sprite item1Sprite;
    [SerializeField] Sprite item2Sprite;
    [SerializeField] Sprite item3Sprite;
    [SerializeField] Sprite item4Sprite;
    [SerializeField] Sprite item5Sprite;

    [SerializeField] int itemQuantity;

    [SerializeField] PlayerInventory inv;
    [SerializeField] PlayerHealth hp;

    [SerializeField] GunController gun1;
    [SerializeField] GunController gun2;
    [SerializeField] GunController gun3;

    [SerializeField] List<int> passiveItemTags;
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
        hp.health += 0.5f;
        if (inv.weaponCount >= 3)
        {
            List<int> itemTags = new List<int>();
            itemTags.Add(gun1.weaponType);
            itemTags.Add(gun2.weaponType);
            itemTags.Add(gun3.weaponType);
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
            int random = Random.Range(1, itemQuantity+1);
            item1.itemTag = random;

            while (random == item1.itemTag)
            {
                random = Random.Range(1, itemQuantity+1);
            }
            item2.itemTag = random;

            while (random == item1.itemTag || random == item2.itemTag)
            {
                random = Random.Range(1, itemQuantity+1);
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
        }
    }
}
