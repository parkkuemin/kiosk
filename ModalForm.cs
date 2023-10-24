using kiosk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class ModalForm : Form
    {
        private ModalFormData formData;

        public ModalForm(ModalFormData data)
        {
            InitializeComponent();
            formData = data;

            if (formData.TopImage != null)
            {
                pictureBoxtop.Image = formData.TopImage;
                pictureBoxtop.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (formData.JugImage != null)
            {
                pictureBoxjug.Image = formData.JugImage;
                pictureBoxjug.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (formData.MidImage != null)
            {
                pictureBoxmid.Image = formData.MidImage;
                pictureBoxmid.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (formData.AdImage != null)
            {
                pictureBoxad.Image = formData.AdImage;
                pictureBoxad.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (formData.SupImage != null)
            {
                pictureBoxsup.Image = formData.SupImage;
                pictureBoxsup.SizeMode = PictureBoxSizeMode.StretchImage;
            }


        }
    }
    public class ModalFormData
    {
        public Image TopImage { get; set; }
        public Image JugImage { get; set; }
        public Image MidImage { get; set; }
        public Image AdImage { get; set; }
        public Image SupImage { get; set; }


    }
}

