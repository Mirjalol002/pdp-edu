﻿namespace PDP_Edu.Domain.Entities
{
    public class Group
    {
#pragma warning disable
        public Group()
#pragma warning restore 
        {
            Lessons = new HashSet<Lesson>();
            StudentGroups = new HashSet<StudentGroup>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int TeacherId { get; set; }
        public int AssitsentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public User Teacher { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
