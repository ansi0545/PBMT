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

    /// <summary>
    /// Gets or sets the list of users.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the file path for the data manager.
    /// </summary>
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
    /// <summary>
    /// Loads data from a file and returns a list of objects of type T.
    /// </summary>
    /// <typeparam name="T">The type of objects to be loaded.</typeparam>
    /// <returns>A list of objects of type T loaded from the file, or null if the file does not exist or an error occurs.</returns>
    internal List<T> LoadDataFromFile<T>()
    {
        var data = new List<T>();

        if (!FileExists(filePath))
        {
            return data;
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

    /// <summary>
    /// Saves the list of reminders to a JSON file.
    /// </summary>
    /// <param name="reminders">The list of reminders to save.</param>
    internal void SaveReminders(List<Reminders> reminders)
    {
        string json = JsonSerializer.Serialize(reminders);
        File.WriteAllText("reminders.json", json);
    }

    /// <summary>
    /// Loads the reminders from a JSON file.
    /// </summary>
    /// <returns>A list of reminders.</returns>
    internal List<Reminders> LoadReminders()
    {
        if (!FileExists("reminders.json"))
        {
            return new List<Reminders>();
        }

        string json = File.ReadAllText("reminders.json");
        return JsonSerializer.Deserialize<List<Reminders>>(json);
    }

    /// <summary>
    /// Checks if a file exists at the specified file path.
    /// </summary>
    /// <param name="filePath">The path of the file to check.</param>
    /// <returns><c>true</c> if the file exists; otherwise, <c>false</c>.</returns>
    public bool FileExists(string filePath)
    {
        return File.Exists(filePath);
    }

    /// <summary>
    /// Saves the provided data to a file.
    /// </summary>
    /// <typeparam name="T">The type of data to be saved.</typeparam>
    /// <param name="data">The list of data to be saved.</param>
    /// <remarks>
    /// This method writes the provided data to a file specified by the <see cref="filePath"/> variable.
    /// The data is serialized using the <see cref="JsonSerializer"/> class and each item is written as a separate line in the file.
    /// </remarks>
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