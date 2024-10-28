using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text;

namespace LeerJSONDinamico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string GetJsonFromUrl(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = client.GetAsync(url).Result; // Synchronous call
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().Result; // Synchronous call
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching JSON: {ex.Message}");
                return string.Empty;
            }
        }


        private void ParseJson(JsonNode jsonNode, TreeNode parentNode)
        {
            if (jsonNode is JsonObject jsonObject)
            {
                foreach (var property in jsonObject)
                {
                    TreeNode newNode = new TreeNode(property.Key);
                    parentNode.Nodes.Add(newNode);
                    ParseJson(property.Value, newNode);
                }
            }
            else if (jsonNode is JsonArray jsonArray)
            {
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    TreeNode newNode = new TreeNode($"[{i}]");
                    parentNode.Nodes.Add(newNode);
                    ParseJson(jsonArray[i], newNode);
                }
            }
            else
            {
                parentNode.Nodes.Add(jsonNode?.ToString());
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            string url = this.txt1.Text;
            string jsonData = GetJsonFromUrl(url);

            if (!string.IsNullOrEmpty(jsonData))
            {
                try
                {
                    // Parse the JSON using System.Text.Json
                    JsonNode jsonObject = JsonNode.Parse(jsonData);

                    // Clear any previous items in the TreeView
                    tree1.Nodes.Clear();

                    // Populate the TreeView with the JSON structure
                    TreeNode rootNode = new TreeNode("JSON Root");
                    tree1.Nodes.Add(rootNode);
                    ParseJson(jsonObject, rootNode);

                    // Expand the TreeView for visibility
                    tree1.ExpandAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error parsing JSON: {ex.Message}");
                }


            }
        }

        private async void btn2_Click(object sender, EventArgs e) //async es una palabra clave en C# que se utiliza para definir métodos que pueden
                                                                  //ejecutarse de manera asíncrona.
                                                                  //La ejecución asíncrona permite que un programa realice tareas que podrían tomar tiempo
                                                                  //(como descargar un archivo desde Internet)
        {
            // Obtener la URL del TextBox
            string url = txt1.Text;


            // Verificar si la URL no está vacía
            using (HttpClient client = new HttpClient())
            {
                if (string.IsNullOrWhiteSpace(url))
                {
                    MessageBox.Show("Por favor, ingrese una URL válida.");
                    return;
                }

                try
                {
                    // Descargar el contenido JSON desde la URL
                    string jsonContent = await client.GetStringAsync(url);

                    // Deserializar el contenido JSON en un objeto Root
                    Root root = JsonSerializer.Deserialize<Root>(jsonContent);

                    // Limpiar el ListBox antes de agregar nuevas mascotas
                    lst1.Items.Clear();

                    // Recorrer la lista de mascotas y agregar cada una al ListBox
                    foreach (Pet pet in root.pets)
                    {
                        StringBuilder petInfo = new StringBuilder(); //hago un stringBuilder en vez de String para poder añadir linea a linea
                                                                     //y tener mejor presentación, se podria hacer con un string perfectamente. Hay que importar System.Text arriba;
                                                                     //Ahora comprobamos que el resto de parametros existen:
                        petInfo.Append($"Nombre: {pet.name}");
                        if (!string.IsNullOrEmpty(pet.species))
                        {
                            petInfo.Append($", Especie: {pet.species}{Environment.NewLine}");
                        }
                        if (pet.favFoods != null && pet.favFoods.Count > 0)
                        {
                            string foodList = string.Join(", ", pet.favFoods);
                            petInfo.Append($", Comida favorita: {foodList}{Environment.NewLine}");
                        }
                        if (pet.birthYear > 0)
                        {
                            petInfo.Append($", Año de nacimiento: {pet.birthYear}{Environment.NewLine}");
                        }
                        if (!string.IsNullOrEmpty(pet.photo))
                        {
                            petInfo.Append($", Foto: {pet.photo}{Environment.NewLine}{Environment.NewLine}"); //Environment new line es como si estuviera haciendo un salto de línea con un \n
                                                                                                         //pero mas efectivo, aquí puse 2 para separar entre mascotas
                        }

                        petInfo.AppendLine();
                        lst1.Items.Add(petInfo);


                    }
                }
                catch (HttpRequestException httpEx)
                {
                    MessageBox.Show($"Error al descargar el archivo: {httpEx.Message}");
                }
                catch (JsonException jsonEx)
                {
                    MessageBox.Show($"Error al procesar el archivo JSON: {jsonEx.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}");
                }
            }
        }
    }
}

    

