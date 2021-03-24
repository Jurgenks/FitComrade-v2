using System;
using System.Collections.Generic;
using System.Text;

namespace FitComradeV2.data.Data
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
