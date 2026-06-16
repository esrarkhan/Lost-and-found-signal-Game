using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoIntro : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        videoPlayer.loopPointReached += EndVideo;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            LoadGame();
        }
    }

    void EndVideo(VideoPlayer vp)
    {
        LoadGame();
    }

    void LoadGame()
    {
        string level = PlayerPrefs.GetString("SelectedLevel", "Hard");
        SceneManager.LoadScene(level);
    }
}
