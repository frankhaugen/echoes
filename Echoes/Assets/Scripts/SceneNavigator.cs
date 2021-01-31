using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public string TargetSceneName;

    private void OnMouseDown()
    {
        GoToScene();
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(TargetSceneName);
    }
}
