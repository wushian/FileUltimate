﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ClientEvents.aspx.vb" Inherits="GleamTech.FileUltimateExamples.WebForms.VB.ClientEventsPage" %>
<%@ Register TagPrefix="GleamTech" Assembly="GleamTech.FileUltimate" Namespace="GleamTech.FileUltimate.AspNet.WebForms" %>
<%@ Register TagPrefix="GleamTech" Assembly="GleamTech.FileUltimate" Namespace="GleamTech.FileUltimate.AspNet.UI" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Client-side events</title>

    <script type="text/javascript">

        function fileManagerLoading(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerLoaded(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerChosen(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerFolderChanged(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerSelectionChanged(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerCreating(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerCreated(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerDeleting(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerDeleted(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerRenaming(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerRenamed(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerCopying(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerCopied(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerMoving(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerMoved(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerCompressing(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerCompressed(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerExtracting(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerExtracted(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerUploading(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerUploaded(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }


        function fileManagerDownloading(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function fileManagerPreviewing(sender, e) {
            var fileManager = sender;

            logEvent(e);
        }

        function sampleCancelEventHandler(sender, e) {
            //Canceling a before event (stops the corresponding action):
            e.isCanceled = true;
    
            //Optionally displaying a message to the user when canceling
            e.message = e.eventName + " event is canceled!";
        }

        function logEvent(e) {
            var logTextBox = document.getElementById("LogTextBox");

            var now = new Date().toLocaleTimeString();
            var json = JSON.stringify(e, null, 2);
            logTextBox.value += "[" + now + "]" + "\nEvent arguments: " + json + "\n\n";
            logTextBox.scrollTop = logTextBox.scrollHeight;
        }

        function clearLog() {
            var logTextBox = document.getElementById("LogTextBox");

            logTextBox.value = "";
        }
    </script>
</head>
<body style="margin: 20px;">
    <textarea id="LogTextBox" style="width: 800px; height: 200px; background-color: white; border: 1px solid black"></textarea>
    <br /><input type="button" value="Clear" onclick="clearLog();" />
    <br /><br />

    <GleamTech:FileManagerControl ID="fileManager" runat="server" 
        Width="800"
        Height="600"
        DisplayLanguage="en"
        ClientLoading="fileManagerLoading"
        ClientLoaded="fileManagerLoaded"
        ClientChosen="fileManagerChosen"
        ClientFolderChanged="fileManagerFolderChanged" 
        ClientSelectionChanged="fileManagerSelectionChanged"
        ClientCreating="fileManagerCreating"
        ClientCreated="fileManagerCreated"
        ClientDeleting="fileManagerDeleting"
        ClientDeleted="fileManagerDeleted"
        ClientRenaming="fileManagerRenaming"
        ClientRenamed="fileManagerRenamed"
        ClientCopying="fileManagerCopying"
        ClientCopied="fileManagerCopied"
        ClientMoving="fileManagerMoving"
        ClientMoved="fileManagerMoved"
        ClientCompressing="fileManagerCompressing"
        ClientCompressed="fileManagerCompressed"
        ClientExtracting="fileManagerExtracting"
        ClientExtracted="fileManagerExtracted"
        ClientUploading="fileManagerUploading"
        ClientUploaded="fileManagerUploaded"
        ClientDownloading="fileManagerDownloading"
        ClientPreviewing="fileManagerPreviewing">

        <GleamTech:FileManagerRootFolder Name="Root Folder 1" Location="~/App_Data/RootFolder1" >
            <GleamTech:FileManagerAccessControl Path="\" AllowedPermissions="Full"/>
        </GleamTech:FileManagerRootFolder>       

    </GleamTech:FileManagerControl>

</body>
</html>
