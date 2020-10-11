using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamarinFormsUnity.Interface;
using XamarinFormsUnity.Model;
using XamarinFormsUnity.Service;

namespace XamarinFormsUnity.ViewModel
{
    public class UserViewModel : BaseModel
    {

        public ObservableCollection<User> Users { get; }

        public UserViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadUsers();
        }

        private async Task LoadUsers()
        {
            Users.Clear();
            var user_api = RestService.For<IRestApi>(EndPoints.BaseUrl);
            var user_return = await user_api.GetTodos();

            foreach (var user in user_return)
            {
                Users.Add(user);
            }
        }
    }
}
