using System.Collections.Generic;

public class FNSDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public FNSDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Налоговая: Здравствуйте.", Options = null },
            new DialogueNode { SpeakerText = "Вы: Вечер добрый. А вы кто?", Options = null },
            new DialogueNode { SpeakerText = "Налоговая: Я из федеральной налоговй службы. Ведь скоро конец года...", Options = null },
            new DialogueNode
            {
                SpeakerText = "Налоговая: Как будете платить налоги?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Вы думали, я собираюсь платить налоги?", Score=0f },
                    new DialogueOption { Text="Займусь этим за день до дедлайна...", Score=0.3f },
                    new DialogueOption { Text="Лично приеду в налоговую.", Score=0.6f },
                    new DialogueOption { Text="В приложении ФНС России.", Score=1f }
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
