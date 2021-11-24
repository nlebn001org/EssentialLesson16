using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson16Task2
{
    class Block
    {

        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }
        public int D { get; private set; }

        public Block(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
                return false;
            Block block = obj as Block;
            return block.A == A && block.B == B && block.C == C && block.D == D;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (A + 2) * (B + 1) * (C + 3) * (D + 2) * 14;
            }
        }

        public override string ToString()
        {
            return $"A = {A}, B = {B}, C = {C}, D = {D}";
        }
    }
}
