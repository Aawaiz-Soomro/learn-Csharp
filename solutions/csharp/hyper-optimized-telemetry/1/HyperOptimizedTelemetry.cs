using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        byte[] payload;

        if (reading > uint.MaxValue)
        {
            buffer[0] = 248; // 256 - 8
            payload = BitConverter.GetBytes(reading);
        }
        else if (reading > int.MaxValue)
        {
            buffer[0] = 4;
            payload = BitConverter.GetBytes((uint)reading);
        }
        else if (reading > ushort.MaxValue)
        {
            buffer[0] = 252; // 256 - 4
            payload = BitConverter.GetBytes((int)reading);
        }
        else if (reading >= 0)
        {
            buffer[0] = 2;
            payload = BitConverter.GetBytes((ushort)reading);
        }
        else if (reading >= short.MinValue)
        {
            buffer[0] = 254; // 256 - 2
            payload = BitConverter.GetBytes((short)reading);
        }
        else if (reading >= int.MinValue)
        {
            buffer[0] = 252; // 256 - 4
            payload = BitConverter.GetBytes((int)reading);
        }
        else
        {
            buffer[0] = 248; // 256 - 8
            payload = BitConverter.GetBytes(reading);
        }

        payload.CopyTo(buffer, 1);
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        switch (buffer[0])
        {
            case 248:
                return BitConverter.ToInt64(buffer, 1);
            case 4:
                return BitConverter.ToUInt32(buffer, 1);
            case 252:
                return BitConverter.ToInt32(buffer, 1);
            case 2:
                return BitConverter.ToUInt16(buffer, 1);
            case 254:
                return BitConverter.ToInt16(buffer, 1);
            default:
                return 0;
        }
    }
}