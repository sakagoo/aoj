using System;
using System.IO;
namespace aoj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            var contestName = args[0].Length != 0 ? args[0] : "abc001_a";

            var folderPath = $"../{contestName}";
            Directory.CreateDirectory(folderPath);
            var pgmContents = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nnamespace " + contestName + "{class Program\n{\n static void Main(string[] args)\n {\n Console.WriteLine(\"Hello\");\n }\n }\n }";
            using (StreamWriter writer = new StreamWriter($"{folderPath}/Program.cs", false))
            {
                writer.WriteLine(pgmContents);
            }

            var csprojct = "<Project Sdk=\"Microsoft.NET.Sdk\"><PropertyGroup><OutputType>Exe</OutputType><TargetFramework>netcoreapp3.1</TargetFramework></PropertyGroup></Project>";
            using (StreamWriter writer = new StreamWriter($"{folderPath}/{contestName}.csproj", false))
            {
                writer.WriteLine(csprojct);
            }

            var contestStrAry = contestName.Split('_');
            var contestHead = contestStrAry[0];
            var contestNum = contestStrAry[1];
            //https://onlinejudge.u-aizu.ac.jp/courses/lesson/1/ALDS1/4/ALDS1_4_A
            var dl = $"oj dl https://onlinejudge.u-aizu.ac.jp/courses/lesson/1/{contestHead}/{contestNum}/{contestName}";
            using (StreamWriter writer = new StreamWriter($"./dl.sh", false))
            {
                writer.WriteLine(dl);
            }

            File.Copy(@"./run.sh", $"{folderPath}/run.sh");
            File.Copy(@"./dl.sh", $"{folderPath}/dl.sh");

        }
    }
}

