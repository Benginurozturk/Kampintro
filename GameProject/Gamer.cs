using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Gamer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
        public string GameName { get; internal set; }
        public int GamePrice { get; internal set; }
        public string SerialNumber { get; internal set; }
    }
}
