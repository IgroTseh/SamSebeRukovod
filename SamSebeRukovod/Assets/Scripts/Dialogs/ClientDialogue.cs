using System.Collections.Generic;

public class ClientDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _currentIndex;

    public ClientDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Почему вы производите этот продукт?", Options = null },
            new DialogueNode { SpeakerText = "Какова его цель для клиентов?", Options = null },

            new DialogueNode { SpeakerText = "Для чего вы стараетесь?", Options = null },
            new DialogueNode { SpeakerText = "Какие задачи решает продукт?", Options = null },

            new DialogueNode
            {
                SpeakerText = "Выберите свой подход:",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Решать реальные проблемы людей", Score = 1f },
                    new DialogueOption { Text="Потому что это интересно", Score = 0.5f },
                    new DialogueOption { Text="Просто чтобы заработать деньги", Score = 0.25f },
                    new DialogueOption { Text="Я не знаю", Score = 0f }
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
