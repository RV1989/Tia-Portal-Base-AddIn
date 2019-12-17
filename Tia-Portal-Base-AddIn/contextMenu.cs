using System;
using System.Collections.Generic;
using System.Text;
using Siemens.Engineering;
using Siemens.Engineering.AddIn;
using Siemens.Engineering.AddIn.Menu;
using System.Diagnostics;





namespace Tia_Portal_Base_AddIn
{
    public class contextMenu : ContextMenuAddIn
        

    {


        public contextMenu(string displayName) : base(displayName)

        {

        }
         

        protected override void BuildContextMenuItems(ContextMenuAddInRoot addInRootSubmenu)

        {

            addInRootSubmenu.Items.AddActionItem<IEngineeringObject>("Entry 1", Entry1_OnClick);

            addInRootSubmenu.Items.AddActionItem<IEngineeringObject>("Entry 2", Entry2_OnClick);

        }


        private void Entry1_OnClick(MenuSelectionProvider<IEngineeringObject> menuSelectionProvider)

        {
            Debugger.Launch();
            Console.WriteLine("entry1");
            
            //Executed program code for the first entry of the shortcut menu 

        }


        private void Entry2_OnClick(MenuSelectionProvider<IEngineeringObject> menuSelectionProvider)

        {
            Debugger.Launch();
            Console.WriteLine("entry2");
            //Executed program code for the second entry of the shortcut menu

        }

    }

}
