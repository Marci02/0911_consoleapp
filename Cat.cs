﻿
namespace _0911_consoleapp
{
    internal class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime Birth { get; set; }
        public bool Sex { get; set; }
        public float Weight { get; set; }
        public int Age => (int)(DateTime.Now - Birth).TotalDays / 365;

        public override string ToString()
        {
            return $"[{Id}], {Name}, ({(Sex ? "hím" : "nőstény")} {Breed}) - {Weight:00.00} kg, {Age} éves";
        }   
    }   
}
