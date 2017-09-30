using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Homework.ViewModels
{




    public class HomeworklViewModel
    {
        public virtual DbSet<HomeworklViewModel> WorkDB { get; set; }
        public DataTable Dt { get; set; }
        public List<HomeworklViewModel> Worklist { get; set; }

        public string Id { get; set; }
        public string Dateee { get; set; }
        public int Amounttt { get; set; }
        public int Categoryyy { get; set; }
        public string Remarkkk { get; set; }



    }

}