using System.Collections.Generic;

public class ITDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public ITDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Хай! А у вас есть эко-френдли бабл-ти с миндалевым молоком и стевией?", Options = null },
            new DialogueNode { SpeakerText = "Эм.. Нет. Вы ошиблись адресом. Мы бипки продаем.", Options = null },
            new DialogueNode { SpeakerText = "Бибки? Как классно! Кстати как раз недавно делал проект для подобного производства...", Options = null },
            new DialogueNode
            {
                SpeakerText = "А вы как за производством вообще следите? Могу помочь с автоматизацией, если что...",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Давай-ка настроим мне CRM, ERP и аналитику", Score=1f },
                    new DialogueOption { Text="Всё в голове держу. Кстати, а какой сегодня месяц...?", Score=0f },
                    new DialogueOption { Text="Бумага и ручка — мои лучшие друзья.", Score=0.3f },
                    new DialogueOption { Text="Хватает электронных таблиц. А тебе не хватает бипки. Купи бипку.", Score=0.6f }
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
