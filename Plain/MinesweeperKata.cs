using System;
using System.Collections.Generic; 

namespace ConsoleApplication
{
    public class MinesweeperKata
    {
        public static void BeginKata(string testinput)
        {
            List<string> sweeperFields = FormatInput.SetupFields(testinput); 
            for(int i=0; i<sweeperFields.Count;i++)
            {
                int fieldNr = i+1; 
                
                Tuple<int, int> nm = FormatInput.FormatNM(sweeperFields[i]);
                if(nm.Item1>0)
                {
                    Console.WriteLine(string.Format("Field #{0}:", fieldNr)); 
                }
                Sweeper playMineSweeper = new Sweeper(nm.Item1, nm.Item2, FormatInput.FormatMineField(sweeperFields[i]));
            }
        }
    }
}


