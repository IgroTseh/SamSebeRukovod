using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour {
    public void Play()
    {
        SceneManager.LoadScene("Dialogs");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
