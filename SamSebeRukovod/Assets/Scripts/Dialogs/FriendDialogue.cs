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
                SpeakerText = "Привет, друг. Слышал ты теперь предприниматель.  Хах, должно быть поинтереснее, чем там в офисе.",
                Options = null
            },
            new DialogueNode
            {
                SpeakerText = "Менеджер опять лютует. А что это у тебя на прилавке? ",
                Options = null
            },

            // Друг
            new DialogueNode
            {
                SpeakerText = "Бипки.",
                Options = null
            },
            new DialogueNode
            {
                SpeakerText = "Я произвожу и продаю бипки.",
                Options = null
            },

            // Вопрос
            new DialogueNode
            {
                SpeakerText = "И … зачем ты этим занимаешься? ",
                Options = new DialogueOption[]
                {
                    new DialogueOption
                    {
                        Text = "Прост)",
                        Score = 0f
                    },
                    new DialogueOption
                    {
                        Text = "В офисе скучно. Он не отвечает моим амбициям",
                        Score = 0.6f
                    },
                    new DialogueOption
                    {
                        Text = "Мне это нравится. ",
                        Score = 0.3f
                    },
                    new DialogueOption
                    {
                        Text = " Я живу бибками. Это самореализация.",
                        Score = 1f
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
