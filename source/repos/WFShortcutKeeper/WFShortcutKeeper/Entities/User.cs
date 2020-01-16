using System.Collections.Generic;

namespace WFShortcutKeeper.Entities
{
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public int Id { get; set; }
        public ICollection<Shortcut> Shortcuts { get; set; }

        public User()
        {
            Shortcuts = new List<Shortcut>();
        }
    }
}
