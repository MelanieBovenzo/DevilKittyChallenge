using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform playerTransform;
    Vector3 playerPosition;
    Vector3 direction;

    public float speed;
    public float health;
    public float damage;


    [SerializeField] GameObject XP;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = playerTransform.position;
        direction = (playerPosition - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);

        if (health <= 0)
        {
            Instantiate(XP, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            other.gameObject.GetComponent<PlayerHealth>().PlayerDamage(damage);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage(other.GetComponent<GunController>().damage);
    }

    public void TakeDamage(float dmg)
    {
        health -= dmg;
    }
}
