using System.Collections.Generic;

public class FNSDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public FNSDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Здравствуйте! Нужно заполнять декларацию.", Options = null },
            new DialogueNode { SpeakerText = "Все налоги должны быть уплачены вовремя.", Options = null },

            new DialogueNode { SpeakerText = "Вы в курсе правил налоговой?", Options = null },
            new DialogueNode { SpeakerText = "Иначе могут быть штрафы.", Options = null },

            new DialogueNode
            {
                SpeakerText = "Как вы планируете действовать?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Сделаю всё вовремя", Score = 1f },
                    new DialogueOption { Text="Попробую разобраться потом", Score = 0.25f },
                    new DialogueOption { Text="Пусть бухгалтер решает", Score = 0.5f },
                    new DialogueOption { Text="Налоги? А зачем?", Score = 0f }
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
