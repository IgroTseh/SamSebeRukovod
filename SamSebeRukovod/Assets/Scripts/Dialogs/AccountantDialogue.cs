using System.Collections.Generic;

public class AccountantDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public AccountantDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Нужно учитывать доходы и расходы.", Options = null },
            new DialogueNode { SpeakerText = "И следить за прибылью.", Options = null },

            new DialogueNode { SpeakerText = "Вы умеете вести учет?", Options = null },
            new DialogueNode { SpeakerText = "Иначе будут ошибки.", Options = null },

            new DialogueNode
            {
                SpeakerText = "Как будете действовать?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Буду считать сам", Score = 1f },
                    new DialogueOption { Text="Попросю помощи", Score = 0.5f },
                    new DialogueOption { Text="Пусть кто-то считает за меня", Score = 0.25f },
                    new DialogueOption { Text="Считать? Скучно", Score = 0f }
                }
            }
        };
        _currentIndex = 0;
    }

    public DialogueNode GetNextNode()
    {
        if (_currentIndex >= _nodes.Count) return null;
        return _nodes[_currentIndex++];
    }
}
