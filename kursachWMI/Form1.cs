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
using System.IO;
using System.Runtime.InteropServices;

namespace kursachWMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");// Процессор
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                procName.Text = ("Наименование  -  " + obj["Name"]);
                procMan.Text = ("Производитель  -  " + obj["Manufacturer"]);
                procCore.Text = ("Колличество ядер  -  " + obj["NumberOfCores"]);
                procTakt.Text = ("Тактовая частота  -  " + obj["CurrentClockSpeed"] + " MHz");
                procCash.Text = ("Размер кэша  -  " + obj["L2CacheSize"]) + " байт";
            }

            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");//Видеокарта
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                videoName.Text = ("Наименование  -  " + obj["Name"]);
                videoRam.Text = ("Видеопамять  -  " + Convert.ToDouble(obj["AdapterRAM"]) / 1048576.0) + " Мб";
                videoDAC.Text = ("Тип ЦАП  -  " + obj["AdapterDACType"]);//Цифрово-аналоговый преобразователь.
                videoDriver.Text = ("Версия драйвера  -  " + obj["DriverVersion"]);
            }

            getdrive();
            void getdrive()
            {
                string[] driv = Directory.GetLogicalDrives();
                foreach (string item in driv)
                {
                    comboBox1.Items.Add(item.ToString());
                }
            }


            /*foreach (var drive in DriveInfo.GetDrives())
            {
                try
                { 
                    label1.Text = ("Имя диска: " + drive.Name);
                    label2.Text = ("Файловая система: " + drive.DriveFormat);
                    label3.Text = ("Тип диска: " + drive.DriveType);
                    label4.Text = ("Объем доступного свободного места (в байтах): " + drive.AvailableFreeSpace);
                    label5.Text = ("Готов ли диск: " + drive.IsReady);
                    label6.Text = ("Корневой каталог диска: " + drive.RootDirectory);
                    label7.Text = ("Общий объем свободного места, доступного на диске (в байтах): " + drive.TotalFreeSpace);
                    label8.Text = ("Размер диска (в байтах): " + drive.TotalSize);
                    label9.Text = ("Метка тома диска: " + drive.VolumeLabel);
                }
                catch { }
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                string getinfo = comboBox1.SelectedItem.ToString();
                DriveInfo drInfo = new DriveInfo(getinfo);
                string Available_space = drInfo.AvailableFreeSpace.ToString();
                string totalspace = drInfo.TotalFreeSpace.ToString();
                string drivety = drInfo.DriveType.ToString();
                MessageBox.Show(Available_space + " " + totalspace + " " + drivety);
            }
        }
    }
}
