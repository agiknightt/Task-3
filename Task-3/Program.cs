using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int countAllImages = 52;
            int countMaxImagesOnPage = 3;
            int fullPagesWithImages = countAllImages / countMaxImagesOnPage;
            int leftImages = countAllImages % countMaxImagesOnPage;

            Console.WriteLine($"Страниц заполненых картинками: {fullPagesWithImages} \n" +
                $"Картинок сверх меры: {leftImages}");
            Console.ReadKey();
        }
    }
}
