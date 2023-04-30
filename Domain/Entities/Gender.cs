﻿namespace Domain.Entities
{
    public class Gender
    {
        public int GenderId { get; set; }
        public string Description { get; set; }

        // Foreing Keys relation
        public IList<User> Users { get; set; }
    }
}
