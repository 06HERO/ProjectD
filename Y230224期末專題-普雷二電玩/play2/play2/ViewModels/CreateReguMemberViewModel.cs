using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace play2.ViewModels
{
    public class CreateReguMemberViewModel
    {
        public string MemberId { get; set; } = null!;

        [DisplayName("帳號(Email)")]
        [EmailAddress(ErrorMessage ="不正確的信箱格式")]
        [Required(ErrorMessage= "此為必填欄位")]
        public string LoginEmail { get; set; } = null!;

        [DisplayName("密碼")]       
        [StringLength(30,ErrorMessage ="密碼長度在 6 到 30 之間",MinimumLength = 6)]
        [Required(ErrorMessage = "此為必填欄位")]
        public string LoginPw { get; set; } = null!;

        [DisplayName("確認密碼")]      
        [Required(ErrorMessage = "此為必填欄位")]
        [Compare("LoginPw", ErrorMessage ="密碼不一致")]
        public string CheckPw { get; set; } = null!;

        public string MemberType { get; set; } = null!;

        public int? IsCheck { get; set; }

        public string? CheckCode { get; set; }

        [DisplayName("會員姓名")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? MemberName { get; set; }

        [DisplayName("身分證字號")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? PersonalNumber { get; set; }

        [DisplayName("電話(手機)")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? Phone { get; set; }

    }
}
