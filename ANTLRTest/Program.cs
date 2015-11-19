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
            // TODO: Receive VBA code as input from Rubberduck or an Excel workbook
            FileStream fileStream = new FileStream(@"c:\example1.txt", FileMode.Open, FileAccess.Read);

            Stream inputStream = Console.OpenStandardInput();
            AntlrInputStream input = new AntlrInputStream(fileStream);            
            VBGrammarLexer lexer = new VBGrammarLexer(input);
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            VBGrammarParser parser = new VBGrammarParser(tokens);

            // Begin parsing using initial rule
            IParseTree tree = parser.startRule(); 
            Console.WriteLine(tree.ToStringTree(parser));


   
           // LabeledExprVisitor eval = new LabeledExprVisitor();
           // eval.Visit(tree);

            //parser.addSubExpr();
        }
    }
}
