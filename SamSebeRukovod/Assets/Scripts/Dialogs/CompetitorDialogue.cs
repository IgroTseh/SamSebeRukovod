using System.Collections.Generic;

public class CompetitorDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public CompetitorDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Это ты у нас бипками торугешь?", Options = null },
            new DialogueNode { SpeakerText = "Да. Отвязные бипки.", Options = null },
            new DialogueNode { SpeakerText = "Этот город слишком тесен для нас двоих...", Options = null },
            new DialogueNode { SpeakerText = "Для моего бутика бипок и твоего ларька. Хе-хе!", Options = null },
            new DialogueNode { SpeakerText = "Пойду-ка я к себе, пока твой объект не отобрали приставы...", Options = null },
            new DialogueNode
            {
                SpeakerText = "Хмм...Конкуренция. Как я превзойду своего соперника?",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Его склад находится в деревянном доме. А у меня есть канистра бензина...", Score=0f },
                    new DialogueOption { Text="Сброшу цену. Займусь демпингом.", Score=0.6f },
                    new DialogueOption { Text="(крикнуть) Купи бипку. Проведи исследование своего конкруента!", Score=0.3f },
                    new DialogueOption { Text="Пора вложиться в маркетинг и рекламу. Пора завести свои соцсети.", Score=1f }
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
