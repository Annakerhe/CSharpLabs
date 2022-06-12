using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using VehicleReflectionModel;
namespace VehicleReflectionView
{
    public partial class Form1 : Form
    {
        Type currentType;
        Assembly assembly;
        MethodInfo currentMethod;
        object[]? methodParameters;
        IEnumerable<Type> types;
        object? currentObject;

        private void PrintFieldsOfClass()
        {
            listBoxFieldsClass.Items.Clear();
            foreach (var item in currentType.GetProperties())
            {
                listBoxFieldsClass.Items.
                    Add(item.Name + " - " + item.GetValue(currentObject));
            }
        }

        public Form1()
        {
            InitializeComponent();

            assembly = Assembly.Load("VehicleReflectionModel");

            types = assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IVehicle") != null);
            ComboBoxClass.Items.AddRange(types.Select(type => type.Name).ToArray());

            comboBoxAction.Enabled = false;
            createObjectClassButton.Enabled = false;
            enterMethodButton.Enabled = false;
            doMethodButton.Enabled = false;
        }

        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            doMethodButton.Enabled = false;
            comboBoxAction.Enabled = false;
            enterMethodButton.Enabled = false;
            comboBoxAction.Items.Clear();
            currentType = types.First(t => t.Name == ComboBoxClass.SelectedItem.ToString());
            currentObject = null;
            createObjectClassButton.Enabled = true;
            IEnumerable<string> objectMethods = new object().GetType().GetMethods().Select(method => method.Name);


            comboBoxAction.Items.
                AddRange(currentType.GetMethods()
                .Where(methInfo => !objectMethods.Contains(methInfo.Name)
                && methInfo.Name.Substring(0, 4) != "get_" && methInfo.Name.Substring(0, 4) != "set_")
                .Select(t => t.Name).ToArray());
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<string> methods = new object()
                .GetType()
                .GetMethods()
                .Select(method => method.Name);

            currentMethod = currentType.GetMethods()
                .First(m => !methods.Contains(m.Name)
                && m.Name.Substring(0, 4) != "get_"
                && m.Name.Substring(0, 4) != "set_"
                && m.Name == comboBoxAction.SelectedItem.ToString());

            if (currentMethod.GetParameters().Length == 0)
            {
                enterMethodButton.Enabled = false;
                methodParameters = null;
            }
            else
            {
                enterMethodButton.Enabled = true;
            }
        }

        private void createObjectClassButton_Click(object sender, EventArgs e)
        {
            doMethodButton.Enabled = true;
            enterMethodButton.Enabled = true;
            comboBoxAction.Enabled = true;
                object newObject = Activator.CreateInstance(currentType);

            foreach (var it in newObject.GetType().GetProperties())
            {
                if (it.PropertyType.Name == "Int32")
                {
                    Form2 inputForm = new Form2("Введите " + it.Name);
                    inputForm.ShowDialog();
                    int number;
                    while (!int.TryParse(inputForm.value, out number))
                    {
                        MessageBox.Show("Некорректный ввод", "Ошибка ввода", MessageBoxButtons.OK);
                        inputForm.ShowDialog();
                    }
                    it.SetValue(newObject, number);
                }
                else if (it.PropertyType.Name == "Double")
                {
                    Form2 inputForm = new Form2("Введите " + it.Name);
                    inputForm.ShowDialog();
                    double number;
                    while (!double.TryParse(inputForm.value, out number))
                    {
                        MessageBox.Show("Некорректный ввод", "Ошибка ввода", MessageBoxButtons.OK);
                        inputForm.ShowDialog();
                    }
                    it.SetValue(newObject, number);
                }
                else
                {
                    Form2 inputForm = new Form2("Введите " + it.Name);
                    inputForm.ShowDialog();
                    string str = inputForm.value;
                    it.SetValue(newObject, str);
                }
            }
            currentObject = newObject;
            PrintFieldsOfClass();
        }

        private void enterMethodButton_Click(object sender, EventArgs e)
        {
            if (comboBoxAction.SelectedIndex != -1)
            {
                listBoxParamMethod.Items.Clear();
                if (currentMethod.GetParameters().Length != 0)
                {
                    var parametersList = new List<object>();

                    foreach (var it in currentMethod.GetParameters())
                    {
                        if (it.ParameterType.Name == "Int32")
                        {
                            Form2 inputForm = new Form2("Введите " + it.Name);
                            inputForm.ShowDialog();
                            int number;
                            while (!int.TryParse(inputForm.value, out number))
                            {
                                MessageBox.Show("Некорректный ввод", "Ошибка ввода", MessageBoxButtons.OK);
                                inputForm.ShowDialog();
                            }
                            parametersList.Add(number);
                            listBoxParamMethod.Items.Add(it.Name + ": " + number);

                        }
                        else if (it.ParameterType.Name == "Double")
                        {
                            Form2 inputForm = new Form2("Введите " + it.Name);
                            inputForm.ShowDialog();
                            double number;
                            while (!double.TryParse(inputForm.value, out number))
                            {
                                MessageBox.Show("Некорректный ввод", "Ошибка ввода", MessageBoxButtons.OK);
                                inputForm.ShowDialog();
                            }
                            parametersList.Add(number);
                            listBoxParamMethod.Items.Add(it.Name + ": " + number);
                        }
                        else
                        {
                            Form2 inputForm = new Form2("Введите " + it.Name);
                            inputForm.ShowDialog();
                            string str = inputForm.value;
                            parametersList.Add(str);
                            listBoxParamMethod.Items.Add(it.Name + ": " + str);
                        }
                    }
                    methodParameters = parametersList.Select(x => x).ToArray();
                    doMethodButton.Enabled = true;

                }
                else
                {
                    methodParameters = null;
                }
            }
        }

        private void doMethodButton_Click(object sender, EventArgs e)
        {
            if (comboBoxAction.SelectedIndex != -1 && currentObject != null)
            {
                if (currentMethod.GetParameters().Length != 0 && methodParameters == null)
                {
                    MessageBox.Show("Введите параметры метода!");
                }
                else
                {
                    if (currentMethod.ReturnType == typeof(void))
                    {
                        currentMethod.Invoke(currentObject, methodParameters);
                    }
                    else
                    {
                        MessageBox.Show(currentMethod.Invoke(currentObject, methodParameters).ToString());
                    }

                    PrintFieldsOfClass();
                }
            }
            else
            {
                MessageBox.Show("Сачала необходимо создать класс и выбрать метод.");
            }
        }
    }
}
