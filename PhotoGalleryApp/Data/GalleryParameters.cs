using System.ComponentModel.DataAnnotations;

namespace PhotoGalleryApp.Data
{
    public class GalleryParameters
    {
        public GalleryParameters() { }
        public GalleryParameters(string query, int imageQuantity, int minWidth, int maxWidth, int minHeight, int maxHeight)
        {
            Query = query;
            ImageQuantity = imageQuantity;
            MinWidth = minWidth;
            MaxWidth = maxWidth;
            MinHeight = minHeight;
            MaxHeight = maxHeight;
        }
        public string Query { get; set; }        
        public int ImageQuantity { get; set; }
        public int MinWidth { get; set; }
        public int MaxWidth { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        
    }
}
