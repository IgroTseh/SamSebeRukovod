using System;

public static class EventBus {
    // Диалоги
    public static Action<DialogueNode> OnNextNode;
    public static Action<float> OnAnswerSelected;
    public static Action OnDialogueEnd;

    // Результаты
    public static Action<float> OnResultCalculated;

    // Мини-игра
    public static Action OnMiniGameStart;
    public static Action<int> OnProfitChanged;
    public static Action<int> OnHealthChanged;
    public static Action<bool> OnMiniGameEnd;
}
