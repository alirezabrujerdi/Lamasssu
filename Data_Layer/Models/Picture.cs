using System;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer
{
    public class Picture
    {
        [Key]
        public Guid PictureID { get; set; }

        [Display(Name = "کاربر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public Guid UserID { get; set; }

        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا عکس را آپلود کنید")]
        public string PictureAddress { get; set; }

        [Display(Name = "عنوان عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Name { get; set; }

        [Display(Name = "توضیحات عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "تعداد افرادی که این عکس را پسندیدند")]
        public int LikeNumbers { get; set; }

        [Display(Name = "بازدید")]
        public int VisitNumbers { get; set; }

        [Display(Name = "تاریخ ثبت")]
        [DataType(DataType.DateTime)]
        public DateTime DateOfCreate { get; set; }

        [Display(Name = "قیمت عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Price { get; set; }

        [Display(Name = "کلمات کلیدی")]
        public string Tags { get; set; }

        [Display(Name ="تأیید ادمین")]
        public bool IsConfiremd { get; set; }

        public virtual Profile User { get; set; }

        public Picture()
        {

        }
    }
}
