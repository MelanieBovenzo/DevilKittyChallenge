using UnityEngine;

public class PlayerBuffs : MonoBehaviour
{
    [SerializeField] PlayerHealth health;
    [SerializeField] PlayerMovement movement;

    [SerializeField] GunController gun1;
    [SerializeField] GunController gun2;
    [SerializeField] GunController gun3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WeaponBuff(string type, float quantity)
    {
        switch (type)
        {
            case "damage":
                gun1.damage += quantity;
                gun2.damage += quantity;
                gun3.damage += quantity;
                break;
            case "range":
                gun1.range += quantity;
                gun2.range += quantity;
                gun3.range += quantity;
                break;
            case "delay":
                gun1.shotDelay /= quantity;
                gun2.shotDelay /= quantity;
                gun3.shotDelay /= quantity;
                break;
            case "bulletSpeed":
                gun1.bulletSpeed += quantity;
                gun2.bulletSpeed += quantity;
                gun3.bulletSpeed += quantity;
                break;
            case "sword":
                if (gun1.weaponType == 1)
                {
                    gun1.damage += gun1.damage * quantity;
                }
                if (gun2.weaponType == 1)
                {
                    gun2.damage += gun2.damage * quantity;
                }
                if (gun3.weaponType == 1)
                {
                    gun3.damage += gun3.damage * quantity;
                }
                break;
            case "laser":
                if (gun1.weaponType == 2)
                {
                    gun1.damage += gun1.damage * quantity;
                }
                if (gun2.weaponType == 2)
                {
                    gun2.damage += gun2.damage * quantity;
                }
                if (gun3.weaponType == 2)
                {
                    gun3.damage += gun3.damage * quantity;
                }
                break;
        }
    }

    public void SpeedBuff(float quantity)
    {
        movement.speed += quantity;
    }

    public void DefenseBuff(string type, float quantity)
    {
        if (type == "health")
        {
            health.health += quantity;
        }
        else if (type == "iFrames")
        {
            health.iFrameTime += quantity;
        }
        else
        {
            Debug.Log("Buff de defesa inválido!");
        }
    }
}
