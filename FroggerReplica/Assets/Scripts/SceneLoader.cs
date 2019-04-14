using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void loadMain() { SceneManager.LoadScene("MainMenu"); }
    public void loadHighScore() { SceneManager.LoadScene("HighScores"); }
    public void loadGame() { SceneManager.LoadScene("Game"); }
    public void loadGameOver() { SceneManager.LoadScene("End"); }
    public void loadSettings() { SceneManager.LoadScene("Settings"); }
}
