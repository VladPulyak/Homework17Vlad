﻿namespace Homework_Module17.ViewModels
{
    public class UserViewModel
    {
        public string? Name { get; set; }
        public Sex Sex { get; set; }
        public string? Country { get; set; }
        public bool IsMarried { get; set; }

    }
    public enum Sex
    {
        Man,
        Woman
    }

}
