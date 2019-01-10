using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Market.Model;
using Market.BSS;
using PostgreSQL;


[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    // GET api/product
    [HttpGet("")]
    public ActionResult<List<Product>> GetProducts()
    {
        using (EntityContext _db = new EntityContext())
        {
            ProductBL pro = new ProductBL(_db);

                return pro.GetAll().ToList();
        }
    }
    [HttpGet("{name}")]
    public ActionResult<List<Product>> GetProductsByName(string name, int sliceNumber = 0, int startPage = 0)
    {
        using (EntityContext _db = new EntityContext())
        {
            ProductBL pro = new ProductBL(_db);
            if (sliceNumber != 0)
            {
                return pro.GetByName(name).ToList();
            }
            else
            {
                return pro.GetByName(name, sliceNumber, startPage).ToList();
            }
        }
    }
    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Product> Get(int id)
    {
        using (EntityContext _db = new EntityContext())
        {
            ProductBL pro = new ProductBL(_db);
            return pro.GetById(id);
        }
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}