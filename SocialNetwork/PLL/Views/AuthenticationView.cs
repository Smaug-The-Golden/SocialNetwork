﻿using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Models.Exceptions;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Views
{
    public class AuthenticationView
    {
        UserService userService;
        public AuthenticationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var authenticationData = new UserAuthenticationData();

            Console.WriteLine("\nВведите почтовый адрес:");
            authenticationData.Email = Console.ReadLine();

            Console.WriteLine("\nВведите пароль:");
            authenticationData.Password = Console.ReadLine();

            try
            {
                var user = this.userService.Authenticate(authenticationData);

                SuccessMessage.Show("Вы успешно вошли в социальную сеть!");
                SuccessMessage.Show("Добро пожаловать " + user.FirstName);

                Program.userMenuView.Show(user);
            }

            catch (WrongPasswordException)
            {
                AlertMessage.Show("Пароль не корректный!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

        }
    }
}
