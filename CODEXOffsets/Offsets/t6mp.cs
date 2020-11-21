using System;
using System.Collections.Generic;
using System.Text;
using CODEXOffsets.Interface;

namespace CODEXOffsets.Offsets
{
    class t6mp : IOffsets, IFog
    {
        public int cbuf_addtext { get { return 0x5BDF70; } }
        public int nop_address { get { return 0x8C90DA; } }
    }
}
