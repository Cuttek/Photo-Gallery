using System.ComponentModel.DataAnnotations;

namespace PhotoGalleryApp.Data
{
    public class GalleryParameters
    {
        
        public GalleryParameters() 
        { 
            Query = String.Empty;
            ImageQuantity = 0;
            Resolution=String.Empty;
            Orientation= String.Empty;
        }
        public GalleryParameters(string query, int imageQuantity,string resolution, string orientation)
        {
            Query = query;
            ImageQuantity = imageQuantity;
            Resolution = resolution;
            Orientation = orientation;
        }
        public string Query { get; set; }        
        public int ImageQuantity { get; set; }
        
        public string Resolution { get; set; }
        public string Orientation { get; set; }
       
    }
}
