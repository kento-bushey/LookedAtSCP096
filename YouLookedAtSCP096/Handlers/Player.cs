using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
namespace YouLookedAtSCP096.Handlers
{
    class Player
    {
        public void OnLookedAtSCP096(AddingTargetEventArgs ev)
        {
            ev.Target.Broadcast(5, YouLookedAtSCP096.Instance.Config.LookedMessage);
        }
    }
}
