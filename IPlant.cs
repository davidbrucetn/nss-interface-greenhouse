using System;

namespace Greenhouse
{
    public interface IPlant
    {
        string Species { get; set; }
        string Color { get; set; }
        int Price { get; set; }

        void Report();
    }
}