using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    bool hasLaser = false;
    bool hasSword = false;
    private PlayerBuffs buff;

    [SerializeField] GunController gun1;
    [SerializeField] GunController gun2;
    [SerializeField] GunController gun3;

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
                    if (gun2.enabled == false)
                    {
                        gun2.gameObject.SetActive(true);
                        gun2.shotDelay = 2;
                        gun2.damage = 1 + damageBuffCount;
                        gun2.weaponType = 1;
                        gun2.bulletSpeed = 1;
                        gun2.range = 1;
                    }
                    else
                    {
                        gun3.gameObject.SetActive(true);
                        gun3.shotDelay = 2;
                        gun3.damage = 1 + damageBuffCount;
                        gun3.weaponType = 1;
                        gun3.bulletSpeed = 1;
                        gun3.range = 1;
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
                    if (gun2.enabled == false)
                    {
                        gun2.gameObject.SetActive(true);
                        gun2.shotDelay = 1;
                        gun2.damage = 6 + damageBuffCount;
                        gun2.weaponType = 2;
                        gun2.bulletSpeed = 10;
                        gun2.range = 4.5f;
                    }
                    else
                    {
                        gun3.gameObject.SetActive(true);
                        gun3.shotDelay = 1;
                        gun3.damage = 6 + damageBuffCount;
                        gun3.weaponType = 2;
                        gun3.bulletSpeed = 10;
                        gun3.range = 4.5f;
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
        }
    }
}
