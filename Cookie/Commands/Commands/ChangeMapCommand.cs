using Cookie.API.Commands;
using Cookie.API.Core;
using Cookie.API.Game.Map;
using Cookie.API.Utils;
using Cookie.API.Utils.Enums;

namespace Cookie.Commands.Commands
{
    public class ChangeMapCommand : ICommand
    {
        public string CommandName => "changemap";

        public void OnCommand(IAccount account, string[] args)
        {
            if (args.Length < 1)
            {
                Logger.Default.Log("Vous devez spécifier la direction pour changer de map (left, right, top, bottom).",
                    LogMessageType.Public);
            }
            else
            {
                IMapChangement move = null;
                switch (args[0])
                {
                    case "top":
                    case "up":
                        move = account.Character.Map.ChangeMap(MapDirectionEnum.North);
                        break;
                    case "left":
                        move = account.Character.Map.ChangeMap(MapDirectionEnum.West);
                        break;
                    case "right":
                        move = account.Character.Map.ChangeMap(MapDirectionEnum.East);
                        break;
                    case "bottom":
                    case "bot":
                        move = account.Character.Map.ChangeMap(MapDirectionEnum.South);
                        break;
                }

                if (move != null)
                {
                    move.ChangementFinished += OnChangementFinished;
                    move.PerformChangement();
                }
            }
        }

        private void OnChangementFinished(object sender, MapChangementFinishedEventArgs e)
        {
            switch (e.Success)
            {
                case true:
                    Logger.Default.Log($"Changement de map réussi ! Arrivé sur la map {e.NewMap}");
                    break;
                case false:
                    Logger.Default.Log($"Changement de map échoué ! Toujours sur la map {e.OldMap}");
                    break;
            }
        }
    }
}