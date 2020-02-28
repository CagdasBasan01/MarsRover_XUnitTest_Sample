using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover_Sample
{

    public class Rover
    {
        public int x; //x poziyonu
        public int y; //y pozisyonu
        public string direction; //kordinat bilgisi

        public Rover(string location)
        {
            x = Convert.ToInt32(location.Split(" ")[0]);
            y = Convert.ToInt32(location.Split(" ")[1]);
            direction = location.Split(" ")[2];
        }

        public void TurnLeft()
        {
            // throw new NotImplementedException();
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;
                case "E":
                    direction = "N";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void TurnRight()
        {
            // throw new NotImplementedException();
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void MoveForward()
        {
            // throw new NotImplementedException();
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "S":
                    y -= 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void GoToLocation( string command) //LMLMLMLMM - MMRMMRMRRM
        {
            char[] info = command.ToCharArray();
            for (int i = 0; i < info.Length; i++)
            {
                switch (info[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }
    }
}
