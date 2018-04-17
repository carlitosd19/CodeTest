namespace WebUI.Controllers
{
    using System.Web.Http;
    using BLL;

    public class CodeTestAPIController : ApiController
    {
        [HttpGet]
        [Route("api/CodeTestAPI/Ispalindrome/{param}")]
        public IHttpActionResult GetPalindrome(string param)
        {
            if (string.IsNullOrEmpty(param))
                return BadRequest("Value cannot be null or empty");
            
            var pal = new CodeTest();
            var palindrome = pal.IsPalindrome(param);
            return Ok(new { ispal = palindrome });
        }
    }
}
