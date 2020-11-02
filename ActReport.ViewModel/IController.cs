using System;
using System.Collections.Generic;
using System.Text;

namespace ActReport.ViewModel
{
    public interface IController
    {
        void ShowWindow(BaseViewModel vieModel);
        void CloseWindow(BaseViewModel viewModel);

    }
}
