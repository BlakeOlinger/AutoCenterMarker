using SldWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenterMark
{
    class Program
    {
        static void Main(string[] args)
        {
            var swInstance = new SldWorks.SldWorks();

            var part = (ModelDoc2)swInstance.ActiveDoc;
            var drawing = (DrawingDoc)part;
            var docExtension = (ModelDocExtension)part.Extension;

            drawing.ActivateView("Drawing View1");
            var activeView = (View)drawing.ActiveDrawingView;

            activeView.AutoInsertCenterMarks2(7, 11, true, true, true, 0.002, 0.0025, true, true, 0);
        }
    }
}
