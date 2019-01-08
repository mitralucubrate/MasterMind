using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind
{
    interface ICompareCodeAndKey
    {
        void CompareCodes( char[] chrCode, char[] chrKey);
    }
}
