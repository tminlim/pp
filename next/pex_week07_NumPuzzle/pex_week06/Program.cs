using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pex_week06
{
    public class NumPuzzle
    {
        private int[,] mBoard;
        private int mCount;
        private int mSize;
        public int mZeroX;
        public int mZeroY;

        public int mMoveX;
        public int mMoveY;
        //private bool mIsClear;
        
        public void Init(int size)
        {
            //first state had not be a clear state
            int n = 0;
            mSize = size;
            mCount = 0;
            mBoard = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j ++){
                    mBoard[i,j] = n;
                    n++;
                }
            }
        }
        public void LocateZero(){
            for (int i = 0; i < mSize; i++){
                for (int j = 0; j < mSize; j++){
                    if (mBoard[i, j] == 0)
                    {
                        mZeroX = i;
                        mZeroY = j;
                        return;
                    }
                }
            }
        }
        public void Move(int nMove)
        {
            for (int i = 0; i < mSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    if (mBoard[i, j] == nMove)
                    {
                        mMoveX = i;
                        mMoveY = j;
                        break;
                    }
                }
                
            }
            Swap();

        }

        private void Swap()
        {
            int tmp;
            tmp = mBoard[mZeroX, mZeroY];
            mBoard[mZeroX, mZeroY] = mBoard[mMoveX, mMoveY];
            mBoard[mMoveX, mMoveY] = tmp;
            mCount++;
        }
        
        public void Print()
        {
            for (int i = 0; i < mSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    if (mBoard[i, j] != 0)
                        Console.Write(" {0:00} ", mBoard[i, j]);
                    else
                        Console.Write(" 0  ");

                }
                Console.WriteLine();
            }
        }
        
        public List<int> MovePossible(int row, int col)
        {
            List<int> nList = new List<int>();
            if (InRange(row, col + 1))
                nList.Add(mBoard[row, col + 1]);
            if (InRange(row, col - 1))
                nList.Add(mBoard[row, col - 1]);
            if (InRange(row -1, col))
                nList.Add(mBoard[row -1, col]);
            if (InRange(row + 1 , col))
                nList.Add(mBoard[row +1, col]);
            return nList;
        }

        public bool InRange(int row, int col)
        {
            if ((row > -1 && row <= mSize - 1) && (col > -1 && col <= mSize -1))
                return true;
            else
                return false;
        }
        
        public bool IsClear()
        {
            return false;
        }
        
        public int GetTurn()
        {
            return mCount;
        }

    }
    class Test{
        static void Main()
        {
            NumPuzzle nP = new NumPuzzle();
            nP.Init(3);
            nP.Print();

            //shown to be numbers of moving
            while (!nP.IsClear())
            {
                nP.LocateZero();
                List<int> nMoveNum = nP.MovePossible(nP.mZeroX, nP.mZeroY);
                Console.WriteLine("움직일 수 있는 숫자는");

                foreach (int num in nMoveNum)
                {
                    if (num != -1)
                        Console.Write(" {0} ", num);
                }
                Console.WriteLine("입니다");
                //choice to move 
                Console.WriteLine("움직이고픈 숫자? 그만하려면 -1");
                int nMove = Convert.ToInt32(Console.ReadLine());
                if (nMove == -1) break; 
                
                nP.Move(nMove);
                nP.Print();

            }
            if (nP.IsClear())
            {
                Console.WriteLine("{0}번에 완성!", nP.GetTurn());
            }
            else
            {
                Console.WriteLine("다음에, {0}동안 플레이!", nP.GetTurn());
            }
            Console.WriteLine("끝");
        }
    }
}
