using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ErrorHandeling.Error_Handling
{
    class TryCatchMeOutside
    {
        public static string documentPath = "C:\\Users\\rudiak_gaven\\source\\repos\\ErrorHandeling\\ErrorHandeling\\data.txt";
        public static void MyErrors()
        {
            try
            {
                using (StreamReader sr = File.OpenText(documentPath))
                {
                    Console.WriteLine($"The first line of the text is:  {sr.ReadLine()}");
                    Console.WriteLine($"The second line of the text is:  {sr.ReadLine()}");
                    sr.Close();

                    StreamWriter sw = new StreamWriter(documentPath);
                    Console.WriteLine("Gimme imput");
                    string swInput = Console.ReadLine();
                    sw.WriteLine(swInput);
                    Console.WriteLine("Gimme imput part 2");
                    sw.WriteLine(Console.ReadLine());
                    Console.WriteLine("it work??????");
                    sw.Close();
                }

            }
            catch (FileNotFoundException e)
            {

                Console.WriteLine($"The file was not found: {e}");
                if (!File.Exists(documentPath))
                {
                    using (StreamWriter sw = File.CreateText(documentPath));

                }
                MyErrors();

            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"File could not found: {e}");

            }
            catch (IOException e)
            {
                Console.WriteLine($"File could not be opened: {e}");

            }
        }

    }
}
