using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revitgridpulgin
{
    class Application : IExternalApplication
    {



        #region from Youtube 
      
            const string ribbon_tab = "PlanMacher";
            const string ribbon_Pannel = "Create a Gird";
            public Result OnStartup(UIControlledApplication application)
            {
                // get the ribbon tab
                try
                {
                    application.CreateRibbonTab(ribbon_tab);
                }
                catch (Exception) { TaskDialog.Show("title there is a problem"
                    ,
                    " Line 35" );
                    } //tab is already exists

                // get or Create the panel 
                RibbonPanel pannel = null;

                List<RibbonPanel> panels = application.GetRibbonPanels(ribbon_tab);

                foreach (RibbonPanel pnl in panels)
                {
                    if (pnl.Name == ribbon_Pannel)
                    {
                        pannel = pnl;
                        break;
                    }
                }
                // couldnot find the pannel. create it 
                if (pannel == null)
                {
                    pannel = application.CreateRibbonPanel(ribbon_tab, ribbon_Pannel);
                }

            // get the image for the Button 
            Image img = Properties.Resources.icons8_fire_extinguisher_ico;
            ImageSource imgSrc = GetImageSource(img);

            // Create the Button data
            PushButtonData btnData = new PushButtonData(
                "MyButton",
                "Create a Gird",
                Assembly.GetExecutingAssembly().Location,
                " Revitgridpulgin.RevitPlanMaker")
                {
                    ToolTip = "Short Description that show when you hover over the button",
                    LongDescription = "Longer description show when you hober over the button for few sec ",
                Image = imgSrc,
                LargeImage = imgSrc
            };
                
                // add your button 
                PushButton button = pannel.AddItem(btnData) as PushButton;
                button.Enabled = true;
                button.
                return Result.Succeeded;
            }

            public Result OnShutdown(UIControlledApplication application)
            {
                return Result.Succeeded;
            }
            private BitmapSource GetImageSource(Image img)
            {
                BitmapImage bmp = new BitmapImage();
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, ImageFormat.Png);
                    ms.Position = 0;

                    bmp.BeginInit();
                    bmp.CacheOption = BitmapCacheOption.OnLoad;
                    bmp.UriSource = null;

                    bmp.StreamSource = ms;
                    bmp.EndInit();

                }
                return bmp;

            }
        }
        #endregion
    }


