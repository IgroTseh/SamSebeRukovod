using System.Collections.Generic;

public class SecondFriendDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public SecondFriendDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            // Игрок
            new DialogueNode
            {
                SpeakerText = "Друг: Привет...это снова я...",
                Options = null
            },
            new DialogueNode
            {
                SpeakerText = "Вы: Привет, дружище. Как оно?",
                Options = null
            },

            // Друг
            new DialogueNode
            {
                SpeakerText = "Друг: Устал дико. Менеджер дурак. Дедлайны горят, премии нет. Хочу всё бросить. ",
                Options = null
            },

            // Вопрос
            new DialogueNode
            {
                SpeakerText = "Друг: Но что поделать. Мне хотя бы платят нормально...",
                Options = new DialogueOption[]
                {
                    new DialogueOption
                    {
                        Text = "Потерпи. Пару лет, потом пару десятков, и вот уже пенсия!",
                        Score = 0f
                    },
                    new DialogueOption
                    {
                        Text = "Ты крутой спец. Найди работу покруче! Например у меня.",
                        Score = 0.3f
                    },
                    new DialogueOption
                    {
                        Text = "У тебя всегды был лучший маникюор! Открой свой салон!",
                        Score = 1f
                    },
                    new DialogueOption
                    {
                        Text = "Значит, можешь себе позволить бипку. Купи бипку.",
                        Score = 0f
                    }
                }
            }
        };
    }

    public DialogueNode GetNextNode()
    {
        if (_index >= _nodes.Count)
            return null;

        return _nodes[_index++];
    }
}
