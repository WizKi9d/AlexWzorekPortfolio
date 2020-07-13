using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstRazerPagesUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;

namespace FirstRazerPagesUI.Pages
{
    public class ContactDisplayModel : PageModel
    {

        private static readonly string cosmosKey = "Sz8UB7oIozunWqNWTxaHeUSmQ7ppjBlzjoUTV5Xa9ttJ8MGAv22ty7HSb3vlfP4uIVHMjlME6edSUAJ6FmO0fA==";
        private static readonly string cosmosUrl = "https://90109cbe-0ee0-4-231-b9ee.documents.azure.com:443/";

        [BindProperty]
        public List<ContactModel> getAllItems { get; set; }

        public void OnGet()
        {
            getAllItems = ReadAllItems();
        }
        
        static List<ContactModel> ReadAllItems()
        {
            CosmosClient client = new CosmosClient(cosmosUrl, cosmosKey);
            var resultsList = new List<ContactModel>();
            var items = client.GetDatabase("ContactForm").GetContainer("SecondaryContactForm").GetItemQueryIterator<ContactModel>("SELECT c.firstName, c.lastName, c.email, c.message, c.date FROM c", null, new QueryRequestOptions() { PartitionKey = new PartitionKey("ContactMessages") });

            while (items.HasMoreResults)
            {
                var result = items.ReadNextAsync().Result;
                resultsList.AddRange(result);
            }
            return resultsList;
        } 
    }
}