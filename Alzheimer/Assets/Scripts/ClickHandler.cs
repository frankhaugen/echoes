using ScriptableObjects;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public Canvas Overlay;
    public Item Item;
    
    private void OnMouseDown()
    {
        Overlay.gameObject.SetActive(!Overlay.gameObject.activeSelf);
        var itemWrapper = Overlay.gameObject.GetComponent<ItemWrapper>();
        itemWrapper.Item = Item;
        itemWrapper.Refresh();
    }
}
