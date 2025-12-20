using System.Collections.Generic;

public class ITDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public ITDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Без учёта ты утонешь.", Options = null },
            new DialogueNode
            {
                SpeakerText = "Как будешь считать деньги?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="CRM + таблицы", Score=1f },
                    new DialogueOption { Text="Только таблицы", Score=0.5f },
                    new DialogueOption { Text="В голове", Score=0.25f },
                    new DialogueOption { Text="Как получится", Score=0f }
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
