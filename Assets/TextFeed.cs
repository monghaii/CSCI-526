using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TextFeed : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    [SerializeField] public TextMeshProUGUI option1;
    [SerializeField] public TextMeshProUGUI option2;
    [SerializeField] public TextMeshProUGUI option3;
    [SerializeField] public TextMeshProUGUI option4;
    public DialogueLineSO currentDialogue;
    private int currentLineIndex = 0;

    private void Awake()
    {
        Debug.Log(currentDialogue.dialogueText);
        option1.text = currentDialogue.options[0].optionText;
        option2.text = currentDialogue.options[1].optionText;
        option3.text = currentDialogue.options[2].optionText;
        option4.text = currentDialogue.options[3].optionText;
        dialogueText.text = currentDialogue.dialogueText;
    }

    public void DisplayNextDialogue(int option)
    {
        Debug.Log("pressed " + option);
        if (currentDialogue.options[option].isWinningChoice)
        {
            Debug.Log("IS WINNING CHOICE");
        } else if (currentDialogue.options[option].triggersFPS)
        {
            Debug.Log("FPS TRIGGERED");
        } else if (currentDialogue.options[option].causesRelationship)
        {
            Debug.Log("RELATIONSHIP CAUSED");
        }
        else
        {
            // select the next dialogue node
            currentDialogue = currentDialogue.options[option].response;
            dialogueText.text = currentDialogue.dialogueText;
            option1.text = currentDialogue.options[0].optionText;
            option2.text = currentDialogue.options[1].optionText;
            option3.text = currentDialogue.options[2].optionText;
            option4.text = currentDialogue.options[3].optionText;
        }
    }
}