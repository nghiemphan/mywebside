//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKho.Model
{
    using QuanLyKho.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class Suplier: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suplier()
        {
            this.Objects = new HashSet<Object>();
        }
        
        private int _Id;
        public int Id { get=>_Id; set { _Id = value;OnPropertyChanged(); } }
        private string _DisplayName;
        public string DisplayName { get=>_DisplayName; set { _DisplayName = value;OnPropertyChanged(); } }
        private string _Address;
        public string Address { get=>_Address; set { _Address = value;OnPropertyChanged();} }
        private string _Phone;
        public string Phone { get=>_Phone; set { _Phone = value;OnPropertyChanged(); } }
        private string _Email;
        public string Email { get=>_Email; set { _Email = value;OnPropertyChanged(); } }
        private string _MoreInfo;
        public string MoreInfo { get=> _MoreInfo; set { _MoreInfo = value;OnPropertyChanged(); } }
        private DateTime? _ContractDate;
        public Nullable<System.DateTime> ContractDate { get => _ContractDate; set { _ContractDate = value; OnPropertyChanged(); } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object> Objects { get; set; }
    }
}
