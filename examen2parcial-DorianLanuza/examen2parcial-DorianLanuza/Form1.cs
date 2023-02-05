using System.Data;
using SpreadsheetLight;
using System.Data;
using System;

namespace examen2parcial_DorianLanuza
{
    public partial class Form1 : Form
    {
        string pathFile = AppDomain.CurrentDomain.BaseDirectory + "miEstadoResultado.xlsx";

        public Form1()
        {
            InitializeComponent();

            inicialTabla1();
            inicialTabla2();
            inicialTablaER();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }







        public void inicialTabla1()
        {
            DataGridViewRow row = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row.Cells[0].Value = "Ventas";
            row.Cells[1].Value = null;

            miTabla1.Rows.Add(row);


            DataGridViewRow row2 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row2.Cells[0].Value = "Inventario inicial";
            row2.Cells[1].Value = null;

            miTabla1.Rows.Add(row2);


            DataGridViewRow row3 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row3.Cells[0].Value = "Devolución sobre ventas";
            row3.Cells[1].Value = null;

            miTabla1.Rows.Add(row3);


            DataGridViewRow row4 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row4.Cells[0].Value = "Gastos de Compras";
            row4.Cells[1].Value = null;

            miTabla1.Rows.Add(row4);


            DataGridViewRow row5 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row5.Cells[0].Value = "Renta de Oficinas";
            row5.Cells[1].Value = null;

            miTabla1.Rows.Add(row5);


            DataGridViewRow row6 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row6.Cells[0].Value = "Sueldo Gerente Aditivo";
            row6.Cells[1].Value = null;

            miTabla1.Rows.Add(row6);


            DataGridViewRow row7 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row7.Cells[0].Value = "Publicidad";
            row7.Cells[1].Value = null;

            miTabla1.Rows.Add(row7);


            DataGridViewRow row8 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row8.Cells[0].Value = "Otros productos";
            row8.Cells[1].Value = null;

            miTabla1.Rows.Add(row8);


            DataGridViewRow row9 = (DataGridViewRow)miTabla1.Rows[0].Clone();
            row9.Cells[0].Value = "Imputestos(30%)";
            row9.Cells[1].Value = null;

            miTabla1.Rows.Add(row9);
        }

        public void inicialTabla2()
        {
            DataGridViewRow row = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row.Cells[0].Value = "Compras";
            row.Cells[1].Value = null;

            miTabla2.Rows.Add(row);


            DataGridViewRow row2 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row2.Cells[0].Value = "Inventario final";
            row2.Cells[1].Value = null;

            miTabla2.Rows.Add(row2);


            DataGridViewRow row3 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row3.Cells[0].Value = "Devolución sobre compras";
            row3.Cells[1].Value = null;

            miTabla2.Rows.Add(row3);


            DataGridViewRow row4 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row4.Cells[0].Value = "Renta de tienda";
            row4.Cells[1].Value = null;

            miTabla2.Rows.Add(row4);


            DataGridViewRow row5 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row5.Cells[0].Value = "Comisión vendedores";
            row5.Cells[1].Value = null;

            miTabla2.Rows.Add(row5);


            DataGridViewRow row6 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row6.Cells[0].Value = "Servicio telefónico ventas";
            row6.Cells[1].Value = null;

            miTabla2.Rows.Add(row6);


            DataGridViewRow row7 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row7.Cells[0].Value = "Empaque de productos";
            row7.Cells[1].Value = null;

            miTabla2.Rows.Add(row7);


            DataGridViewRow row8 = (DataGridViewRow)miTabla2.Rows[0].Clone();
            row8.Cells[0].Value = "Otros gastos";
            row8.Cells[1].Value = null;

            miTabla2.Rows.Add(row8);

        }


