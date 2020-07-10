using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstRazerPagesUI
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using FirstRazerPagesUI.Models;

    public interface ICosmosDbService
    {
        Task AddFirstNameAsync(ContactModel item);
        Task AddLastNameAsync(ContactModel item);
        Task AddEmailAsync(ContactModel item);
        Task AddMessageAsync(ContactModel item);

    }
}