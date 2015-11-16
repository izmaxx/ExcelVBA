using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Z3;

namespace Z3Solver
{
    class Program
    {
        static void Main(string[] args)
        {

            using (Context ctx = new Context())
            {
                IntExpr x = ctx.MkIntConst("a");
                IntExpr one = ctx.MkInt(3);
                BoolExpr test = ctx.MkLt(x, one);
                Model model = Check(ctx, test, Status.SATISFIABLE);
            }


        }

        static Model Check(Context ctx, BoolExpr f, Status sat)
        {
            Solver s = ctx.MkSolver();
            s.Assert(f);
            if (s.Check() != sat)
            {//do something
            };
            if (sat == Status.SATISFIABLE)
            {
                Console.WriteLine("Data" + s.Model);
                return s.Model;
            }

            else
                return null;
        }
    }

}
