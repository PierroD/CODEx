﻿using System;
using System.Collections.Generic;
using System.Text;
using CODEXOffsets.Interface;

namespace CODEXOffsets.Offsets
{
    class iw4mp : IOffsets
    {
        public int cbuf_addtext { get { return 0x563BE0; } }
        public int nop_address { get { return 0x0; } }
    }
}
