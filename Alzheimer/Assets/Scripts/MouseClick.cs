using UnityEngine;

public class MouseClick : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log($"{gameObject.name}");
    }
    
    public void Click()
    {
        Debug.Log($"{gameObject.name}");
    }
}
