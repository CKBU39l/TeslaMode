using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class ok
    {
        public void TriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (ev.Player.Role.Side == Exiled.API.Enums.Side.Mtf)
            {
                ev.IsAllowed = false;
            }
        }


    }
}
