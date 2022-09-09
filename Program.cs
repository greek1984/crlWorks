using System.Linq;

namespace Ctrlwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = new string[5]{ "are", "milk", "84", "to 6", "golden autumn" };
            string[] stringArr2 = new string [stringArr.Length];
            void SelectFromArray()
            {    
                int index = 0;         
                for (int i = 0; i < stringArr.Length; i++) 
                {
                    if (stringArr[i].Length <= 3) 
                    {
                        stringArr2[index] = stringArr[i];
                        index++;
                        Console.WriteLine($"{stringArr[i]} ");
                    }
                }
                 
            }                 
            SelectFromArray();
        }
    
    }
       
}
