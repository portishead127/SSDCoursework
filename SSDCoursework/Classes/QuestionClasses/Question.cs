using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Classes.QuestionClasses
{
    internal interface IQuestion
    {
        string QuestionText { get; }
        object Answer { get; }  //Needs to be of type object as the type of answer will be either string or bool
    }
}
