<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Association.aspx.vb" Inherits="Association" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="myvbproject/Styles/Site.css" rel="stylesheet" />
     <script src="javascript/jquery-1.7.1.js"></script>
    <script src="javascript/AjaxFileupload.js" type="text/javascript"></script>
    <style type="text/css">
    /* DEFAULTS
----------------------------------------------------------*/

body   
{
   
}

a:link, a:visited
{
    color: #034af3;
}

a:hover
{
    color: #1d60ff;
    text-decoration: none;
}

a:active
{
    color: #034af3;
}

p
{
    margin-bottom: 10px;
    line-height: 1.6em;
}


/* HEADINGS   
----------------------------------------------------------*/

h1, h2, h3, h4, h5, h6
{
    font-size: 1.5em;
    color: #666666;
    font-variant: small-caps;
    text-transform: none;
    font-weight: 200;
    margin-bottom: 0px;
}

h1
{
    font-size: 1.6em;
    padding-bottom: 0px;
    margin-bottom: 0px;
}

h2
{
    font-size: 1.5em;
    font-weight: 600;
}

h3
{
    font-size: 1.2em;
}

h4
{
    font-size: 1.1em;
}

h5, h6
{
    font-size: 1em;
}

/* this rule styles <h1> and <h2> tags that are the 
first child of the left and right table columns */
.rightColumn > h1, .rightColumn > h2, .leftColumn > h1, .leftColumn > h2
{
    margin-top: 0px;
}


/* PRIMARY LAYOUT ELEMENTS   
----------------------------------------------------------*/

.page
{
    width: 1000px;
    background-color: #fff;
    margin: 20px auto 0px 125px;
    border: 1px solid #496077;
}

.header
{
    position: relative;
    margin: 0px;
    padding: 0px;
    background: #4b6c9e;
    width: 100%;
}

.header h1
{
    font-weight: 700;
    margin: 0px;
    padding: 0px 0px 0px 20px;
    color: #f9f9f9;
    border: none;
    line-height: 2em;
    font-size: 2em;
}

.main
{
    padding: 0px 12px;
    margin: 12px 8px 8px 8px;
    min-height: 420px;
}

.leftCol
{
    padding: 6px 0px;
    margin: 12px 8px 8px 8px;
    width: 200px;
    min-height: 200px;
}

.footer
{
    color: #4e5766;
    padding: 8px 0px 0px 0px;
    margin: 0px auto;
    text-align: center;
    line-height: normal;
}


/* TAB MENU   
----------------------------------------------------------*/

div.hideSkiplink
{
    background-color:#3a4f63;
    width:100%;
    color: #FFFFFF;
}

div.menu
{
    padding: 4px 0px 4px 8px;
}

div.menu ul
{
    list-style: none;
    margin: 0px;
    padding: 0px;
    width: auto;
}

div.menu ul li a, div.menu ul li a:visited
{
    background-color: #465c71;
    border: 1px #4e667d solid;
    color: #dde4ec;
    display: block;
    line-height: 1.35em;
    padding: 4px 20px;
    text-decoration: none;
    white-space: nowrap;
}

div.menu ul li a:hover
{
    background-color: #bfcbd6;
    color: #465c71;
    text-decoration: none;
}

div.menu ul li a:active
{
    background-color: #465c71;
    color: #cfdbe6;
    text-decoration: none;
}

/* FORM ELEMENTS   
----------------------------------------------------------*/

fieldset
{
    margin: 1em 0px;
    padding: 1em;
    border: 1px solid #ccc;
}

fieldset p 
{
    margin: 2px 12px 10px 10px;
}

fieldset.login label, fieldset.register label, fieldset.changePassword label
{
    display: block;
}

fieldset label.inline 
{
    display: inline;
}

legend 
{
    font-size: 1.1em;
    font-weight: 600;
    padding: 2px 4px 8px 4px;
}

input.textEntry 
{
    width: 320px;
    border: 1px solid #ccc;
}

input.passwordEntry 
{
    width: 320px;
    border: 1px solid #ccc;
}

