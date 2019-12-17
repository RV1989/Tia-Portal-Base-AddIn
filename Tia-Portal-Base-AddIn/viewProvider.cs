using System;
using System.Collections.Generic;
using System.Text;
using Siemens.Engineering.AddIn;
using Siemens.Engineering.AddIn.Menu;

namespace Tia_Portal_Base_AddIn
{
    public class projectTreeViewProvider : ProjectTreeAddInProvider
    {
        protected override IEnumerable<ContextMenuAddIn> GetContextMenuAddIns()

        {

            yield return new contextMenu("ProjectTreeAddInMenu");



        }

    }

    public class globalLibraryViewProvider : GlobalLibraryTreeAddInProvider
    {
        protected override IEnumerable<ContextMenuAddIn> GetContextMenuAddIns()

        {

            yield return new contextMenu("GobalLibraryAddInMenu");



        }

    }

    public class projectLibraryViewProvider : ProjectLibraryTreeAddInProvider
    {
        protected override IEnumerable<ContextMenuAddIn> GetContextMenuAddIns()

        {

            yield return new contextMenu("ProjectLibraryAddInMenu");



        }

    }

    public class deviceNetworkViewProvider : DevicesAndNetworksAddInProvider
    {
        protected override IEnumerable<ContextMenuAddIn> GetContextMenuAddIns()

        {

            yield return new contextMenu("DeviceNetworkAddInMenu");



        }

    }

   

    
}
