using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Collections.Generic;
namespace Heera.InputCollector
{
    public class InputSaver
    {
        public void SaveInputData(PageModel pageModel)
        {
            var inputs = pageModel.Request.Form;

            List<string> columns = new List<string>();
            List<string> values = new List<string>();

            foreach (var key in inputs.Keys)
            {
                // You can add logic here to filter specific input controls if needed
                columns.Add(key);
                values.Add(inputs[key]);
            }

            
            
        }
    }
}
