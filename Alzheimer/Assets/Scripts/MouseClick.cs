using UnityEngine;
using UnityEngine.UI;

public class MouseClick : MonoBehaviour
{
    public Text Text;
    
    private void OnMouseDown()
    {
        Debug.Log($"{Input.mousePosition}");
        
    }
}
