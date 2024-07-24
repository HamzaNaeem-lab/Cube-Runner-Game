using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject GamaOverPanel;
    public GameObject taptostart;
    public GameObject scoretext;

    private void Start()
    {
       GamaOverPanel.SetActive(false);
       taptostart.SetActive(true);
       scoretext.SetActive(false);
       pausegame();
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            startgame();
        }
    }

    public void GameOver()
    {
        scoretext.SetActive(false);
        GamaOverPanel.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene("Game");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void pausegame()
    {
        Time.timeScale = 0f;
    }
    public void startgame()
    {
        scoretext.SetActive(true);
        taptostart.SetActive(false);
        Time.timeScale = 1f;
    }
}
