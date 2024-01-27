using Exiled.API.Interfaces;
using Exiled.Events.Commands.PluginManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaMode
{
    public class cfg : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;

    }
}