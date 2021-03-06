﻿using Cookie.API.Utils.IO;

namespace Cookie.API.Protocol.Network.Messages.Game.Character.Creation
{
    public class CharacterCanBeCreatedRequestMessage : NetworkMessage
    {
        public const uint ProtocolId = 6732;

        public override uint MessageID => ProtocolId;

        public override void Serialize(IDataWriter writer)
        {
            //
        }

        public override void Deserialize(IDataReader reader)
        {
            //
        }
    }
}