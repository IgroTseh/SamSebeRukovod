using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueResultUI : MonoBehaviour {
    [Header("UI")]
    [SerializeField] private TMP_Text resultText;       // Сюда перетащи текстовое поле
    [SerializeField] private Button continueButton;     // Сюда перетащи кнопку

    private void Awake()
    {
        if (continueButton != null)
            continueButton.onClick.AddListener(OnContinueClicked);

        if (resultText == null)
            Debug.LogError("DialogueResultUI: resultText не назначен!");
    }

    // Вызываем вручную из DialogueSystem
    public void ShowResult()
    {
        if (resultText == null) return;

        float score = GameState.RiskScore;
        string text;

        if (score >= 6.75f)
            text = "Да вы прирождённая акула бизнеса!!";
        else if (score >= 4.25f)
            text = "Кажется, вы можете попробовать открыть своё дело.";
        else if (score > 2.15f)
            text = "В вас есть задатки предпринимателя, но многое будет неприятно. Есть только один способ проверить — попробовать!";
        else
            text = "Кажется, вам не особо это надо) Вы слишком крутой спец, и без вас вашему боссу придётся туго.";

        resultText.text = text;
        gameObject.SetActive(true); // обязательно активируем панель
    }

    private void OnContinueClicked()
    {
        SceneManager.LoadScene("MiniGame");
    }
}
