using System;
using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            // 1. String Immutability (ToUpper())
            Console.WriteLine("=== Question 1 ===");
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"Original title: {title}");
            Console.WriteLine($"Upper title: {upperTitle}\n");

            // 2. Reference Equality (ReferenceEquals())
            Console.WriteLine("=== Question 2 ===");
            string bookOne = "Clean Code";
            string bookTwo = "Clean Code";
            bool areSameReference = object.ReferenceEquals(bookOne, bookTwo);
            Console.WriteLine($"Same reference in memory: {areSameReference}\n");

            // 3. StringBuilder (Append())
            Console.WriteLine("=== Question 3 ===");
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine($"{sb}\n");

            // 4. StringBuilder (Replace())
            Console.WriteLine("=== Question 4 ===");
            sb.Replace("Book List", "Library");
            Console.WriteLine($"{sb}\n");

            // 5. String Concatenation (+ Operator)
            Console.WriteLine("=== Question 5 ===");
            string bookTitle = "Clean Code";
            int pages = 464;
            string sentencePlus = "Book: " + bookTitle + ", Pages: " + pages;
            Console.WriteLine($"{sentencePlus}\n");

            // 6. String Interpolation ($"...")
            Console.WriteLine("=== Question 6 ===");
            string sentenceInterpolated = $"Book: {bookTitle}, Pages: {pages}";
            Console.WriteLine($"{sentenceInterpolated}\n");

            // 7. string.Format()
            Console.WriteLine("=== Question 7 ===");
            string sentenceFormatted = string.Format("Book: {0}, Pages: {1}", bookTitle, pages);
            Console.WriteLine($"{sentenceFormatted}\n");

            // 8. if / else Statement
            Console.WriteLine("=== Question 8 ===");
            if (pages > 300)
            {
                Console.WriteLine("Long Book\n");
            }
            else
            {
                Console.WriteLine("Short Book\n");
            }

            // 9. Logical AND (&&)
            Console.WriteLine("=== Question 9 ===");
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book\n");
            }

            // 10. switch Statement
            Console.WriteLine("=== Question 10 ===");
            string switchTitle = "Refactoring";
            switch (switchTitle)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!\n");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!\n");
                    break;
                default:
                    Console.WriteLine("Never heard of it\n");
                    break;
            }

            // 11. Ternary Operator (? :)
            Console.WriteLine("=== Question 11 ===");
            string sizeLabel = (pages > 300) ? "Long Book" : "Short Book";
            Console.WriteLine($"{sizeLabel}\n");

            // 12. for Loop with Position Number
            Console.WriteLine("=== Question 12 ===");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            Console.WriteLine();

            // 13. while Loop
            Console.WriteLine("=== Question 13 ===");
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            Console.WriteLine();

            // 14. do-while Loop
            Console.WriteLine("=== Question 14 ===");
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            Console.WriteLine();

            // 15. foreach Loop
            Console.WriteLine("=== Question 15 ===");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();

            // 16. Loop with break
            Console.WriteLine("=== Question 16 ===");
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }
            Console.WriteLine();

            // 17. Loop with continue
            Console.WriteLine("=== Question 17 ===");
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }
            Console.WriteLine();

            // 18. Method with Early return
            Console.WriteLine("=== Question 18 ===");
            PrintFirstBook(books);
            PrintFirstBook(Array.Empty<string>()); // Does not print anything
        }

        static void PrintFirstBook(string[] books)
        {
            if (books == null || books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }