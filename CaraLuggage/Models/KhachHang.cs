﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CaraLuggage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.DonHangs = new HashSet<DonHang>();
        }

        [Display(Name = "Mã khách hàng")]
        public string customer_id { get; set; }

        [Display(Name = "Tên khách hàng")]
        public string customer_name { get; set; }

        [Display(Name = "SĐT khách hàng")]
        public string customer_phone { get; set; }

        [Display(Name = "Địa chỉ khách hàng")]
        public string customer_address { get; set; }

        [Display(Name = "Tài khoản khách hàng")]
        public string customer_account { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
