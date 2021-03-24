using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FitComradeV2.data
{
    public class FitComradeV2Context : DbContext
    {
        public FitComradeV2Context()
        {
        }

        public FitComradeV2Context(DbContextOptions<FitComradeV2Context> options)
            : base(options)
        {
        }



        
    }
}
