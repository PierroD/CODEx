using System;
using System.Collections.Generic;
using System.Text;
using CODEXOffsets.Interface;


namespace CODEXOffsets.Offsets
{
    class BlackOpsMP : IOffsets
    {
        public int cbuf_addtext { get { return 0x56EF70; } }
        public int nop_address { get { return 0x8B5A37; } }

    }
}
