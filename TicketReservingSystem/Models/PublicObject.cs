using System;
namespace TicketReservingSystem.Models
{
    public class PublicObject
    {
        public bool IsActive { get; set; } = true;
        public bool IsDel { get; set; } = false;
        public DateTime CreatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public int DeletedBy { get; set; }
        public int ModifiedBy { get; set; }
        public string Desciption { get; set; }


        public void CreateIt(int userId)
        {
            this.CreatedBy = userId;
            this.CreatedDate = DateTime.Now;
        }

        public void ModifyIt(int userId)
        {
            this.ModifiedDate = DateTime.Now;
            this.ModifiedBy = userId;
        }

        public void DeleteIt(int userId)
        {
            this.DeletedBy = userId;
            this.DeletedDate = DateTime.Now;
            this.IsDel = true;
        }
    }
}
