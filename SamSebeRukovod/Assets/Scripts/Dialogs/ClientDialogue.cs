using System.Collections.Generic;

public class ClientDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public ClientDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode
            {
                SpeakerText = "Зачем ты делаешь этот продукт?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Решить проблему", Score=1f },
                    new DialogueOption { Text="Заработать", Score=0.5f },
                    new DialogueOption { Text="Попробовать", Score=0.25f },
                    new DialogueOption { Text="Случайно вышло", Score=0f }
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
