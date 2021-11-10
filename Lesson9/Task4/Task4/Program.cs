using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoBook album1 = new PhotoBook();
            Console.WriteLine(album1.GetNumberPages());

            PhotoBook album2 = new PhotoBook(24);
            Console.WriteLine(album2.GetNumberPages());

            BigPhotoBook bigPhotoAlbum = new BigPhotoBook();
            Console.WriteLine(bigPhotoAlbum.GetNumberPages());
        }
        public class PhotoBook
        {
            protected int numPages;
            public PhotoBook()
            {
                numPages = 16;
            }

            public PhotoBook(int numPages)
            {
                this.numPages = numPages;
            }

            public int GetNumberPages()
            {
                return numPages;
            }
        }
        public class BigPhotoBook : PhotoBook
        {
            public BigPhotoBook()
            {
                numPages = 64;
            }
        }
    }
}
