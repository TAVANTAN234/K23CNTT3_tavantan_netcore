using System.ComponentModel.DataAnnotations;

namespace tvtlesson08.Models
{
    public class tvtAccount
    {
        [Key]
        public int tvtId { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [MinLength(6, ErrorMessage = "Họ và tên ít nhất 6 ký tự")]
        [MaxLength(20, ErrorMessage = "Họ và tên tối đa 20 ký tự")]
        public string tvtFullName { get; set; }

        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng")]
        public string tvtEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^(\+84|0)\d{2}[-.\s]?\d{3}[-.\s]?\d{4}$",
            ErrorMessage = "Số điện thoại không hợp lệ")]
        public string tvtPhone { get; set; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không được vượt quá 35 ký tự")]
        public string tvtAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string tvtAvatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime tvtBirthday { get; set; }

        [Display(Name = "Giới tính")]
        public string tvtGender { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [MinLength(6, ErrorMessage = "Mật khẩu phải ít nhất 6 ký tự")]
        [DataType(DataType.Password)]
        public string tvtPassword { get; set; }

        [Display(Name = "Facebook")]
        public string tvtFacebook { get; set; }
    }
}