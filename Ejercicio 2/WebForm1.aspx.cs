using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practica_2_EjerProp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitProductos();
            }
        }
        
        protected void InitProductos()
        {
            Productos.Items.Add("Seleccionar");
            Productos.Items.Add("CIENCIAS DE LA SALUD");
            Productos.Items.Add("CIENCIAS JURIDICAS Y EMPRESARIALES");
            Productos.Items.Add("CIENCIAS E INGENIERIAS");
            Productos.Items.Add("CIENCIAS SOCIALES");

        }

        protected void SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Productos.Items[0].Selected == true)
            {
                TextBox1.Enabled = false;
                TextBox1.Text = "";
                TextBox2.Enabled = false;
                TextBox2.Text = "";
                TextBox3.Enabled = false;
                TextBox3.Text = "";
                TextBox4.Enabled = false;
                TextBox4.Text = "";
                
            }
            if (Productos.Items[1].Selected == true)
            {
                TextBox1.Enabled = false;
                TextBox1.Text = "23021";
                TextBox2.Enabled = false;
                TextBox2.Text = "Televisor";
                TextBox3.Enabled = false;
                TextBox3.Text = "Smart tv 60' OLED";
                TextBox4.Enabled = false;
                TextBox4.Text = "LG";
                //Image1.Height = 350;
                //Image1.Width = 530;
                //Image1.ImageUrl = "~/Resources/des_1_n.jpg";
            }
            if (Productos.Items[2].Selected == true)
            {
                f1.Enabled = false;
                f1.Text = "Administracion de empresas";
                TextBox1.Enabled = false;
                TextBox1.Text = "ciencia politica y gobierno";
                TextBox2.Enabled = false;
                TextBox2.Text = "Contabilidad";
                TextBox3.Enabled = false;
                TextBox3.Text = "Derecho";
                TextBox4.Enabled = false;
                TextBox4.Text = "ingenieria Comercial";
                //Image1.Height = 300;
                //Image1.Width = 300;
                //Image1.ImageUrl = "~/Resources/16754100_1.jpg";
            }
            if (Productos.Items[3].Selected == true)
            {
                TextBox1.Enabled = false;
                TextBox1.Text = "23023";
                TextBox2.Enabled = false;
                TextBox2.Text = "Microondas";
                TextBox3.Enabled = false;
                TextBox3.Text = "Microondas con dorador EasyClean";
                TextBox4.Enabled = false;
                TextBox4.Text = "LG";
                //Image1.Height = 350;
                //Image1.Width = 370;
                //Image1.ImageUrl = "~/Resources/15768826_1.jpg";
            }
            if (Productos.Items[4].Selected == true)
            {
                TextBox1.Enabled = false;
                TextBox1.Text = "23024";
                TextBox2.Enabled = false;
                TextBox2.Text = "Licuadora";
                TextBox3.Enabled = false;
                TextBox3.Text = "Licuadora 550W 2 velocidades";
                TextBox4.Enabled = false;
                TextBox4.Text = "Oster";
                //Image1.Height = 300;
                //Image1.Width = 300;
                //Image1.ImageUrl = "~/Resources/ac0cdf781827ac14cae9cdb4b80f97f8-product.jpg";
            }
            /*
            if (Productos.Items[5].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23025";
                Nombre.Enabled = false;
                Nombre.Text = "Tostadora";
                Descripcion.Enabled = false;
                Descripcion.Text = "Tostadora 750W Holstein";
                Marca.Enabled = false;
                Marca.Text = "Holstein";
                Image1.Height = 300;
                Image1.Width = 300;
                //Image1.ImageUrl = "~/Resources/tostadora-holstein-2-rebanadas-roja-1.jpg";
            }
            if (Productos.Items[6].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23026";
                Nombre.Enabled = false;
                Nombre.Text = "Cafetera";
                Descripcion.Enabled = false;
                Descripcion.Text = "Cafetera Oster PrimaLatte";
                Marca.Enabled = false;
                Marca.Text = "Oster";
                Image1.Height = 300;
                Image1.Width = 370;
                //Image1.ImageUrl = "~/Resources/2019148956993_2.jpg";
            }
            if (Productos.Items[7].Selected == true)
            {
                Codigo.Enabled = false;
                Codigo.Text = "23027";
                Nombre.Enabled = false;
                Nombre.Text = "Lavadora";
                Descripcion.Enabled = false;
                Descripcion.Text = "Lavadora LG Miniwash con secadora";
                Marca.Enabled = false;
                Marca.Text = "LG";
                Image1.Height = 350;
                Image1.Width = 300;
                //Image1.ImageUrl = "~/Resources/14933874_1.jpg";
            }*/
        }
        
    }
}