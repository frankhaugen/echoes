using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public string TargetSceneName;
    public MusicManager Music;

    private void Awake()
    {
        Music = FindObjectOfType<MusicManager>();
    }

    private void OnMouseDown()
    {
        GoToScene();
    }

    public void GoToScene()
    {
        Music.NextSong();
        SceneManager.LoadScene(TargetSceneName);
    }
}
