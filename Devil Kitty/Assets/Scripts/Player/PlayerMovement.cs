using UnityEngine;
using Unity;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] DialogueController dialogueController;
    public float speed;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        if (!dialogueController.isTalking)
        {
            animator.SetFloat("HorizontalMovement", xMove);
            animator.SetFloat("VerticalMovement", yMove);
            transform.Translate(new Vector3(xMove, yMove, 0).normalized * speed * Time.deltaTime);

            if (xMove > 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
    }
}
