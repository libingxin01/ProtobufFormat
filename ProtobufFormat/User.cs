using ProtoBuf;

namespace ProtobufFormat
{
    [ProtoContract]
    public class User
    {
        [ProtoMember(1)]
        public int Id { get; set; }
        [ProtoMember(2)]
        public string Name { get; set; }
        [ProtoMember(3)]
        public int Age { get; set; }
    }
}
