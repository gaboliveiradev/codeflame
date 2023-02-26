using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codeflame.Helpers;

namespace codeflame.Commands
{
    public class MakeLayer
    {
        string baseDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory.ToString());

        public void createController(string nameController)
        {
            ChangeName changeName = new ChangeName();
            changeName.controller(baseDirectory, nameController);
        }

        public void createModel(string nameModel)
        {

        }

        public void createDAO(string nameDAO)
        {

        }
    }
}
