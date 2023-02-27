using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace play2.ViewModels
{
    public class CreateCompMemberViewModel
    {
        public string MemberId { get; set; } = null!;

        [DisplayName("帳號(Email)")]
        [EmailAddress(ErrorMessage = "不正確的信箱格式")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string LoginEmail { get; set; } = null!;

        [DisplayName("密碼")]
        [StringLength(30, ErrorMessage = "密碼長度在 6 到 30 之間", MinimumLength = 6)]
        [Required(ErrorMessage = "此為必填欄位")]
        public string LoginPw { get; set; } = null!;

        [DisplayName("確認密碼")]
        [Required(ErrorMessage = "此為必填欄位")]
        [Compare("LoginPw", ErrorMessage = "密碼不一致")]
        public string CheckPw { get; set; } = null!;

        public string MemberType { get; set; } = null!;

        public int? IsCheck { get; set; }

        public string? CheckCode { get; set; }

        [DisplayName("公司名稱")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? CompanyName { get; set; }

        [DisplayName("負責人姓名")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? PrincipalMan { get; set; }

        [DisplayName("統一編號")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? TaxIdnumber { get; set; }

        [DisplayName("公司電話")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? Phone { get; set; }

        [DisplayName("公司地址")]
        [Required(ErrorMessage = "此為必填欄位")]
        public string? Addrest { get; set; }
    
        public string? SwiftCode { get; set; }

        public string? BankAccount { get; set; }
    }
}
