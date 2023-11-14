﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Final
{
    ///класс для 1 ко многим
    //public class Company
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public List<User> Users { get; set; }
    //}
    /// <summary>
    /// класс для 1 к 1
    /// </summary>
    //public class UserCredential
    //{
    //    public int Id { get; set; }
    //    public string Login { get; set; }
    //    public string Password { get; set; }

    //    // Внешний ключ
    //    public int UserId { get; set; }
    //    // Навигационное свойство
    //    public User User { get; set; }

    //}
    /// <summary>
    /// класс для многие ко многим
    /// </summary>
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Навигационное свойство
        public List<User> Users { get; set; } = new List<User>();
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Role { get; set; }
        // Внешний ключ
        //public int CompanyId { get; set; }
        //// Навигационное свойство
        //public Company Company { get; set; }
        // Навигационное свойство
        //public UserCredential UserCredential { get; set; }
        // Навигационное свойство
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
}
