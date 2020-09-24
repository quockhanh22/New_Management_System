using System;
namespace Animal_management_system
{
    interface Animal_management_system
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
    interface ITerrestrialAnimal : IAnimal
    {
        void Move();
    }

    internal interface IAnimal
    {
    }

    interface IMarineAnimal : IAnimal
    {
        void Move();
    }
}