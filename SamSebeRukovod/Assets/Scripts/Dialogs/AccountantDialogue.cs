using System.Collections.Generic;

public class AccountantDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public AccountantDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Доходы — не равно прибыль.", Options = null },
            new DialogueNode
            {
                SpeakerText = "Ты это понимаешь?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Конечно", Score=1f },
                    new DialogueOption { Text="Примерно", Score=0.5f },
                    new DialogueOption { Text="Не совсем", Score=0.25f },
                    new DialogueOption { Text="Нет", Score=0f }
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
