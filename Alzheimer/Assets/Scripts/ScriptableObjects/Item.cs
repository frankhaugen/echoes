using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "NewItem", menuName = "Item", order = 1)]
    public class Item : ScriptableObject {

        public new string name = "NewItem";
        public MouseClick MouseClick { get; set; }
        public Sprite sprite = null;
    }
}