using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class StackX
    {
        private int maxSize; // size of stack array
        private MahalleSinifi[] stackArray;
        private int top; // top of stack
                         //--------------------------------------------------------------
        public StackX(int s) // constructor
        {
            maxSize = s; // set array size
            stackArray = new MahalleSinifi[maxSize]; // create array
            top = -1; // no items yet
        }
        //--------------------------------------------------------------
        public void push(MahalleSinifi j) // put item on top of stack
        {
            stackArray[++top] = j; // increment top, insert item
        }

        public MahalleSinifi pop() // take item from top of stack
        {
         
                return stackArray[top--];
             // access item, decrement top
        }
        //--------------------------------------------------------------
        public MahalleSinifi peek() // peek at top of stack
        {
            return stackArray[top];
        }
        //--------------------------------------------------------------
        public bool isEmpty() // true if stack is empty
        {
            return (top == -1);
        }
        //--------------------------------------------------------------
        public bool isFull() // true if stack is full
        {
            return (top == maxSize - 1);
        }
        public int Count()
        {
            return top +1 ;
        }
        //--------------------------------------------------------------
    } // end class StackX
      ////////////////////////////////////////////////////////////////
}
