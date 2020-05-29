﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailRace
{
    public class Snail
    {
        // fields
        public int _minSpeed { get; set; }
        public int _maxSpeed { get; set; }
        public string _snailName { get; set; }

        //constructors
        public Snail() 
        {
            _minSpeed = 40;
            _maxSpeed = 70;
            _snailName = "defaultSnailName";
        }

     
        public Snail(int minSpeed, int maxSpeed, string snailName)
        {
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _snailName = snailName;
        }

        //methods
        public override string ToString()
        {
            return _snailName;
        }
       
        public int Move()
        {
            int _distanceMoved;
            Random moveSnail = new Random();

            _distanceMoved = moveSnail.Next(_minSpeed, _maxSpeed);
            return _distanceMoved;      
        }

    }
}


