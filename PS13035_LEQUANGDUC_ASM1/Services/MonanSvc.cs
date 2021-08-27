using PS13035_LEQUANGDUC_ASM1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS13035_LEQUANGDUC_ASM1.Services
{
    public interface IMonAnSvc
    {
        List<MonAn> GetMonAnAll();
        MonAn GetMonAn(int id);
        int AddMonAn(MonAn monAn);
        int EditMonAn(int id, MonAn monAn);

    }
    public class  MonanSvc : IMonAnSvc
    {
        protected DataContext _context;
        public MonanSvc(DataContext context)
        {
            _context = context;
        }
        public List<MonAn> GetMonAnAll()
        {
            List<MonAn> List = new List<MonAn>();
            List = _context.MonAns.ToList();
            return List;
        }
        public MonAn GetMonAn(int id)
        {
            MonAn monAn = null;
            monAn = _context.MonAns.Find(id);
            return monAn;
        }
        public int AddMonAn(MonAn monAn)
        {
            int ret = 0;
            try
            {
                _context.Add(monAn);
                _context.SaveChanges();
                ret = monAn.MonanID;
            }
            catch
            {
                ret = 0;
            }
            return ret;
        }

        public int EditMonAn(int id, MonAn monAn)
        {
            int ret = 0;
            try
            {
                MonAn _monAn = null;
                _monAn = _context.MonAns.Find(id); //cách này chỉ dùng cho Khóa chính

                _monAn.Name = monAn.Name;
                _monAn.Gia = monAn.Gia;
                _monAn.Phanloai = monAn.Phanloai;
                _monAn.Hinh = monAn.Hinh;
                _monAn.Mota = monAn.Mota;
                _monAn.Trangthai = monAn.Trangthai;

                _context.Update(_monAn);
                _context.SaveChanges();
                ret = monAn.MonanID;
            }
            catch
            {
                ret = 0;
            }
            return ret;

        }

       
    }
}
