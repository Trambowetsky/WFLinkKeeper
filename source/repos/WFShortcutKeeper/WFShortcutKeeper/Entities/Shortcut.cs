using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFShortcutKeeper.Entities
{
    public class Shortcut
    {
        public int ShortcutId { get; set; }
        public string Link { get; set; }
        public string Desc { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
