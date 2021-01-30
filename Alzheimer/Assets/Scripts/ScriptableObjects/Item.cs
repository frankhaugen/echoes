using System.Collections.Generic;
using Models.Enums;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Item", menuName = "Create Item", order = 0)]
    public class Item : ScriptableObject
    {
        public string Name;
        public ArticleName ArticleName;
        public List<string> Paragraphs;
        public Sprite Sprite;
        public ItemType ItemType;
    }
}