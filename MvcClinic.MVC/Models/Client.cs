using System;
using System.ComponentModel.DataAnnotations;

namespace MvcClinic.MVC.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [StringLength(150, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(11)]
        public string CPF { get; set; }
        [Display(Name = "Número do Celular")]
        public string CellPhone { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string DateBirth { get; set; }
        [Display(Name = "Endereço")]
        [StringLength(150, ErrorMessage = "Máximo de 150 caracteres")]
        public string Address { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de cadastro")]
        public DateTime RegDate { get; set; }
        [Display(Name = "Estado Civil")]
        public string MaritalStatus { get; set; }
    }
}
