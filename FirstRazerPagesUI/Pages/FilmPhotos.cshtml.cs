using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRazerPagesUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Azure.Cosmos;
using Microsoft.Extensions.Options;

namespace FirstRazerPagesUI.Pages
{
    public class FilmPhotosModel : PageModel
    {

        [BindProperty]
        public ContactModel Contact { get; set; }

        private static readonly string cosmosKey = "Sz8UB7oIozunWqNWTxaHeUSmQ7ppjBlzjoUTV5Xa9ttJ8MGAv22ty7HSb3vlfP4uIVHMjlME6edSUAJ6FmO0fA==";
        private static readonly string cosmosUrl = "https://90109cbe-0ee0-4-231-b9ee.documents.azure.com:443/";
        private static readonly string databaseName = "ContactForm";

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            string firstName = Contact.FirstName;
            string lastName = Contact.LastName;
            string email = Contact.Email;
            string message = Contact.Message;
            string date = DateTime.Now.ToString();
            CreateItem(firstName, lastName, email, message, date, databaseName).Wait();

            return RedirectToPage("/Index");
        }

        public static async Task CreateItem(string firstName, string lastName, string email, string message, string date, string databaseName)
        {
            CosmosClient client = new CosmosClient(cosmosUrl, cosmosKey);
            Database database = await client.CreateDatabaseIfNotExistsAsync(databaseName);
            Container container = await database.CreateContainerIfNotExistsAsync(
                "SecondaryContactForm", "/partitionKeyPath", 400);
            dynamic TestItem = new { id = Guid.NewGuid().ToString(), partitionKeyPath = "ContactMessages", firstName = firstName, lastName = lastName, email = email, message = message, date = date };
            var response = await container.CreateItemAsync(TestItem);
        }


    }
}