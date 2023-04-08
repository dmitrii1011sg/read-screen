using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadScreen
{
    class Constance
    {
        public static readonly ComboItemLang[] ComboxItemsLang = new ComboItemLang[] {
            new ComboItemLang{ Id = "rus", Lang = "Russian" },
            new ComboItemLang{ Id = "en", Lang = "English" }
        };

        public static readonly string developerEmail = "mailto:dmitrii1011sg@gmail.com";
    }

    class ComboItemLang
    {
        public string Id { get; set; }
        public string Lang { get; set; }
    }
}
