﻿using BlImplementation;

namespace BlApi
{
    public class Factory
    {
        public static IBl Get()
        {
            //return new Bl();
            IBl Bl = new Bl();
            return Bl;
        }
    }
}
