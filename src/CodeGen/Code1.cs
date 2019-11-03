using System;
using System.IO;
using System.CodeDom.Compiler;

namespace CodeGen
{
    class Code1
    {
        public void Run()
        {
            CreateSourceCodeFile("MyClass1", "cs");
        }
        void CreateSourceCodeFile(string className, string ext)
        {
            string fileName = className + '.' + ext;
            using StreamWriter sw = new StreamWriter(fileName, false);
            using IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");
            tw.WriteLine($@"using System;");
            tw.WriteLine();
            tw.WriteLine($@"class {className}");
            tw.WriteLine($@"{{");
            tw.Indent++;
            tw.WriteLine($@"static void Main(string args[])");
            tw.WriteLine($@"{{");
            tw.Indent++;
            tw.WriteLine($@"Console.WriteLine(""Hello world"");");
            tw.Indent--;
            tw.WriteLine($@"}}");
            tw.Indent--;
            tw.WriteLine($@"}}");
        }
    }
}

