using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TryCatchTest : MonoBehaviour
{
    class Progaram
    {
        static void Main(string[] args)

        {
            int[] nums = new int[4];

            try
            {
                Console.WriteLine("������� ������:");
                string message = Console.ReadLine();

                if (message.Length > 6)
                {
                    throw new Exception("����� ������ ������ 6 ��������")
                }

                Console.WriteLine("End of try Block");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error occured: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error occured: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error occured: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Finally block");
            }

            Console.ReadKey();
        }
    }

}
