using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingActions : MonoBehaviour {
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button exitButton;

    public void Initialize()
    {
        playAgainButton.onClick.AddListener(PlayAgain);
        exitButton.onClick.AddListener(Exit);
    }

    private void PlayAgain()
    {
        PlayerPrefs.DeleteKey("Profit");
        SceneManager.LoadScene("Dialogs");
    }

    private void Exit()
    {
        PlayerPrefs.DeleteKey("Profit");
        Application.Quit();
    }
}
