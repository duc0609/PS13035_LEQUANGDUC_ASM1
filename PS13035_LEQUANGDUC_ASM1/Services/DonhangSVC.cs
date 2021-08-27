using Microsoft.EntityFrameworkCore;
using PS13035_LEQUANGDUC_ASM1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Services
{
    public interface IDonhangSVC
    {
        List<Donhang> GetDonhangAll();
        List<Donhang> GetDonhangbykhachhang(int khachhangID);
        Donhang GetDonhang(int id);
        int AddDonhang(Donhang donhang);
        int editDonhang(int id, Donhang donhang);
    }
    public class DonhangSVC : IDonhangSVC
    {
        protected DataContext _context;

        public DonhangSVC(DataContext context)
        {
            _context = context;
        }
        public List<Donhang> GetDonhangAll()
        {
            List<Donhang> list = new List<Donhang>();
            list = _context.Donhangs.OrderByDescending(x => x.Ngaydat)
                .Include(x => x.khachhang)
                .Include(x => x.DonhangChitiets)
                .ToList();
            return list;
        }
        public List<Donhang>GetDonhangbykhachhang(int khachhangid)
        {
            List<Donhang> list = new List<Donhang>();
            list = _context.Donhangs.Where(x => x.KhachhangID == khachhangid).OrderByDescending(x => x.Ngaydat)
                .Include(x => x.khachhang)
                .Include(x => x.DonhangChitiets)
                .ToList();
            return list;
        }
        public Donhang GetDonhang(int id)
        {
            Donhang donhang = null;
            donhang = _context.Donhangs.Where(x => x.DonhangID == id)
                .Include(x => x.khachhang)
                .Include(x => x.DonhangChitiets).ThenInclude(y => y.MonAn)
                .FirstOrDefault();
            return donhang;
        }
        public int AddDonhang(Donhang donhang)
        {
            int ret = 0;
            try
            {
                _context.Add(donhang);
                _context.SaveChanges();
                ret = donhang.DonhangID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }
        public int editDonhang( int id,Donhang donhang)
        {
            int ret = 0;
            try
            {
                _context.Update(donhang);
                _context.SaveChanges();
                ret = donhang.DonhangID;
            }
            catch (Exception )
            {
                ret = 0;
            }
            return ret;
        }

    }
 
}
