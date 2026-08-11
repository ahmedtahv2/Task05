namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Book book;
            //Console.WriteLine(book.password);
            ////we cant reach it because it's private we can only access it from the class 
            #endregion

            #region Q2
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            ////we can access it because we can access internal when we are in the same 
            #endregion project

            #region Q3
            //Book book = new Book();
            //book.Title = "Test";
            //Console.WriteLine(book.Title); 
            #endregion

            #region Q4
            //Book book = new Book();
            //book.genre = Genre.science;
            //Console.WriteLine(book.genre); 
            #endregion

            #region Q5
            //Book book = new Book();
            //book.genre = Genre.fiction;
            //Console.WriteLine((int)book.genre);
            //book.genre = Genre.NonFiction;
            //Console.WriteLine((int)book.genre); 
            #endregion
        }
    }
}
