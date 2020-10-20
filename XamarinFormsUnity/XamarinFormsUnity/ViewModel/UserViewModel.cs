using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsUnity.Model;
using XamarinFormsUnity.Service;

namespace XamarinFormsUnity.ViewModel
{
    public class UserViewModel : BaseModel
    {
        private readonly RestApiService _restapiservice;
        public ObservableCollection<User> Users { get; }
        public Command ChangeAppearanceCommand { get; set; }

        public UserViewModel(RestApiService restapiservice)
        {
            ChangeAppearanceCommand = new Command<User>(ChangeAppearance);
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
        public void ChangeAppearance(User data)
        {
            var IdNivel = data.Id;
            App.Current.MainPage.DisplayAlert("", IdNivel.ToString(), "Ok");
        }
    }
}
