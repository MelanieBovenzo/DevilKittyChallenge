using System.Collections;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
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

    [SerializeField] float textSpeed;
    private bool isWriting;
    private string[] currentDialogue;

    int i;
    int Index;

    public bool isTalking = false;
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
                if (i + 1 <= currentDialogue.Length - 1)
                {
                    i++;
                    dialogueText.text = string.Empty;
                    WriteLine();
                }
                else
                {
                    isTalking = false;
                    dialogueCanvas.SetActive(false);
                    if (Index == 3)
                    {
                        SceneManager.LoadScene("MenuScene");
                    }
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
        Index = dialogueIndex;
        dialogueText.text = string.Empty;
        speakerName1.text = string.Empty;
        speakerName2.text = string.Empty;
        isWriting = true;
        i = 0;

        isTalking = true;

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

        print(currentDialogue.Length);

        dialogueCanvas.SetActive(true);

        WriteLine();
    }
    IEnumerator WriteLineCoroutine()
    {
        foreach (char c in currentDialogue[i].Substring(1).ToCharArray())
        {
            isWriting = true;
            dialogueText.text += c;
            yield return new WaitForSeconds(textSpeed * Time.deltaTime);
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
