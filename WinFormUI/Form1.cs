using System.Diagnostics;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = Application.StartupPath;
        }
        Type type;

        private void btnGetDllFiles_Click(object sender, EventArgs e)
        {
            // WinFormUI\WinFormUI\bin\Debug\net7.0 - windows taki tipleri ald�k
            Assembly asm = Assembly.LoadFrom(Application.StartupPath + "Plugins/Calculation.dll");
            // GetTypes() Bu assembly deki b�t�n tipleri bana dizi olarak versin
            //var types = asm.GetTypes()[2];  

            // ald���m�z tipte ismi Calculator olan tipi se�tik 
            type = asm.GetTypes().FirstOrDefault(t => t.Name == "Calculator");







            // ve Calculator tipinin �al��ma zaman� metodlar�n� ald�k
            var methodInfos = type.GetRuntimeMethods();

            // ald���m�z metodlardan isimleri GetType,ToString,MemberwiseClone olmayan metodlar� listbox i�ine ekledik
            foreach (var info in methodInfos)
            {
                if (!info.IsVirtual && info.Name != "GetType" && info.Name != "ToString" && info.Name != "MemberwiseClone")
                    lbxMethodNames.Items.Add(info.Name);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string methodName = lbxMethodNames.SelectedItem.ToString();

            //type yi �rettik object olarak
            object obj = Activator.CreateInstance(type);
            //Calculator c= new Calculator();

            //listboxta se�ti�imiz metodun ismindeli metodu istedik
            var selectorMethodInfo=type.GetMethod(methodName);


            decimal p1 = Convert.ToDecimal(txtOperant1.Text);
            decimal p2=Convert.ToDecimal(txtOperant2.Text);

            var methodParams=new object[] { p1, p2 };

            lblResult.Text = selectorMethodInfo.Invoke(obj, methodParams).ToString();
            //c.Carp(p1,p2);
            
               
        }
    }
}

/*
 * Type bize ilgili tipin metadata verilerini getirip veriyor.
 * Bu tipin i�inde hangi metodlar,propertyler yada de�i�kenler,olaylar var,
 * Bu tip hangi s�n�flardan kal�t�m alm��
 * 
 * Get ile ba�layan metodlara bak
 * methodInfos method bilgileri
 * GetRuntimeMethods(); metodlar� almak i�in kullan�l�r.
 * 
 * */