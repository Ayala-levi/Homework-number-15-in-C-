using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> Products = new List<Product>() {
              new Product(1, "חלב תנובה 3%", "חלב טרי 3% שומן", 5.90, 50),
              new Product(2, "לחם אחיד", "לחם לבן פרוס", 8.50, 30),
              new Product(3, "ביצים L", "ביצים בגודל גדול", 12.00, 20),
              new Product(4, "עגבניות", "עגבניות טריות", 7.90, 100),
              new Product(5, "מלפפונים", "מלפפונים טריים", 6.50, 80),
              new Product(6, "קוטג' תנובה 5%", "גבינת קוטג' 5% שומן", 6.20, 40),
              new Product(7, "שוקולד פרה", "שוקולד חלב", 4.80, 60),
              new Product(8, "קפה נמס עלית", "קפה נמס מגורען", 18.00, 25),
              new Product(9, "אורז בסמטי", "אורז בסמטי איכותי", 15.50, 35),
              new Product(10, "פסטה ספגטי", "פסטה ספגטי מחיטת דורום", 9.90, 50),
              new Product(11, "תפוזים", "תפוזים סחוטים טריים", 8.90, 60),
              new Product(12, "לחם שיפון", "לחם שיפון מלא", 12.50, 25),
        };
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }


        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product p = Products.First(p => p.Id == id);
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
                    foreach (Product p in Products)
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


        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product p)
        {
            try
            {
               p.Id = Products[Products.Count - 1].Id + 1;
               Products.Add(p);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product p)
        {
            int index = Products.FindIndex(p => p.Id == id);
            Products[index].Id = id;
            Products[index].Name = p.Name;
            Products[index].Description = p.Description;
            Products[index].Price = p.Price;
            Products[index].StockQuantity = p.StockQuantity;

        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                int index = Products.FindIndex(p => p.Id == id);
                Products.RemoveAt(index);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

