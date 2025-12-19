using UnityEngine;
using TMPro;

public class ResultUI : MonoBehaviour {
    public TMP_Text resultText;

    private void OnEnable()
    {
        EventBus.OnResultCalculated += ShowResult;
    }

    private void OnDisable()
    {
        EventBus.OnResultCalculated -= ShowResult;
    }

    void ShowResult(float score)
    {
        if (score >= 7f)
            resultText.text = "Да вы прирождённая акула бизнеса!!";
        else if (score >= 5f)
            resultText.text = "Кажется, вы можете попробовать открыть своё дело.";
        else if (score >= 3f)
            resultText.text = "В вас есть задатки предпринимателя, но многое будет неприятным. Попробуйте!";
        else
            resultText.text = "Кажется, вам не особо это надо) Вы слишком крутой спец, и без вас вашему боссу придётся туго.";
    }
}
