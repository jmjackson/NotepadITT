using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadITT
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveTStMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();  //Esta funcion como su nombre lo dice, guarda el documento
            sfd.Filter = "Documento Word 2016 (.docx) |*.Docx|Documento Word (.doc)|*.Doc|" + "Todos los archivos (*.*)|*.*"; //tipos que contendra la pestañana de formatos
            sfd.Title = "Guardar archivo de texto"; //nombre de la ventana emergente de guardado
            sfd.DefaultExt = "Doc"; //dara por determinado la extencion "Doc" antes de seleccionar un tipo de formato en la pestaña
            sfd.FilterIndex = 2; //posicion 2 del index que es Doc
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                RTxtLineas.SaveFile(sfd.FileName);
            }

            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Documento de Word |*.Doc";       ponemos la opcion de la pestañana de guardado, y su extencion()
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                RTxtLineas.SaveFile(sfd.FileName);
            }*/

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Esta funcion abre el documento seleccionado 
            ofd.Filter = "Documento Word 2016 (.docx) |*.Docx|Documento Word (.doc)|*.Doc|" + "Todos los archivos (*.*)|*.*"; //tipos que contendra la pestañana de formatos
            ofd.Title = "Abrir archivo"; //nombre de la ventana emergente de guardado
            ofd.DefaultExt = "Doc"; //dara por determinado la extencion "Doc" antes de seleccionar un tipo de formato en la pestaña
            ofd.FilterIndex = 2; //posicion 2 del index que es Doc

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                RTxtLineas.LoadFile(ofd.FileName);
            }
        }
    }
}
