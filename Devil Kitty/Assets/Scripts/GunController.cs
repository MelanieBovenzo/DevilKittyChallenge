using UnityEngine;

public class GunController : MonoBehaviour
{
    public float shotDelay;
    public float damage;
    public string weaponType;
    public float bulletSpeed;
    public float range;

    [SerializeField] GameObject bullet;

    [SerializeField] AimController aimController;
    private bool canShoot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Shoot();
    }

    void Shoot()
    {
        switch (weaponType)
        {
            case "laser":
                GameObject curBullet = Instantiate(bullet, transform.position, transform.rotation);
                curBullet.transform.Rotate(new Vector3(0, 0, -90));
                curBullet.GetComponent<BulletController>().damage = damage;
                curBullet.GetComponent<BulletController>().speed = bulletSpeed;
                break;
            case "sword":
                break;
            default:
                Debug.Log("Invalid Weapon Type!");
                break;
        }
        canShoot = false;
        Invoke("AllowShoot", shotDelay);
    }

    void Update()
    {
        float distance;
        if (aimController.FindClosestEnemy() != null)
        {
            distance = Vector2.Distance(aimController.FindClosestEnemy().transform.position, aimController.center.position);
            Debug.Log(distance);
        }
        else
        {
            distance = Mathf.Infinity;
        }
        if (distance <= range && canShoot)
        {
            Shoot();
        }
    }
    void AllowShoot()
    {
        canShoot = true;
    }
}