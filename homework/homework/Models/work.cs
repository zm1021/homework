using Homework.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Homework.Models
{
    using homework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    

    public partial class SkillTreeHomeworkEntities : DbContext
    {
        public SkillTreeHomeworkEntities()
            : base("name=SkillTreeHomeworkEntities")
        {
        }
        public virtual DbSet<AccountBook> DBcmd { get; set; }
       
    }





public class Work
    {

        public string today = DateTime.Now.ToString("yyyy-MM-dd");
        public string lastday = DateTime.UtcNow.AddHours(8).AddDays(-1).ToString("yyyy-MM-dd");
        public string tomday = DateTime.UtcNow.AddHours(8).AddDays(+1).ToString("yyyy-MM-dd");


       

      


        public DataTable Worktemp()
        {


         




            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("類別");
            dt.Columns.Add("日期");
            dt.Columns.Add("金額");

            for (int i = 0; i < 1000; i++)
            {
                DataRow da = dt.NewRow();
                da["#"] = i;
                da["類別"] = i % 2 == 0 ? "收入" : "支出";
                da["日期"] = i % 2 == 0 ? tomday : i % 3 == 0 ? lastday : tomday;
                da["金額"] = i % 2 == 0 ? i * 10 + i : i;
                dt.Rows.Add(da);
            }

            return dt;
        }

        public List<HomeworklViewModel> Homework2()
        {
            SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

            var result = (from x in db.DBcmd
                          select new HomeworklViewModel()
                          {
                              Id = x.Id.ToString(),
                              Categoryyy = x.Categoryyy,
                              Dateee = x.Dateee.ToString(),
                              Amounttt = x.Amounttt,
                              Remarkkk = x.Remarkkk
                          }).ToList();
            return result;
        }









    }




}