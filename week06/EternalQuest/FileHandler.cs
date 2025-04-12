using System.IO;

public class FileHandler
{
    public static void SaveGoals(string fileName, List<Goal> goals)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetType().Name + ":" + goal.Name + "," + goal.Points);
            }
        }
    }

    public static List<Goal> LoadGoals(string fileName)
    {
        List<Goal> goals = new List<Goal>();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
        }

        return goals;
    }
}