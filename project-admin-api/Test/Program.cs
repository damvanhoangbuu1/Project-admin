using System;
using Services.Implementations;
using Services.DTOs.Input;
using AutoMapper;
using DAL.Models;
using DAL.Extensions;
using Services.DTOs.Output;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputDto us = new UserInputDto{
                UserName= "damvanhoangbuu1",
                Email = "damhoangbuu@gmail.com"
            };
            //var user = Mapper.Map<User>(us);
            //user.UserName = us.Email;
            //user.EncodePassword("Sioux@Asia");
            //CreateUser(user);
            UserService.Register(us);
            Console.WriteLine("Hello World!");
        }
    }
}
