using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class TextFeed : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    [SerializeField] public Button option1;
    [SerializeField] public Button option2;
    [SerializeField] public Button option3;
    [SerializeField] public Button option4;
    public DialogueLineSO baseDialogue;
    public string[] dialogueLines;
    private int currentLineIndex = 0;

    private void Awake()
    {
        Debug.Log(baseDialogue.dialogueText);
    }

    public void DisplayNextDialogue(bool transitionToFPS = false)
    {
        if (currentLineIndex < dialogueLines.Length)
        {
            string nextLine = dialogueLines[currentLineIndex];
            currentLineIndex++;

            if (transitionToFPS && nextLine.Equals("Special Dialogue"))
            {
                Debug.Log("TRANSITIONING TO FPS.");
            }
            else
            {
                textMeshPro.text = nextLine;
            }
        }
        else
        {
            Debug.Log("No more dialogue lines to display.");
        }
    }
}