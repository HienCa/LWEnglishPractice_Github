using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LWEnglishPractice.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Cryptography;
using QuanLySanXuat.Service;
using QuanLySanXuat.Entities;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace LWEnglishPractice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ListenAndWriteContext _context;

        public HomeController(ListenAndWriteContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Learning(int id, Track track)
        {

            
           
            List<Track> mytrack = await _context.Track.Where(a => a.Idlesson == id).Include(l => l.IdlessonNavigation).Include(l => l.IdlessonNavigation.IdlevelNavigation).ToListAsync();
            TempData["track"] = mytrack;
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Formatting = Formatting.Indented
            };
            ViewBag.CookieValue = JsonConvert.SerializeObject(mytrack, settings);
            return View(await _context.Track.Where(a => a.Idlesson == id).Include(l => l.IdlessonNavigation).Include(l => l.IdlessonNavigation.IdlevelNavigation).FirstOrDefaultAsync());

        }
        public async Task<IActionResult> Index()
        {
            var listenAndWriteContext = _context.Lesson.Include(l => l.IdlevelNavigation);
            return View(await listenAndWriteContext.Where(a => a.Active == 1).ToListAsync());
        }
        //public IActionResult Index()
        //{
        //    ClaimsPrincipal claimUser = HttpContext.User;
        //    if (claimUser.Identity.IsAuthenticated)
        //    {
        //        return RedirectToAction("Learning", "Home");

        //    }
        //    return View();
        //}
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup(Account account)
        {
            Learner learner = new Learner();
            learner.Email = account.Email;
            learner.Password = account.Password;
            learner.Fullname = "Bimat";
            learner.Sex = "Khác";
            learner.Joindate = DateTime.Now;
            _context.Learner.Add(learner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Login));

        }
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Account account)
        {

            Learner l = _context.Learner.Where(tk => tk.Email.Equals(account.Email)).Where(tk => tk.Password.Equals(account.Password)).FirstOrDefault();
            if (l != null)
            {
                Response.Cookies.Append("HienCaCookie", l.Email);
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, l.Email),
                    new Claim("OtherProperties", "Example Role")
                };
                ClaimsIdentity claimIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);
                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = account.KeepLoggedIn
                };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimIdentity), properties);


                return RedirectToAction("Learning", "Home");

            }
            else
            {
                ViewData["ValidateMessage"] = "Tài khoản đăng nhập không hợp lệ";

            }

            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public string GenerateToken(int length)
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer);
            }
        }
        [HttpPost]
        public IActionResult ForgotPassword(Learner learner)
        {

            var newPassword = GenerateToken(12);
            string errorMessage = "Email không chính xác. Vui lòng kiểm tra lại email!";


            try
            {
                Learner l = _context.Learner.Where(tk => tk.Email.Equals(learner.Email)).FirstOrDefault();

                string message = "";
                var address = learner.Email;

                var subject = "Reset your password";

                var mailContent = new MailContent();
                mailContent.Subject = subject;
                if (l != null)
                {
                    message = "Xin Chào '" + l.Fullname + "' Mật khẩu mới của bạn là " + newPassword;
                    l.Password = newPassword;
                    mailContent.To = l.Email;
                }

                else
                {
                    ViewData["errorMessage"] = errorMessage;
                }
                mailContent.Body = "<h1>From HienCa Production</h1><br/>" + message;


                SendMailService c = new SendMailService();
                c.SendMail(mailContent);

                _context.SaveChanges();

                TempData["SuccessMessage"] = "Chúng tôi đã gửi mail xác nhận đến cho bạn. Vui lòng kiểm tra mail!";

                //return RedirectToAction("Login", "Access");


            }
            catch (Exception e)
            {
                ViewData["errorMessage"] = "Email không khả dụng " + e;
            }



            return View();
        }

        public static string RandomNumber(int numberRD)
        {
            string randomStr = "";
            try
            {

                int[] myIntArray = new int[numberRD];
                int x;
                //that is to create the random # and add it to string
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return randomStr;
        }
    }
}
