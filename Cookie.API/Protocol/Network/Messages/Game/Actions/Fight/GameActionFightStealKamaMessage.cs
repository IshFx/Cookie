//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Actions.Fight
{
    using Cookie.API.Protocol.Network.Messages.Game.Actions;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class GameActionFightStealKamaMessage : AbstractGameActionMessage
    {
        
        public new const uint ProtocolId = 5535;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private ulong m_amount;
        
        public virtual ulong Amount
        {
            get
            {
                return m_amount;
            }
            set
            {
                m_amount = value;
            }
        }
        
        public GameActionFightStealKamaMessage(double targetId, ulong amount)
        {
            m_targetId = targetId;
            m_amount = amount;
        }
        
        public GameActionFightStealKamaMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteVarUhLong(m_amount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_amount = reader.ReadVarUhLong();
        }
    }
}
