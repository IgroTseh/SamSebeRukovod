using System.Collections.Generic;

public class CompetitorDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public CompetitorDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Ты уверен, что справишься лучше меня?", Options = null },
            new DialogueNode { SpeakerText = "Это будет не просто.", Options = null },

            new DialogueNode { SpeakerText = "Ты готов к конкуренции?", Options = null },
            new DialogueNode { SpeakerText = "Будь уверен в своих силах.", Options = null },

            new DialogueNode
            {
                SpeakerText = "Как будешь действовать?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Да, готов к борьбе", Score = 1f },
                    new DialogueOption { Text="Попробую, но осторожно", Score = 0.5f },
                    new DialogueOption { Text="Сдаюсь", Score = 0f },
                    new DialogueOption { Text="Буду учиться у тебя", Score = 0.25f }
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
