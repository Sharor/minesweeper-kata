namespace ConsoleApplication
{
    public class Tests
    {
        
        //In place of unit tests on Dotnet Core v1.1.0, since microsoft are busy breaking their stuff.
        public static bool NoUnitTests()
        {
            string testinput = @"4 4
*...
....
.*..
....
3 5
**...
.....
.*...
0 0";

            MinesweeperKata.BeginKata(testinput); 
            return true; 
        }
    }
}