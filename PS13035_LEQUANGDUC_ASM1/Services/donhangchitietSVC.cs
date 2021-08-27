using PS13035_LEQUANGDUC_ASM1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Services
{
    public interface IdonhangchitietSVC
    {
        int AddDonhangchitietSVC(DonhangChitiet donhangchitiet);
      
    }
    public class donhangchitietSVC :IdonhangchitietSVC
    {
        protected DataContext _context;
        public donhangchitietSVC(DataContext context)
        {
            _context = context;
        }
        public int AddDonhangchitietSVC(DonhangChitiet donhangChitiet)
        {
            int ret = 0;
            try
            {
                _context.Add(donhangChitiet);
                _context.SaveChanges();
                ret = donhangChitiet.ChitietID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

      
    }
}
