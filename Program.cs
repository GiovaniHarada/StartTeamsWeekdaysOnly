using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        var today = (int)DateTime.Now.DayOfWeek;
        if(today >= 1 && today <= 5) {
            Console.WriteLine("Day of week, stating work apps...");
            Process proc = new Process();
            proc.StartInfo.FileName = "explorer.exe";
            proc.StartInfo.Arguments = "shell:appsFolder\\MSTeams_8wekyb3d8bbwe!MSTeams";   
            proc.Start(); 
        } else {
            Console.WriteLine("Weekend, no need for stating apps...");
        }

    }
}