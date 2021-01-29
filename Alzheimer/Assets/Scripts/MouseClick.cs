using UnityEditor;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log($"{Input.mousePosition}");        
    }
}
