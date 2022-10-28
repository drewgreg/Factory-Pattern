﻿using System;
namespace FactoryPattern
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This three wheeler is in drive");
        }
    }
}

