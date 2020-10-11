using Refit;
using System;
using System.Collections.Generic;
using System.Text;
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
