using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string URL;
        
    private void OnMouseDown()
    {
        Application.OpenURL(URL);
    }
}