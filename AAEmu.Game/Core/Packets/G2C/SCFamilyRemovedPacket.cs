using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCFamilyRemovedPacket : GamePacket
    {
        private readonly uint _familyId;
        
        public SCFamilyRemovedPacket(uint familyId) : base(0x02e, 1) // TODO 1.0 opcode: 0x02a
        {
            _familyId = familyId;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_familyId);
            return stream;
        }
    }
}