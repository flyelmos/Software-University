﻿namespace _03DependencyInversion
{
    using _03.Dependency_Inversion.Contracts;

    public class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
