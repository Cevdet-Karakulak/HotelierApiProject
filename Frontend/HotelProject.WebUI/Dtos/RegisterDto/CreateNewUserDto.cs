using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Cinsiyet Alanı Gereklidir")]
        public string Gender { get; set; }
        
        [Required(ErrorMessage = "Resim Seçimi Gereklidir")]
        public string ImageUrl { get; set; }


        [Required(ErrorMessage = "Şehir Alanı Gereklidir")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "Ülke Alanı Gereklidir")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        [MinLength(6, ErrorMessage = "Şifre en az 6 karakter olmalıdır")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
