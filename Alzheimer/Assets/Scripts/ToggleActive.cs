using UnityEngine;

public class ToggleActive : MonoBehaviour
{
    public void Click()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}