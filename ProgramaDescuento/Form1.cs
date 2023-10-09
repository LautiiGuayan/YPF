using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramaDescuento;

namespace ProgramaDescuento
{

    public partial class Form1 : Form

       

    {
        public Form1()
        {
            InitializeComponent();

        }

        

        public string nombreregistrado;
        public string contraseñaregistrada;

        private bool primerClic = true;

        



        int porcentaje = 0;

        private async void B1_Click(object sender, EventArgs e)
        {
         
            porcentaje=porcentaje+100;
            BARRA1.Value = porcentaje;




            await Task.Delay(900);

           B1.Visible = false;
            label1.Visible=false;
            BARRA1.Visible=false;



            LBL1.Visible = true;
            LBL3.Visible = true;
            LBL2.Visible = true;
            txtcontraseña.Visible = true;
            txtusuario.Visible = true;
            btnguardar.Visible = true;
            BTNACCEDER.Visible= true;

            





          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrEmpty(txtusuario.Text) && !string.IsNullOrEmpty(txtcontraseña.Text))
            {
                nombreregistrado = txtusuario.Text;
                contraseñaregistrada = txtcontraseña.Text ; 

                MessageBox.Show("Registro exitoso.", "Correcto");
            }
            else
            {
                MessageBox.Show("Ingrese Un Uusario o Contraseña.", "Error");
            }
            txtusuario.Text = "";
            txtcontraseña.Text = "";
        }

        private void BTNACCEDER_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtusuario.Text + "@gmail.com";
            string contrasenaIngresada = txtcontraseña.Text;

            if (usuarioIngresado == nombreregistrado && contrasenaIngresada == contraseñaregistrada)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Correcto");

                LBL1.Visible = false;
                LBL2.Visible = false;
                LBL3.Visible = false;

                txtusuario.Visible = false;
                txtcontraseña.Visible = false;

                btnguardar.Visible = false;
                BTNACCEDER.Visible = false;




                comboBox1.Visible =true;

                L1.Visible = true;
                L2.Visible = true;
                L3.Visible = true;
                L4.Visible = true;

                NUMERO1.Visible = true;
                comprar.Visible = true;
                VOLVER.Visible = true;

                lbltitulo.Visible = true;
                lblnafta.Visible = true;
                lblgnc.Visible = true;
                lblaceite.Visible = true;
                lbltimer.Visible = true;


                VOLVER.Visible=true;




            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error");
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            }

        private void comprar_Click(object sender, EventArgs e)
        {
            

            string productoSeleccionado = comboBox1.SelectedItem.ToString();
                int cantidad = (int)NUMERO1.Value;
            

            if (cantidad > 0)
                {
               
                MessageBox.Show($"Has comprado {cantidad} unidades de {productoSeleccionado}.", "Compra exitosa");
                
            }
                else
                {
                    MessageBox.Show("Por favor, selecciona al menos una unidad.", "Error");
                }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (primerClic)
            {
                comboBox1.Visible = false;

                L1.Visible = false;
                L2.Visible = false;
                L3.Visible = false;
                L4.Visible = false;

                NUMERO1.Visible = false;
                comprar.Visible = false;

                LBL1.Visible = true;
                LBL2.Visible = true;
                LBL3.Visible = true;

                txtusuario.Visible = true;
                txtcontraseña.Visible = true;

                btnguardar.Visible = true;
                BTNACCEDER.Visible = true;
                txtusuario.Text ="";
                txtcontraseña.Text = "";



            }


            else
            {
                LBL1.Visible = false;
                LBL2.Visible = false;
                LBL3.Visible = false;

                txtusuario.Visible = false;
                txtcontraseña.Visible = false;

                btnguardar.Visible = false;
                BTNACCEDER.Visible = false;


                label1.Visible = true;
                B1.Visible = true;

                porcentaje = 0;
                BARRA1.Value = porcentaje;

                BARRA1.Visible = true;

                VOLVER.Visible = false;
            }
            
            {
                //  VOLVER.Visible = false;
                //VOLVER.Enabled = false;
                primerClic = !primerClic;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            lbltimer.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text= DateTime.Now.ToLongDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}