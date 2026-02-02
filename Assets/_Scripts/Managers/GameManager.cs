using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int highscore;
    int currentScore;

    private void Awake()
    {
        // Instance setup
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        // Retrieve highscore
        GetHighscoreFromPlayerPrefs();
    }

    #region Methods
    #region Highscore
    public int GetHighscoreFromPlayerPrefs()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        return highscore;
    }

    public void CompareAndSetHighscore(int _newScore)
    {
        if (_newScore > highscore) { SetHighscore(_newScore); }
    }

    public void SetHighscore(int _newScore)
    {
        PlayerPrefs.SetInt("highscore", _newScore);
        highscore = _newScore;
    }
    #endregion
    #endregion

    #region Getters/Setters
    public int Highscore { get => highscore; set => SetHighscore(highscore);  }
    public int CurrentScore { get => currentScore; set => currentScore = value; }
    #endregion
}
