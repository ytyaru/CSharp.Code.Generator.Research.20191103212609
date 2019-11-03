using System;
using System.IO;
using System.CodeDom.Compiler;

namespace CodeGen
{
    class Program
    {
        static void Main()
        {
            new Code0().Run();
            new Code1().Run();
//            CreateSourceCodeFile("MyClass", "cs");
//            CreateSourceCodeFile2("MyClass2", "cs");
        }
        /*
        static void CreateSourceCodeFile(string className, string ext)
        {
            string fileName = className + '.' + ext;
            using StreamWriter sw = new StreamWriter(fileName, false);
            using IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");
            tw.WriteLine(GetCode(className));
        }
        static string GetCode(string className)
        {
            return $@"using System;

class {className}
{{
    static void Main(string args[])
    {{
        Console.WriteLine(""Hello world"");
    }}
}}
";
        }
        static void CreateSourceCodeFile2(string className, string ext)
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
        */
    }
}

