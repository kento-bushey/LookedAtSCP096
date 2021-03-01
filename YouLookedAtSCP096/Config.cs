using Exiled.API.Interfaces;
using System.ComponentModel;

namespace YouLookedAtSCP096
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Sets the message broadcasted to player after looking at SCP 096.")]
        public string LookedMessage { get; set; } = "You looked at SCP 096!";
    }
}

