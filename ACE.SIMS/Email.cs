//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACE.SIMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Email
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public bool NotifyUpload { get; set; }
        public bool NotifyProcessed { get; set; }
        public bool NotifySent { get; set; }
        public string EmailAddress { get; set; }
    }
}
