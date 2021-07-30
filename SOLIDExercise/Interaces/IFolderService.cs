using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExercise.Interaces
{
    interface IFolderService
    {
        string name { get; set; }

        
        bool containsEmail(string emailId);
        void addEmail(Email emailToMove);
        Email removeEmail(string emailId);
    }
}