div.accountInfo
{
    width: 42%;
}

/* MISC  
----------------------------------------------------------*/

.clear
{
    clear: both;
}

.title
{
    display: block;
    float: left;
    text-align: left;
    width: auto;
}

.loginDisplay
{
    font-size: 1.1em;
    display: block;
    text-align: right;
    padding: 10px;
    color: White;
}

.loginDisplay a:link
{
    color: white;
}

.loginDisplay a:visited
{
    color: white;
}

.loginDisplay a:hover
{
    color: white;
}

.failureNotification
{
    font-size: 1.2em;
    color: Red;
}

.bold
{
    font-weight: bold;
}

.submitButton
{
    text-align: right;
    padding-right: 10px;
}    
    </style>
            <script type = "text/javascript">
        function WinPos() {
            var randomno = Math.floor((Math.random() * 100) + 1);
            x = parseInt(window.screen.width) / 1 - 0;  // the number 175 is the exact half of the width of the pop-up and so should be changed according to the size of the pop-up
            y = parseInt(window.screen.height) / 1 - 0;  // the number 67 is the exact half of the height of the pop-up and so should be changed according to the size of the pop-up
  
            //window.open('PrivateChat.aspx', 'NewWin' + randomno, 'toolbar=no,menubar=no,location=no,resizable=no,status=no,width=350,height=475,scrollbars=no')
            // change the figures of width and height above to customize the size of the window to be opened.
            CW.moveTo(x, y);
        }
    </script>
     
   
      <script type = "text/javascript">
          function ShowCurrentTime() {
              var PostText = $("#message").val().toString();
              $.ajax({

                  type: "POST",

                  url: "Association.aspx/GetCurrentTime",

                  data: '{name: "' + PostText + '" }',

                  contentType: "application/json; charset=utf-8",

                  dataType: "json",

                  success: OnSuccess,

                  failure: function (response) {


                      alert(response.d);

                  }

              });

          }
          function OnSuccess(response) {

              ShowPost(response.d);
          }
    </script>
    <script type="text/javascript">
        // check extension of file to be upload
        function checkFileExtension(file) {

            var flag = true;
            var extension = file.substr((file.lastIndexOf('.') + 1));
            switch (extension) {
                case 'jpg':
                case 'jpeg':
                case 'png':
                case 'gif':
                case 'zip':
                case 'rar':
                case 'pdf':
                case 'doc':
                case 'docx':
                case 'txt':
                case 'JPG':
                case 'JPEG':
                case 'PNG':
                case 'GIF':
                case 'ZIP':
                case 'RAR':
                case 'PDF':
                case 'DOC':
                case 'DOCX':
                case 'TXT':
                    flag = true;
                    break;
                default:
                    flag = false;
            }

            return flag;
        }
        //get file path from client system
        function getNameFromPath(strFilepath) {

            var objRE = new RegExp(/([^\/\\]+)$/);
            var strName = objRE.exec(strFilepath);
            if (strName == null) {
                return null;
            }
            else {
                return strName[0];
            }
        }
        // Asynchronous file upload process
        function ajaxFileUpload(object) {

            var RandomId = $("#" + object.id).attr('randomId');
            var FileFolder = $('#hdnFileFolder').val();
            var fileToUpload = getNameFromPath($('#fileToUpload').val());
            var filename = fileToUpload.substr(0, (fileToUpload.lastIndexOf('.')));
            if (checkFileExtension(fileToUpload)) {

                var flag = true;
                var counter = $('#hdnCountFiles').val();

                if (filename != "" && filename != null && FileFolder != "0") {
                    //Check duplicate file entry

                    for (var i = 1; i <= counter; i++) {
                        var hdnDocId = "#hdnDocId_" + i;

                        if ($(hdnDocId).length > 0) {
                            var mFileName = "#lblfilename_" + i;
                            if ($(mFileName).html() == filename) {
                                flag = false;
                                break;
                            }

                        }
                    }
                    if (flag == true) {
                        $("#loading").ajaxStart(function () {
                            $(this).show();
                        }).ajaxComplete(function () {
                            $(this).hide();
                            return false;
                        });

                        $.ajaxFileUpload({

                            url: 'FileUpload.ashx?id=' + FileFolder,
                            //url: 'dsefault.aspx',
                            secureuri: false,
                            fileElementId: 'fileToUpload',
                            dataType: 'json',
                            success: function (data, status) {


                                if (typeof (data.error) != 'undefined') {
                                    if (data.error != '') {
                                        alert(data.error);
                                    } else {
                                        if (RandomId.toString().trim() == "null") {

                                            ShowUploadedFiles(data.upfile, filename);
                                        } else {

                                            ReCommImage(object, FileFolder, fileToUpload);
                                            $("#fileToUpload").attr("RandomId", "null");
                                        }
                                        $('#fileToUpload').val("");
                                    }
                                }
                            },
                            error: function (data, status, e) {
                                alert(e);

                            }
                        });
                    }
                    else {
                        alert('file ' + filename + ' already exist')
                        return false;
                    }
                }
            }
            else {
                alert('You can upload only jpg,jpeg,pdf,doc,docx,txt,zip,rar extensions files.');
            }
            return false;

        }
        //show uploaded file 
        function ShowUploadedFiles(file, fileName) {
            count = parseInt($("#hdnCountFiles").val()) + 1;
            var hdnid = 'hdnDocId_' + count;
            var txtDocDescId = 'txtDocDesc_' + count;
            var lblfilename = 'lblfilename_' + count;
            var path = $('#hdnUploadFilePath').val();
            $("#uploadedDiv").append("<div id='" + hdnid + "' style='clear:both; background-color:#d2e9ff; padding-top:5px; height:25px; width:500px'><span id='" + lblfilename + "' style='width:175px;float:left;margin-left:40px;overflow:hidden;'>" + fileName +
                "</span><span style='width:170px;float:left;margin-left:0px;'><input type='text' id='" + txtDocDescId + "' value='" + fileName +
                "' /><input name='" + hdnid + "' id='" + hdnid + "' value='" + count + "' type='hidden'></span><span style='float:left; margin-left:10px; width:40px;' >" +
                "<a href='#' class='dellink' onclick='deleterow(\"#" + hdnid + "," + file + "\")'>Delete</a></span>" + // for deleting file
                "<span style='float:left; margin-left:10px; width:40px;' ><a class='dellink' href='FileUpload.ashx?filepath=" + path + "&file=" + file + "' >View</a></span></div>" // for downloading file

                );

            var FileFolder = $('#hdnFileFolder').val();
            var RandomId = $.now().toString().trim();
            var CurrentDate = new Date($.now());
            $("#CommentsMainContainer").append("<div class=\"MainPostBlock\" id=\"CommentsMainContainer" + RandomId + "\"></div>");
            $("#CommentsMainContainer" + RandomId).append("<div class=\"ImagePost\"><span>Posted by : <span style=\"color:red\">UserName  </span> at  : " + CurrentDate + "</span>");
            $("#CommentsMainContainer" + RandomId).append("<img height=\"300px\" width=\"50%\" style=\"float:none;margin:auto;border-radius:5px; position:relative;\" src=\"UploadFiles\\" + FileFolder + "\\" + file + "\"><br/>").append("<div class=\"ReMainPostBlock\" id=\"ReCommentsMainContainer" + RandomId + "\"></div>");
            $("#CommentsMainContainer" + RandomId).append("<input style=\"width:70%; float:left;margin-top:10px; position:relative; height:20px;\" type=\"text\" id=\"txtCommentsMainContainer" + RandomId + "\"/>").append("<input value=\"Comment\" onclick=\"ReComment(this)\" style=\"width:100px;margin-top:10px; float:left;  position:relative; height:26px;\" type=\"button\" randomId=\"" + RandomId + "\"id=\"btnCommentsMainContainer" + RandomId + "\"/>");
            $("#CommentsMainContainer" + RandomId).append("<input value=\"Image\" onclick=\"TriggerFileUpload(this)\" style=\"width:100px;margin-top:10px; float:left;  position:relative; height:26px;\" type=\"button\" randomId=\"" + RandomId + "\"id=\"imgCommentsMainContainer" + RandomId + "\"/><br/><br/></div>");
            //update file counter
            $("#hdnCountFiles").val(count);
            return false;

        }
        function ReComment(object) {

            var RandomId = $("#" + object.id).attr('randomId');
            var ReComment = $("#txtCommentsMainContainer" + RandomId).val();
            $("#ReCommentsMainContainer" + RandomId).append("<div style=\"color:red;margin-left:50px;margin-top:1px;padding-top:5px; height:30px;border:1px solid background-color:rgba(66, 134, 108, 0.09);  margin-bottom:3px; margin-right:50px; background-color:rgba(66, 134, 108, 0.09);\"><span style=\"color:Black; margin-left:50px;  position:relative\">" + ReComment + "</span></div>");
        }
        function ReCommImage(object, FileFolder, file) {

            var RandomId = $("#" + object.id).attr('randomId');
            var ReComment = $("#txtCommentsMainContainer" + RandomId).val();
            var CurrentDate = new Date($.now());
            $("#ReCommentsMainContainer" + RandomId).append("<div class=\"ImagePost \" style=\"width: 42%;font-size: 12px;font-family: serif;margin-top: 130px;float: right;border-top-right-radius: 0px;border-bottom-left-radius: 20px;border-top-left-radius: 20px;padding-top: 10px;padding-left: 10px;\"><span>Posted by : <span style=\"color:red\">UserName  </span> at  : " + CurrentDate + "</span>");

            $("#ReCommentsMainContainer" + RandomId).append("<img height=\"300px\" width=\"50%\" style=\"float:none;margin:auto;margin-left:50px;border-radius:5px; position:relative;\" src=\"UploadFiles\\" + FileFolder + "\\" + file + "\"><br/></div>")

        }
        function ShowPost(text) {
            var RandomId = $.now().toString().trim();
            $("#CommentsMainContainer").append("<div class=\"MainPostBlock\" id=\"CommentsMainContainer" + RandomId + "\"></div>");
            var CurrentDate = new Date($.now());
            $("#CommentsMainContainer" + RandomId).append("<div class=\"ImagePost\"><span>Posted by : <span style=\"color:red\">UserName  </span> at  : " + CurrentDate + "</span>");
            $("#CommentsMainContainer" + RandomId).append("<div style=\"color:black;margin-left:5px;margin-top:1px;padding-top:5px; height:50px; margin-bottom:5px; margin-right:50px; background-color:rgba(143, 174, 242, 0.48); border:1px solid rgb(168, 168, 195);\"><span>" + text + "</span></div>").append("<div class=\"ReMainPostBlock\" id=\"ReCommentsMainContainer" + RandomId + "\"></div></div>");

            $("#CommentsMainContainer" + RandomId).append("<input style=\"width:70%; float:left;margin-top:10px; position:relative; height:20px;\" type=\"text\" id=\"txtCommentsMainContainer" + RandomId + "\"/>").append("<input value=\"Comment\" onclick=\"ReComment(this)\" style=\"width:100px;margin-top:10px; float:left;  position:relative; height:26px;\" type=\"button\" randomId=\"" + RandomId + "\"id=\"btnCommentsMainContainer" + RandomId + "\"/>");
            $("#CommentsMainContainer" + RandomId).append("<input value=\"Image\" onclick=\"TriggerFileUpload(this)\" style=\"width:100px;margin-top:10px; float:left;  position:relative; height:26px;\" type=\"button\" randomId=\"" + RandomId + "\"id=\"imgCommentsMainContainer" + RandomId + "\"/><br/><br/>");
        }
        // delete existing file
        function deleterow(divrow) {
            var str = divrow.split(",");
            var row = str[0];
            var file = str[1];
            var path = $('#hdnUploadFilePath').val();
            if (confirm('Are you sure to delete?')) {
                $.ajax({
                    url: "FileUpload.ashx?path=" + path + "&file=" + file,
                    type: "GET",
                    cache: false,
                    async: true,
                    success: function (html) {

                    }
                });
                $(row).remove();
            }
            return false;
        }
        function TriggerFileUpload(object) {
            var RandomId = $("#" + object.id).attr('randomId');
            $("#fileToUpload").attr("RandomId", RandomId);

            $("#fileToUpload").click();
        }
    </script>
    
    <style type="text/css">
        #TextArea1
        {
            height: 91px;
            width: 554px;
        }
    </style>
