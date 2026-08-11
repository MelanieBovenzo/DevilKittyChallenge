using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector3 playerPosition;
    Vector3 direction;
    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = playerTransform.position;
        direction = (playerPosition - transform.position).normalized;
        transform.position += direction * speed;
    }
}
