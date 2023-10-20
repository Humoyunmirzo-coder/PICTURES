using Domain.Pictures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Users
{
    public class User : UserBaseEntity
    {
        public int Id { get; set; }
        public int ImageID { get; set; }

        public  List<Image> _images = new List<Image>();

        public IReadOnlyCollection<Image> Images => _images.AsReadOnly();

        public ICollection<UserFriends>? UserFriends { get; set; }

        public void AddImage(Image image)
        {
            _images.Add(image);
        }

        public void RemoveImage(Image image)
        {
            _images.Remove(image);
        }

        public bool IsFriend(User user)
        {
            return UserFriends.Any(uf => uf.Friend.Id == user.Id);
        }
    }
}
