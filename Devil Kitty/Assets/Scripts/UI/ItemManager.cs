using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    [SerializeField] ItemController item1;
    [SerializeField] ItemController item2;
    [SerializeField] ItemController item3;

    [SerializeField] PlayerExperience xp;
    [SerializeField] PlayerInventory inv;

    [SerializeField] Sprite item1Sprite;
    [SerializeField] Sprite item2Sprite;
    [SerializeField] Sprite item3Sprite;
    [SerializeField] Sprite item4Sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnEnable()
    {
        int random = Random.Range(1, 5);
        item1.itemTag = random;

        while (random == item1.itemTag)
        {
            random = Random.Range(1, 5);
        }
        item2.itemTag = random;

        while (random == item1.itemTag || random == item2.itemTag)
        {
            random = Random.Range(1, 5);
        }
        item3.itemTag = random;

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
        }
    }
}
