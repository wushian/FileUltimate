﻿Imports GleamTech.AspNet.UI
Imports GleamTech.FileUltimate.AspNet.UI

Namespace Controllers
    Partial Public Class FileManagerController
        Public Function Chooser() As ActionResult

            Dim fileManager1 = New FileManager() With {
             .Id = "fileManager1",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .CollapseRibbon = True,
             .DisplayMode = DisplayMode.Window,
             .WindowOptions = new WindowOptions() With {
                .Title = "Choose a file",
                .Modal = true
              },
             .ClientChosen = "fileManagerChosen",
             .Chooser = True
            }
            fileManager1.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager1.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Dim fileManager2 = New FileManager() With {
             .Id = "fileManager2",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .CollapseRibbon = True,
             .WindowOptions = new WindowOptions() With {
                .Title = "Choose a folder",
                .Modal = true
              },
             .ClientChosen = "fileManagerChosen",
             .Chooser = True,
             .ChooserType = FileManagerChooserType.Folder
            }
            fileManager2.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager2.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Dim fileManager3 = New FileManager() With {
             .Id = "fileManager3",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .CollapseRibbon = True,
             .WindowOptions = new WindowOptions() With {
              .Title = "Choose a file or a folder",
              .Modal = true
              },
             .ClientChosen = "fileManagerChosen",
             .Chooser = True,
             .ChooserType = FileManagerChooserType.FileOrFolder
            }
            fileManager3.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager3.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Dim fileManager4 = New FileManager() With {
             .Id = "fileManager4",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .CollapseRibbon = True,
             .WindowOptions = new WindowOptions() With {
               .Title = "Choose files",
               .Modal = true
              },
             .ClientChosen = "fileManagerChosen",
             .Chooser = True,
            .ChooserMultipleSelection = True
            }
            fileManager4.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager4.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Dim fileManager5 = New FileManager() With {
             .ID = "fileManager5",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .CollapseRibbon = True,
             .WindowOptions = new WindowOptions() With {
               .Title = "Choose folders",
               .Modal = true
              },
             .ClientChosen = "fileManagerChosen",
             .Chooser = True,
             .ChooserType = FileManagerChooserType.Folder,
            .ChooserMultipleSelection = True
            }
            fileManager5.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager5.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Dim fileManager6 = New FileManager() With {
             .ID = "fileManager6",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .CollapseRibbon = True,
             .WindowOptions = new WindowOptions() With {
               .Title = "Choose files or folders",
               .Modal = true
              },
             .ClientChosen = "fileManagerChosen",
             .Chooser = True,
             .ChooserType = FileManagerChooserType.FileOrFolder,
            .ChooserMultipleSelection = True
            }
            fileManager6.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager6.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Dim fileManager7 = New FileManager() With {
             .ID = "fileManager7",
             .Width = 800,
             .Height = 400,
             .Resizable = True,
             .DisplayLanguage = "en",
             .Hidden = true,
             .ShowRibbon = False,
             .ClientChosen = "fileManagerChosen",
            .Chooser = True
            }
            fileManager7.RootFolders.Add(New FileManagerRootFolder() With {
             .Name = "Root Folder 1",
             .Location = "~/App_Data/RootFolder1"
            })
            fileManager7.RootFolders(0).AccessControls.Add(New FileManagerAccessControl() With {
             .Path = "\",
             .AllowedPermissions = FileManagerPermissions.Full
            })

            Return View(New FileManager() {fileManager1, fileManager2, fileManager3, fileManager4, fileManager5, fileManager6, fileManager7})
        End Function

    End Class
End Namespace
