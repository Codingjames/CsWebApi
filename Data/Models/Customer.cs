using System;
namespace JApi.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }   
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string TaxNo { get; set; }
        public int CustomerTypeId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatorId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? EditorId { get; set; }


        // INSERT INTO Customers 
        // (Code,Name,LastName,PhoneNo,Address,Email,TaxNo,CustomerTypeId,IsActive,IsDelete,EditorId,CreatedDate,CreatorId) 
        // VALUES('0003','ยลดา','ธนครุฑ','','131 ม1 บ.ท่าอุเทน ต.ท่าอุเทน อ.ท่าอุเทน จ.นครพนม 48120','','',1,1,0,1,
        // getdate(),1
        // );
    }
}