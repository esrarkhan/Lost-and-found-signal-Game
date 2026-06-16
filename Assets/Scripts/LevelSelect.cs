using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void LoadEasy()
    {
        PlayerPrefs.SetString("SelectedLevel", "Easy");
        SceneManager.LoadScene("LoadingScreen");
    }

    public void LoadMedium()
    {
        PlayerPrefs.SetString("SelectedLevel", "Medium");
        SceneManager.LoadScene("LoadingScreen");
    }

    public void LoadHard()
    {
        PlayerPrefs.SetString("SelectedLevel", "Hard");
        SceneManager.LoadScene("LoadingScreen");
    }
}
