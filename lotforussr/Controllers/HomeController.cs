using lotforussr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace lotforussr.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
     
        

        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        
        public IActionResult Index()
        {
            var temp = db.Users.Include(i=>i.Lots).Include(i=>i.Histories).SingleOrDefault(i => i.isreg);
         
            return View(temp);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> Eror()
        {
            return View();

        }
        public async Task<IActionResult> Regist()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Regist(User user)
        {
            if (user!=null)
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
            var data = db.Users.ToList() ;
            return RedirectToAction("Index");
        }
  
        public async Task<IActionResult> Enter()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Enter(User user)
        {
            var username = db.Users.Select(i=>i.UserName).ToList();
            var userpas = db.Users.Select(i => i.Password).ToList();

            if (user!=null)
            {

            if (username.Contains(user.UserName)&& userpas.Contains(user.Password))
            {

                    user = db.Users.Include(i => i.Lots).SingleOrDefault(i=>i.UserName==user.UserName&&i.Password==user.Password);

                    user.isreg = true;
                    db.Update(user);
                    var temp = db.Users.ToList();


                    db.SaveChanges();
                     temp = db.Users.ToList();



                    return RedirectToAction("Index");
            }
            }
            return RedirectToAction("Eror");
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(lot lot)
        {
            if (lot != null)
            {
                lot.User = db.Users.SingleOrDefault(i=>i.isreg);
                db.Lots.Add(lot);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
           
            if (id != null)
            {
                var details = db.Lots.Include(i=>i.History).Include(i=>i.User).SingleOrDefault(i => i.Id == id);
                if (details != null)
                    return View(details);


            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                var details = db.Lots.SingleOrDefault(i => i.Id == id);
                if (details != null)
                    return View(details);


            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(lot lot)
        {
          

            lot.User = db.Users.SingleOrDefault(i=>i.isreg);
            db.Lots.Update(lot);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                db.Lots.Remove(db.Lots .SingleOrDefault(i => i.Id == id));
                await db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            else
                return NotFound();

        }
        public async Task<IActionResult> Exit()
        {

            var temp = db.Users.ToList();

            var user = db.Users.SingleOrDefault(i=>i.isreg);
            user.isreg = false;
            db.Users.Update(user);
             temp = db.Users.ToList();

            db.SaveChanges();
             


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Bidon(int? id)
        {
            var lotbid = db.Lots.ToList().SingleOrDefault(i => i.Id == id);
            lotbid.isbid = true;
            db.Update(lotbid);
            db.SaveChanges();
            var temp = db.Lots.ToList();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Fullbid()
        {
            var bid = db.Lots.Include(i => i.User).Where(i => i.isbid).ToList();
            return View(bid);
        }
        public async Task<IActionResult> Monforbid(int? id)
        {
            if (id!=null)
            {
                var lotbid = db.Lots.Include(i => i.User).ToList().SingleOrDefault(i => i.Id == id); ;
                return View(lotbid);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Monforbid(int? id,int sum)
        {
            var lot = db.Lots.Include(i=>i.User).Include(i=>i.History).ToList().SingleOrDefault(i => i.Id == id);
            lot.Finalprice = sum;
            var regu = db.Users.Single(i=>i.isreg);
            var his = new History { bid = sum, bidusername = regu.UserName, Userforbid = regu,Lot=lot };
            db.Histories.Add(his);
            lot.History.Add(his);

            db.Update(lot);
            db.SaveChanges();
            var temp = db.Lots.Include(i => i.History).Include(i=>i.User).ToList();
            return RedirectToAction("Fullbid");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
