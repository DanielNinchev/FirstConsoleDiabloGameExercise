﻿using ConsoleDiablo.App.Entities.Contracts;
using ConsoleDiablo.App.Entities.Contracts.Factories;
using ConsoleDiablo.App.Entities.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDiablo.App.Entities.Commands
{
    public class MultiplayerCommand : IMenuCommand
    {
        private IMenuFactory menuFactory;

        public MultiplayerCommand(IMenuFactory menuFactory)
        {
            this.menuFactory = menuFactory;
        }
        public IMenu Execute(params string[] args)
        {
            return this.menuFactory.CreateMenu("MultiplayerMenu");
        }
    }
}
