using Exiled.Events.EventArgs.Server;

namespace NoRespawns
{
    public class EventHandlers
    {
        public void OnRespawningTeam(RespawningTeamEventArgs ev)
        {
            ev.IsAllowed = false;
        }
    }
}