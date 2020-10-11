using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XamarinFormsUnity.Model;
using XamarinFormsUnity.Service;

namespace XamarinFormsUnity.ViewModel
{
    public class UserViewModel : BaseModel
    {
        private readonly RestApiService _restapiservice;
        public ObservableCollection<User> Users { get; }

        public UserViewModel(RestApiService restapiservice)
        {
            Users = new ObservableCollection<User>();
            _restapiservice = restapiservice;
            
            LoadUsers(_restapiservice).GetAwaiter();
        }

        private async Task LoadUsers(RestApiService restapiservice)
        {
            Users.Clear();
            var user_return = await restapiservice.GetTodos();
            foreach (var item in user_return)
            {
                Users.Add(item);
            }

        }
    }
}
