using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueUI : MonoBehaviour {
    public TMP_Text dialogueText;
    public Button[] optionButtons;

    private DialogueSystem _dialogueSystem;

    private void Awake()
    {
        _dialogueSystem = FindObjectOfType<DialogueSystem>();
    }

    private void OnEnable()
    {
        EventBus.OnNextNode += UpdateUI;
    }

    private void OnDisable()
    {
        EventBus.OnNextNode -= UpdateUI;
    }

    void UpdateUI(DialogueNode node)
    {
        dialogueText.text = node.SpeakerText;

        for (int i = 0; i < optionButtons.Length; i++)
        {
            if (node.Options != null && i < node.Options.Length)
            {
                optionButtons[i].gameObject.SetActive(true);
                optionButtons[i].GetComponentInChildren<TMP_Text>().text = node.Options[i].Text;
                float score = node.Options[i].Score;
                optionButtons[i].onClick.RemoveAllListeners();
                optionButtons[i].onClick.AddListener(() => _dialogueSystem.SelectOption(score));
            }
            else
            {
                optionButtons[i].gameObject.SetActive(false);
            }
        }
    }
}
