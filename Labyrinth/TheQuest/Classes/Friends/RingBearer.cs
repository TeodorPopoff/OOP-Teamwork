﻿using System;

namespace TheQuest
{
    public abstract class RingBearer : Hobbit, ISpy
    {
        public RingBearer(char symbol, string name, string description, Location position)
            : base(symbol, name, description, position)
        {
            
        }

        int ISpy.Range
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        int ISpy.Times
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}