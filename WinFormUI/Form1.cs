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
            // WinFormUI\WinFormUI\bin\Debug\net7.0 - windows taki tipleri aldýk
            Assembly asm = Assembly.LoadFrom(Application.StartupPath + "Plugins/Calculation.dll");
            // GetTypes() Bu assembly deki bütün tipleri bana dizi olarak versin
            //var types = asm.GetTypes()[2];  

            // aldýðýmýz tipte ismi Calculator olan tipi seçtik 
            type = asm.GetTypes().FirstOrDefault(t => t.Name == "Calculator");







            // ve Calculator tipinin çalýþma zamaný metodlarýný aldýk
            var methodInfos = type.GetRuntimeMethods();

            // aldýðýmýz metodlardan isimleri GetType,ToString,MemberwiseClone olmayan metodlarý listbox içine ekledik
            foreach (var info in methodInfos)
            {
                if (!info.IsVirtual && info.Name != "GetType" && info.Name != "ToString" && info.Name != "MemberwiseClone")
                    lbxMethodNames.Items.Add(info.Name);
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string methodName = lbxMethodNames.SelectedItem.ToString();

            //type yi ürettik object olarak
            object obj = Activator.CreateInstance(type);
            //Calculator c= new Calculator();

            //listboxta seçtiðimiz metodun ismindeli metodu istedik
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
 * Bu tipin içinde hangi metodlar,propertyler yada deðiþkenler,olaylar var,
 * Bu tip hangi sýnýflardan kalýtým almýþ
 * 
 * Get ile baþlayan metodlara bak
 * methodInfos method bilgileri
 * GetRuntimeMethods(); metodlarý almak için kullanýlýr.
 * 
 * */