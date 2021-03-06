﻿

using JTNE.Protocol.Extensions;
using JTNE.Protocol.MessageBody;
using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.Formatters.MessageBodyFormatters
{
    public class JTNE_0x81_0x07_Device_Formatter : IJTNEFormatter<JTNE_0x81_0x07_Device>
    {
        public JTNE_0x81_0x07_Device Deserialize(ReadOnlySpan<byte> bytes, out int readSize)
        {
            int offset = 0;
            JTNE_0x81_0x07_Device jTNE_0x81_0x07 = new JTNE_0x81_0x07_Device();
            jTNE_0x81_0x07.ParamValue = JTNEBinaryExtensions.ReadStringLittle(bytes, ref offset, jTNE_0x81_0x07.ParamLength);
            readSize = offset;
            return jTNE_0x81_0x07;
        }

        public int Serialize(ref byte[] bytes, int offset, JTNE_0x81_0x07_Device value)
        {
            offset += JTNEBinaryExtensions.WriteStringLittle(bytes, offset, value.ParamValue,value.ParamLength);
            return offset;
        }
    }
}
