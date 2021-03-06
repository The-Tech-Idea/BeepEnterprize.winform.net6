using System;
using System.Collections.Generic;
using System.Text;
using TheTechIdea.Util;

namespace TheTechIdea.Beep.AppModule
{
    public interface IAppVersion
    {
        int Ver { get; set; }
        DateTime CreateDate { get; set; }
        AppType? Apptype { get; set; }
        string OuputFolder { get; set; }
        string GeneratorName { get; set; }
    }
}
