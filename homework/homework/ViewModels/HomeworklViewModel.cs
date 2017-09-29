using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace Homework.ViewModels
{
    public class HomeworklViewModel
    {
        public DataTable Dt { get; set; }

        public string Id { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Count { get; set; }



        public string Today
        {
            get
            {
                var day = DateTime.Now.ToString("yyyy-MM-dd");
                return day;
            }
        }

        public string Lastday
        {
            get
            {
                var day = DateTime.UtcNow.AddHours(8).AddDays(-1).ToString("yyyy/MM/dd");
                return day;
            }
        }

        public string Tomday
        {
            get
            {
                var day = DateTime.UtcNow.AddHours(8).AddDays(+1).ToString("yyyy/MM/dd");
                return day;
            }
        }



    }

}