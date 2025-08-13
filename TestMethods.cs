using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal static uint StackFirstPrime(Stack<uint> stack)
        {
            foreach (var num in stack)
            {
                if (SiEsPrimo(num))

                return num;
                
            }
            return 0;
        }

        private static bool SiEsPrimo(uint n)
        {
            if (n < 2) return false;  // se recorre la vuelta  evade el 1 y el 0

            uint i = 3;
            while (i * i <= n)
            {
                if (n % i == 0) return false; 
                i += 2;
                
            }
            return true;
        }

        internal static Stack<uint> RemoveFirstPrime(Stack<uint> stack)
        {

            return null;
        }

        internal static Queue<uint> CreateQueueFromStack(Stack<uint> stack)// punto c
        {
            // se crea la cola
            Queue<uint> queue = new Queue<uint>();

      
      
            foreach (var item in stack) // se recorre la vuelta 
            {

               
                queue.Enqueue(item);  // El primero de pila es primero en cola
            }

            // Devolvemos la cola ya construida con los elementos en el orden que pide el test.
            return queue;
        }

        internal static List<uint> StackToList(Stack<uint> stack)
        {

            // se crea la lidta 
            List<uint> list = new List<uint>();

            
            foreach (var item in stack) // se recorre la vuelta 
            {
                
                list.Add(item); 
            }

            return null;
        }

        internal static bool FoundElementAfterSorted(List<int> list, int value)
        {
            list.Sort();

            
            return list.Contains(value);

        }
    }
}