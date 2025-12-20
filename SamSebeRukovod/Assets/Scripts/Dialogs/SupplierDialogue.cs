using System.Collections.Generic;

public class SupplierDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public SupplierDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Сроки важны.", Options = null },
            new DialogueNode
            {
                SpeakerText = "Что будешь делать при срыве?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Коммуницировать", Score=1f },
                    new DialogueOption { Text="Искать замену", Score=0.5f },
                    new DialogueOption { Text="Надеяться", Score=0.25f },
                    new DialogueOption { Text="Игнорировать", Score=0f }
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
