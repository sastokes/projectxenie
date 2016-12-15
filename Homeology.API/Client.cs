//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homeology.API
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Attachments = new HashSet<Attachment>();
            this.DealByContacts = new HashSet<DealByContact>();
        }
    
        public int ID { get; set; }
        public int client_id { get; set; }
        public Nullable<int> agent_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string client_email { get; set; }
        public string client_phone { get; set; }
        public string client_notes { get; set; }
        public string client_referrer { get; set; }
        public Nullable<System.DateTime> client_registration { get; set; }
        public string IdentityCard { get; set; }
    
        public virtual Agent Agent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attachment> Attachments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealByContact> DealByContacts { get; set; }
    }
}