</head>
<body>
<center>
<div class="page">
        <div class="header">

            <form id="Form" runat="server">
<hr />
    
    <br />
                           
       <div style="width:60%; min-height:130px; background-color:white;margin:auto;position:relative; min-width:800px; border:1px solid silver">
            <div style="width:98%; min-height:30px; background-color:white;margin:auto;position:relative; margin-top:3px; ">
                <div onclick="ShowCurrentTime()" style="width:25%; min-height:26px; background-color:rgb(229, 235, 240); float:left; margin:auto;position:relative;padding-top:3px; padding-left:5px ">
              <span  onclick="ShowCurrentTime()">Update Status</span> 
                     </div>
            <div style="width:30%; border-left:1px solid silver; min-height:26px;margin:auto;position:relative;float:left; background-color:white; padding-left:5px;padding-top:3px; ">
          <asp:FileUpload ID="fileToUpload" runat="server" RandomId="null" value="Photos" ClientIDMode="Static" />               
                  </div>
            </div>
            <div id="PStatusArea" style="width:98%; min-height:70px; margin:auto; position:relative; background-color:whitesmoke;margin-top:2px;border-top:1px solid silver ; border-bottom:1px solid silver ; padding-top:3px">
     <textarea id="message"  style="width:98%; height:70px; background-color:snow"  name="mainPost" aria-multiline="true"  ></textarea>  
            </div>
            <div style="width:100%; min-height:30px; background-color:whitesmoke; ">
            <input style="float:right; margin-right:10px; position:relative; background-color:blue; color:white; height:25px; width:50px; border-radius:3px; " type ="button" value="Post" onclick="ShowCurrentTime()"/>
        </div>
        </div> 
    <div id="CommentsMainContainer" class="Maincontainer" style="width:60%; position:relative; min-width: 800px;margin:auto; margin-top:5px; margin-bottom:5px; border:1px solid silver">
