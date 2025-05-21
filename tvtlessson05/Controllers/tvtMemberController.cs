using Microsoft.AspNetCore.Mvc;
using tvtlessson05.Models.DataModels;

namespace tvtlessson05.Controllers
{
    public class tvtMemberController : Controller
    {
        private static List<tvtMember> tvtlistMember = new List<tvtMember>()
        {
             new tvtMember
                {
                    TvtMemberId = "23090095",
                    TvtUserName = "vawn taan",
                    TvtPassword = "password123",
                    TvtFullName = "ta van tan ",
                    TvtEmail = "tavantan113355@gmail.com"
                },
                new tvtMember
                {
                    TvtMemberId = "SV002",
                    TvtUserName = "tranthib",
                    TvtPassword = "abc123",
                    TvtFullName = "Trần Thị B",
                    TvtEmail = "thib@example.com"
                },
                new tvtMember
                {
                    TvtMemberId = "SV003",
                    TvtUserName = "lequangc",
                    TvtPassword = "quangpass",
                    TvtFullName = "Lê Quang C",
                    TvtEmail = "quangc@example.com"
                },
                new tvtMember
                {
                    TvtMemberId = "SV004",
                    TvtUserName = "phamthid",
                    TvtPassword = "phamt123",
                    TvtFullName = "Phạm Thị D",
                    TvtEmail = "thid@example.com"
                },
                new tvtMember
                {
                    TvtMemberId = "SV005",
                    TvtUserName = "hoangvanh",
                    TvtPassword = "hoang456",
                    TvtFullName = "Hoàng Văn H",
                    TvtEmail = "vanh@example.com"
                }
        };
        public IActionResult tvtIndex()
        {
            return View(tvtlistMember);
        }
    }
}
