using System.Collections.Generic;
using Models.Enums;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Item", menuName = "Create Item", order = 0)]
    public class Item : ScriptableObject
    {
        public new string Name;
        public List<string> Paragraphs;
        public Sprite Sprite;
        public ItemType ItemType;
    }
}