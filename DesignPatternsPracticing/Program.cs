using DesignPatternsPracticing.Iterator;
using DesignPatternsPracticing.State;
using System;

namespace DesignPatternsPracticing
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- Memento Design Pattern --------------------
            //Memnto();
            // ---------------- State Design Pattern --------------------
            //State();
            ProductHistory productHistory = new ProductHistory();
            productHistory.Push("a");
            productHistory.Push("b");
            productHistory.Push("c");
            IIterator<string> it = productHistory.CreateIterator();
            while(it.HasNext())
            {
                string product = it.Current();
                Console.WriteLine(product);
                it.Next();
            }
        }

        private static void State()
        {
            Canvas canvas = new Canvas();
            canvas.CurrentTool = new Brush();
            canvas.MouseUp();
            canvas.MouseDown();
            canvas.CurrentTool = new Selection();
            canvas.MouseUp();
            canvas.MouseDown();
        }

        private static void Memnto()
        {
            // Doing something in the document.
            Document document = new Document();
            document.Content = "Design Pattern Series - Memento (1)";
            document.FontName = "Arial";
            document.FontSize = 18;
            // Printing the output on the screen
            Console.WriteLine(document.Content);
            Console.WriteLine(document.FontName);
            Console.WriteLine(document.FontSize);
            // Current State
            DocumentState documentState = document.CreateState();
            // Making CTRL+S or Having a Backup
            DocumentHistory documentHistory = new DocumentHistory();
            documentHistory.Backup(documentState);
            // Chaing something else 
            document.Content = "Now we're going to talk about first design pattern!";
            document.FontSize = 14;
            // Printing the output on the screen
            Console.WriteLine(document.Content);
            Console.WriteLine(document.FontName);
            Console.WriteLine(document.FontSize);
            // Doing an Undo 
            documentState = documentHistory.Undo();
            document.RestoreState(documentState);
            // Printing the output on the screen
            Console.WriteLine(document.Content);
            Console.WriteLine(document.FontName);
            Console.WriteLine(document.FontSize);
        }
    }
}
