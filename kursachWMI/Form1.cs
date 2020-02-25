using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace kursachWMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                label1.Text = ("Name  -  " + obj["Name"]);
            }

        }
    }
}
