using System.Collections;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public float shotDelay;
    public float damage;
    public int weaponType;
    public float bulletSpeed;
    public float range;

    [SerializeField] GameObject bullet;

    [SerializeField] AimController aimController;
    private bool canShoot;

    private Animator animator;

    public bool isSwinging = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        canShoot = false;
        Invoke("AllowShoot", shotDelay);
    }

    void Shoot()
    {
        switch (weaponType)
        {
            case 2:
                GameObject curBullet = Instantiate(bullet, transform.position, transform.rotation);
                curBullet.transform.Rotate(new Vector3(0, 0, -90));
                curBullet.GetComponent<BulletController>().damage = damage;
                curBullet.GetComponent<BulletController>().speed = bulletSpeed;
                break;
            case 1:
                animator.SetBool("SwingingSword", true);
                isSwinging = true;
                GetComponent<BoxCollider2D>().enabled = true;
                break;
            case 4:
                animator.SetBool("SwingingSpear", true);
                isSwinging = true;
                GetComponent<BoxCollider2D>().enabled = true;
                break;
            default:
                Debug.Log("Invalid Weapon Type!");
                break;
        }
        canShoot = false;
        Invoke("AllowShoot", shotDelay);
    }

    void StopSwing()
    {
        isSwinging = false;
        GetComponent<BoxCollider2D>().enabled = false;
        if (weaponType == 1)
        {
            animator.SetBool("SwingingSword", false);
        }
        if (weaponType == 4)
        {
            animator.SetBool("SwingingSpear", false);
        }
    }

    void Update()
    {
        float distance;
        if (aimController.FindClosestEnemy() != null)
        {
            distance = Vector2.Distance(aimController.FindClosestEnemy().transform.position, aimController.center.position);
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