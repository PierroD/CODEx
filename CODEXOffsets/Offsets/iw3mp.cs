using System;
using System.Collections.Generic;
using System.Text;
using CODEXOffsets.Interface;


namespace CODEXOffsets.Offsets
{
    class iw3mp : IOffsets
    {
        public int cbuf_addtext { get { return 0x56C230; } }
        public int nop_address { get { return 0x0; } }
    }
}
