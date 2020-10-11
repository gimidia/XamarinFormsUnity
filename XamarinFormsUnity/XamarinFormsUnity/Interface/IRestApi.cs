using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinFormsUnity.Model;

namespace XamarinFormsUnity.Interface
{
    public interface IRestApi
    {
        [Get("/todos")]
        Task<ICollection<User>> GetTodos();

        [Get("/todos/{id}")]
        Task<User> GetTodos(long id);
    }
}
