using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_Filtering.Support
{
    class LoadingInForm
    {
        SplashScreenManager splash;

        public LoadingInForm(SplashScreenManager splash)
        {
            this.splash = splash;
        }

        public void ShowWaitForm()
        {
            if (splash.IsSplashFormVisible)
            {
                splash.CloseWaitForm();
            }
            splash.ShowWaitForm();
        }

        public void CloseWaitForm()
        {
            if (splash.IsSplashFormVisible)
            {
                splash.CloseWaitForm();
            }
        }
    }
}
