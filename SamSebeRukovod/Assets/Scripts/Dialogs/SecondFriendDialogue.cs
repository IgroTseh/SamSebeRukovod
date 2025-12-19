using System.Collections.Generic;

public class SecondFriendDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public SecondFriendDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Эх, я бы тоже ушёл из найма.", Options = null },
            new DialogueNode { SpeakerText = "Но боюсь рисковать.", Options = null },

            new DialogueNode { SpeakerText = "А ты как думаешь?", Options = null },
            new DialogueNode { SpeakerText = "Тебе риск не страшен?", Options = null },

            new DialogueNode
            {
                SpeakerText = "Что выберешь?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Рискну и попробую", Score = 1f },
                    new DialogueOption { Text="Я тоже боюсь", Score = 0f },
                    new DialogueOption { Text="Подожду", Score = 0.25f },
                    new DialogueOption { Text="Буду осторожен", Score = 0.5f }
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
