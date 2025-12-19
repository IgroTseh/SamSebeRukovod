using System.Collections.Generic;

public class AmbitiousFriendDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public AmbitiousFriendDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Привет! Как дела с твоим проектом?", Options = null },
            new DialogueNode { SpeakerText = "Ты ещё не ушёл из найма?", Options = null },

            new DialogueNode { SpeakerText = "Да, думаю об этом. Уверен, что смогу.", Options = null },
            new DialogueNode { SpeakerText = "Ты талантлив, пора пробовать!", Options = null },

            new DialogueNode
            {
                SpeakerText = "Почему бы не начать прямо сейчас?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Да, начинаю!", Score = 1f },
                    new DialogueOption { Text="Подумаю ещё", Score = 0.25f },
                    new DialogueOption { Text="Нет, слишком страшно", Score = 0f },
                    new DialogueOption { Text="Начну по чуть-чуть", Score = 0.5f }
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
