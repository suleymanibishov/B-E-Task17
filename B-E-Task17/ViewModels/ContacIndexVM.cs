using B_E_Task17.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B_E_Task17.ViewModels
{
    public class ContacIndexVM
    {
        public ContactTitle ContactInfo { get; set; }
        public List<ContactsType> ContactsTypes { get; set; }
    }
}
