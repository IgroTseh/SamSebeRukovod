using System.Collections.Generic;

public class AccountantDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public AccountantDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Ало? Да. Здравствуйте.", Options = null },
            new DialogueNode { SpeakerText = "Здравствуйте. Я ваш экономический консультат. И уменя предлоежние.", Options = null },
            new DialogueNode { SpeakerText = "Вы продаете бипки за 500. Себестоимость 300. Почему не 700? ", Options = null },
            new DialogueNode { SpeakerText = "Боюсь потерять клиентов.", Options = null },
            new DialogueNode { SpeakerText = "Вы сейчас теряете не клиентов, а прибыль", Options = null },
            new DialogueNode { SpeakerText = "Ваши бипки экологичны. Продавайте не товар, а «зелёный имидж»!", Options = null },
            new DialogueNode
            {
                SpeakerText = "Как вам моё предложение?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Идея — огонь! Так и сделаю! Купи бипку.", Score=0.6f },
                    new DialogueOption { Text="Хмм, возможно идея неплохо. Надо проанализировать.", Score=1f },
                    new DialogueOption { Text="Буду работать по-старинке. Так надёжнее.", Score=0.3f },
                    new DialogueOption { Text="Я не разговариваю с мошенниками. До свидания!", Score=0f }
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
