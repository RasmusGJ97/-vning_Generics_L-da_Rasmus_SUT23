using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Generics_Låda
{
    internal class BoxSameProp:EqualityComparer<Box>
    {
        public override bool Equals(Box B1, Box B2)
        {
            if (B1.Height == B2.Height && B1.Length == B2.Length && B1.Width == B2.Width ||
                B1.Height * B1.Length * B1.Width == B2.Height * B2.Length * B2.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(Box obj)
        {
            return obj.GetHashCode();
        } 
    }
}
