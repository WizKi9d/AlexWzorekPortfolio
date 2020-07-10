using System;


namespace FirstRazerPagesUI
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FirstRazerPagesUI.Models;
    using Microsoft.Azure.Cosmos;
    using Microsoft.Azure.Cosmos.Fluent;
    using Microsoft.Extensions.Configuration;

    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddFirstNameAsync(ContactModel item)
        {
            await this._container.CreateItemAsync<ContactModel>(item, new PartitionKey(item.FirstName));
        }

        public async Task AddLastNameAsync(ContactModel item)
        {
            await this._container.CreateItemAsync<ContactModel>(item, new PartitionKey(item.LastName));
        }

        public async Task AddEmailAsync(ContactModel item)
        {
            await this._container.CreateItemAsync<ContactModel>(item, new PartitionKey(item.Email));
        }

        public async Task AddMessageAsync(ContactModel item)
        {
            await this._container.CreateItemAsync<ContactModel>(item, new PartitionKey(item.Message));
        }


    }
}