using Personal_budget_management_tool;
using Personal_budget_management_tool.HelperMethods;
using System.Text.Json;

public class DataManager
{
    private const string Token = "PersonalBudgetManagementTool";
    private string filePath;
    private List<User> users;
    private double savings;
    private User currentUser;

    internal List<User> Users
    {
        get
        {
            if (users == null)
            {
                users = LoadDataFromFile<User>();
            }
            return users;
        }
        set
        {
            users = value;
            SaveData(users);
        }
    }

    public string FilePath
    {
        get
        {
            return filePath;
        }
        set
        {
            filePath = value;
            users = null;
        }
    }
    internal List<T> LoadDataFromFile<T>()
    {
        var data = new List<T>();

        if (!FileExists(filePath))
        {
            return null;
        }

        ErrorHandling.CheckFilePath(filePath);

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                ErrorHandling.CheckFileToken(line, Token);

                int dataCount = int.Parse(reader.ReadLine());

                for (int i = 0; i < dataCount; i++)
                {
                    line = reader.ReadLine();
                    var item = JsonSerializer.Deserialize<T>(line);
                    data.Add(item);
                }
            }
        }
        catch (Exception ex)
        {
            ErrorHandling.ShowErrorMessage($"An error occurred while loading data: {ex.Message}");
            return null;
        }

        return data;
    }

    internal void SaveReminders(List<Reminders> reminders)
    {
        string json = JsonSerializer.Serialize(reminders);
        File.WriteAllText("reminders.json", json);
    }

    internal List<Reminders> LoadReminders()
    {
        if (!FileExists("reminders.json"))
        {
            return new List<Reminders>();
        }

        string json = File.ReadAllText("reminders.json");
        return JsonSerializer.Deserialize<List<Reminders>>(json);
    }

    public bool FileExists(string filePath)
    {
        return File.Exists(filePath);
    }

    internal void SaveData<T>(List<T> data)
    {
        ErrorHandling.CheckFilePath(filePath);

        try
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(Token);
                writer.WriteLine(data.Count);
                foreach (var item in data)
                {
                    var line = JsonSerializer.Serialize(item);
                    writer.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            ErrorHandling.ShowErrorMessage($"An error occurred while saving data: {ex.Message}");
        }
    }
}