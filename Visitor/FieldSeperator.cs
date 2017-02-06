using System; 
namespace ConsoleApplication
{
    public class ForLoop : IForLoop
{
        private string test=""; 
        public int BaseFound(RecursionBase visitor)
        {
            return visitor.i; 
        }

        public int RecursionContinued(RecursionContinues visitor)
        {
            visitor.i+=1; 
            return new RecursionContinues().Accept(visitor); 
        }
}


public class RecursionContinues : Recursion
{
        public override void Accept(IForLoop visitor)
        {
            visitor.RecursionContinued(this); 
        }
}

public class RecursionBase : Recursion
{
    public override void Accept(IForLoop visitor)
    {
        visitor.BaseFound(this); 
    }
}

public interface IForLoop
{
    int BaseFound(RecursionBase visitor);
    int RecursionContinued(RecursionContinues visitor); 
}

public abstract class Recursion
{
    public int i; 
    public int length; 

    public abstract void Accept(IForLoop visitor); 

}


public class SimpleForLoop
{
    public int RecursiveMethod(int length, int i)
    {
        i+=1; 
        Console.WriteLine(i); 
        if(i==length)
        {
            return i; 
        }
        return RecursiveMethod(length, i); 
    }
}
}

   
        /*
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
            }*/

