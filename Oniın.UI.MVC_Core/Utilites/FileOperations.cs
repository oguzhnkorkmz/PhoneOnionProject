using System.Threading.Tasks;

namespace Onion.UI.MVC_Core.Utilites
{
    public static class FileOperations
    {
        public static async Task<string> UploadImageAsync(IFormFile file)
        {
            string guid = Guid.NewGuid().ToString() + "_" + file.FileName; 
            string strPath = "wwwRoot/TelefonResimleri/" + guid;

            FileStream stream = new FileStream(strPath,FileMode.Create);

            await file.CopyToAsync(stream);
            stream.Close();

            return guid; 
        }
    }
}
