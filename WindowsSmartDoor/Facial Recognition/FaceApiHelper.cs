using System;
using System.Threading.Tasks;
using Windows.Storage;
using Microsoft.ProjectOxford.Face.Contract;
using HomeSecurityCameraApp.FaceRecognition;

namespace HomeSecurityCameraApp.FaceRecognition
{
    class FaceApiUtils
    {
        public static bool ValidateImageFile(StorageFile imageFile)
        {
            return  imageFile != null       &&
                    imageFile.IsAvailable   &&
                    (imageFile.FileType.ToUpper() == ".JPG" ||
                     imageFile.FileType.ToUpper() == ".PNG" ||
                     imageFile.FileType.ToUpper() == ".GIF" ||
                     imageFile.FileType.ToUpper() == ".BMP");
        }

        public static async Task<string> GetParentFolderNameAsync(StorageFile imageFile)
        {
            var parentFolder = await imageFile.GetParentAsync();
            return parentFolder.Name;
        } 

        public static Guid[] FacesToFaceIds(Face[] faces)
        {
            var faceIds = new Guid[faces.Length];

            for(var i = 0; i < faces.Length; i++)
            {
                faceIds[i] = faces[i].FaceId;
            }
            return faceIds;
        }

        public static async Task<int> GetFilesCntInWhitelist(StorageFolder folder)
        {
            int fileCnt = 0;

            fileCnt += (await folder.GetFilesAsync()).Count;

            var subFolders = await folder.GetFoldersAsync();

            foreach(var subFolder in subFolders)
            {
                fileCnt += (await subFolder.GetFilesAsync()).Count;
            }

            return fileCnt;
        }
    }
}
