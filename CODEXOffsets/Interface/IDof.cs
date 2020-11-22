using System;
using System.Collections.Generic;
using System.Text;

namespace CODEXOffsets.Interface
{
    interface IDof
    {
       int DOFfarBlur { get;}
        int DOFfarStart { get; }
        int DOFfarEnd { get; }
        int DOFnearBlur { get; }
        int DOFnearStart { get; }
        int DOFnearEnd { get; }
        int DOFquality { get; }
    }
}
