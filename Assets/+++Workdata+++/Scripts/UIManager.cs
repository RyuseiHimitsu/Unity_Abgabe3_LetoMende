using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Defining
    public GameObject MainMenuPanel;
    public GameObject LevelSelectPanel;
    public GameObject LostPanel;
    public GameObject WinPanel;
    public Timer timer;

    public bool canMove;
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MainMenuPanel.SetActive(true);
        LostPanel.SetActive(false);
        WinPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        canMove = true;
    }

    public void OpenMainMenuPanel()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void OpenLevelOne()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenLevelTwo()
    {
        SceneManager.LoadScene("LevelTwoScene");
    }

    public void OpenLostPanel()
    {
        LostPanel.SetActive(true);
        canMove = false;
        timer.gamePaused = true;
    }

    public void OpenWinPanel()
    {
        WinPanel.SetActive(true);
        canMove = false;
        timer.gamePaused = true;
    }

    public void OpenLevelSelectPanel()
    {
        LevelSelectPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }
}
