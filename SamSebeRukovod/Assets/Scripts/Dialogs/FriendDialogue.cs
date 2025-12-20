using System.Collections.Generic;

public class FriendDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public FriendDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            // Игрок
            new DialogueNode
            {
                SpeakerText = "Привет. Как ты?",
                Options = null
            },
            new DialogueNode
            {
                SpeakerText = "Ты всё ещё в офисе?",
                Options = null
            },

            // Друг
            new DialogueNode
            {
                SpeakerText = "Да… всё там же.",
                Options = null
            },
            new DialogueNode
            {
                SpeakerText = "Каждый день одно и то же. Уже подташнивает.",
                Options = null
            },

            // Вопрос
            new DialogueNode
            {
                SpeakerText = "А ты сам задумывался о чём-то своём?",
                Options = new DialogueOption[]
                {
                    new DialogueOption
                    {
                        Text = "Да, хочу попробовать своё дело",
                        Score = 1f
                    },
                    new DialogueOption
                    {
                        Text = "Иногда думаю, но страшно",
                        Score = 0.5f
                    },
                    new DialogueOption
                    {
                        Text = "Пока просто мысли",
                        Score = 0.25f
                    },
                    new DialogueOption
                    {
                        Text = "Нет, стабильность важнее",
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
