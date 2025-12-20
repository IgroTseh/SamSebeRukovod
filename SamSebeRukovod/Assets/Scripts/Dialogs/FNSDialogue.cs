using System.Collections.Generic;

public class FNSDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public FNSDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Здравствуйте.", Options = null },
            new DialogueNode { SpeakerText = "Вы знакомы с режимом самозанятости?", Options = null },
            new DialogueNode
            {
                SpeakerText = "Как будете платить налоги?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Через приложение", Score=1f },
                    new DialogueOption { Text="Разберусь позже", Score=0.5f },
                    new DialogueOption { Text="Пока не знаю", Score=0.25f },
                    new DialogueOption { Text="Не буду", Score=0f }
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
