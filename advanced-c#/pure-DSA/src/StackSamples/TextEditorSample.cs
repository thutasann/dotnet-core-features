using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pure_DSA.src.StackSamples
{
    /// <summary>
    /// Text Editor Undo Functionality
    /// </summary>
    public class TextEditor
    {
        private StringBuilder text = new();
        private Stack<string> undoStack = new();

        public void AddText(string newText)
        {
            text.Append(newText);
            undoStack.Push(newText);
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                string lastChange = undoStack.Pop();
                Console.WriteLine("lastChange " + lastChange);
                int lengthToRemove = lastChange.Length;
                text.Remove(text.Length - lengthToRemove, lengthToRemove);
            }
            else
            {
                Console.WriteLine("No more undo operations available.");
            }
        }

        public void PrintText()
        {
            Console.Write("Current Text: ");
            Console.Write(text);
            Console.WriteLine();
        }
    }

    public static class TextEditorUsage
    {
        public static void SampleOne()
        {
            Console.Write("\nText Editor Stack Sample ==> ");
            TextEditor editor = new();

            editor.AddText("Hello");
            editor.PrintText();

            editor.AddText("World!!");
            editor.PrintText();

            editor.Undo();
            editor.PrintText();

            editor.Undo();
            editor.PrintText();

        }
    }
}