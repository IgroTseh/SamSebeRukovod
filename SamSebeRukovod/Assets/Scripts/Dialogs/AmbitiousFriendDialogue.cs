using System.Collections.Generic;

public class AmbitiousFriendDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public AmbitiousFriendDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Я уволился.", Options = null },
            new DialogueNode { SpeakerText = "Решил рисовать и жить этим.", Options = null },
            new DialogueNode { SpeakerText = "Да, страшно. Но иначе никак.", Options = null },
            new DialogueNode
            {
                SpeakerText = "А ты бы рискнул?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Да, без риска нет роста", Score=1f },
                    new DialogueOption { Text="Если будет подушка", Score=0.5f },
                    new DialogueOption { Text="Не сейчас", Score=0.25f },
                    new DialogueOption { Text="Никогда", Score=0f }
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
