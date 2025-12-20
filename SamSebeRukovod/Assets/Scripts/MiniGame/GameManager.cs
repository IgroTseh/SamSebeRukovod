using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;

    public int Health = 5;
    public int Profit = 0;
    public int ProfitToWin = 20;

    [Header("UI")]
    public TMP_Text HealthText;
    public TMP_Text ProfitText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    public void CatchTask(Task.TaskType type)
    {
        Profit += 1;
        UpdateUI();
    }

    public void MissTask()
    {
        Health -= 1;
        UpdateUI();

        if (Health <= 0)
        {
            EndGame();
        }
    }

    private void UpdateUI()
    {
        if (HealthText != null) HealthText.text = "Health: " + Health;
        if (ProfitText != null) ProfitText.text = "Profit: " + Profit;
    }

    private void EndGame()
    {
        if (Profit >= ProfitToWin)
        {
            Debug.Log("Победа! Вы готовы к насыщенной самозанятости.");
        }
        else
        {
            Debug.Log("Проигрыш. Нужно набраться сил.");
        }

        SceneManager.LoadScene("MainMenu"); // например, возвращаем на меню
    }
}
