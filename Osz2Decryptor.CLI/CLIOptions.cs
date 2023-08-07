using CommandLine;

namespace Osz2Decryptor.CLI;

public class CLIOptions
{
    [Option('f', "file", Required = true, HelpText = "Path to the .osz file")]
    public string FilePath { get; set; } = string.Empty;
    
    [Option('o', "output", Required = false, HelpText = "Path to the output directory")]
    public string OutputPath { get; set; } = string.Empty;
}