using UnityEngine;

public class CloseDialog : MonoBehaviour
{
    public Canvas Overlay;

    void OnMouseDown()
    {
        Overlay.gameObject.SetActive(false);
    }
}
