﻿namespace SuperHeroAPI.Model
{
    public class SuperHero
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }  = string.Empty;
        public string Origin { get; set; } = string.Empty;
    }
}
