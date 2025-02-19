using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Assignment_4_Implementing_Undo_Redo_with_Stack_T
{
    internal class TextEditor
    {

        #region Assignment 4: Implementing Undo/Redo with Stack<T>

        /*Assignment 4: Implementing Undo/Redo with Stack<T>

        1.	Create a Text Editor Simulation where:
            o	Stack<string> undoStack keeps previous states.
            o	Stack<string> redoStack stores redoable actions.
        2.	Allow the user to:
            o	Type a new text (add it to the undo stack).
            o	Undo (pop from undo stack and push to redo stack).
            o	Redo (pop from redo stack and push back to undo stack).
        3.	Display the current text after each operation.      */

        #endregion

        //Stack<string> stack;
        public Stack<string> StackT { get; set; } = new Stack<string>();
        public Stack<string> PopedItems { get; set; } = new Stack<string>();



        public void Undo()
        {
            if (StackT.Count > 0)
            {
                PopedItems.Push(StackT.Peek());
                StackT.Pop();
            }
            else Console.WriteLine("The Stack is Empty ^_^ ");
        }
        public void Redo()
        {
            if (PopedItems.Count > 0)
                StackT.Push(PopedItems.Pop());
            else Console.WriteLine("No Redo Actions can be done");
        }

        public void AddNewText(string s) =>
              StackT.Push(s);


    }
}
