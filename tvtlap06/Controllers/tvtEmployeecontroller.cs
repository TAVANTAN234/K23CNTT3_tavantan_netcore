using Microsoft.AspNetCore.Mvc;
using tvtlap06.Models;

namespace NvkLab06.Controllers
{
    public class tvtEmployeeController : Controller
    {
        private static List<tvtEmployee> tvtEmployees = new List<tvtEmployee>()
        {
            new tvtEmployee
            {
                tvtId = 1,
                tvtName = "tạ văn tân ",
                tvtBirthday = new DateTime(2005 , 5, 29),
                tvtEmail = "tavantan113355@gmail.com",
                tvtPhone = "0983915173",
                tvtSalary = 15000000,
                tvtStatus = true
            },
            new tvtEmployee
            {
                tvtId = 2,
                tvtName = "Trần Thị B",
                tvtBirthday = new DateTime(2004 , 4 , 16 ),
                tvtEmail = "tranthib@example.com",
                tvtPhone = "0912345678",
                tvtSalary = 18000000,
                tvtStatus = true
            },
            new tvtEmployee
            {
                tvtId = 3,
                tvtName = "Lê Văn C",
                tvtBirthday = new DateTime(2005 , 12, 10),
                tvtEmail = "levanc@example.com",
                tvtPhone = "0934567890",
                tvtSalary = 12000000,
                tvtStatus = false
            },
            new tvtEmployee
            {
                tvtId = 4,
                tvtName = "Phạm Thị D",
                tvtBirthday = new DateTime(2003 , 3, 22),
                tvtEmail = "phamthid@example.com",
                tvtPhone = "0978123456",
                tvtSalary = 20000000,
                tvtStatus = true
            },
            new tvtEmployee
            {
                tvtId = 5,
                tvtName = "Hoàng Văn E",
                tvtBirthday = new DateTime(2004 , 7, 30),
                tvtEmail = "hoangvane@example.com",
                tvtPhone = "0987654321",
                tvtSalary = 22000000,
                tvtStatus = false
            }
        };

        public ActionResult tvtIndex()
        {
            return View(tvtEmployees);
        }

        // GET: tvtEmployee/tvtCreate
        public ActionResult tvtCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult tvtCreate(tvtEmployee model)
        {
            if (ModelState.IsValid)
            {
                // Tự động tăng ID
                int newId = tvtEmployees.Any() ? tvtEmployees.Max(e => e.tvtId) + 1 : 1;
                model.tvtId = newId;

                tvtEmployees.Add(model);

                // Chuyển hướng về trang danh sách
                return RedirectToAction("tvtIndex");
            }

            // Nếu có lỗi, trả lại view form để sửa
            return View(model);
        }

        [HttpGet]
        public IActionResult tvtEdit(int id)
        {
            var tvtEmp = tvtEmployees.FirstOrDefault(e => e.tvtId == id);
            return View(tvtEmp);
        }

        [HttpPost]
        public IActionResult tvtEditPUT(tvtEmployee updatedEmp)
        {
            var tvtEmp = tvtEmployees.FirstOrDefault(e => e.tvtId == updatedEmp.tvtId);
            if (tvtEmp != null)
            {
                tvtEmp.tvtName = updatedEmp.tvtName;
                tvtEmp.tvtBirthday = updatedEmp.tvtBirthday;
                tvtEmp.tvtEmail = updatedEmp.tvtEmail;
                tvtEmp.tvtPhone = updatedEmp.tvtPhone;
                tvtEmp.tvtSalary = updatedEmp.tvtSalary;
                tvtEmp.tvtStatus = updatedEmp.tvtStatus;
            }
            return RedirectToAction("tvtIndex");
        }

        public IActionResult tvtDelete(int id)
        {
            var tvtEmp = tvtEmployees.FirstOrDefault(e => e.tvtId == id);
            if (tvtEmp != null) tvtEmployees.Remove(tvtEmp);
            return RedirectToAction("tvtIndex");
        }
    }
}
