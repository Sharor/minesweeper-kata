using System; 
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Sweeper
    {
        public Sweeper(int n, int m, string minefield)
        {
            PrintMines(PopulateMinefield(MineField(n), minefield, m));
        }

        List<List<char>> MineField(int n)
        {
            List<List<char>> mineField = new List<List<char>>(); 
            for(int i=0;i<n;i++)
            {
                mineField.Add(new List<char>());
            }
            return mineField;
        }

        List<List<char>> PopulateMinefield(List<List<char>> mineField, string setup, int m)
        {
            int stack = 0; 
            for(int j=0;j<mineField.Count;j++)
            {
                for(int i=0;i<m;i++)
                {
                    mineField[j].Add(setup[(stack+i)]);
                }
                stack+=m;
            }
            return mineField; 
        }
        
        void PrintMines(List<List<char>> field)
        {
            List<string[]> printItOut = FindBombs(field);
            for(int i=0; i<printItOut.Count;i++)
            {
                for(int j=0;j<printItOut[i].Length;j++)
                {
                    Console.Write(printItOut[i][j]);
                }
                Console.WriteLine(); 
            }
        }

        List<string[]> FindBombs(List<List<char>> sweep)
        {
            List<string[]> sweptMinefield = new List<string[]>();
            for(int i=0;i<sweep.Count;i++)
            {
                sweptMinefield.Add(new string[sweep[i].Count]);
                for(int j=0; j<sweep[i].Count;j++)
                {
                    if(sweep[i][j]=='*')
                    {
                        sweptMinefield[i][j] = sweep[i][j].ToString(); 
                    }
                    else
                    {
                        sweptMinefield[i][j] = "0"; 
                    }
                }
            }

            for(int i=0;i<sweep.Count;i++)
            {
                for(int j=0; j<sweep[i].Count;j++)
                {
                    if(sweep[i][j]=='*')
                    {
                       sweptMinefield = SweepTopLeft(sweptMinefield, i,j); 
                       sweptMinefield = SweepTop(sweptMinefield, i,j); 
                       sweptMinefield = SweepTopRight(sweptMinefield, i,j); 

                       sweptMinefield = SweepMidLeft(sweptMinefield, i,j); 
                       sweptMinefield = SweepMidRight(sweptMinefield, i,j); 

                       sweptMinefield = SweepBotRight(sweptMinefield, i,j); 
                       sweptMinefield = SweepBotLeft(sweptMinefield, i,j); 
                       sweptMinefield = SweepBot(sweptMinefield, i,j);                      
                    }
                }
            }
            return sweptMinefield; 
        }

        #region SweepOctogonal
        List<string[]> SweepTopLeft(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n-1; 
            int yCoordinate = m-1; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepTop(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n-1; 
            int yCoordinate = m; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepTopRight(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n-1; 
            int yCoordinate = m + 1; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepMidRight(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n; 
            int yCoordinate = m + 1; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepMidLeft(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n; 
            int yCoordinate = m - 1; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepBotLeft(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n+1; 
            int yCoordinate = m - 1; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepBot(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n+1; 
            int yCoordinate = m ; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }

        List<string[]> SweepBotRight(List<string[]> sweptMinefield, int n, int m)
        {
            int xCoordinate = n+1 ; 
            int yCoordinate = m + 1; 
            if(WithinArray(xCoordinate,yCoordinate, sweptMinefield))
            {
                if(sweptMinefield[xCoordinate][yCoordinate]=="*")
                {
                    return sweptMinefield;
                }
                sweptMinefield[xCoordinate][yCoordinate] = (int.Parse(sweptMinefield[xCoordinate][yCoordinate]) + 1).ToString(); 
            }
            return sweptMinefield; 
        }
        #endregion

        bool WithinArray(int n, int m, List<string[]> sweptMinefield)
        {
            if(n < 0 || m < 0)
            {
                return false; 
            }
            if(n>=sweptMinefield.Count||m>=sweptMinefield[0].Length)
            {
                return false; 
            }
            return true; 
        }
    }
}