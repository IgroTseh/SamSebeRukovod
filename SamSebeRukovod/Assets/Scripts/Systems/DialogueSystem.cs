using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueSystem : MonoBehaviour {
    private IDialogue _currentDialogue;
    private DialogueNode _currentNode;
    private int _currentDialogueIndex;

    private IDialogue[] _dialogues;

    [Header("Result UI")]
    [SerializeField] private GameObject resultUIPanel;

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
                ShowResult();
                return;
            }

            StartDialogue(_dialogues[_currentDialogueIndex]);
            return;
        }

        EventBus.OnNextNode?.Invoke(_currentNode);
    }

    public void SelectOption(float score)
    {
        GameState.RiskScore += score;
        ShowNextNode();
    }

    public void NextNode()
    {
        ShowNextNode();
    }

    private void ShowResult()
    {
        if (resultUIPanel != null)
        {
            resultUIPanel.SetActive(true); // активируем панель

            var resultUI = resultUIPanel.GetComponent<DialogueResultUI>();
            if (resultUI != null)
            {
                resultUI.ShowResult();     // обновляем текст
            }
            else
            {
                Debug.LogError("DialogueResultUI не найден на панели resultUIPanel");
            }
        }
        else
        {
            SceneManager.LoadScene("MiniGame");
        }
    }


}
