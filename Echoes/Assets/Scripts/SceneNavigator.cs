using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public string TargetSceneName;
    // public GameObject Music;
    
    private void OnMouseDown()
    {
        GoToScene();
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(TargetSceneName);
        // SceneManager.MoveGameObjectToScene(Music, SceneManager.GetSceneByName(TargetSceneName));
    }
}
