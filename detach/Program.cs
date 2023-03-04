using System.Diagnostics;

if (args.Length < 1)
{
    Console.WriteLine("No target was supplied. Exiting ...");
    return;
}

string target = args[0];
string arguments = string.Join(' ', args[1..].Select(a => $"\"{a}\""));
ProcessStartInfo pinfo = new(target, arguments)
{
    UseShellExecute = true
};
Process.Start(pinfo);