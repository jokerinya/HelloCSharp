using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class CourseManager
    {
        Course course = new Course(); // internal class ulasabiliyorum
        private class MyInnerCourse 
        {
            // Bu class private olabilir, onun disinda classlar ya public yada
            // internaldir
        }
    }
}
