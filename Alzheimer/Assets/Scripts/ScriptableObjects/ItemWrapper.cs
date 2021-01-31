using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace ScriptableObjects
{
    public class ItemWrapper : MonoBehaviour
    {
        public Item Item;
        
        public Text Header;
        public Text Body;
        
        void Start()
        {
            Refresh();
        }
        
        public void Refresh()
        {
            Header.text = Item.Name;
            if (Item.Paragraphs.Any())
            {
                Body.text = string.Join("\n\n", Item.Paragraphs);
            }
        }
    }
}
