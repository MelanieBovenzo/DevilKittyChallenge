using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public int itemTag;
    private string displayName;
    public Sprite itemImage;

    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] PlayerInventory playerInventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnBuy()
    {
        playerInventory.heldItems.Add(itemTag);
    }

    void OnEnable()
    {
        switch (itemTag)
        {
            case 1:
                displayName = "Espada de balão";
                break;
            case 2:
                displayName = "Pistola de laser";
                break;
            case 3:
                displayName = "+1 dano";
                break;
            default:
                displayName = "ERRO!";
                break;
        }

        nameText.text = displayName;
        GetComponent<Image>().sprite = itemImage;
    }
}
