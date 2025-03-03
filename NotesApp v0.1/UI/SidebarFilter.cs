using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1;

namespace NotesApp_v0._1.UI
{
    public class SidebarFilter
    {
        private Panel sidebarPanel;
        public SidebarFilter(frmPrincipal principal)
        {
            this.sidebarPanel = principal.panelFilter;
        }

        public void ShowSidebar()
        {
            sidebarPanel.Visible = true;
        }

        public void HideSidebar()
        {
            sidebarPanel.Visible = false;
        }


    }
}
