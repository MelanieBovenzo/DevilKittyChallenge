using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float startingHealth;
    [SerializeField] float startingIFrames;
    [SerializeField] SpriteRenderer playerSprite;
    private float health;
    private bool invul = false;
    private float iFrameTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = startingHealth;
        iFrameTime = startingIFrames;
    }

    // Update is called once per frame
    void Update()
    {
        if (invul)
        {
            Invoke("RemoveInvul", iFrameTime);
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MenuScene");
        }
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
