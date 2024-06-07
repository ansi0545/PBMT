using Personal_budget_management_tool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataManager
{
    private const string Token = "PersonalBudgetManagementTool";
    private string filePath;

    internal List<User> Users
    {
        get
        {
            return LoadDataFromFile<User>();
        }
        set
        {
            SaveData(value);
        }
    }

    public string FilePath
    {
        set
        {
            filePath = value;
        }
    }

    private List<T> LoadDataFromFile<T>()
    {
        var data = new List<T>();

        if (string.IsNullOrEmpty(filePath))
        {
            return data;
        }

        try
        {
            using (var reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                if (line != Token)
                {
                    throw new InvalidOperationException("File was not saved by this application.");
                }

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
            Console.WriteLine($"An error occurred while loading data: {ex.Message}");
        }

        return data;
    }

    private void SaveData<T>(List<T> data)
    {
        try
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new InvalidOperationException("File path has not been set.");
            }

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
            Console.WriteLine($"An error occurred while saving data: {ex.Message}");
        }
    }
}
