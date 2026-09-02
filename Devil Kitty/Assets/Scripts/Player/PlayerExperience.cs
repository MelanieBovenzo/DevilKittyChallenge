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

    [SerializeField] GameObject levelCanvas;
    [SerializeField] ItemManager itemManager;
    
    [SerializeField] DialogueController dialogueController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xpText.text = "XP: " + xp.ToString();
        levelText.text = "NÍVEL: " + level.ToString() + "\n XP Restate: " + (Mathf.Ceil(Mathf.Pow((level - 1) * 1.1f, 2) + 10) - xp);

        if (xp >= Mathf.Ceil(Mathf.Pow((level-1) * 1.1f, 2) + 10))
        {
            xp = 0;
            level++;

            levelCanvas.SetActive(true);
            itemManager.LevelUp();
            dialogueController.isTalking = true;

            if(level == 2)
            {
                dialogueController.StartDialogue(2);
            }

            if (level == 15)
            {
                dialogueController.StartDialogue(4);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Collectable"))
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
