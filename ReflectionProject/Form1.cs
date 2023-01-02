using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReflectionProject
{
    public partial class Form1 : Form
    {
        Assembly library= null;
        int countForCtor = 0;
        int countForMethod = 0;
        int countForProperty = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void lbl_members_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            library = Assembly.GetExecutingAssembly();
            Type[] types = library.GetTypes();
            lb_classes.DataSource = types;
            lb_classes.SelectedIndex = -1;
            txt_className.Text = string.Empty;
            pnl_classDetails.Visible = false;
        }

        private void btn_getDLL_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_GetClass_Click(object sender, EventArgs e)
        {
           
            if (!(String.IsNullOrEmpty(txt_className.Text))){
                Type selectedType = Type.GetType(txt_className.Text);
                pnl_classDetails.Visible = true;
                
                lb_constructors.DataSource = selectedType.GetConstructors();
                lb_methods.DataSource = selectedType.GetMethods();
                lb_properties.DataSource = selectedType.GetProperties();

                lb_constructors.SelectedIndex = -1;
                lb_methods.SelectedIndex = -1;
                lb_properties.SelectedIndex = -1;


            }
            else
            {
                MessageBox.Show("Please fill the text field.");
            }
               

        }

        private void lb_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lb_classes.SelectedIndex != -1)
            {
                txt_className.Text = lb_classes.SelectedItem.ToString();
            }
        }

        private void lb_constructors_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (countForCtor > 1)
            {
                ConstructorInfo selectedCtor = lb_constructors.SelectedItem as ConstructorInfo;
                var CtorParameters= selectedCtor.GetParameters();
                string text = "";
                foreach (var item in CtorParameters)
                {
                    text += $"Type : {item.ParameterType.Name} Name : {item.Name}\n";
                }
                MessageBox.Show(text);
                
            }
            else
            {
                countForCtor++;
            }
            
        }

        private void lb_methods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countForMethod > 1)
            {
                var selectedMethod = lb_methods.SelectedItem as MethodInfo;
                string text = selectedMethod.Name;
                MessageBox.Show(text);
            }
            else
            {
                countForMethod++;
            }
        }

        private void lb_properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (countForProperty > 1)
            {
                var selectedProperty = lb_properties.SelectedItem as PropertyInfo;
                string text = selectedProperty.Name;
                MessageBox.Show(text);
            }
            else
            {
                countForProperty++;
            }
        }
    }
}
