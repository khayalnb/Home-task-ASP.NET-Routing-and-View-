using HomeTaskViewModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTaskViewModel.ViewModels
{
    public class HomeViewModel
    {
        public string Learn { get; set; }
         
        public List<Car> Cars { get; set; }

        public List<Student> Students { get; set; }
    }
}
