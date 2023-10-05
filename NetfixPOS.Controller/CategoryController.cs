using NetfixPOS.Controller.Common;
using NetfixPOS.Controller.Interface;
using NetfixPOS.DataAccess;
using NetfixPOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetfixPOS.Controller
{
    public class CategoryController : ICategory
    {
        private CategoryDAL _category;
        private EventLogsController _eventLogs;
        public CategoryController()
        {
            _category = new CategoryDAL();
            _eventLogs = new EventLogsController();
        }
        public void Delete(int id)
        {
            try
            {
                _category.Delete(id);
                _eventLogs.AddLog("Delete", DateTime.Now, "Category Form", "Delete CategoryId "+id.ToString(), "Delete Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Delete", DateTime.Now, "Category Form", "Delete Category", ex.Message);
            }
            
        }

        public void Insert(CategoryModel category)
        {
            try
            {
                _category.Insert(category);
                _eventLogs.AddLog("Insert", DateTime.Now, "Category Form", "Insert "+category.CategoryName, "Insert Success");
            }
           catch(Exception ex)
            {
                _eventLogs.AddLog("Insert", DateTime.Now, "Category Form", "Insert Category", ex.Message);
            }
        }

        public void Update(CategoryModel category)
        {
            try
            {
                _category.Update(category);
                _eventLogs.AddLog("Update", DateTime.Now, "Category Form", "Update Category", "Update Success");
            }
            catch(Exception ex)
            {
                _eventLogs.AddLog("Update", DateTime.Now, "Category Form", "Update Category", ex.Message);
            }
           
        }

        public DataTable GetCategory(int id)
        {
            return _category.GetCategory(id);
        }
    }
}
