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
        const long KbSize = 1024;
        const long MbSize = KbSize * 1024;
        const long GbSize = MbSize * 1024;
        const long TbSize = GbSize * 1024;
        public Form1()
        {
            
            
            InitializeComponent();

            
        ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor"); // Процессор
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                procName.Text = ("Наименование  -  " + obj["Name"]);
                procMan.Text = ("Производитель  -  " + obj["Manufacturer"]);
                procCore.Text = ("Колличество ядер  -  " + obj["NumberOfCores"]);
                procTakt.Text = ("Тактовая частота  -  " + obj["CurrentClockSpeed"] + " MHz");
                procCash.Text = ("Размер кэша  -  " + obj["L2CacheSize"]) + " байт";
            }

            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController"); // Видеокарта
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                videoName.Text = ("Наименование  -  " + obj["Name"]);
                videoRam.Text = ("Видеопамять  -  " + Convert.ToDouble(obj["AdapterRAM"]) / GbSize + " GB");
                videoDAC.Text = ("Тип ЦАП  -  " + obj["AdapterDACType"]); // Цифрово-аналоговый преобразователь.
                videoDriver.Text = ("Версия драйвера  -  " + obj["DriverVersion"]);
            }

            getdrive();


            //foreach (var drive in DriveInfo.GetDrives()) // Диски
            //{
            //    try
            //    { 
            //        label1.Text = ("Имя диска: " + drive.Name);
            //        label2.Text = ("Файловая система: " + drive.DriveFormat);
            //        label3.Text = ("Тип диска: " + drive.DriveType);
            //        label4.Text = ("Объем доступного свободного места: " + Convert.ToDouble(drive.AvailableFreeSpace) / 1048576.0 + " Мб");
            //        label5.Text = ("Статус работы: " + drive.IsReady);
            //        label6.Text = ("Корневой каталог диска: " + drive.RootDirectory);
            //        label7.Text = ("Общий объем свободного места, доступного на диске: " + Convert.ToDouble(drive.TotalFreeSpace) / 1048576.0 + " Мб");
            //        label8.Text = ("Размер диска: " + Convert.ToDouble(drive.TotalSize) / 1048576.0 + " Мб");
            //        label9.Text = ("Метка тома: " + drive.VolumeLabel);
            //    }
            //    catch { }
            //}
        }
        string GetSize(long bytes)
        {
            if (bytes < MbSize)
            {
                return (bytes / KbSize).ToString() + " KB";
            }
            else if (bytes < GbSize)
            {
                return $"{bytes / MbSize} MB";
            }
            else if (bytes <TbSize)
            {
                return (bytes / GbSize).ToString() + " GB";
            }
            else
            {
                return (bytes / TbSize).ToString() + " TB";
            }
        }

        void getdrive()
        {
            string[] driv = Directory.GetLogicalDrives();
            foreach (string item in driv)
            {
                comboBox1.Items.Add(item.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            var drives = DriveInfo.GetDrives();
            var drive = drives[index];
            if (index >= 0)
            {
                label1.Text = ("Имя диска: " + drive.Name);
                label2.Text = ("Файловая система: " + drive.DriveFormat);
                label3.Text = ("Тип диска: " + drive.DriveType);
                label4.Text = ("Объем доступного свободного места: " + GetSize(drive.AvailableFreeSpace));//Convert.ToDouble(drive.AvailableFreeSpace) / 1048576.0 + " Мб");
                label5.Text = ("Статус работы: " + drive.IsReady);
                label6.Text = ("Корневой каталог диска: " + drive.RootDirectory);
                label7.Text = ("Общий объем свободного места, доступного на диске: " + GetSize(drive.TotalFreeSpace));
                label8.Text = ("Размер диска: " + GetSize(drive.TotalSize));
                label9.Text = ("Метка тома: " + drive.VolumeLabel);
            }
        }
        
    }
}
