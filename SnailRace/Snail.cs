using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    public class Snail
    {
        // fields
        public int _minSpeed { get; }
        public int _maxSpeed { get; }
        public int _snailPosition { get; set; }

        //constructor
        public Snail(int minspeed, int maxspeed)
        {
            _minSpeed = minspeed;
            _maxSpeed = maxspeed;
            _snailPosition = 0;
        }

        //methods
        public Move()
        {   
            //get current snailposition

            //moves the snail to a new position based on a random number between its min and max speed
            _snailPosition += Random.Next(_minSpeed, _maxSpeed);

            // set new snailPostion
            return _snailPosition;
        }

    }
}


