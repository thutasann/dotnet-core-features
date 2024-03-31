namespace pure_DSA.src.StackSamples
{
    public static class StackCRUD
    {
        public static void SampleOne()
        {
            Console.WriteLine("\nStack CRUD Sample One ===> ");
            Stack<string> stack = new();

            Push(stack, "Item 1");
            Push(stack, "Item 2");
            Push(stack, "Item 3");

            Console.WriteLine("Top item on the stack => " + Peek(stack));

            Update(stack, "New Updated Item");
            Console.WriteLine("Top item After update => " + Peek(stack));

            Pop(stack);
            Console.WriteLine("Top item on the stack after deletion: " + Peek(stack));
        }

        private static void Push(Stack<string> stack, string item)
        {
            stack.Push(item);
            Console.WriteLine($"Added {item} to the stack.");
        }

        private static string Peek(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                return stack.Peek();
            }
            return "Stack is empty";
        }

        private static void Pop(Stack<string> stack)
        {
            if (stack.Count > 0)
            {
                string poppedItem = stack.Pop();
                Console.WriteLine($"Removed '{poppedItem}' from the stack.");
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        private static void Update(Stack<string> stack, string updatedItem)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                stack.Push(updatedItem);
                Console.WriteLine($"Updated top item on the stack to '{updatedItem}'.");
            }
            else
            {
                Console.WriteLine("Stack is empty. Cannot update.");
            }
        }
    }
}