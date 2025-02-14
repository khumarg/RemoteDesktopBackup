using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IVP_ConsoleApp1
{
    internal class ExceptionHandling
    {
        //try - Code which is bound to throw exception must be included in the try block.
        //catch - exception thrown by try is handled by catch
        //finally - Code written in finally block will executive irrespective of the exception occur or not.
        //try will either have catch or finally.
        public void Divide(int a, int b)
        {
            int c = 0;
            try 
            { 
                    c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Cannot divide by zero: {e.Message}");
            }
            
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"{a} / {b} = {c}");
            }
        }

        public void ArrayAddition(int[] arr)
        {
            int sum = 0;
            
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    sum += arr[i];
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Last element will be at N-1 index position");
            }
            finally 
            {
                Console.WriteLine("Addition of array elements: " + sum);

            }
        }

        int SID, data, value;
        string name;
        float marks;
        public void GetStudentDetails()
        {
            Console.WriteLine("Please enter student details: ");
            try
            {
                SID = int.Parse(Console.ReadLine());
                name = Console.ReadLine();
                marks = Convert.ToSingle(Console.ReadLine());
                data = int.Parse(Console.ReadLine());
                value = (int)marks / data;
            }
            
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine($"Student Details: {SID} - {name} - {marks}");
            }
        }

        public void Voting()
        {
            int age = 16;
            if(age < 18)
            {
                throw new AgeException("Age cannot be less than 18");
            }
            else
            {
                Console.WriteLine("You are eligible for voting.");
            }
        }

        FileStream fs;
        StreamReader sr;

        public void FileCreation()
        {
            try
            {
                fs = new FileStream("C:\\MyIVPFiles\\Data.txt", FileMode.Open, FileAccess.Read);

                sr = new StreamReader(fs);

                Console.WriteLine(sr.ReadToEnd());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null && fs != null)
                {
                    sr.Close();
                    fs.Close();
                    sr.Dispose();
                    fs.Dispose();
                }
            }
        }
    }
}
