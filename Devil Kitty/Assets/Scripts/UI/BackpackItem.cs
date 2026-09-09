using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackpackItem : MonoBehaviour
{
    public int itemTag;
    public int itemQuantity;

    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] Image imageComponent;
    [SerializeField] TextMeshProUGUI quantityText;

    public Sprite itemImage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (itemTag)
        {
            case 1:
                nameText.text = "Espada de balão";
                break;
            case 2:
                nameText.text = "Pistola de laser";
                break;
            case 3:
                nameText.text = "+ Dano";
                break;
            case 4:
                nameText.text = "Lança Doce";
                break;
            case 5:
                nameText.text = "Martelo de Pirulito";
                break;
            case 6:
                nameText.text = "+ Vida";
                break;
            case 7:
                nameText.text = "+ Velocidade de Movimento";
                break;
            default:
                nameText.text = "ERRO!";
                break;
        }
        imageComponent.sprite = itemImage;
        quantityText.text = itemQuantity.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