</div>
         <%--script for file upload--%>
    <div style="display:none">
        <p style="font-size: 15px; margin-bottom: 10px; margin-left: 10px; font-weight: bold">
            Upload Files</p>
        <div style="width: 500px; background-color: #93c9ff; height: 25px; clear: both">
            <div style="width: 175px; float: left; margin-left: 40px;">
                File Name</div>
            <div style="width: 180px; float: left">
                Description</div>
            <div style="width: 50px; float: left">
                Action</div>
        </div>
        <div id="uploadedDiv" runat="server" style="width: 500px; clear: both" clientidmode="Static">
        </div>
       
       <asp:HiddenField ID="hdnFileFolder" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hdnCountFiles" runat="server" Value="0" ClientIDMode="Static" />
        <asp:HiddenField ID="hdnUploadFilePath" runat="server" ClientIDMode="Static" />
       <div style="padding-top: 10px; clear: both">
            <div style="float: left; padding-top: 5px;">
                <%--Show wrapper on above of fileUpload Control--%>
                <label class="file-upload">
                    <%-- Set Text To be displayed inplace of Browse button--%>
                    <span><strong>Select file</strong></span>
                   <%--Make clientID static if you are using Master Page--%>
                   <%-- <asp:FileUpload ID="fileToUpload" runat="server" ClientIDMode="Static" /> --%>
                </label>
            </div>
            <div style="float: left; padding-left: 10px">
                <span style="padding-left: 10px">
                     <%--Progress bar--%> 
                    <img id="loading" src="images/loading.gif" style="display: none;"></span>
            </div>
        </div>
    </div>
                                                   
      <br />
                                                         
                     
                                 <hr />
  
   </form>
</body>
</html>
