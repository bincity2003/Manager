using System;

namespace Backend
{
    public class Entry
    {
        public bool Prioritized;

        public string _desc;
        public DateTime _dl;

        public string Display => _dl == DateTime.Today ? SpecialGetDesc(_desc) : GetDesc(_desc);

        public Entry(string desc, bool pro, DateTime date)
        {
            Prioritized = pro;
            _dl = date;
            _desc = desc;
        }

        private string GetDesc(string desc)
        {
            return Prioritized ? $"{_dl.ToShortDateString()} - **{desc}**" : $"{_dl.ToShortDateString()} - {desc}";
        }

        private string SpecialGetDesc(string desc)
        {
            return Prioritized ? $"**{desc}**" : desc; 
        }
    }
}
