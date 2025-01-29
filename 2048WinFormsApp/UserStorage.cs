using Newtonsoft.Json;

namespace _2048WinFormsApp;

public class UserStorage
{
    public static string path = "UserResults.json";

    public static List<Users> GetUserResults()
    {
        if (FileProvider.Exists(path))
        {
            var jsonData = FileProvider.GetValue(path);
            return JsonConvert.DeserializeObject<List<Users>>(jsonData)!;
        }
        return new List<Users>();
    }

    public void Add(Users newUser)
    {
        var users = GetUserResults();
        users.Add(newUser);
        var jsonData = JsonConvert.SerializeObject(users);
        FileProvider.Replace(path, jsonData);
    }
}
