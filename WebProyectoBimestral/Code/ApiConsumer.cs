using System.Text;

namespace WebProyectoBimestral.Code
{
    public class ApiConsumer
    {
        public static string CrearImagen(string apiUrl, string ruta)
        {
            var api = new System.Net.WebClient();
            api.Headers.Add("Content-Type", "application/json");
            var qs = "ruta=" + ruta;

            var json = api.UploadFile(apiUrl + "?" + qs, "POST", ruta);
            var resp = Encoding.UTF8.GetString(json);
            return resp;
        }
    }
}
