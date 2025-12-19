using System.Collections.Generic;

public class ITDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public ITDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Нужно подключить систему учёта.", Options = null },
            new DialogueNode { SpeakerText = "И настроить отчёты.", Options = null },

            new DialogueNode { SpeakerText = "Вы знакомы с софтом?", Options = null },
            new DialogueNode { SpeakerText = "Иначе придётся потратить время на обучение.", Options = null },

            new DialogueNode
            {
                SpeakerText = "Когда начнём настройку?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Сейчас", Score = 1f },
                    new DialogueOption { Text="Позже", Score = 0.5f },
                    new DialogueOption { Text="Мне это не нужно", Score = 0f },
                    new DialogueOption { Text="Разберусь постепенно", Score = 0.25f }
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
