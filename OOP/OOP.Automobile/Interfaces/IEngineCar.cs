﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Automobile.Interfaces
{
    public interface IEngineCar : ICar
    {
        bool IsHigherFuelEfficiency { get; set; }
    }
}