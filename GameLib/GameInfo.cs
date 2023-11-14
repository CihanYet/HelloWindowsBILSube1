using System;

namespace GameLib
{
    public enum Level
    {
        Kolay,
        Orta,
        Zor
    }
    public class GameInfo
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Level Seviye { get; set; }
    }
}
