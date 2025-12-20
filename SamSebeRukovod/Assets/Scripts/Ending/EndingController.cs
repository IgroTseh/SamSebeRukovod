using UnityEngine;
using TMPro;

public class EndingController : MonoBehaviour {
    [Header("References")]
    [SerializeField] private EndingTextDisplay textDisplay;
    [SerializeField] private EndingActions actions;

    [Header("Game Settings")]
    public int profitThreshold = 20;

    private void Start()
    {
        // Получаем прибыль из PlayerPrefs
        int playerProfit = PlayerPrefs.GetInt("Profit", 0);

        if (playerProfit >= profitThreshold)
        {
            textDisplay.ShowGoodEnding(playerProfit);
        }
        else
        {
            textDisplay.ShowBadEnding(playerProfit);
        }

        actions.Initialize();
    }
}
