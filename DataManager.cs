// DataManager.cs
using System.Text.Json;

namespace Personal_budget_management_tool
{
    public class DataManager
    {
        private string filePath;

        public string FilePath 
        { 
            get { return filePath; } 
            set { filePath = value; } 
        }

        public List<User> LoadData() 
        {
            if (!File.Exists(filePath))
            {
                return new List<User>();
            }

            var jsonData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<User>>(jsonData);
        }

        public void SaveData(List<User> users) 
        {
            var jsonData = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, jsonData);
        }
    }
}