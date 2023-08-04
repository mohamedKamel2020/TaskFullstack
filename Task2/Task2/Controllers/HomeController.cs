using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Task2.Models;

namespace Task2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string input1, string input2)
        {
            int leftNumber=0;
            int rightNumber=0;
            string encryptedInput1 = EncryptString(input1);
            string encryptedInput2 = EncryptString(input2);

            // Perform the sum operation
            int result = leftNumber << rightNumber;

            // Pass the encrypted inputs and sum to the view
            ViewBag.EncryptedInput1 = encryptedInput1;
            ViewBag.EncryptedInput2 = encryptedInput2;
            ViewBag.Result=result;
            return View();
        }
        private static string EncryptString(string input)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes("YourEncryptionKey123");
                aes.IV = Encoding.UTF8.GetBytes("YourEncryptionIV456");

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                return Convert.ToBase64String(encryptedBytes);
            }

        } 
        public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    } 