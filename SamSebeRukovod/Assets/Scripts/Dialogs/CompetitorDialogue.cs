using System.Collections.Generic;

public class CompetitorDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public CompetitorDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Рынок переполнен.", Options = null },
            new DialogueNode
            {
                SpeakerText = "Почему клиенты выберут тебя?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Лучшее качество", Score=1f },
                    new DialogueOption { Text="Цена", Score=0.5f },
                    new DialogueOption { Text="Не знаю", Score=0.25f },
                    new DialogueOption { Text="Им всё равно", Score=0f }
                }
            }
        };
    }

    public DialogueNode GetNextNode()
    {
        if (_index >= _nodes.Count) return null;
        return _nodes[_index++];
    }
}
