using Microsoft.AspNetCore.Mvc;
using webShop.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //בתוך הדאטה בייס
        //static List<Product> Products = new List<Product>() {
        //      new Product(1, "חלב תנובה 3%", "חלב טרי 3% שומן", 5.90, 50),
        //      new Product(2, "לחם אחיד", "לחם לבן פרוס", 8.50, 30),
        //      new Product(3, "ביצים L", "ביצים בגודל גדול", 12.00, 20),
        //      new Product(4, "עגבניות", "עגבניות טריות", 7.90, 100),
        //      new Product(5, "מלפפונים", "מלפפונים טריים", 6.50, 80),
        //      new Product(6, "קוטג' תנובה 5%", "גבינת קוטג' 5% שומן", 6.20, 40),
        //      new Product(7, "שוקולד פרה", "שוקולד חלב", 4.80, 60),
        //      new Product(8, "קפה נמס עלית", "קפה נמס מגורען", 18.00, 25),
        //      new Product(9, "אורז בסמטי", "אורז בסמטי איכותי", 15.50, 35),
        //      new Product(10, "פסטה ספגטי", "פסטה ספגטי מחיטת דורום", 9.90, 50),
        //      new Product(11, "תפוזים", "תפוזים סחוטים טריים", 8.90, 60),
        //      new Product(12, "לחם שיפון", "לחם שיפון מלא", 12.50, 25),
        //};

        //ShopDBContext יצרנו משתנה מסוג  
        //כי הוא מחובר ישירות לדאטה בייס
        private readonly ShopDBContext _Context;

        public ProductController()
        {
            _Context=new ShopDBContext();
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_Context.Products.ToList());
        }


        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product p = _Context.Products.First(p => p.Id == id);
                return Ok(p);
            }
            catch
            {
                return NotFound("Id is not valid");
            }

        }


        //מסמך של כל המוצרים
        // POST api/<ProductController>
        [HttpPost("createDataSave/{path}")]
        public IActionResult Post(string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Product p in _Context.Products)
                    {
                        writer.WriteLine("product" + p.Id);
                        writer.WriteLine(p.Name);
                        writer.WriteLine(p.Price);
                        writer.WriteLine(p.Description);
                        writer.WriteLine(p.StockQuantity);
                    }
                    return Ok("succeed");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product p)
        {
            try
            {
                _Context.Products.Add(p);  
                _Context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product p)
        {
            Product product = _Context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new Exception("Not Exist for update");  
            }
            product.Name = p.Name;
            product.Description = p.Description;
            product.Price = p.Price;
            product.StockQuantity = p.StockQuantity;

            _Context.SaveChanges();

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                Product product = _Context.Products.FirstOrDefault(p => p.Id == id);
                if (product == null)
                {
                    throw new Exception("Not Exist for delete");
                }
                _Context.Products.Remove(product);
                _Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

