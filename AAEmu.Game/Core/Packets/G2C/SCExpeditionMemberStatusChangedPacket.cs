using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCExpeditionMemberStatusChangedPacket : GamePacket
    {
        private readonly Member _member;
        private readonly byte _flag;

        public SCExpeditionMemberStatusChangedPacket(Member member, byte flag) : base(0x016, 1) // TODO 1.0 opcode: 0x014
        {
            _member = member;
            _flag = flag;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_member);
            stream.Write(_flag);
            return stream;
        }
    }
}