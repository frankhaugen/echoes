using UnityEngine;

namespace ScriptableObjects
{
    public class ItemWrapper : MonoBehaviour
    {
        public Item Item;
        
        
        void Start()
        {
            var spriteRenderer = gameObject.AddComponent<SpriteRenderer>();

            spriteRenderer.sprite = Item.Sprite;
        }
    }
}
