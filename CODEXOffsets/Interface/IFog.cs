using System;
using System.Collections.Generic;
using System.Text;

namespace CODEXOffsets.Interface
{
    interface IFog
    {
        int FogStart { get;  }
        int FogFade { get; }
        int FogHeight { get; }
        int FogBias { get; }
        int FogBaseExposure { get; }
        int FogFarExposure { get; }

        int FogBaseColorR { get; }
        int FogBaseColorG { get; }
        int FogBaseColorB { get; }

        int FogFarColorR { get; }
        int FogFarColorG { get; }
        int FogFarColorB { get; }
    }
}
