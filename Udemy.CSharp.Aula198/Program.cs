namespace Udemy.CSharp.Aula198
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\mathe\OneDrive\Documentos\Projetos C#\Udemy.CSharp.Aula198\file1.txt";
            string targetPath = @"C:\Users\mathe\OneDrive\Documentos\Projetos C#\Udemy.CSharp.Aula198\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            } catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}