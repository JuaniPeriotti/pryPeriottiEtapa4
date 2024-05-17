namespace pryPeriottiEtapa4
{
    public partial class frmVehiculos : Form
    {
        clsVehiculo objVehiculo;
        //List<clsVehiculo> lstVehiculo = new List<clsVehiculo>();
        public frmVehiculos()
        {
            InitializeComponent();
        }

        private void btnCrearVehiculo_Click(object sender, EventArgs e)
        {
            if (cbVehiculos.Text == "Auto")
            {
                objVehiculo = new clsVehiculo();
                objVehiculo.crearAuto();
                objVehiculo.imgAuto.Location = new Point(20, 30);
                Controls.Add(objVehiculo.imgAuto);
            }
            else if (cbVehiculos.Text == "Moto")
            {
                objVehiculo.imgAuto.Dispose();
                objVehiculo = new clsVehiculo();
                objVehiculo.crearMoto();
                objVehiculo.imgMoto.Location = new Point(20, 30);
                Controls.Add(objVehiculo.imgMoto);

            }
            else if (cbVehiculos.Text == "Avión")
            {
                objVehiculo.imgMoto.Dispose();
                objVehiculo = new clsVehiculo();
                objVehiculo.crearAvion();
                objVehiculo.imgAvion.Location = new Point(20, 30);
                Controls.Add(objVehiculo.imgAvion);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string[] Vehiculos = { "Zentorno", "Bati-801", "Besra" };
            List<string> lstVehiculos = new List<string>(Vehiculos);
            lbVehiculos.Items.Clear();
            foreach (string vehiculo in lstVehiculos)
            {
                lbVehiculos.Items.Add(vehiculo);
            }
        }
    }
}
