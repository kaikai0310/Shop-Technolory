using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class RegisterModel
    {
        [Key]
        public long ID { get; set; }
        [Display(Name="Tên đăng nhập")]
        [Required(ErrorMessage ="Yêu cầu nhập tên đăng nhập.")]
        public string UserName { get; set; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="Độ dài mật khẩu ít nhất 6 ký tự.")]
        [Required(ErrorMessage = "Yêu cầu nhập mật khẩu.")]
        public string PassWord { get; set; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("PassWord",ErrorMessage ="Xác nhận mật khẩu không đúng.")]
        public string ConfirmPassWord { get; set; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên.")]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Yêu cầu nhập email.")]
        public string Email { get; set; }

        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }

        [Display(Name = "Tỉnh/Thành phố")]
        [Required(ErrorMessage ="Yêu cầu chọn tỉnh/thành phố bạn đang sống")]
        public string ProvinceID { get; set; }

        [Display(Name = "Quận/Huyện")]
        [Required(ErrorMessage = "Yêu cầu chọn quận/huyện bạn đang sống")]
        public string DistrictID { get; set; }

        //[Display(Name = "Xã/Thị trấn")]
        //[Required(ErrorMessage = "Yêu cầu chọn xã/thị trấn bạn đang sống")]
        //public string PrecinctID { get; set; }

    }
}