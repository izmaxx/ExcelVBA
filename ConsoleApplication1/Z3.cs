using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Z3;

namespace ConsoleApplication1
{
    class Z3
    {
        static void Main(string[] args)
        {
            using (Context ctx = new Context())
            {
                Expr x = ctx.MkConst("x", ctx.MkIntSort());
                Expr zero = ctx.MkNumeral(0, ctx.MkIntSort());

                Solver s = ctx.MkSolver();
                s.Assert(ctx.MkLt((ArithExpr)zero, (ArithExpr)x)); // 0<x

                Status result = s.Check();
                Console.WriteLine(result);
            }
        }
    }
}
