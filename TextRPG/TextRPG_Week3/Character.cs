using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Week3
{
    public class Character
    {
        public int Level { get; set; } = 1;
        public string Name { get; set; } = "이름";
        public string Job { get; set; } = "직업";
        public int Attack { get; set; } = 10;
        public int Defense { get; set; } = 5;
        public int Hp { get; set; } = 100;
        public int Gold { get; set; } = 1500;
    }
}
