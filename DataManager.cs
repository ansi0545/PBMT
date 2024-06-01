using Personal_budget_management_tool;

public class DataManager
{
    public string FilePath { get; set; }

    public List<User> LoadData()
    {
        List<User> users = new List<User>();

        if (File.Exists(FilePath))
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Assuming each user is stored in a separate line
                    // And the properties of the user are separated by a comma
                    string[] properties = line.Split(',');

                    User user = new User(properties[0], properties[1]);
                    users.Add(user);
                }
            }
        }

        return users;
    }

    public void SaveData(List<User> users)
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            foreach (User user in users)
            {
                // Assuming the properties of the user are separated by a comma
                writer.WriteLine($"{user.Username},{user.Password}");
            }
        }
    }
}
