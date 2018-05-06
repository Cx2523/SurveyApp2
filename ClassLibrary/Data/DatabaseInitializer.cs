using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Models;
using System.Diagnostics;

namespace ClassLibrary.Data
{
    public class DevDatabaseInitializer
    {
        public void SeedDatabase(Context context)
        {
            SeedData.Seed1(context);
        }
    }
}
