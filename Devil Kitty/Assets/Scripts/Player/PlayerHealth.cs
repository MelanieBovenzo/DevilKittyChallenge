using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float startingHealth;
    [SerializeField] float startingIFrames;

    [SerializeField] SpriteRenderer playerSprite;

    public float health;
    public float maxHealth;
    private bool invul = false;
    [HideInInspector] public float iFrameTime;

    [SerializeField] RectTransform healthBar;

    [SerializeField] DialogueController dialogueController;

    private bool dead = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = startingHealth;
        maxHealth = startingHealth;
        iFrameTime = startingIFrames;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (!dead)
            {
                dead = true;
                dialogueController.StartDialogue(3); 
            }
        }

        healthBar.sizeDelta = new Vector2(health/maxHealth * 106, 6);
    }

    private void RemoveInvul()
    {
        invul = false;
    }

    public void PlayerDamage(float dmg)
    {
        if (!invul)
        {
            invul = true;
            Invoke("RemoveInvul", iFrameTime);
            health -= dmg;
            StartCoroutine(iFrames());
        }
    }

    private IEnumerator iFrames()
    {
        yield return new WaitForSeconds(0.2f);

        if (playerSprite.enabled)
        {
            playerSprite.enabled = false;
        }
        else
        {
            playerSprite.enabled = true;
        }

        if (invul)
        {
            StartCoroutine(iFrames());
        }
        else
        {
            playerSprite.enabled = true;
        }
    }
}
