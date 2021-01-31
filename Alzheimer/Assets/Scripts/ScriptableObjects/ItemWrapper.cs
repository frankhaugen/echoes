using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

namespace ScriptableObjects
{
    public class ItemWrapper : MonoBehaviour
    {
        public Item Item;
        
        public Text Name;
        // public ArticleName ArticleName;
        // public ItemType Type;
        public Image Image;
        // public Text Description;
        
        void Start()
        {
            Name.text = Item.Name;
            // ArticleName = Item.ArticleName;
            // Type = Item.ItemType;
            Image.sprite = Item.Sprite;
            // SetDescription();
        }

        void SetDescription()
        {
            // if (Type == ItemType.Interesting)
            // {
                // var wikipedia = new Wikipedia();
                // var summary = wikipedia.GetSummary(ArticleName);
                // Description.text = summary.Extract;
            // }
            // else if (Type == ItemType.Story)
            // {
                // Description.text = string.Join("\n\n", Item.Paragraphs);
            // }
            // else
            // {
            //     Description.text = "Error!";
            // }
        }
    }
}
