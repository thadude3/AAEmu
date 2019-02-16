using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCSlaveBoundPacket : GamePacket
    {
        private readonly uint _masterId;
        private readonly uint _slaveId;

        public SCSlaveBoundPacket(uint masterId, uint slaveId) : base(0x063, 1) // TODO 1.0 opcode: 0x05f
        {
            _masterId = masterId;
            _slaveId = slaveId;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_masterId);
            stream.Write(_slaveId);
            return stream;
        }
    }
}