using System;

namespace Models.Wikipedia
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class Summary    {
        public string Type { get; set; } 
        public string Title { get; set; } 
        public string Displaytitle { get; set; } 
        public Namespace Namespace { get; set; } 
        public string WikibaseItem { get; set; } 
        public Titles Titles { get; set; } 
        public int Pageid { get; set; } 
        public Thumbnail Thumbnail { get; set; } 
        public Originalimage Originalimage { get; set; } 
        public string Lang { get; set; } 
        public string Dir { get; set; } 
        public string Revision { get; set; } 
        public string Tid { get; set; } 
        public DateTime Timestamp { get; set; } 
        public string Description { get; set; } 
        public string DescriptionSource { get; set; } 
        public ContentUrls ContentUrls { get; set; } 
        public string Extract { get; set; } 
        public string ExtractHtml { get; set; } 
    }
}