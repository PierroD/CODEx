using System;
using System.Collections.Generic;
using System.Text;
using CODEXOffsets.Interface;

namespace CODEXOffsets.Offsets
{
    class t6mp : IOffsets, IFog, IDof
    {
        public int cbuf_addtext { get { return 0x5BDF70; } }
        public int nop_address { get { return 0x8C90DA; } }

        public int FogStart { get { return 0x36434B8; } }
        public int FogFade { get { return 0x36434BC; } }
        public int FogHeight { get { return 0x36434C4; } }
        public int FogBias { get { return 0x36434C8; } }
        public int FogBaseExposure { get { return 0x36434E4; } }
        public int FogFarExposure { get { return 0x36434F4; } }

        public int FogBaseColorR { get { return 0x36434D8; } }
        public int FogBaseColorG { get { return 0x36434DC; } }
        public int FogBaseColorB { get { return 0x36434E0; } }

        public int FogFarColorR { get { return 0x36434E8; } }
        public int FogFarColorG { get { return 0x36434F0; } }
        public int FogFarColorB { get { return 0x36434F4; } }

        public int DOFfarBlur { get {return 0x2A3CA60; } }
        public int DOFfarStart { get { return 0x2A3CC40; } }
        public int DOFfarEnd{ get { return 0x2A3CCA0; } }
        public int DOFnearBlur { get { return 0x2A3CA00; } }
        public int DOFnearStart { get { return 0x2A3CB80; } }
        public int DOFnearEnd { get { return 0x2A3CBE0; } }
        public int DOFquality { get { return 0x2A3BE10; } }
    }
}
