using System.Net;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examen_desin_xml
{

    /*
     Ejercicio 1 — Gestor de personas con XML
Crea una aplicación WinForms que gestione personas almacenadas en personas.xml. Hazlo con XDocument, XElement, XAttribute y foreach, sin expresiones lambda.
Interfaz
Añade:
- txtDni
- txtNombre
- txtApellido
- txtEdad
- btnAñadir
- btnBuscar
- btnModificar
- btnEliminar
- btnMostrarTodos
- btnLimpiar
- lstPersonas
XML esperado
<personas>
  <persona dni="12345678A">
    <nombre>Ane</nombre>
    <apellido>López</apellido>
    <edad>22</edad>
  </persona>
</personas>

Funcionamiento
1. Al abrir la aplicación:
   - Si personas.xml no existe, créalo con la raíz <personas>.
   - Si existe, cárgalo.
   - Muestra las personas existentes en el ListBox.
2. Añadir:
   - Todos los campos son obligatorios.
   - La edad debe ser un número válido y mayor que cero.
   - No puede haber dos personas con el mismo DNI.
   - Añade el XElement a la raíz, guarda y actualiza la lista.
3. Buscar:
   - Busca una persona por su atributo dni.
   - Si existe, carga nombre, apellido y edad en los TextBox.
   - Si no existe, muestra un mensaje.
4. Modificar:
   - Localiza la persona por DNI.
   - Modifica sus elementos hijos.
   - Guarda los cambios y actualiza la lista.
5. Eliminar:
   - Busca por DNI.
   - Pide confirmación con un MessageBox.
   - Si se confirma, elimina el elemento, guarda y actualiza la lista.
6. Mostrar todos:
   - Limpia el ListBox.
   - Recorre todas las etiquetas <persona>.
   - Muestra algo como:
12345678A - Ane López - 22 años

7. Limpiar:
   - Vacía los campos.
   - Devuelve el foco al DNI.
Métodos recomendados
Intenta organizarlo utilizando estos métodos, pero escribe tú su contenido:
private void PrepararArchivo()
private XElement? BuscarPersona(XDocument doc, string dni)
private void RefrescarLista(XDocument doc)
private bool ValidarCampos()
private void LimpiarCampos()

Casos que debes probar
- Archivo inexistente.
- Añadir correctamente.
- Campos vacíos.
- Edad no numérica.
- DNI repetido.
- Buscar un DNI inexistente.
- Modificar una persona.
- Eliminar cancelando la confirmación.
- Eliminar confirmando.
- Cerrar y abrir la aplicación para comprobar que persiste.*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // TODO: Preparar el archivo, cargar el documento y mostrar las personas.
            try
            {
                // Comprobar si el archivo personas.xml existe, si no, crearlo con la raíz <personas>
                if (!File.Exists("personas.xml"))
                {
                    PrepararArchivo();
                }
                XDocument doc = XDocument.Load("personas.xml");

                RefrescarLista(doc);

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar el archivo XML. Asegúrate de que el archivo personas.xml existe y tiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnAñadir_Click(object? sender, EventArgs e)
        {
            // TODO: Validar, comprobar el DNI, añadir la persona, guardar y refrescar.

            if (!ValidarCampos())
            {
                MessageBox.Show("Error al añadir la persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XDocument doc = XDocument.Load("personas.xml");

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string dni = txtDni.Text;
                string edad = txtEdad.Text;

                XElement nuevaPersona = crearPersona(dni, nombre, apellido, edad);

                doc.Root.Add(nuevaPersona);

                doc.Save("personas.xml");

                RefrescarLista(doc);
            }

        }

        private void btnBuscar_Click(object? sender, EventArgs e)
        {
            // TODO: Buscar por DNI y rellenar los campos o avisar si no existe.
            string dni = txtDni.Text;
            XDocument doc = XDocument.Load("personas.xml");

            XElement persona = new XElement(BuscarPersona(doc, dni));

            LimpiarCampos();

            lstPersonas.Items.Add(persona);
        }

        private void btnModificar_Click(object? sender, EventArgs e)
        {
            // TODO: Validar, localizar por DNI, modificar, guardar y refrescar.

        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            // TODO: Localizar por DNI, pedir confirmación, eliminar, guardar y refrescar.
        }

        private void btnMostrarTodos_Click(object? sender, EventArgs e)
        {
            // TODO: Cargar el documento y refrescar la lista.
            XDocument doc = XDocument.Load("personas.xml");
            
            RefrescarLista(doc);
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            // TODO: Llamar a LimpiarCampos.
        }

        // Completa estos métodos con XDocument, XElement, XAttribute y foreach.
        // No uses expresiones lambda. Los eventos todavía no llaman a estos métodos.
        private void PrepararArchivo()
        {
            try
            {
                XDocument doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", null),
                    new XElement("personas")
                );
                // guardo un archivo llamado como indique en las comillas 
                doc.Save("personas.xml");
            }
            catch (Exception e)
            {
                throw new NotImplementedException("Completa PrepararArchivo.");
            }
        }

        private XElement? BuscarPersona(XDocument doc, string dni)
        {
            // TODO: Recorrer las personas y comparar su atributo dni.
            if (!ValidarCampos())
            {
                throw new NotImplementedException("Completa BuscarPersona.");
                MessageBox.Show("Error");
            }
            else
            {

                foreach (XElement persona in doc.Root!.Elements("persona"))
                {
                    if (dni == persona.Attribute("dni")?.Value)
                    {
                        return persona;
                    }
                }
                return null;
            }

        }

        private void RefrescarLista(XDocument doc)
        {
            // TODO: Vaciar lstPersonas y añadir cada persona con el formato del enunciado.
            // Vaciar la lista antes de llenarla

            if (!ValidarCampos())
            {
                MessageBox.Show("error");
            }
            else
            {
                LimpiarCampos();
                // Recorrer cada elemento <persona> y añadir su nombre al ListBox
                foreach (XElement persona in doc.Root!.Elements("persona"))
                {
                    XElement personaLista = new XElement("persona",
                        new XAttribute("dni", persona.Attribute("dni")!.Value),
                        new XElement("nombre", persona.Element("nombre")!.Value),
                        new XElement("apellido", persona.Element("apellido")!.Value),
                        new XElement("edad", persona.Element("edad")!.Value)
                    );
                    lstPersonas.Items.Add(personaLista);
                }
            }
        }

        private bool ValidarCampos()
        {
            // TODO: Comprobar campos obligatorios y una edad numérica mayor que cero.
            try
            {
                XDocument doc = XDocument.Load("personas.xml");
                return true;
            }
            catch (System.Xml.XmlException ex)
            {
                MessageBox.Show("El XML está mal escrito: " + ex.Message);
                return false;
            }
        }

        private void LimpiarCampos()
        {
            // TODO: Vaciar los cuatro campos y devolver el foco a txtDni.
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtEdad.Clear();
            lstPersonas.Items.Clear();
        }

        private XElement crearPersona(string dni, string nombre, string apellido, string edad)
        {
            XElement personaLista = new XElement("persona",
                   new XAttribute("dni", dni),
                   new XElement("nombre", nombre),
                   new XElement("apellido", apellido),
                   new XElement("edad", edad)
               );
            return personaLista;


        }
        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
