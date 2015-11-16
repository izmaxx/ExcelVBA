using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace ANTLRTest
{
    class LabeledExprVisitor : ExprBaseVisitor<Int32>
    {
        /* ID '=' expr NEWLINE */
        public override int VisitAssign([NotNull] ExprParser.AssignContext context)
        {
            String id = context.ID().GetText();
            int value = Visit(context.expr());

            System.Console.WriteLine("Assign Context, ID: " + id);
            System.Console.WriteLine("Assign Context, Value: ");
            return value;
        }
    }
}
