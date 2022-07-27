using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;




namespace Revitgridpulgin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    //transaction can be mannual and can be only readonly
    public class RevitPlanMaker : IExternalCommand          /*the Interface IExternalCommand is used*/
    {
        public Result Execute(
            ExternalCommandData commandData, 
            ref string message, 
            ElementSet elements)
        {
            Form1 form1 = new Form1();
            return Result.Succeeded;
        }
    }
}
