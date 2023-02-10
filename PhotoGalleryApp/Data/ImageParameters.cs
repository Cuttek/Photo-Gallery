namespace PhotoGalleryApp.Data
{
    public class ImageParameters
    {

        public int Width { get; set; }
        public int Height { get; set; }
        static Random random=new Random(0);
        public ImageParameters() { }
        public ImageParameters(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public static ImageParameters RequestImageParameters(string resolution, string orientation)
        {
            int length1, length2;
            length1 = GetLengthFromParameter(resolution);
            length2 = GetLengthFromParameter(resolution);
            switch (orientation)
            {
                case "Squares":
                    length1 = length2;
                    break;
                case "Landscapes":
                    if (length1 < length2)
                    {
                        swap(ref length1, ref length2);
                    }
                    while (length1*.85 < length2)
                    {
                        length2 = (int)(length2 * .85);
                    }
                    break;
                case "Portraits":
                    if (length1 > length2)
                    {
                        swap(ref length1, ref length2);

                    }
                    while (length1 > length2*.85)
                    {
                        length1 =(int)(length1*.85);
                    }
                    break;

            }


            return new ImageParameters(length1, length2);
        }
        static int GetLengthFromParameter(string resolution)
        {
            switch (resolution)
            {
                case "Low":
                    return random.Next(300, 600);
                case "Medium":
                    return random.Next(600, 900);
                case "High":
                    return random.Next(900, 1200);
            }
            return 0;
        }
        static void swap(ref int source, ref int target)
        {
            int temp;
            temp = source;
            source = target;
            target = temp;

        }
        public static void SetSeed(int seed)
        {
            random = new Random(seed);
        }
    }
}
