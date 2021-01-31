using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Item", menuName = "Create Item", order = 0)]
    public class Item : ScriptableObject
    {
        public string Name;
        public List<string> Paragraphs;
    }
}