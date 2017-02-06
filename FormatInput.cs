using System; 
using System.Collections.Generic; 

namespace ConsoleApplication
{
    public static class FormatInput
    {
        public static Tuple<int, int> FormatNM (string input)
        {
            int n = int.Parse(input.Split(' ')[0]);
            int m = int.Parse(input.Split(' ')[1]);
            return new Tuple<int, int>(n, m); 
        }

        public static string SeperateFields(string input, int fields)
        {

            return ""; 
        }

        public static string FormatMineField (string input)
        {
            return input.Split(' ')[2];            
        }

        public static List<string> SetupFields(string testinput)
        {
            List<string> fields = new List<string>(); 
            string[] testInputFormatted = testinput.Split(Environment.NewLine.ToCharArray()); 
           
            for(int i=0; i<testInputFormatted.Length;i++)
            {
                Tuple<int, int> nm = FormatInput.FormatNM(testInputFormatted[i]);
                string field = string.Format("{0} {1} ", nm.Item1, nm.Item2); 
                for(int j = 1 ; j< nm.Item1+1; j++)
                {
                    field+=testInputFormatted[i+j];
                }
                fields.Add(field); 
                i+=nm.Item1; 
            }

            return fields; 
        }
    }
}