using UnityEngine;
using Unity;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        transform.position += new Vector3(xMove, yMove, 0).normalized * speed;
    }
}
