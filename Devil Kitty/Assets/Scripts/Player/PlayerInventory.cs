using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    bool hasLaser = false;
    bool hasSword = false;
    bool hasSpear = false;
    private PlayerBuffs buff;

    [SerializeField] GunController gun1;
    [SerializeField] GunController gun2;
    [SerializeField] GunController gun3;

    [SerializeField] Sprite wpn1Sprite;
    [SerializeField] Sprite wpn2Sprite;
    [SerializeField] Sprite wpn4Sprite;

    private int damageBuffCount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        buff = GetComponent<PlayerBuffs>();
        hasLaser = true;
    }

    // Update is called once per frame
    public void AddItem(int tag)
    {
        switch (tag)
        {
            case 1:
                if (!hasSword)
                {
                    hasSword = true;
                    if (gun2.gameObject.activeSelf == false)
                    {
                        gun2.gameObject.SetActive(true);
                        gun2.shotDelay = 1.5f;
                        gun2.damage = 6 + damageBuffCount;
                        gun2.weaponType = 1;
                        gun2.range = 2.5f;
                        gun2.gameObject.GetComponent<SpriteRenderer>().sprite = wpn1Sprite;
                        gun2.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(1f, 0.3f);
                    }
                    else
                    {
                        gun3.gameObject.SetActive(true);
                        gun3.shotDelay = 2;
                        gun3.damage = 6 + damageBuffCount;
                        gun3.weaponType = 1;
                        gun3.range = 2.5f;
                        gun3.gameObject.GetComponent<SpriteRenderer>().sprite = wpn1Sprite;
                        gun3.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(1f, 0.3f);
                    }
                }
                else
                {
                    buff.WeaponBuff("sword", 0.1f);
                }
                break;
            case 2:
                if (!hasLaser)
                {
                    hasLaser = true;
                    if (gun2.gameObject.activeSelf == false)
                    {
                        gun2.gameObject.SetActive(true);
                        gun2.shotDelay = 1.5f;
                        gun2.damage = 6 + damageBuffCount;
                        gun2.weaponType = 2;
                        gun2.bulletSpeed = 10;
                        gun2.range = 4.5f;
                        gun2.gameObject.GetComponent<SpriteRenderer>().sprite = wpn2Sprite;
                        gun2.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(1f, 0.4f);
                    }
                    else
                    {
                        gun3.gameObject.SetActive(true);
                        gun3.shotDelay = 1.5f;
                        gun3.damage = 6 + damageBuffCount;
                        gun3.weaponType = 2;
                        gun3.bulletSpeed = 10;
                        gun3.range = 4.5f;
                        gun3.gameObject.GetComponent<SpriteRenderer>().sprite = wpn2Sprite;
                        gun3.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(1f, 0.4f);
                    }
                }
                else
                {
                    buff.WeaponBuff("laser", 0.1f);
                }
                break;
            case 3:
                buff.WeaponBuff("damage", 1);
                ++damageBuffCount;
                break;
            case 4:
                if (!hasSpear)
                {
                    hasSpear = true;
                    if (gun2.gameObject.activeSelf == false)
                    {
                        gun2.gameObject.SetActive(true);
                        gun2.shotDelay = 1;
                        gun2.damage = 5 + damageBuffCount;
                        gun2.weaponType = 4;
                        gun2.bulletSpeed = 10;
                        gun2.range = 3.5f;
                        gun2.gameObject.GetComponent<SpriteRenderer>().sprite = wpn4Sprite;
                        gun2.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(1.4f, 0.3f);
                    }
                    else
                    {
                        gun3.gameObject.SetActive(true);
                        gun3.shotDelay = 1;
                        gun3.damage = 5 + damageBuffCount;
                        gun3.weaponType = 4;
                        gun3.bulletSpeed = 10;
                        gun3.range = 3.5f;
                        gun3.gameObject.GetComponent<SpriteRenderer>().sprite = wpn4Sprite;
                        gun3.gameObject.GetComponent<SpriteRenderer>().size = new Vector2(1.4f, 0.3f);
                    }
                }
                else
                {
                    buff.WeaponBuff("spear", 0.1f);
                }
                break;
        }
    }
}
