using System.Collections.Generic;

public class ClientDialogue : IDialogue {
    private List<DialogueNode> _nodes;
    private int _index;

    public ClientDialogue()
    {
        _nodes = new List<DialogueNode>
        {
            new DialogueNode { SpeakerText = "Клиент: Здрасте. Тут бипками торгуют?", Options = null },
            new DialogueNode { SpeakerText = "Вы: Ну здрасте. Если вы про лучшие в городе бипки. То да, это к нам.", Options = null },
            new DialogueNode { SpeakerText = "Клиент: Лучшие?! Да они ломаются после первого обуревания!", Options = null },
            new DialogueNode
            {
                SpeakerText = "Клиент: Ерунда эти ваши бипки!",
                Options = new DialogueOption[]
                {
                    new DialogueOption { Text="Вам досталась бракованная бипка. Давайте я бесплатно заменю её на новую!", Score=0.6f },
                    new DialogueOption { Text="Я надеюсь...ты правильно понял, что такое «обуревание»...да?", Score=0f },
                    new DialogueOption { Text="Вы не прочитали инструкцию перед применением. Наши бипки необуреваемы. Купите новую бипку!", Score=0.3f },
                    new DialogueOption { Text="Расскажите пожалуйста подробнее про ваш опыт обуревания бипки и её недостатки. Я зафиксирую.", Score=1f }
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
