using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JJBA_SITE.Models
{
    public class Usuario
    {
        [Display(Name = "Digite seu nome:")]
        [Required(ErrorMessage = "Você não recebeu um nome")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Personagem ou/e Stand Favoritos:")]
        [Required(ErrorMessage = "Tem certeza que você não gosta de nenhum personagem? NEM DO SPEEDWAGON?")]
        public string Favs { get; set; }

        [Display(Name = "Email:")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Insira um email válido")]
        public string Email { get; set; }

        [Display(Name = "Crie seu Login:")]
        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login obrigatório")]
        // [Remote("Login", "Usuario", ErrorMessage = "Usuario já registrado")]
        public string Login { get; set; }

        [Display(Name = "Crie sua Senha:")]
        [Required(ErrorMessage = "Senha obrigatório")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar Senha:")]
        [System.ComponentModel.DataAnnotations.Compare("Senha", ErrorMessage = "A senha não corresponde")]
        public string ConfSenha { get; set; }
        
    }
}