using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
#if DEBUG
using System.Windows.Forms;
#endif
namespace ZibomodInstaller
{
    class DriveAPI
    {
        public Dictionary<string,dynamic> GetDriveFolderList(string DriveFolderID)
        {
            Dictionary<string, dynamic> folderContentData = null;
            JavaScriptSerializer jsonParser = new JavaScriptSerializer();
            using (WebClient DriveClient = new WebClient())
            {
                string jsonData = DriveClient.DownloadString("https://www.googleapis.com/drive/v2beta/files?openDrive=true&reason=102&syncType=0&errorRecovery=false&q=trashed = false and '" + DriveFolderID + "' in parents&fields=kind,nextPageToken,items(kind,title,mimeType,createdDate,modifiedDate,modifiedByMeDate,lastViewedByMeDate,fileSize,owners(kind,permissionId,displayName,picture),lastModifyingUser(kind,permissionId,displayName,picture),hasThumbnail,thumbnailVersion,iconLink,id,shared,sharedWithMeDate,userPermission(role),explicitlyTrashed,quotaBytesUsed,shareable,copyable,fileExtension,sharingUser(kind,permissionId,displayName,picture),spaces,editable,version,teamDriveId,hasAugmentedPermissions,trashingUser(kind,permissionId,displayName,picture),trashedDate,parents(id),labels(starred,hidden,trashed,restricted,viewed),capabilities(canCopy,canDownload,canEdit,canAddChildren,canDelete,canRemoveChildren,canShare,canTrash,canRename,canReadTeamDrive,canMoveTeamDriveItem)),incompleteSearch&appDataFilter=NO_APP_DATA&spaces=drive&maxResults=50&orderBy=folder,title_natural asc&key=AIzaSyCTF8x5DeVXllRTPMrtIwnY5DaBjbjKts8");
                folderContentData = jsonParser.Deserialize<Dictionary<string, dynamic>>(jsonData);
            }
            return folderContentData;
        }
    }
    class InstallActions
    {
        public static void ZiboInstall()
        {
            DriveAPI ZiboDrive = new DriveAPI();
            Dictionary<string,dynamic> folderContentData = ZiboDrive.GetDriveFolderList("0B-tdl3VvPeOOYm12Wm80V04wdDQ");
            List<string> folderItemName = new List<string>();
            List<string> folderItemAddedDate = new List<string>();
            for (int i = 0; i < folderContentData["items"].Count; i++)
            {
                folderItemName.Add(folderContentData["items"][i]["title"]);
                folderItemAddedDate.Add(folderContentData["items"][i]["createdDate"]);
                if (folderItemName[i].Contains(".zip"))
                {

                }
            }

#if DEBUG
            string debugList = "";
            for (int i = 0; i < folderItemName.Count; i++)
            {
                debugList += folderItemName[i] + "\n";

            }
            MessageBox.Show(debugList);

#endif
        }
    }
}
