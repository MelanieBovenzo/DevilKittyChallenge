using System;
using System.Transactions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    public int xp;
    public int level;
    [SerializeField] float XPSpeed;

    [SerializeField] TextMeshProUGUI xpText;
    [SerializeField] TextMeshProUGUI levelText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xpText.text = "XP: " + xp.ToString();
        levelText.text = "NÍVEL: " + level.ToString() + "\n XP Restate: " + (Mathf.Ceil(Mathf.Pow(level * 1.1f, 2) + 10) - xp);

        if (xp >= Mathf.Ceil(Mathf.Pow(level * 1.1f,2) + 10))
        {
            xp = 0;
            level++;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Collectable"))
        {
            collider.gameObject.GetComponent<XPController>().FollowPlayer(transform, XPSpeed);
        }
        else if (collider.gameObject.CompareTag("XP"))
        {
            xp += 1;
            Destroy(collider.transform.parent.gameObject);
        }
    }
}
