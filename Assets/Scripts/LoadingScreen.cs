using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingBar;
    public float loadingTime = 3f;
    public string nextSceneName = "Hard";

    private float timer = 0f;

    void Start()
    {
        if (loadingBar == null)
        {
            Debug.LogError("Loading Bar is NOT connected!");
            return;
        }

        loadingBar.minValue = 0;
        loadingBar.maxValue = 1;
        loadingBar.value = 0;
    }

    void Update()
    {
        if (loadingBar == null) return;

        timer += Time.deltaTime;
        loadingBar.value = timer / loadingTime;

        if (timer >= loadingTime)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
