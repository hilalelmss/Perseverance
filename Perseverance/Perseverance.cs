using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perseverance
{
    public class Perseverance
    {
        public int xLocation;
        public int yLocation;
        public int xMax;
        public int yMax;
        public string steps;
        public char position;
        char[] direction = new char[] { 'N', 'E', 'S', 'W' };

        public Perseverance()
        {
        }
        public Perseverance(int xMax, int yMax, int xLocation, int yLocation, char position, string steps)
        {
            this.xMax = xMax;
            this.yMax = yMax;
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.position = position;
            this.steps = steps;
        }
        public static void Main()
        {
            Perseverance pers = new Perseverance();
            pers.Run();
        }
        public void Run()
        {
            Console.WriteLine("Test Input:\n" + xLocation + " " + yLocation + " " + position + "\n" + steps + "\n");
            Motion(steps.ToCharArray());
            Console.WriteLine("Expected Output:\n" + xLocation + " " + yLocation + " " + position);
        }
        private void TurnLeft()
        {
            for (int i = 0; i < direction.Length; i++)
            {
                if (direction[i] == position)
                {
                    if (i == 0)
                    {
                        position = direction[direction.Length - 1];
                        break;
                    }
                    else
                    {
                        position = direction[i - 1];
                        break;
                    }
                }
            }
        }
        private void TurnRight()
        {
            for (int i = 0; i < direction.Length; i++)
            {
                if (direction[i] == position)
                {
                    if (i == (direction.Length - 1))
                    {
                        position = direction[0];
                        break;
                    }
                    else
                    {
                        position = direction[i + 1];
                        break;
                    }
                }
            }
        }
        private void Forward()
        {
            if (position == 'N')
            {
                yLocation++;
            }
            if (position == 'E')
            {
                xLocation++;
            }
            if (position == 'S')
            {
                yLocation--;
            }
            if (position == 'W')
            {
                xLocation--;
            }
        }
        private void Motion(char[] steps)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                if (steps[i] == 'L')
                    TurnLeft();
                else if (steps[i] == 'R')
                    TurnRight();
                else if (steps[i] == 'M')
                    Forward();
            }
        }
    }
}

