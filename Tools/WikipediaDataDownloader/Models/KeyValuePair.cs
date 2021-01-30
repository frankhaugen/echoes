using System;

namespace WikipediaDataDownloader.Models
{
    public class KeyValuePair<TKey, TValue> where TValue : class, new() where TKey : Enum
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
