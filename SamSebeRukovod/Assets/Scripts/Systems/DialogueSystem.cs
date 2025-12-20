using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour {
    private IDialogue _currentDialogue;
    private DialogueNode _currentNode;
    private int _currentDialogueIndex;

    private IDialogue[] _dialogues;

    private void Start()
    {
        _dialogues = new IDialogue[]
        {
            new FriendDialogue(),
            new AmbitiousFriendDialogue(),
            new FNSDialogue(),
            new ITDialogue(),
            new CompetitorDialogue(),
            new AccountantDialogue(),
            new SecondFriendDialogue(),
            new SupplierDialogue(),
            new ClientDialogue()
        };

        _currentDialogueIndex = 0;
        StartDialogue(_dialogues[_currentDialogueIndex]);
    }

    private void StartDialogue(IDialogue dialogue)
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

            if (_currentDialogueIndex >= _dialogues.Length)
            {
                EventBus.OnDialogueEnd?.Invoke();
                SceneManager.LoadScene("MiniGame");
                return;
            }

            StartDialogue(_dialogues[_currentDialogueIndex]);
            return;
        }

        // вызов события для UI
        EventBus.OnNextNode?.Invoke(_currentNode);
    }

    // вызывается кнопкой в UI, передаём очки
    public void SelectOption(float score)
    {
        GameState.RiskScore += score;
        ShowNextNode();
    }

    // Если нет опций, кнопка Далее вызывает этот метод
    public void NextNode()
    {
        ShowNextNode();
    }
}
