using System.Collections.Generic;

public class SupplierDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public SupplierDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Поставщик: Здравствуйте. Давайте продлим договор на поставки!", Options = null },
            new DialogueNode { SpeakerText = "Поставщик: Я вам ещё много товара доставлю!", Options = null },
            new DialogueNode { SpeakerText = "Вы: Здравствуйте. Новый договр — дело-то хорошее.", Options = null },
            new DialogueNode { SpeakerText = "Вы: Но вы мне уже задерживаете партию форм для бибок на 3 месяца.", Options = null },
            new DialogueNode { SpeakerText = "Вы: Я несу убытки!", Options = null },
            new DialogueNode { SpeakerText = "Поставщик: Мы тут честные уважаемые люди. Всё будет. Даю слово.", Options = null },
            new DialogueNode
            {
                SpeakerText = "Поставщик: А если вы откажитесь...Не завидую я вашему дельцу.",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Купи бипку. Целую партию. Ту самую, что задерживается. Тогда поговорим.", Score=0.3f },
                    new DialogueOption { Text="Ясно. Пойду других поставщиков поищу.", Score=0.6f },
                    new DialogueOption { Text="Ладно, подпишу. Мы же оба самозанятые. На одной стороне баррикады!", Score=0.0f },
                    new DialogueOption { Text="Ало, юрист? Мне тут неустойку нужно взискать. А ещё упущенную выгоду. И моральный ущерб.", Score=0f }
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
