using AMA;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIUtils : MonoBehaviour
{
    public static UIUtils instance;

    [Header("HUD")]
    [SerializeField] TMP_Text scoreText;

    [Header("Menus")]
    [SerializeField] GameObject pauseMenuGameObject;
    [SerializeField] GameObject victoryScreenGameObject;
    [SerializeField] GameObject defeatScreenGameObject;
    [SerializeField] GameObject pauseButton;

    #region Monobehaviour
    private void Awake()
    {
        // Instance setup
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        // Ensure pause menu is deactivated
        if (pauseMenuGameObject != null && pauseMenuGameObject.activeSelf)
        {
            Debug.LogWarning("Pause menu was deactivated!");
            TogglePause(false);
        }

        // Ensure Victory screen is deactivated
        if (victoryScreenGameObject != null && victoryScreenGameObject.activeSelf)
        {
            Debug.LogWarning("Victory menu was deactivated!");
            ToggleVictoryScreen(false);
        }

        // Ensure Defeat screen is deactivated
        if (defeatScreenGameObject != null && defeatScreenGameObject.activeSelf)
        {
            Debug.LogWarning("Defeat menu was deactivated!");
            ToggleDefeatScreen(false);
        }

    }
    #endregion

    #region Methods
    public void UpdateScore(int _newScore)
    {
        scoreText.text = _newScore.ToString();
    }

    public void ToggleVictoryScreen(bool _isToggle)
    {
        victoryScreenGameObject.SetActive(_isToggle);
        pauseButton.SetActive(!_isToggle);
    }

    public void ToggleDefeatScreen(bool _isToggle)
    {
        defeatScreenGameObject.SetActive(_isToggle);
        pauseButton.SetActive(!_isToggle);
    }

    public void TogglePause(bool _isToggle)
    {
        pauseMenuGameObject.SetActive(_isToggle);
        pauseButton.SetActive(!_isToggle);

        Time.timeScale = _isToggle ? 0.0f : 1.0f;
    }

    public void Resume()
    {
        TogglePause(false);
    }


    public void LoadMainMenu()
    {
        // Reset Time Scale
        Time.timeScale = 1.0f;

        // Save score
        GameManager.instance.CompareAndSetHighscore(GameManager.instance.CurrentScore);

        SceneManager.LoadScene("MainMenu");
        AMAMain.StopAll();
    }
    #endregion

}
