using UnityEngine;

public class DialogueStarter : MonoBehaviour
{
    [SerializeField] DialogueController dialogueController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueController.StartDialogue(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
