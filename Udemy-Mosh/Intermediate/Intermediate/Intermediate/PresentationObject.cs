namespace Intermediate
{
    public class PresentationObject
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied into clipboard ");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }

    }
    
}
 