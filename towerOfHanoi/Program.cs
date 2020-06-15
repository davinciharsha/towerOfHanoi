using System;

namespace towerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tower of Hanoi");
            int countOfTowers = Convert.ToInt32(Console.ReadLine());
            Program prog = new Program();
            prog.solveTowerOfHanoi(countOfTowers, 'A', 'C', 'B');
        }

        public void solveTowerOfHanoi(int towersCount,char startPos, char endPos, char auxilaryPos)
        {
            if (towersCount == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + startPos
                                               + " to rod " + endPos);
                return;
            }
            solveTowerOfHanoi(towersCount - 1, startPos, auxilaryPos, endPos);
            Console.WriteLine("Move disk " + towersCount + " from rod " + startPos + " to rod " + endPos);
            solveTowerOfHanoi(towersCount - 1, auxilaryPos, endPos, startPos);
        }
    }
}
