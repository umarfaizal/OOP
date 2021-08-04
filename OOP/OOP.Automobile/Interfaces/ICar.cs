﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
    public interface ICar : IVehicle
    {
        bool IsAcAvailable { get; set; }
        bool IsSunRoofAvailable { get; set; }
    }
}