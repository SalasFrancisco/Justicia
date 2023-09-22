using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profugos
{
    public partial class Form1 : Form
    {
        Profugos oProfugos;
        DataTable tPro;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oProfugos = new Profugos();
            tPro = oProfugos.getData();

            listBox1.DisplayMember = "nombre";
            listBox1.ValueMember = "id";
            listBox1.DataSource = tPro;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "";
            label6.Text = "";
            
            int foto = 1;
            DateTime fecha;

            foreach (DataRow fPro in tPro.Rows)
            {
                if (fPro["id"].ToString() == listBox1.SelectedValue.ToString())
                {
                    foto = Convert.ToInt32(fPro["id"]);
                    pictureBox1.Load($"C:\\Users\\Alumno\\source\\repos\\Profugos\\Fotos\\{foto}.jpg");

                    label4.Text = fPro["alias"].ToString();

                    fecha = (DateTime)fPro["profugo_desde"];
                    label6.Text = fecha.ToString("dd/MM/yyyy");
                }
            }
        }
    }
}
