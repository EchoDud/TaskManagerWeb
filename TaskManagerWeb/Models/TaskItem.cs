﻿namespace TaskManagerWeb.Models

{
    public class TaskItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public User User {  get; set; }

    }
}
