using System;

namespace FuncDelegateDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var execManager = new ExecutionManager();
            var opManager = new OperationManager(20, 0, execManager);
            var result = opManager.Execute(Operation.Divide);
            Console.WriteLine($"The result of our operation is {result}.");
        }
    }
}
