using System;
using System.IO;
using System.CodeDom.Compiler;

namespace CodeGen
{
    class Code0
    {
        public void Run()
        {
            CreateSourceCodeFile("MyClass0", "cs");
        }
        void CreateSourceCodeFile(string className, string ext)
        {
            string fileName = className + '.' + ext;
            using StreamWriter sw = new StreamWriter(fileName, false);
            using IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");
            tw.WriteLine(GetCode(className));
        }
        string GetCode(string className)
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

    }
}

