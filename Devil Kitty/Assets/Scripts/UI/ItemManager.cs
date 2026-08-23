using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] ItemController item1;
    [SerializeField] ItemController item2;
    [SerializeField] ItemController item3;

    [SerializeField] PlayerExperience xp;
    [SerializeField] PlayerInventory inv;
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
        int random = Random.Range(0, 3);
        item1.itemTag = random;

        while (random == item1.itemTag)
        {
            random = Random.Range(0, 3);
        }
        item2.itemTag = random;

        while (random == item1.itemTag || random == item2.itemTag)
        {
            random = Random.Range(0, 3);
        }
        item3.itemTag = random;
    }
}
