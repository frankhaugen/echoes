using UnityEngine;
using UnityEngine.UI;

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
