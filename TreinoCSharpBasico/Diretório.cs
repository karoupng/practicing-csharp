using System;
using System.Collections.Generic;
using System.Text;

namespace TreinoCSharpBasico
{
     class Diretório
    {
        public static void Executar()
        {
            #region Directory e Directory Info

            //Directory estático para operações rápidas
            var folderName = "pasta";
            var subFolderName = "subpasta";
            var subFolderNameStatic = "subpasta_estatica";

            //Instanciar para reutilizar o objeto, facilitando múltiplas operações.

            var directoryInfoSubFolder = new DirectoryInfo(subFolderName);

            if (!Directory.Exists(folderName) || !directoryInfoSubFolder.Exists)
            {
                Directory.CreateDirectory(subFolderNameStatic);
            }


            


            #endregion

        }
    }
}
