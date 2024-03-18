using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Tutorial3
{
    public class StaffData
    {
        public int txtStaffNo { get; set; }
        public string txtStaffName { get; set; }
        public DateTime txtJoinFrom { get; set; }
        public DateTime txtDob { get; set; }
        public int txtAge { get; set; }
        public string cbStaffType { get; set; }
        public string txtNrcNo { get; set; }
        public string gender { get; set; }
        public string txtPhoneone { get; set; }
        public string txtPhonetwo { get; set; }
        public Image Image { get; set; }
        public string rtxtAddress { get; set; }
    }
}
