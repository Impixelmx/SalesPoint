using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FontAwesome.Sharp;

namespace Presentation.Forms
{
    public partial class FormUser : Form
    {

        //fields

        private IconButton currentBtn;
        private Panel leftBorderBtn;


        public FormUser()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            //evitamos parpadeo en la pantalla
            this.DoubleBuffered = true;
            //Barra de tareas
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }

        public struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        /// <summary>
        /// Method privado de tipo vacio para resaltar el color de botton activo
        /// como parametro un objeto del boton remitente y un color
        /// </summary>
        /// <param name="senderBtn"></param>
        /// <param name="color"></param>
        private void ActivateButton(object senderBtn, Color color)
        {
            DisableButton();

            //Comprobamos si el boton esta nulo 
            if (senderBtn != null)
            {
                //convertimos el objeto al mismo tipo de boton
                currentBtn = (IconButton)senderBtn;
                //cambiamos el color de fondo del boton 
                currentBtn.BackColor = Color.FromArgb(8, 31, 75);
                //cambiamos el color de texto del boton 
                currentBtn.ForeColor = color;
                //Alineamos el texto al centro
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                //cambiamos el color del icono al parametro color
                currentBtn.IconColor = color;
                //Cambiamos la relacion de texto e imagen a imagen antes de texto
                currentBtn.TextImageRelation =TextImageRelation.TextBeforeImage;
                //Alineamos el icono a la decrecha
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //panel izquierdo de botton
                leftBorderBtn.BackColor = color;
                //asignamos una nueva ubicacion
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                //colocamos visibilidad en 0
                leftBorderBtn.Visible = true;
                //traemos al frente el boton
                leftBorderBtn.BringToFront();
                //iconCurrent
                IconCurrentChildForm.IconChar = currentBtn.IconChar;
                IconCurrentChildForm.IconColor = color;
            }
        }
        /// <summary>
        /// estado natural del boton
        /// </summary>
        public void DisableButton()
        {
            if (currentBtn != null)
            {
                //cambiamos el color de fondo del boton 
                currentBtn.BackColor = Color.FromArgb(9, 13, 20);
                //cambiamos el color de texto del boton 
                currentBtn.ForeColor = Color.Gainsboro;
                //Alineamos el texto al centro
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //cambiamos el color del icono al parametro color
                currentBtn.IconColor = Color.Gainsboro;
                //Cambiamos la relacion de texto e imagen a imagen antes de texto
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //Alineamos el icono a la decrecha
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; 
            }
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnPagoServivios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //iconCurrent
            IconCurrentChildForm.IconChar = IconChar.Home;
            IconCurrentChildForm.IconColor = Color.MediumPurple;
            LblTitleChildForm.Text = "Inicio";
        }

        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int LParam);


        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
