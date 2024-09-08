using Exiled.API.Enums;
using Exiled.API.Features;
using System;

namespace NoRespawns
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "NoRespawns";
        public override string Prefix => "NoRespawns";
        public override string Author => "aksueikava";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);
        public override PluginPriority Priority { get; } = PluginPriority.Default;

        public static Plugin Instance;
        private EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();

            Log.Debug("NoRespawns has been enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnregisterEvents();

            Log.Debug("NoRespawns has been disabled.");
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _handlers = new EventHandlers();
            Exiled.Events.Handlers.Server.RespawningTeam += _handlers.OnRespawningTeam;
        }

        private void UnregisterEvents()
        {
            Exiled.Events.Handlers.Server.RespawningTeam -= _handlers.OnRespawningTeam;
            _handlers = null;
        }
    }
}