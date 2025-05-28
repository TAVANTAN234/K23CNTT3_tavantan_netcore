using Microsoft.AspNetCore.Mvc;
using tvtlap06.Models;

namespace tvtlap06.Controllers
{
    public class tvtEmployeecontroller : Controller
    {
        private static List<tvtEmployee> tvtEmployees = new List<tvtEmployee>()
        {
                new tvtEmployee { tvtId = 1, tvtName = "ta van tan ",tvtBirthDay = new DateTime(1990, 5, 12), tvtEmail = "tavantan113355@gmail.com", tvtPhone = "0867437604", tvtSalary = 15000000, tvtStatus = true },
                new tvtEmployee { tvtId = 2, tvtName = "Trần Thị B", tvtBirthDay = new DateTime(1985, 11, 23), tvtEmail = "b.tran@example.com", tvtPhone = "0907654321", tvtSalary = 17000000, tvtStatus = false },
                new tvtEmployee { tvtId = 3, tvtName = "Lê Văn C", tvtBirthDay = new DateTime(1995, 1, 8), tvtEmail = "c.le@example.com", tvtPhone = "0912345678", tvtSalary = 13000000, tvtStatus = true },
                new tvtEmployee { tvtId = 4, tvtName = "Phạm Thị D", tvtBirthDay = new DateTime(1992, 7, 19), tvtEmail = "d.pham@example.com", tvtPhone = "0932123456", tvtSalary = 16000000, tvtStatus = true },
                new tvtEmployee { tvtId = 5, tvtName = "Hoàng Văn E", tvtBirthDay = new DateTime(1988, 3, 3), tvtEmail = "e.hoang@example.com", tvtPhone = "0978123456", tvtSalary = 14500000, tvtStatus = false }
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
