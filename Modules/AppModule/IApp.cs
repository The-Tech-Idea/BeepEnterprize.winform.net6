using System;
using System.Collections.Generic;
using System.Text;
using TheTechIdea.Beep.DataBase;
using TheTechIdea.Beep.Report;
using TheTechIdea.Util;

namespace TheTechIdea.Beep.AppModule
{
    public interface IApp
    {
        string ID { get; set; }
        string AppName { get; set; }
        string DataViewDataSourceName { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        int Ver { get; set; }
        AppType Apptype { get; set; }
        string OuputFolder { get; set; }
        List<IEntityStructure> Entities { get; set; }
        string ImageLogoName { get; set; }
        string AppTitle { get; set; }
        string AppSubTitle { get; set; }
        string AppDescription { get; set; }
        List<IAppScreen> Screens { get; set; }
        List<IAppVersion> AppVersions { get; set; }

        LinkedList<IBreadCrumb> breadCrumb { get; set; }

        List<ConnectionProperties> dataConnections { get; set; }


    }
}
