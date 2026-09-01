namespace V380Decoder.src
{
    public enum VideoCodec
    {
        H264,
        HEVC
    }

    public class FrameData
    {
        public byte RawType;
        public uint FrameId;
        public ushort FrameType;
        public ushort FrameRate;
        public ulong Timestamp;
        public byte[] Payload;
        public VideoCodec Codec;

        public bool IsKeyframe =>
            Codec == VideoCodec.HEVC
                ? RawType == 0x28
                : RawType == 0x00;
    }
}
