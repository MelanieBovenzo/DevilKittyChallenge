using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI DialogueText;
    [SerializeField] TextMeshProUGUI SpeakerName1;
    [SerializeField] TextMeshProUGUI SpeakerName2;

    [SerializeField] Image image1;
    [SerializeField] Image image2;

    [SerializeField] GameObject DialogueCanvas;

    [SerializeField] string dialogue1;
    [SerializeField] string dialogue2;
    [SerializeField] string dialogue3;
    [SerializeField] string dialogue4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartDialogue()
    {
        DialogueText.text = string.Empty;
        SpeakerName1.text = string.Empty;
        SpeakerName2.text = string.Empty;
    }
}
