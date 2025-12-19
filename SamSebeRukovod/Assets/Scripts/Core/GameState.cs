public static class GameState {
    public static float RiskScore = 0f;  // очки диалогов
    public static int Profit = 0;        // прибыль мини-игры
    public static int Health = 3;        // здоровье игрока

    public static void Reset()
    {
        RiskScore = 0f;
        Profit = 0;
        Health = 3;
    }
}
