﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phoenix.WorkshopTool;

namespace Phoenix.MEWorkshopTool
{
    class Program
    {
        public static int Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += GameBase.CurrentDomain_AssemblyResolve;

            var game = new MedievalGame();
            return game.InitGame(args);
        }
    }
}
