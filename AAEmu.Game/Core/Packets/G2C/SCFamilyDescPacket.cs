using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCFamilyDescPacket : GamePacket
    {
        private readonly Family _family;
        
        public SCFamilyDescPacket(Family family) : base(0x02f, 1) // TODO 1.0 opcode: 0x02b
        {
            _family = family;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_family);
            return stream;
        }
    }
}