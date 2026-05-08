using System.Diagnostics;

namespace CalculatorLibrary
{
   
        public class CalculatorLogic
        {
            public CalculatorLogic()
            {
                // Вся настройка прямо в конструкторе (без проверок)
                Trace.Listeners.Add(new ConsoleTraceListener());
                Trace.Listeners.Add(new TextWriterTraceListener("calculator_debug.log"));
                Trace.AutoFlush = true;

                Debug.WriteLine("=== БИБЛИОТЕКА ЗАГРУЖЕНА ===");
            }

            public int Add(int a, int b)
            {
                Debug.WriteLine($"Add({a}, {b}) = {a + b}");
                return a + b;
            }

            public int Subtract(int a, int b)
            {
                Debug.WriteLine($"Subtract({a}, {b}) = {a - b}");
                return a - b;
            }

            public int Multiply(int a, int b)
            {
                Debug.WriteLine($"Multiply({a}, {b}) = {a * b}");
                Debug.WriteLine("Что-то поменяла");
            return a * b;
            }

            public double Divide(int a, int b)
            {
                Debug.WriteLine($"Divide({a}, {b})");

                if (b == 0)
                {
                    Debug.WriteLine("ОШИБКА: деление на ноль!");
                    if (Debugger.IsAttached) Debugger.Break();
                    throw new DivideByZeroException("Нельзя делить на ноль!");
                }

                return (double)a / b;
            }
        }
    }


