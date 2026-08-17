using Unity.VisualScripting;
using UnityEngine;

public class XPController : MonoBehaviour
{
    private Transform playerTransform;
    private float XPSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            Vector2 dir = (playerTransform.position - transform.position).normalized;
            transform.Translate(dir * Time.deltaTime * XPSpeed);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerExperience>().xp += 1;
            Destroy(gameObject);
        }
    }

    public void FollowPlayer(Transform pt, float speed)
    {
        playerTransform = pt;
        XPSpeed = speed;
    }
}
