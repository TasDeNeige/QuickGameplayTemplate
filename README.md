# Quick Gameplay Template
Template project for Quick Gameplay iterations with multiple ready-to-use functions for highscore and victory/defeat.
> Embarks a WIP version of the Ama Motion Automatiser.


![QGTShowcase](https://github.com/user-attachments/assets/9adbeac2-8980-4279-9715-f564d3f1eff0)


# Features
## Main menu
• Editable background (can change sprite)<br>
• Button to load first level<br>
• Displays player's highscore

<br>

## Sample level
• Pause menu<br>
• Callable victory & defeat screens<br>
• Display current score

<br><br>

# Functions
## Score & Highscore

### • `Get/Set current score`
Get Player's current score (i.e. score during this game) 

**Variable:** `int currentScore`
<br>**Usage:**
```cs
GameManager.instance.CurrentScore
```

<br>

### • `Update score display`
Update Score display in game

**Function:** `public void UpdateScore(int _newScore)`
<br>**Usage:**
```cs
UIUtils.instance.UpdateScore(score);
```

<br>

### • `Get highscore from PlayerPrefs`
Retrieve highscore from PlayerPrefs

**Function:** `public int GetHighscoreFromPlayerPrefs()`
<br>**Usage:**
```cs
GameManager.instance.GetHighscoreFromPlayerPrefs();
```

<br>

### • `Set highscore`
Change highscore and saves it in PlayerPrefs

**Function:** `public void SetHighscore(int _newScore)`
<br>**Usage:**
```cs
GameManager.instance.SetHighscore(score);
```

<br>

### • `Compare and Set highscore`
Automatically compare given score to registered highscore and updates it if needed.

**Function:** `public void CompareAndSetHighscore(int _newScore)`
<br>**Usage:**
```cs
GameManager.instance.CompareAndSetHighscore(score);
```

<br><br>

## UI Menus
> Available in Levels scene
<br>

### • `Pause Menu`
When activated, Time.scale is set to 0.<br>
Available options on screen are 'Resume' (quits pause menu and set Time.scale to 1) and 'Back to menu'.

**Related Function:** `public void TogglePause(bool _isToggle)`
<br>-> Activate or deactivate pause menu
<br>**Usage:**
```cs
UIUtils.instance.TogglePause(true);
```

<br>

### • `Victory Screen`
Available option on screen is 'Back to menu'.

**Related Function:** `public void ToggleVictoryScreen(bool _isToggle)`
<br>-> Activate or deactivate victory screen
<br>**Usage:**
```cs
UIUtils.instance.ToggleVictoryScreen(true);
```

<br>

### • `Defeat Screen`
Available option on screen is 'Back to menu'.

**Function:** `public void ToggleDefeatScreen(bool _isToggle)`
<br>-> Activate or deactivate defeat screen
<br>**Usage:**
```cs
UIUtils.instance.ToggleDefeatScreen(true);
```

<br><br>

## Useful functions
### • `Load main menu`
Set Time.scale to 1, compare and set highscore, load Main Menu.

**Function:** `public void LoadMainMenu()`
<br>**Usage:**
```cs
UIUtils.instance.LoadMainMenu();
```

<br>

### • `Load level`
Load a selected scene.

**Function:** `public void LoadLevel(string _scene)`
<br>**Usage:**
```cs
MainMenuUtils.instance.LoadLevel("Level1");
```

<br>

### • `Quit Game`
Quits game.

**Related Function:** `public void QuitGame()`
<br>**Usage:**
```cs
MainMenuUtils.instance.QuitGame();
```
