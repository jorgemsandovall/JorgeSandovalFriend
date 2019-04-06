using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public enum FriendType
    {
        Conocido,
        Compañero,
        Estudio,
        ColegaTrabajo,
        Amigo,
        AmigoInfancia,
        Pariente,


    }



    public class JorgeSandovalFriend
    {
        [Key]
        public int FriendId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Apodo { get; set; }
        public string Birthday { get; set; }
        [Required]
        public FriendType Type { get; set;}





    }
}