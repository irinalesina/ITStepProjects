//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Example2ModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientSet
    {
        public ClientSet()
        {
            this.MessageSet = new HashSet<Message>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<Message> MessageSet { get; set; }
    }
}