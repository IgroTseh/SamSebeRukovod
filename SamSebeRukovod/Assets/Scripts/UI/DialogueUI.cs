using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueUI : MonoBehaviour {
    [Header("Text")]
    [SerializeField] private TMP_Text dialogueText;

    [Header("Answer Buttons")]
    [SerializeField] private Button[] answerButtons;
    [SerializeField] private TMP_Text[] answerTexts;

    private DialogueSystem _dialogueSystem;

    private void Awake()
    {
        _dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    private void OnEnable()
    {
        EventBus.OnNextNode += ShowNode;
    }

    private void OnDisable()
    {
        EventBus.OnNextNode -= ShowNode;
    }

    private void ShowNode(DialogueNode node)
    {
        dialogueText.text = node.SpeakerText;

        if (node.Options == null)
        {
            HideAnswers();
        }
        else
        {
            ShowAnswers(node.Options);
        }
    }

    private void ShowAnswers(DialogueOption[] options)
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (i < options.Length)
            {
                answerButtons[i].gameObject.SetActive(true);
                answerTexts[i].text = options[i].Text;

                float score = options[i].Score;
                answerButtons[i].onClick.RemoveAllListeners();
                answerButtons[i].onClick.AddListener(() =>
                {
                    _dialogueSystem.SelectOption(score);
                });
            }
            else
            {
                answerButtons[i].gameObject.SetActive(false);
            }
        }
    }

    private void HideAnswers()
    {
        foreach (var btn in answerButtons)
            btn.gameObject.SetActive(false);
    }
}
