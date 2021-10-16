using System.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace JApi.Controllers
{
    public interface IControllerApi<T>
    {
        // CRUD

         public IActionResult Create(T request);
        
 
         public ActionResult<List<T>> GetAll();
        

         public ActionResult<T> Get(int id);
         

         public IActionResult Update(int id,T request);
         

         public IActionResult Delete(int id);
        
    }
}