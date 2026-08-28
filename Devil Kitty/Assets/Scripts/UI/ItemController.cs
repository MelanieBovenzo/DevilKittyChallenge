using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public int itemTag;
    private string displayName;

    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] PlayerInventory playerInventory;

    [SerializeField] GameObject levelCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnBuy()
    {
        playerInventory.AddItem(itemTag);

        levelCanvas.SetActive(false);
        Time.timeScale = 1;

    }

    void Update()
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
            case 4:
                displayName = "Lança Doce";
                break;
            case 5:
                displayName = "Martelo de Pirulito";
                break;
            default:
                displayName = "ERRO!";
                break;
        }

        nameText.text = displayName;
    }
}
