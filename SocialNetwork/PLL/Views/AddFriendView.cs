using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Models.Exceptions;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        UserService userService;
        public AddFriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            try
            {
                var userAddFriendData = new AddFriendData();

                Console.WriteLine("\nВведите почтовый адрес пользователя которого хотите добавить в друзья: ");

                userAddFriendData.FriendEmail = Console.ReadLine();
                userAddFriendData.UserId = user.Id;

                this.userService.AddFriend(userAddFriendData);

                SuccessMessage.Show("Вы успешно добавили пользователя в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователя с указанным почтовым адресом не существует!");
            }

            catch (Exception)
            {
                AlertMessage.Show("Произоша ошибка при добавлении пользотваеля в друзья!");
            }

        }
    }
}
