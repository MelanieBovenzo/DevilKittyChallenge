using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    Transform playerTransform;
    Vector3 playerPosition;
    Vector3 direction;
    [SerializeField] float speed;

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
        transform.position += direction * speed;
    }
}
