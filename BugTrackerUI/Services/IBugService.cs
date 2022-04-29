using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public interface IBugService
    {
        
        void AddBug(Bug newBug);

        List<Bug> GetBugs();

    }
}
