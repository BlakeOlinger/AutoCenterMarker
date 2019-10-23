using SldWorks;

namespace AutoCenterMark
{
    class Program
    {
        static void Main(string[] args)
        {
            var swInstance = new SldWorks.SldWorks();

            var model = (ModelDoc2)swInstance.ActiveDoc;
            var drawing = (DrawingDoc)model;
            var docExtension = (ModelDocExtension)model.Extension;

            drawing.ActivateView("Drawing View1");
            var activeView = (View)drawing.ActiveDrawingView;

            activeView.AutoInsertCenterMarks2(7, 11, true, true, true, 0.002, 0.0025, true, true, 0);
        }
    }
}
