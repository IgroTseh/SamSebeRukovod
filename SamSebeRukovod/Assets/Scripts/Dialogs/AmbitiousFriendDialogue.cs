using System.Collections.Generic;

public class AmbitiousFriendDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public AmbitiousFriendDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Вы: Ты выглядишь подавленным. Я могу как-то помочь?", Options = null },
            new DialogueNode { SpeakerText = "Друг: Ничего такого. Просто меня не взяли в художественную школу.", Options = null },
            new DialogueNode { SpeakerText = "Друг: Я же хотел прославиться! Искусство — это моя жизнь!", Options = null },
            new DialogueNode
            {
                SpeakerText = "Друг: Что же мне делать??",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Главное не иди в политику.", Score=0.3f },
                    new DialogueOption { Text="Сдайся. Это слишком сложно.", Score=0f },
                    new DialogueOption { Text="Купи бипку! Уверен, тебе станет лучше!", Score=0.6f },
                    new DialogueOption { Text="Может нарисуешь мне постер для рекламы бипок?", Score=1f }
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
