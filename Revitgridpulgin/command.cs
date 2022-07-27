using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revitgridpulgin
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    
    public class command : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message, 
            ElementSet elements)
        {
            
            Form1 form = new Form1();   
            return Result.Succeeded;
        }
    }
}
