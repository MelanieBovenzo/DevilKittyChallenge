using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackpackItem : MonoBehaviour
{
    public int itemTag;

    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] Image imageComponent;

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
                nameText.text = "+1 dano";
                break;
            case 4:
                nameText.text = "Lança Doce";
                break;
            case 5:
                nameText.text = "Martelo de Pirulito";
                break;
            default:
                nameText.text = "ERRO!";
                break;
        }
        imageComponent.sprite = itemImage;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
