using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public sealed class ConvertionsRepository
    {
        private ConvertionsRepository()
        {

        }

        public static ConvertionsRepository Instance { get; } = new();
        public ConvertionListViewModel convertion = new();
    }
}
