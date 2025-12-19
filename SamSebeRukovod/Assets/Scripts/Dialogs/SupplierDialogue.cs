using System.Collections.Generic;

public class SupplierDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public SupplierDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Нужны условия оплаты и доставки.", Options = null },
            new DialogueNode { SpeakerText = "Когда сможете согласовать?", Options = null },

            new DialogueNode { SpeakerText = "Вы готовы заключить договор?", Options = null },
            new DialogueNode { SpeakerText = "И как будете работать с поставками?", Options = null },

            new DialogueNode
            {
                SpeakerText = "Как действуем?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Договоримся прямо сейчас", Score = 1f },
                    new DialogueOption { Text="Позже уточним детали", Score = 0.5f },
                    new DialogueOption { Text="Пусть будет как у всех", Score = 0.25f },
                    new DialogueOption { Text="Не важно", Score = 0f }
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
