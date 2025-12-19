using UnityEngine;

public class DialogueSystem : MonoBehaviour {
    private IDialogue _currentDialogue;
    private DialogueNode _currentNode;
    private int _currentDialogueIndex = 0;
    private IDialogue[] _allDialogues;

    public void StartDialogues(IDialogue[] dialogues)
    {
        GameState.Reset();
        _allDialogues = dialogues;
        _currentDialogueIndex = 0;
        StartDialogue(_allDialogues[_currentDialogueIndex]);
    }

    void StartDialogue(IDialogue dialogue)
    {
        _currentDialogue = dialogue;
        ShowNextNode();
    }

    public void ShowNextNode()
    {
        _currentNode = _currentDialogue.GetNextNode();

        if (_currentNode == null)
        {
            _currentDialogueIndex++;
            if (_currentDialogueIndex < _allDialogues.Length)
            {
                StartDialogue(_allDialogues[_currentDialogueIndex]);
            }
            else
            {
                EventBus.OnDialogueEnd?.Invoke();
            }
            return;
        }

        EventBus.OnNextNode?.Invoke(_currentNode);
    }

    public void SelectOption(float score)
    {
        GameState.RiskScore += score;
        ShowNextNode();
    }
}
