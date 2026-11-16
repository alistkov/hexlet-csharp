namespace App.OopBasics;

public class User(int id, string nickName)
{
    public int Id { get; } = id;

    public string Nickname { get; set; } = nickName;

    public bool IsSame(User? user)
    {
        if (user is null)
        {
            return false;
        }

        return this.Id == user.Id;
    }
}
