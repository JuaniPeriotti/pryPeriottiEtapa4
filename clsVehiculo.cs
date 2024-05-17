using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPeriottiEtapa4
{
    internal class clsVehiculo
    {
        string Nombre;
        public PictureBox imgAuto;
        public PictureBox imgMoto;
        public PictureBox imgAvion;

        public void crearAuto()
        {
            Nombre = "Zentorno";
            imgAuto = new PictureBox();
            imgAuto.SizeMode = PictureBoxSizeMode.Zoom;
            imgAuto.Size = new Size(300, 300);
            imgAuto.ImageLocation = @"../../../" + "/Resources/" + "Zentorno.jpg";
        }

        public void crearMoto()
        {
            Nombre = "Bati 801";
            imgMoto = new PictureBox();
            imgMoto.SizeMode = PictureBoxSizeMode.Zoom;
            imgMoto.Size = new Size(300, 300);
            imgMoto.ImageLocation = @"../../../" + "/Resources/" + "Bati801.jpg";
        }

        public void crearAvion()
        {
            Nombre = "Besra";
            imgAvion = new PictureBox();
            imgAvion.SizeMode = PictureBoxSizeMode.Zoom;
            imgAvion.Size = new Size(300, 300);
            imgAvion.ImageLocation = @"../../../" + "/Resources/" + "Besra.jpg";
        }
    }
}
