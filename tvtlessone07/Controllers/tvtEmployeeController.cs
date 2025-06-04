using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tvtlessone07.Models;

namespace tvtlessone07.Controllers
{
    public class tvtEmployeeController : Controller
    {
        //moc data:
        private static List<tvtEmployee> tvtListEmployees = new List<tvtEmployee>()
        { 
         new tvtEmployee
            {
                tvtId = 1,
                tvtName = "tạ văn tân ",
                tvtBirthDay  = new DateTime(2005 , 5, 29),
                tvtEmail = "tavantan113355@gmail.com",
                tvtPhone = "0983915173",
                tvtSalary = 15000000,
                tvtStatus = true
            },
            new tvtEmployee
            {
                tvtId = 2,
                tvtName = "Trần Thị B",
                tvtBirthDay = new DateTime(2004 , 4 , 16 ),
                tvtEmail = "tranthib@example.com",
                tvtPhone = "0912345678",
                tvtSalary = 18000000,
                tvtStatus = true
            },
            new tvtEmployee
            {
                tvtId = 3,
                tvtName = "Lê Văn C",
                tvtBirthDay  = new DateTime(2005, 12, 10),
                tvtEmail = "levanc@example.com",
                tvtPhone = "0934567890",
                tvtSalary = 12000000,
                tvtStatus = false
            },
            new tvtEmployee
            {
                tvtId = 4,
                tvtName = "Phạm Thị D",
                tvtBirthDay  = new DateTime(2003, 3, 22),
                tvtEmail = "phamthid@example.com",
                tvtPhone = "0978123456",
                tvtSalary = 20000000,
                tvtStatus = true
            },
            new tvtEmployee
            {
                tvtId = 5,
                tvtName = "Hoàng Văn E",
                tvtBirthDay = new DateTime(2004, 7, 30),
                tvtEmail = "hoangvane@example.com",
                tvtPhone = "0987654321",
                tvtSalary = 22000000,
                tvtStatus = false
            }
           
    };
        // GET: tvtEmployeeController
        public ActionResult tvtIndex()
        {
            return View(tvtListEmployees);
        }

        // GET: tvtEmployeeController/Details/5
        public ActionResult tvtDetails(int id)
        {
            var tvtEmployee = tvtListEmployees.FirstOrDefault(x => x.tvtId == id);
            return View(tvtEmployee);
        }

        // GET: tvtEmployeeController/tvtCreate
        public ActionResult tvtCreate()
        {
            var tvtEmployee = new tvtEmployee();
            return View(tvtEmployee);
        }

        // POST: tvtEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult tvtCreate(tvtEmployee tvtModel)
        {
            try
            {
                //them moi nhan vien 
                tvtModel.tvtId = tvtListEmployees.Max(X => X.tvtId);
                tvtListEmployees.Add(tvtModel);
                return RedirectToAction(nameof(tvtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: tvtEmployeeController/Edit/5
        public ActionResult tvtEdit(int id)
        {
            var tvtEmployee = tvtListEmployees.FirstOrDefault(x => x.tvtId == id);
            return View();
        }

        // POST: tvtEmployeeController/tvtEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult tvtEdit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(tvtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: tvtEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: tvtEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, tvtEmployee tvtModel)
        {
            try
            {
                for (int i = 0; i < tvtListEmployees.Count(); i++ )
                {
                    if (tvtListEmployees[i].tvtId == id)
                    {
                        tvtListEmployees[i] = tvtModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(tvtIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
