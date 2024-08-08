using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace TheOtherRoles.Utilities;

public static class StreamExtensions
{
    [RegisterInIl2Cpp]
    public class StreamWrapper : Il2CppSystem.IO.Stream
    {
        private readonly Stream _stream;

        public StreamWrapper(IntPtr pointer) : base(pointer)
        {
            throw new NotSupportedException("This shouldn't ever be called because StreamWrapper is injected from managed side");
        }

        public StreamWrapper(Stream stream) : base(ClassInjector.DerivedConstructorPointer<StreamWrapper>())
        {
            ClassInjector.DerivedConstructorBody(this);
            _stream = stream;
        }

        [HideFromIl2Cpp]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Span<byte> GetSpan(Il2CppStructArray<byte> buffer, int offset, int count)
        {
            var rawBuffer = (byte*) buffer.Pointer + 4 * IntPtr.Size;
            return new Span<byte>(rawBuffer + offset, count);
        }

        public override int Read(Il2CppStructArray<byte> buffer, int offset, int count)
        {
            return _stream.Read(GetSpan(buffer, offset, count));
        }

        public override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
        {
            _stream.Write(GetSpan(buffer, offset, count));
        }

        public override void Flush()
        {
            _stream.Flush();
        }

        public override void Close()
        {
            _stream.Close();
        }

        public override void Dispose()
        {
            _stream.Dispose();
        }

        public override long Seek(long offset, Il2CppSystem.IO.SeekOrigin origin)
        {
            return _stream.Seek(offset, origin switch
            {
                Il2CppSystem.IO.SeekOrigin.Begin => SeekOrigin.Begin,
                Il2CppSystem.IO.SeekOrigin.Current => SeekOrigin.Current,
                Il2CppSystem.IO.SeekOrigin.End => SeekOrigin.End,
                _ => throw new ArgumentOutOfRangeException(nameof(origin), origin, null),
            });
        }

        public override void SetLength(long value)
        {
            _stream.SetLength(value);
        }

        public override bool CanRead => _stream.CanRead;

        public override bool CanSeek => _stream.CanSeek;

        public override bool CanWrite => _stream.CanWrite;

        public override long Length => _stream.Length;

        public override long Position
        {
            get => _stream.Position;
            set => _stream.Position = value;
        }
    }

    public static StreamWrapper AsIl2Cpp(this Stream stream) => new(stream);

    public static byte[] ReadFully(this Stream input)
    {
        using var ms = new MemoryStream();
        input.CopyTo(ms);
        return ms.ToArray();
    }
}
