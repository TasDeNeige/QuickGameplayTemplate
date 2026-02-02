using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUtils : MonoBehaviour
{
    [SerializeField] TMP_Text highscoreText;

    #region Monobehaviour
    void Start()
    {
        // Display highscore
        if (highscoreText != null)
        {
            highscoreText.text = "Highscore: " + (GameManager.instance.Highscore).ToString();
        }
    }
    #endregion

    #region Methods
    public void LoadLevel(string _scene)
    {
        GameManager.instance.CurrentScore = 0;
        SceneManager.LoadScene(_scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    #endregion
}
