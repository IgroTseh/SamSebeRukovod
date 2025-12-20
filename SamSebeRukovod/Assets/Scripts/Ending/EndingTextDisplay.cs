using UnityEngine;
using TMPro;

public class EndingTextDisplay : MonoBehaviour {
    [SerializeField] private TMP_Text endingText;   // Текст с концовкой

    public void ShowGoodEnding(int profit)
    {
        endingText.text = $"Поздравляем! \n\nВы достигли успеха, который вдохновляет других! С таким подходом к делу, впереди только победы. \n\nИтоговый результат: <b>{profit}</b> прибыли! Бизнес-империя на горизонте!";
    }

    public void ShowBadEnding(int profit)
    {
        endingText.text = $"Не всё потеряно. \n\nВы справились, но могли бы и лучше. Итоговый результат: <b>{profit}</b> прибыли. Нужно больше опыта, но всё впереди!";
    }
}
