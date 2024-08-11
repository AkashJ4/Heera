using Heera.InputCollector;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Heera.Pages.Authorization
{
    public class UsersModel : PageModel
    {
        private readonly InputSaver _inputSaver;

        public UsersModel()
        {
            _inputSaver = new InputSaver();
        }

        public void OnGet()
        {
            // Your logic to load the page if necessary
        }

        public void OnPost()
        {
            // Example: Pass the PageModel, connection string, and table name to the helper method
            string connectionString = "Your_SQL_Connection_String";
            string tableName = "YourTableName";

            _inputSaver.SaveInputData(this);

            // You can add additional logic here if needed
        }
        public void OnPostSave()
        {
            
            _inputSaver.SaveInputData(this);

            // You can add additional logic here if needed
        }
    }
}
