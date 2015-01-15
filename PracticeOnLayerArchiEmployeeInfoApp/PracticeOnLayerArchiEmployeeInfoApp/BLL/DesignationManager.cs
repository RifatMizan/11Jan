using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeOnLayerArchiEmployeeInfoApp.DAL.DAO;
using PracticeOnLayerArchiEmployeeInfoApp.DAL.DBGateway;

namespace PracticeOnLayerArchiEmployeeInfoApp.BLL
{
    class DesignationManager
    {
        public void Save(Designation aDesignation)
        {
            DesignationDBGateway aDesignationDbGateway=new DesignationDBGateway();
            aDesignationDbGateway.Save(aDesignation);
        }
    }
}
