using System;

class Program
{
    public static void Main()
    {
        string input = "text.txt";
        string output = "textcopy.txt";

        try
        {
            if(!File.Exists(input))
            {
                throw new FileNotFoundException("Where is the input file? Your head?");
            }
            else
            {
                string[] lines = File.ReadAllLines(input);
                int wordcount = 0;
                foreach(var line in lines)
                {
                    Console.WriteLine("Counting words...");

                    // string []words = line.Split(' ');
                    string []words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordcount+=words.Length;
                }

                int linecount = lines.Length;
                string result = $"The input file contains {linecount} lines and total of {wordcount} words in them.";
                File.WriteAllText(output,result);

                Console.WriteLine("Process completed, go checkout the output text file.");
                return ;
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}