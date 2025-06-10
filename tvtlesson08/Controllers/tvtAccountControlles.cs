using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tvtlesson08.Models;

namespace tvtlesson08.Controllers
{
    
    public class tvtAccountControlles : Controller
    {
        private static List<tvtAccount> tvtListAccount = new List<tvtAccount>()
        {
             new tvtAccount
    {
                tvtId = 231090095,
                tvtFullName = "ta van tan",
                tvtEmail = "tavantan113355@gmail.com",
                tvtPhone = "0901234567",
                tvtAddress = "Ha Noi",
                tvtAvatar = "https://example.com/a.jpg",
                tvtBirthday = new DateTime(2005,12,31),
                tvtGender = "Nam",
                tvtPassword = "123456",
                tvtFacebook = "https://facebook.com/nguyenvana"
    },
             new tvtAccount
    {
                 tvtId = 2,
                 tvtFullName = "Tran Thi B",
                 tvtEmail = "b@gmail.com",
                 tvtPhone = "0912345678",
                 tvtAddress = "TP.HCM",
                 tvtAvatar = "https://example.com/b.jpg",
                 tvtBirthday = new DateTime(1998, 5, 10),
                 tvtGender = "Nữ",
                 tvtPassword = "abcdef",
                 tvtFacebook = "https://facebook.com/tranthib"
    },
             new tvtAccount
    {
                tvtId = 3,
                tvtFullName = "Le Van C",
                tvtEmail = "c@gmail.com",
                tvtPhone = "0923456789",
                tvtAddress = "Da Nang",
                tvtAvatar = "https://example.com/c.jpg",
                tvtBirthday = new DateTime(1995, 12, 20),
                tvtGender = "Nam",
                tvtPassword = "pass123",
                tvtFacebook = "https://facebook.com/levanc"
    },
             new tvtAccount
    {
                tvtId = 4,
                tvtFullName = "Pham Thi D",
                tvtEmail = "d@gmail.com",
                tvtPhone = "0934567890",
                tvtAddress = "Can Tho",
                tvtAvatar = "https://example.com/d.jpg",
                tvtBirthday = new DateTime(1999, 3, 15),
                tvtGender = "Nữ",
                tvtPassword = "qwerty",
                tvtFacebook = "https://facebook.com/phamthid"
    },
             new tvtAccount
    {
                tvtId = 5,
                tvtFullName = "Hoang Van E",
                tvtEmail = "e@gmail.com",
                tvtPhone = "0945678901",
                tvtAddress = "Hue",
                tvtAvatar = "https://example.com/e.jpg",
                tvtBirthday = new DateTime(2001, 7, 25),
                tvtGender = "Nam",
                tvtPassword = "letmein",
                tvtFacebook = "https://facebook.com/hoangvane"
            }
    };
        // GET: tvtAbout
        public ActionResult tvtIndex()
        {
            return View(tvtListAccount);
        }

        // GET: tvtAbout/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: tvtAbout/Create
        public ActionResult tvtCreate()
        {
            return View();
        }

        // POST: tvtAbout/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: tvtAbout/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: tvtAbout/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: tvtAbout/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: tvtAbout/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }


        }
    }
}