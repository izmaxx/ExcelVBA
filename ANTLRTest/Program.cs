using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace ANTLRTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream inputStream = Console.OpenStandardInput();
            //AntlrInputStream input = new AntlrInputStream(inputStream);
            AntlrInputStream input = new AntlrInputStream("{1,2}");
            ArrayInit1Lexer lexer = new ArrayInit1Lexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            ArrayInit1Parser parser = new ArrayInit1Parser(tokens);

            IParseTree tree = parser.init(); // begin parsing at init rule
            Console.WriteLine(tree.ToStringTree(parser));
            

            //parser.addSubExpr();
        }
    }
}
