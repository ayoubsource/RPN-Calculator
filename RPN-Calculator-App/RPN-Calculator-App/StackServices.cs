using System;
using System.Collections.Generic;

namespace RPN_Calculator_App
{
    public class StackServices : IStackServices

    {
    public Stack<double> Stack { get; set; }

    public StackServices()
    {
        Stack = new Stack<double>();
    }

    public void AddElementToStack(double e)
    {
        this.Stack.Push(e);
    }

    public void ClearStack()
    {
        this.Stack.Clear();
    }

    public double[] GetStackAsArray()
    {
        return this.Stack.ToArray();
    }

    public double Pop()
    {
        return Stack.Pop();
    }

    public double Count()
    {
        return Stack.Count;
    }
    }
}