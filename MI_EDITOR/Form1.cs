namespace MI_EDITOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //Configurar el filtro para archivos de texto
            Open.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir archivo de texto";
            Open.ShowDialog(this);
            try
            {
                //Este código para mostrar la info en el rich text box
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //Limpia el contenido del RichTextBox
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se crea un objeto SaveFileDialog para mostrar el cuadro de diálogo de guardar archivo
            SaveFileDialog Save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            // Al igual que para abrir ponemos filtros para guardar
            Save.Filter = "Archivos de texto (*.txt)|HTML (*.html)*.html|Todos los archivos (*.*)|*.*";
            Save.Title = "Guardar archivo";
            Save.CheckPathExists = true;
            Save.Title = "Guardar archivo de texto";
            Save.ShowDialog(this);
            try
            {
                //Este código para guardar la info del rich text box en un archivo de texto
                myStreamWriter = System.IO.File.CreateText(Save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo(); //Deshace la última acción realizada en el RichTextBox
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo(); //Rehace la última acción deshecha en el RichTextBox   
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); //Copia el texto seleccionado en el RichTextBox al portapapeles
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste(); //Pega el texto copiado 
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut(); //Corta el texo seleccionado y previamente copiado
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll(); //Selecciona todo
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); //Elimina todo
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Creamos el objeto FontDialog para mostrar el cuadro de diálogo de selección de fuente
            FontDialog font = new FontDialog();
            //Aplicamos la fuente seleccionada al RichTextBox si el usuario hace clic en Aceptar
            font.Font = richTextBox1.Font;
            //Se hace la validación de que el usuario haya hecho clic en Aceptar
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if(fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            }
        }
    }
}
