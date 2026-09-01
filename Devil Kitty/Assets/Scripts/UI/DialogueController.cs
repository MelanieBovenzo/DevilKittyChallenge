using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Splines;
using UnityEngine.UI;
using static UnityEditor.Rendering.MaterialUpgrader;

public class DialogueController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialogueText;
    [SerializeField] TextMeshProUGUI speakerName1;
    [SerializeField] TextMeshProUGUI speakerName2;

    [SerializeField] Image image1;
    [SerializeField] Image image2;

    [SerializeField] GameObject dialogueCanvas;

    [SerializeField] string[] dialogue1list;
    [SerializeField] string[] dialogue2list;
    [SerializeField] string[] dialogue3list;
    [SerializeField] string[] dialogue4list;

    [SerializeField] int textSpeed;
    private bool isWriting;
    private string[] currentDialogue;

    int i;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            if (!isWriting)
            {
                if (currentDialogue.Length >= i+1)
                {
                    i++;
                    WriteLine();
                }
                else
                {
                    dialogueCanvas.SetActive(false);
                }
            }
            else
            {
                StopAllCoroutines();
                dialogueText.text = currentDialogue[i].Substring(1);
                isWriting = false;
            }
        }
    }

    public void StartDialogue(int dialogueIndex)
    {
        dialogueText.text = string.Empty;
        speakerName1.text = string.Empty;
        speakerName2.text = string.Empty;
        isWriting = false;
        i = 0;

        switch (dialogueIndex)
        {
            case 1:
                currentDialogue = dialogue1list;
                break;
            case 2:
                currentDialogue = dialogue2list;
                break;
            case 3:
                currentDialogue = dialogue3list;
                break;
            case 4:
                currentDialogue = dialogue4list;
                break;
        }

        WriteLine();
    }
    IEnumerator WriteLineCoroutine()
    {
        foreach (char c in currentDialogue[i].Substring(1).ToCharArray())
        {
            isWriting = true;
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed);
            isWriting = false;
        }
    }

    private void WriteLine()
    {
        switch (currentDialogue[i][0])
        {
            case 'c':
                speakerName1.text = "Cindy";
                speakerName2.text = string.Empty;
                break;
            case 'k':
                speakerName1.text = string.Empty;
                speakerName2.text = "Kitty";
                break;
        }
        StartCoroutine("WriteLineCoroutine");
    }
}
