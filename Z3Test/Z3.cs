using System;
using Microsoft.Z3;
using Z3Solver;

namespace Z3Test
{
    public class Z3
    {
        static void Main(string[] args)
        {
            // if 3 < x
            Program.CheckLessThan(2, "x");

            //using (Context ctx = new Context())
            //{
            //    Expr x = ctx.MkConst("x", ctx.MkIntSort());
            //    Expr zero = ctx.MkNumeral(0, ctx.MkIntSort());

            //    Solver s = ctx.MkSolver();
            //    s.Assert(ctx.MkLt((ArithExpr)zero, (ArithExpr)x)); // 0<x

            //    Status result = s.Check();
            //    Console.WriteLine(result);
            //}
        }
    }
}