        public void inicialTablaER()
        {
            DataGridViewRow row = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row.Cells[0].Value = "Ventas Netas";
            row.Cells[1].Value = null;

            miTablaER.Rows.Add(row);


            DataGridViewRow row2 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row2.Cells[0].Value = "Inventario inicial";
            row2.Cells[1].Value = null;

            miTablaER.Rows.Add(row2);


            DataGridViewRow row3 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row3.Cells[0].Value = "+Compras Netas";
            row3.Cells[1].Value = null;

            miTablaER.Rows.Add(row3);


            DataGridViewRow row4 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row4.Cells[0].Value = "-Inventario final";
            row4.Cells[1].Value = null;

            miTablaER.Rows.Add(row4);


            DataGridViewRow row5 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row5.Cells[0].Value = "Costo de ventas";
            row5.Cells[1].Value = null;

            miTablaER.Rows.Add(row5);


            DataGridViewRow row6 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row6.Cells[0].Value = "Util bruto";
            row6.Cells[1].Value = null;

            miTablaER.Rows.Add(row6);


            DataGridViewRow row7 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row7.Cells[0].Value = "Gastos de Ventas";
            row7.Cells[1].Value = null;

            miTablaER.Rows.Add(row7);


            DataGridViewRow row8 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row8.Cells[0].Value = "Gastos administrativos";
            row8.Cells[1].Value = null;

            miTablaER.Rows.Add(row8);

            DataGridViewRow row9 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row9.Cells[0].Value = "Gastos financieros";
            row9.Cells[1].Value = null;

            miTablaER.Rows.Add(row9);

            DataGridViewRow row10 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row10.Cells[0].Value = "Productos financieros";
            row10.Cells[1].Value = null;

            miTablaER.Rows.Add(row10);



            DataGridViewRow row11 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row11.Cells[0].Value = "Total Gastos Operativos";
            row11.Cells[1].Value = null;

            miTablaER.Rows.Add(row11);



            DataGridViewRow row12 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row12.Cells[0].Value = "Util operativo";
            row12.Cells[1].Value = null;

            miTablaER.Rows.Add(row12);


            DataGridViewRow row13 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row13.Cells[0].Value = "Otros gastos";
            row13.Cells[1].Value = null;

            miTablaER.Rows.Add(row13);


            DataGridViewRow row14 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row14.Cells[0].Value = "Otros productos";
            row14.Cells[1].Value = null;

            miTablaER.Rows.Add(row14);


            DataGridViewRow row15 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row15.Cells[0].Value = "Util antes de impuestos";
            row15.Cells[1].Value = null;

            miTablaER.Rows.Add(row15);

            DataGridViewRow row16 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row16.Cells[0].Value = "Impuestos(30%)";
            row16.Cells[1].Value = null;

            miTablaER.Rows.Add(row16);

            DataGridViewRow row17 = (DataGridViewRow)miTablaER.Rows[0].Clone();
            row17.Cells[0].Value = "Utilidad Neta";
            row17.Cells[1].Value = null;

            miTablaER.Rows.Add(row17);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            decimal value;


            if(comboBox1.SelectedIndex == 0 || string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Verifique los datos! No pueden haber datos vacios.");
            }else
            {
                name = comboBox1.Text;  
                value = Convert.ToDecimal(textBox1.Text);
          
                if(value < 0)
                {
                    MessageBox.Show("Los valores numericos no pueden ser negativos!");
                }
                else{

                    switch (name)
                    {
                        case "Ventas":
                            miTabla1.Rows[0].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Inventario inicial":
                            miTabla1.Rows[1].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Devolución sobre ventas":
                            miTabla1.Rows[2].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Gasto de Compras":
                            miTabla1.Rows[3].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Renta de Oficina":
                            miTabla1.Rows[4].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Sueldo Gerente Aditivo":
                            miTabla1.Rows[5].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Publicidad":
                            miTabla1.Rows[6].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Otros Productos":
                            miTabla1.Rows[7].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Compras":
                            miTabla2.Rows[0].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Inventario Final":
                            miTabla2.Rows[1].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Devolución sobre compras":
                            miTabla2.Rows[2].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Renta de tienda":
                            miTabla2.Rows[3].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Comisión Vendedores":
                            miTabla2.Rows[4].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Servicio telefónico ventas":
                            miTabla2.Rows[5].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Empaque de productos":
                            miTabla2.Rows[6].Cells[1].Value = Convert.ToString(value);
                            break;
                        case "Otros gastos":
                            miTabla2.Rows[7].Cells[1].Value = Convert.ToString(value);
                            break;
                        default:
                            MessageBox.Show("Error");
                            break;  




                    }

                    btnAdd.Enabled = false;

                }


            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            textBox1.Text = null;
            btnAdd.Enabled = true;

        }

        private void btnER_Click(object sender, EventArgs e)
        {
            decimal VentasNetas, invInicial ,comprasNetas, invFinal, costoVentas, 
                utilBruto, gastosVentas, gastosAdmin, gastosFinancieros, totalProductosFinancieros,
                totalGastosOperativos, otrosGastos, otrosProductos, utilAntesImpuestos, imputestos,
                utilNeto, utilOperacional;


            bool completeTable = true;

            int fila1 = miTabla1.RowCount - 1;
            int fila2 = miTabla1.RowCount;

            for(int i = 0; i < fila1; i++)
            {
                try
                {
                    if (miTabla1.Rows[i].Cells[2].Value == null)
                    {
                        completeTable = false;
                    }
                }catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

            }

            for (int i = 0; i < fila2; i++)
            {
                try
                {
                    if (miTabla2.Rows[i].Cells[2].Value == null)
                    {
                        completeTable = false;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            if (!completeTable)
            {
                MessageBox.Show("Debe llenar la tabla antes de progresar");
            }
            else
            {
                invFinal = Convert.ToDecimal(miTabla2.Rows[1].Cells[1].Value);


                VentasNetas = calcularVentasNetas(Convert.ToDecimal(miTabla1.Rows[0].Cells[1].Value), Convert.ToDecimal(miTabla1.Rows[2].Cells[1].Value), 0M);

                miTablaER.Rows[0].Cells[1].Value = VentasNetas.ToString();

                invInicial = Convert.ToDecimal(miTabla1.Rows[1].Cells[1].Value);

                miTablaER.Rows[1].Cells[1].Value = invFinal.ToString();

                decimal devCompras, comprasTotales, gastosCompras, compras;

                compras = Convert.ToDecimal(miTabla2.Rows[0].Cells[1].Value);
                gastosCompras = Convert.ToDecimal(miTabla1.Rows[3].Cells[1].Value);
                comprasTotales = calcularComprasTotales(compras, gastosCompras);

                devCompras = Convert.ToDecimal(miTabla2.Rows[2].Cells[1].Value);


                comprasNetas = calcularComprasNetas(comprasTotales, devCompras, 0M);

                miTablaER.Rows[2].Cells[1].Value = comprasNetas.ToString();

                miTablaER.Rows[3].Cells[1].Value = invFinal.ToString();

                costoVentas = (invInicial + comprasNetas) - invFinal;

                miTablaER.Rows[4].Cells[1].Value = costoVentas.ToString();

                utilBruto = VentasNetas - costoVentas;
            
                miTablaER.Rows[5].Cells[1].Value = utilBruto.ToString();


                gastosVentas = calcularGastodeVentas(Convert.ToDecimal(miTabla1.Rows[6].Cells[1].Value), Convert.ToDecimal(miTabla2.Rows[3].Cells[1].Value),
                    Convert.ToDecimal(miTabla2.Rows[4].Cells[1].Value), Convert.ToDecimal(miTabla2.Rows[5].Cells[1].Value), Convert.ToDecimal(miTabla2.Rows[6].Cells[1].Value));

                miTablaER.Rows[6].Cells[1].Value = gastosVentas.ToString();


                gastosAdmin = calcularGastosAdministrativos(Convert.ToDecimal(miTabla1.Rows[4].Cells[1].Value), Convert.ToDecimal(miTabla1.Rows[5].Cells[1].Value));


                miTablaER.Rows[7].Cells[1].Value = gastosAdmin.ToString();


                gastosFinancieros = 0;

                miTablaER.Rows[8].Cells[1].Value = gastosFinancieros.ToString();

                totalProductosFinancieros = 0;

                miTablaER.Rows[9].Cells[1].Value = totalProductosFinancieros.ToString();

                totalGastosOperativos = (gastosAdmin + (gastosFinancieros - totalProductosFinancieros) + gastosVentas);



                miTablaER.Rows[10].Cells[1].Value = totalGastosOperativos.ToString();


                utilOperacional = utilBruto - totalGastosOperativos;

                miTablaER.Rows[11].Cells[1].Value = utilOperacional.ToString();

               

                otrosGastos = Convert.ToDecimal(miTabla2.Rows[7].Cells[1].Value);


                miTablaER.Rows[12].Cells[1].Value = otrosGastos.ToString();

                otrosProductos = Convert.ToDecimal(miTabla1.Rows[7].Cells[1].Value);

                miTablaER.Rows[13].Cells[1].Value = otrosProductos.ToString();


                utilAntesImpuestos = utilOperacional + otrosProductos - otrosGastos;

                miTablaER.Rows[14].Cells[1].Value = utilAntesImpuestos.ToString();

                imputestos = utilAntesImpuestos * 0.3M;

                miTabla1.Rows[8].Cells[1].Value = imputestos.ToString();
                miTablaER.Rows[15].Cells[1].Value = imputestos.ToString();

                utilNeto = utilAntesImpuestos - imputestos;

                miTablaER.Rows[16].Cells[1].Value = utilNeto.ToString();


            }




        }

        public decimal calcularVentasNetas(decimal ventas, decimal devVentas, decimal rebajasVentas)
        {
            decimal ventasTotales = ventas - (devVentas+rebajasVentas) ;

            return ventasTotales;
        }

        public decimal calcularComprasTotales(decimal compras, decimal gastosCompras)
        {
            decimal comprasTotales = compras + gastosCompras;
            return comprasTotales;
        }

        public decimal calcularComprasNetas(decimal comprasTotales, decimal devCompras, decimal rebajasCompras)
        {
            decimal comprasNetas = comprasTotales - (devCompras+rebajasCompras) ;
            return comprasNetas;
        }

        public decimal calcularCostoVentas(decimal invInicial, decimal comprasNetas, decimal invFinal)
        {
            decimal CostoVentas = (invInicial + comprasNetas) - invFinal;
            return CostoVentas;
        }


        public decimal calcularGastodeVentas(decimal comisionVend, decimal publicidad, decimal rentaTienda, decimal telefonoTienda
            , decimal empaqueProductos)
        {
            return comisionVend + publicidad +rentaTienda 
                + telefonoTienda + empaqueProductos;
        }

        public decimal calcularGastosAdministrativos(decimal sueldoGerente, decimal alquileresOficinas)
        {
            return sueldoGerente + alquileresOficinas;  

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SLDocument archivo = new SLDocument();
            DataTable miTabla = new DataTable();

            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "miEstadoResultado.xlsx");
            foreach(string file in files )
            {
                File.Delete(file);
            }

            miTabla.Columns.Add("Nombre cuenta", typeof(string));
            miTabla.Columns.Add("Calculo", typeof(decimal));

            int fila = miTablaER.RowCount-1;

            for (int i = 0; i < fila; i++)
            {
                miTabla.Rows.Add(Convert.ToString(miTablaER.Rows[i].Cells[0].Value), 
                    Convert.ToDecimal(miTablaER.Rows[i].Cells[1].Value));
            }

            archivo.ImportDataTable(1, 1,
                miTabla, true);

            archivo.SaveAs(pathFile);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar == 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }
    }
}