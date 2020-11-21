using System;
using System.Collections.Generic;
using System.Text;
using CODEXOffsets.Interface;

namespace CODEXOffsets.Offsets
{
    class t6zm : IOffsets
    {
        public int cbuf_addtext { get { return 0x4C7120; } }
        public int nop_address { get { return 0x8C768A; } }
    }
}
