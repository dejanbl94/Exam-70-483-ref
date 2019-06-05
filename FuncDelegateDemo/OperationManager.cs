namespace FuncDelegateDemo
{
    public class OperationManager
    {
        private int firstOperand, secondOperand;
        private ExecutionManager executionManager;

        public OperationManager(int firstOperand, int secondOperand, ExecutionManager execManager)
        {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;
            executionManager = execManager;

            execManager.PopulateFunc(this.Add, this.Subtract, this.Multiply, this.Divide, this.Modulo);
            execManager.PrepareFunc();

        }

        public int Execute(Operation operation)
        {
            return executionManager.FuncExec.ContainsKey(operation) ?
                                                executionManager.FuncExec[operation]() : -1;
        }

        private int Add()
        {
            return firstOperand + secondOperand;
        }

        private int Subtract()
        {
            return firstOperand > secondOperand ? firstOperand - secondOperand : secondOperand - firstOperand;
        }

        private int Multiply()
        {
            return firstOperand * secondOperand;
        }

        private int Divide()
        {
            return secondOperand != 0 ? firstOperand / secondOperand : -1;
        }

        private int Modulo()
        {
            return firstOperand % secondOperand;
        }

    }
}
