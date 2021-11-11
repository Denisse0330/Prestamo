using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDePrestamos
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            Combobox();
           
        }

        private void Combobox()
        {
            ComboboxItem defaultOption = new ComboboxItem
            {
                text = "Seleccione la opcion deseada",
                value = null
            };
            ComboboxItem personalOption = new ComboboxItem
            {
                text = "Prestamo Personal",
                value = 1
            };
            ComboboxItem automovilOption = new ComboboxItem
        {
            text = "Prestamo Automovil",
            value = 2
            };
            ComboboxItem hipotecarioOption = new ComboboxItem
            {
                text = "Prestamo Hipotecario",
                value = 3
            };
            CbxTipoDePrestamo.Items.Add(defaultOption);
            CbxTipoDePrestamo.Items.Add(personalOption);
            CbxTipoDePrestamo.Items.Add(automovilOption);
            CbxTipoDePrestamo.Items.Add(hipotecarioOption);
            CbxTipoDePrestamo.SelectedItem = defaultOption;

            ///////////////////////////////////////

            ComboboxItem defaultOption2 = new ComboboxItem
            {
                text = "Seleccione lo deseado",
                value = null
            };
            ComboboxItem meses12 = new ComboboxItem
            {
                text = "12 meses a pagar",
                value = 1
            };
            ComboboxItem meses18 = new ComboboxItem
            {
                text = "18 meses a pagar",
                value = 2
            };
            ComboboxItem meses24 = new ComboboxItem
            {
                text = "24 meses a pagar",
                value = 3
            };
            ComboboxItem meses30 = new ComboboxItem
            {
                text = "30 meses a pagar",
                value = 4
            };
            ComboboxItem meses36 = new ComboboxItem
            {
                text = "36 meses a pagar",
                value = 5
            };
            ComboboxItem meses42 = new ComboboxItem
            {
                text = "42 meses a pagar",
                value = 6
            };
            ComboboxItem meses48 = new ComboboxItem
            {
                text = "48 meses a pagar",
                value = 7
            };
            ComboboxItem meses54 = new ComboboxItem
            {
                text = "54 meses a pagar",
                value = 8
            };
            ComboboxItem meses60 = new ComboboxItem
            {
                text = "60 meses a pagar",
                value = 9
            };
            ComboboxItem meses66 = new ComboboxItem
            {
                text = "66 meses a pagar",
                value = 10
            };
            ComboboxItem meses72 = new ComboboxItem
            {
                text = "72 meses a pagar",
                value = 11
            };
            ComboboxItem meses78 = new ComboboxItem
            {
                text = "78 meses a pagar",
                value = 12
            };
            ComboboxItem meses84 = new ComboboxItem
            {
                text = "84 meses a pagar",
                value = 13
            };
            ComboboxItem meses90 = new ComboboxItem
            {
                text = "90 meses a pagar",
                value = 14
            };
            ComboboxItem meses96 = new ComboboxItem
            {
                text = "96 meses a pagar",
                value = 15
            };
            ComboboxItem meses102 = new ComboboxItem
            {
                text = "102 meses a pagar",
                value = 16
            };
            ComboboxItem meses108 = new ComboboxItem
            {
                text = "108 meses a pagar",
                value = 17
            };
            ComboboxItem meses114 = new ComboboxItem
            {
                text = "114 meses a pagar",
                value = 18
            };
            ComboboxItem meses120 = new ComboboxItem
            {
                text = "120 meses a pagar",
                value = 19
            };

            cbxMesesApagar.Items.Add(defaultOption2);
            cbxMesesApagar.Items.Add(meses12);
            cbxMesesApagar.Items.Add(meses18);
            cbxMesesApagar.Items.Add(meses24);
            cbxMesesApagar.Items.Add(meses30);
            cbxMesesApagar.Items.Add(meses36);
            cbxMesesApagar.Items.Add(meses42);
            cbxMesesApagar.Items.Add(meses48);
            cbxMesesApagar.Items.Add(meses54);
            cbxMesesApagar.Items.Add(meses60);
            cbxMesesApagar.Items.Add(meses66);
            cbxMesesApagar.Items.Add(meses72);
            cbxMesesApagar.Items.Add(meses78);
            cbxMesesApagar.Items.Add(meses84);
            cbxMesesApagar.Items.Add(meses90);
            cbxMesesApagar.Items.Add(meses96);
            cbxMesesApagar.Items.Add(meses102);
            cbxMesesApagar.Items.Add(meses108);
            cbxMesesApagar.Items.Add(meses114);
            cbxMesesApagar.Items.Add(meses120);
            cbxMesesApagar.SelectedItem = defaultOption2;

        }

        private Boolean calcular()
        {
            try
            {
                ComboboxItem selectedTipoDePrestamo = CbxTipoDePrestamo.SelectedItem as ComboboxItem;
                ComboboxItem selectedMesesApagar = cbxMesesApagar.SelectedItem as ComboboxItem;

                if (selectedTipoDePrestamo.value == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de prestamo.", "advertencia");
                    return false;
                }
                else if (selectedMesesApagar.value == null)
                {
                    MessageBox.Show("Debe seleccionar la cantidad de meses.", "advertencia");
                    return false;
                }
                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Debe colocar el monto que desea.", "advertencia");
                    return false;
                }
                else
                {
                    //MessageBox.Show("todo correcto", "advertencia");
                    return true;
                }

                txtResultado.Text = selectedTipoDePrestamo.value + "";
            }
            catch (Exception)
            {
                return false;
               
            }

        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (calcular())
            {



                double cantidad = Convert.ToDouble(txtMonto.Text);
                int interes = CbxTipoDePrestamo.SelectedIndex;
                int meses = cbxMesesApagar.SelectedIndex;
                int mes = 06 + (6 * meses);
                switch (interes)
                {
                    case 1:
                        cantidad = cantidad * 1.22;
                        break;
                    case 2:
                        cantidad = cantidad * 1.12;
                        break;
                    case 3:
                        cantidad = cantidad * 1.08;
                        break;
                }

                cantidad = cantidad / mes;
                txtResultado.Text = cantidad.ToString();


            }
        }

        private void CbxTipoDePrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTasaDeInteres.Text = CbxTipoDePrestamo.SelectedIndex.ToString();
            int opcion = CbxTipoDePrestamo.SelectedIndex;
            switch (opcion)
            {
                case 1: txtTasaDeInteres.Text = "22% de interes.";
                    break;
                case 2: txtTasaDeInteres.Text = "12% de interes";
                    break;
                case 3: txtTasaDeInteres.Text = "8% de interes";
                    break;
                default:
                    txtTasaDeInteres.Text = "tasa de interes";
                    break;
            }
        }

        private void cbxMesesApagar_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
