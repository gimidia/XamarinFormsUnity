using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinFormsUnity.Interface;
using XamarinFormsUnity.Model;

namespace XamarinFormsUnity.Service
{
    public class RestApiService : IRestApi
    {
        private readonly IRestApi _irestapi;
        public RestApiService()
        {
            _irestapi = RestService.For<IRestApi>(EndPoints.BaseUrl);
        }
        public async Task<ICollection<User>> GetTodos()
        {
            return await _irestapi.GetTodos();
        }

        public async Task<User> GetTodos(long id)
        {
            return await _irestapi.GetTodos(id);
        }
    }
}
