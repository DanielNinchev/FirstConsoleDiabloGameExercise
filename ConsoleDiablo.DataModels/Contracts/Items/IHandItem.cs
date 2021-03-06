using ConsoleDiablo.App.Entities.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.DataModels.Contracts.Items
{
    public interface IHandItem : IItem
    {
        bool IsTwoHanded { get; }

        bool IsTheItemTwoHanded();
    }
}
