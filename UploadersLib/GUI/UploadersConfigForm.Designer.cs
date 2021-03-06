﻿namespace UploadersLib
{
    partial class UploadersConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadersConfigForm));
            this.tcUploaders = new System.Windows.Forms.TabControl();
            this.tpImageUploaders = new System.Windows.Forms.TabPage();
            this.tcImageUploaders = new System.Windows.Forms.TabControl();
            this.tpImageShack = new System.Windows.Forms.TabPage();
            this.atcImageShackAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.btnImageShackOpenPublicProfile = new System.Windows.Forms.Button();
            this.cbImageShackIsPublic = new System.Windows.Forms.CheckBox();
            this.btnImageShackOpenMyImages = new System.Windows.Forms.Button();
            this.lblImageShackUsername = new System.Windows.Forms.Label();
            this.btnImageShackOpenRegistrationCode = new System.Windows.Forms.Button();
            this.txtImageShackUsername = new System.Windows.Forms.TextBox();
            this.txtImageShackRegistrationCode = new System.Windows.Forms.TextBox();
            this.lblImageShackRegistrationCode = new System.Windows.Forms.Label();
            this.tpTinyPic = new System.Windows.Forms.TabPage();
            this.atcTinyPicAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.btnTinyPicLogin = new System.Windows.Forms.Button();
            this.txtTinyPicPassword = new System.Windows.Forms.TextBox();
            this.lblTinyPicPassword = new System.Windows.Forms.Label();
            this.txtTinyPicUsername = new System.Windows.Forms.TextBox();
            this.lblTinyPicUsername = new System.Windows.Forms.Label();
            this.btnTinyPicOpenMyImages = new System.Windows.Forms.Button();
            this.cbTinyPicRememberUsernamePassword = new System.Windows.Forms.CheckBox();
            this.lblTinyPicRegistrationCode = new System.Windows.Forms.Label();
            this.txtTinyPicRegistrationCode = new System.Windows.Forms.TextBox();
            this.tpImgur = new System.Windows.Forms.TabPage();
            this.oauth2Imgur = new UploadersLib.GUI.OAuth2Control();
            this.txtImgurAlbumID = new System.Windows.Forms.TextBox();
            this.lblImgurAlbumID = new System.Windows.Forms.Label();
            this.lvImgurAlbumList = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImgurRefreshAlbumList = new System.Windows.Forms.Button();
            this.cbImgurThumbnailType = new System.Windows.Forms.ComboBox();
            this.lblImgurThumbnailType = new System.Windows.Forms.Label();
            this.atcImgurAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.tpFlickr = new System.Windows.Forms.TabPage();
            this.btnFlickrOpenImages = new System.Windows.Forms.Button();
            this.pgFlickrAuthInfo = new System.Windows.Forms.PropertyGrid();
            this.pgFlickrSettings = new System.Windows.Forms.PropertyGrid();
            this.btnFlickrCheckToken = new System.Windows.Forms.Button();
            this.btnFlickrCompleteAuth = new System.Windows.Forms.Button();
            this.btnFlickrOpenAuthorize = new System.Windows.Forms.Button();
            this.tpPhotobucket = new System.Windows.Forms.TabPage();
            this.gbPhotobucketAlbumPath = new System.Windows.Forms.GroupBox();
            this.btnPhotobucketAddAlbum = new System.Windows.Forms.Button();
            this.btnPhotobucketRemoveAlbum = new System.Windows.Forms.Button();
            this.cboPhotobucketAlbumPaths = new System.Windows.Forms.ComboBox();
            this.gbPhotobucketAlbums = new System.Windows.Forms.GroupBox();
            this.lblPhotobucketNewAlbumName = new System.Windows.Forms.Label();
            this.lblPhotobucketParentAlbumPath = new System.Windows.Forms.Label();
            this.txtPhotobucketNewAlbumName = new System.Windows.Forms.TextBox();
            this.txtPhotobucketParentAlbumPath = new System.Windows.Forms.TextBox();
            this.btnPhotobucketCreateAlbum = new System.Windows.Forms.Button();
            this.gbPhotobucketUserAccount = new System.Windows.Forms.GroupBox();
            this.lblPhotobucketDefaultAlbumName = new System.Windows.Forms.Label();
            this.btnPhotobucketAuthOpen = new System.Windows.Forms.Button();
            this.txtPhotobucketDefaultAlbumName = new System.Windows.Forms.TextBox();
            this.lblPhotobucketVerificationCode = new System.Windows.Forms.Label();
            this.btnPhotobucketAuthComplete = new System.Windows.Forms.Button();
            this.txtPhotobucketVerificationCode = new System.Windows.Forms.TextBox();
            this.lblPhotobucketAccountStatus = new System.Windows.Forms.Label();
            this.tpTwitPic = new System.Windows.Forms.TabPage();
            this.lblTwitPicTip = new System.Windows.Forms.Label();
            this.chkTwitPicShowFull = new System.Windows.Forms.CheckBox();
            this.cboTwitPicThumbnailMode = new System.Windows.Forms.ComboBox();
            this.lblTwitPicThumbnailMode = new System.Windows.Forms.Label();
            this.tpTwitSnaps = new System.Windows.Forms.TabPage();
            this.lblTwitSnapsTip = new System.Windows.Forms.Label();
            this.tpYFrog = new System.Windows.Forms.TabPage();
            this.lblYFrogPassword = new System.Windows.Forms.Label();
            this.lblYFrogUsername = new System.Windows.Forms.Label();
            this.txtYFrogPassword = new System.Windows.Forms.TextBox();
            this.txtYFrogUsername = new System.Windows.Forms.TextBox();
            this.tpPicasa = new System.Windows.Forms.TabPage();
            this.txtPicasaAlbumID = new System.Windows.Forms.TextBox();
            this.lblPicasaAlbumID = new System.Windows.Forms.Label();
            this.lvPicasaAlbumList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPicasaRefreshAlbumList = new System.Windows.Forms.Button();
            this.oauth2Picasa = new UploadersLib.GUI.OAuth2Control();
            this.tpTextUploaders = new System.Windows.Forms.TabPage();
            this.tcTextUploaders = new System.Windows.Forms.TabControl();
            this.tpPastebin = new System.Windows.Forms.TabPage();
            this.btnPastebinLogin = new System.Windows.Forms.Button();
            this.pgPastebinSettings = new System.Windows.Forms.PropertyGrid();
            this.tpPaste_ee = new System.Windows.Forms.TabPage();
            this.lblPaste_eeUserAPIKey = new System.Windows.Forms.Label();
            this.txtPaste_eeUserAPIKey = new System.Windows.Forms.TextBox();
            this.tpFileUploaders = new System.Windows.Forms.TabPage();
            this.tcFileUploaders = new System.Windows.Forms.TabControl();
            this.tpDropbox = new System.Windows.Forms.TabPage();
            this.cbDropboxShortURL = new System.Windows.Forms.CheckBox();
            this.cbDropboxAutoCreateShareableLink = new System.Windows.Forms.CheckBox();
            this.btnDropboxShowFiles = new System.Windows.Forms.Button();
            this.btnDropboxCompleteAuth = new System.Windows.Forms.Button();
            this.pbDropboxLogo = new System.Windows.Forms.PictureBox();
            this.btnDropboxRegister = new System.Windows.Forms.Button();
            this.lblDropboxStatus = new System.Windows.Forms.Label();
            this.lblDropboxPathTip = new System.Windows.Forms.Label();
            this.lblDropboxPath = new System.Windows.Forms.Label();
            this.btnDropboxOpenAuthorize = new System.Windows.Forms.Button();
            this.txtDropboxPath = new System.Windows.Forms.TextBox();
            this.tpMega = new System.Windows.Forms.TabPage();
            this.atcMegaAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.lblMegaStatus = new System.Windows.Forms.Label();
            this.pnlMegaLogin = new System.Windows.Forms.Panel();
            this.btnMegaRefreshFolders = new System.Windows.Forms.Button();
            this.btnMegaRegister = new System.Windows.Forms.Button();
            this.lblMegaFolder = new System.Windows.Forms.Label();
            this.cbMegaFolder = new System.Windows.Forms.ComboBox();
            this.lblMegaEmail = new System.Windows.Forms.Label();
            this.txtMegaEmail = new System.Windows.Forms.TextBox();
            this.lblMegaPassword = new System.Windows.Forms.Label();
            this.txtMegaPassword = new System.Windows.Forms.TextBox();
            this.btnMegaLogin = new System.Windows.Forms.Button();
            this.lblMegaStatusTitle = new System.Windows.Forms.Label();
            this.tpFTP = new System.Windows.Forms.TabPage();
            this.tlpFtp = new System.Windows.Forms.TableLayoutPanel();
            this.panelFtp = new System.Windows.Forms.Panel();
            this.btnFtpClient = new System.Windows.Forms.Button();
            this.btnFTPExport = new System.Windows.Forms.Button();
            this.btnFTPImport = new System.Windows.Forms.Button();
            this.btnFtpHelp = new System.Windows.Forms.Button();
            this.ucFTPAccounts = new UploadersLib.AccountsControl();
            this.gbFtpSettings = new System.Windows.Forms.GroupBox();
            this.lblFtpFiles = new System.Windows.Forms.Label();
            this.lblFtpText = new System.Windows.Forms.Label();
            this.lblFtpImages = new System.Windows.Forms.Label();
            this.cboFtpFiles = new System.Windows.Forms.ComboBox();
            this.cboFtpText = new System.Windows.Forms.ComboBox();
            this.cboFtpImages = new System.Windows.Forms.ComboBox();
            this.tpBox = new System.Windows.Forms.TabPage();
            this.txtBoxFolderID = new System.Windows.Forms.TextBox();
            this.lblBoxFolderID = new System.Windows.Forms.Label();
            this.btnBoxRefreshFolders = new System.Windows.Forms.Button();
            this.tvBoxFolders = new System.Windows.Forms.TreeView();
            this.btnBoxCompleteAuth = new System.Windows.Forms.Button();
            this.btnBoxOpenAuthorize = new System.Windows.Forms.Button();
            this.tpRapidShare = new System.Windows.Forms.TabPage();
            this.txtRapidShareFolderID = new System.Windows.Forms.TextBox();
            this.lblRapidShareFolderID = new System.Windows.Forms.Label();
            this.btnRapidShareRefreshFolders = new System.Windows.Forms.Button();
            this.tvRapidShareFolders = new System.Windows.Forms.TreeView();
            this.lblRapidSharePassword = new System.Windows.Forms.Label();
            this.lblRapidSharePremiumUsername = new System.Windows.Forms.Label();
            this.txtRapidSharePassword = new System.Windows.Forms.TextBox();
            this.txtRapidShareUsername = new System.Windows.Forms.TextBox();
            this.tpSendSpace = new System.Windows.Forms.TabPage();
            this.btnSendSpaceRegister = new System.Windows.Forms.Button();
            this.lblSendSpacePassword = new System.Windows.Forms.Label();
            this.lblSendSpaceUsername = new System.Windows.Forms.Label();
            this.txtSendSpacePassword = new System.Windows.Forms.TextBox();
            this.txtSendSpaceUserName = new System.Windows.Forms.TextBox();
            this.atcSendSpaceAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.tpGe_tt = new System.Windows.Forms.TabPage();
            this.lblGe_ttAccessToken = new System.Windows.Forms.Label();
            this.lblGe_ttPassword = new System.Windows.Forms.Label();
            this.lblGe_ttEmail = new System.Windows.Forms.Label();
            this.btnGe_ttLogin = new System.Windows.Forms.Button();
            this.txtGe_ttPassword = new System.Windows.Forms.TextBox();
            this.txtGe_ttEmail = new System.Windows.Forms.TextBox();
            this.tpHostr = new System.Windows.Forms.TabPage();
            this.cbLocalhostrDirectURL = new System.Windows.Forms.CheckBox();
            this.lblLocalhostrPassword = new System.Windows.Forms.Label();
            this.lblLocalhostrEmail = new System.Windows.Forms.Label();
            this.txtLocalhostrPassword = new System.Windows.Forms.TextBox();
            this.txtLocalhostrEmail = new System.Windows.Forms.TextBox();
            this.tpJira = new System.Windows.Forms.TabPage();
            this.txtJiraIssuePrefix = new System.Windows.Forms.TextBox();
            this.lblJiraIssuePrefix = new System.Windows.Forms.Label();
            this.gpJiraServer = new System.Windows.Forms.GroupBox();
            this.txtJiraConfigHelp = new System.Windows.Forms.TextBox();
            this.txtJiraHost = new System.Windows.Forms.TextBox();
            this.lblJiraHost = new System.Windows.Forms.Label();
            this.oAuthJira = new UploadersLib.GUI.OAuth2Control();
            this.tpGoogleDrive = new System.Windows.Forms.TabPage();
            this.oauth2GoogleDrive = new UploadersLib.GUI.OAuth2Control();
            this.tpMinus = new System.Windows.Forms.TabPage();
            this.gbMinusUserPass = new System.Windows.Forms.GroupBox();
            this.btnAuthRefresh = new System.Windows.Forms.Button();
            this.lblMinusPassword = new System.Windows.Forms.Label();
            this.lblMinusUsername = new System.Windows.Forms.Label();
            this.txtMinusPassword = new System.Windows.Forms.TextBox();
            this.txtMinusUsername = new System.Windows.Forms.TextBox();
            this.btnMinusAuth = new System.Windows.Forms.Button();
            this.gbMinusUpload = new System.Windows.Forms.GroupBox();
            this.lblMinusURLType = new System.Windows.Forms.Label();
            this.cbMinusURLType = new System.Windows.Forms.ComboBox();
            this.btnMinusReadFolderList = new System.Windows.Forms.Button();
            this.chkMinusPublic = new System.Windows.Forms.CheckBox();
            this.btnMinusFolderAdd = new System.Windows.Forms.Button();
            this.btnMinusFolderRemove = new System.Windows.Forms.Button();
            this.cboMinusFolders = new System.Windows.Forms.ComboBox();
            this.lblMinusAuthStatus = new System.Windows.Forms.Label();
            this.tpEmail = new System.Windows.Forms.TabPage();
            this.chkEmailConfirm = new System.Windows.Forms.CheckBox();
            this.lblEmailSmtpServer = new System.Windows.Forms.Label();
            this.lblEmailPassword = new System.Windows.Forms.Label();
            this.cbEmailRememberLastTo = new System.Windows.Forms.CheckBox();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.txtEmailDefaultBody = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.txtEmailSmtpServer = new System.Windows.Forms.TextBox();
            this.lblEmailDefaultSubject = new System.Windows.Forms.Label();
            this.lblEmailDefaultBody = new System.Windows.Forms.Label();
            this.nudEmailSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.lblEmailSmtpPort = new System.Windows.Forms.Label();
            this.txtEmailDefaultSubject = new System.Windows.Forms.TextBox();
            this.tpSharedFolder = new System.Windows.Forms.TabPage();
            this.tlpSharedFolders = new System.Windows.Forms.TableLayoutPanel();
            this.ucLocalhostAccounts = new UploadersLib.AccountsControl();
            this.gbSharedFolder = new System.Windows.Forms.GroupBox();
            this.lblSharedFolderFiles = new System.Windows.Forms.Label();
            this.lblSharedFolderText = new System.Windows.Forms.Label();
            this.lblSharedFolderImages = new System.Windows.Forms.Label();
            this.cboSharedFolderFiles = new System.Windows.Forms.ComboBox();
            this.cboSharedFolderText = new System.Windows.Forms.ComboBox();
            this.cboSharedFolderImages = new System.Windows.Forms.ComboBox();
            this.tpURLShorteners = new System.Windows.Forms.TabPage();
            this.tcURLShorteners = new System.Windows.Forms.TabControl();
            this.tpGoogleURLShortener = new System.Windows.Forms.TabPage();
            this.oauth2GoogleURLShortener = new UploadersLib.GUI.OAuth2Control();
            this.atcGoogleURLShortenerAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.tpSocialNetworkingServices = new System.Windows.Forms.TabPage();
            this.tcSocialNetworkingServices = new System.Windows.Forms.TabControl();
            this.tpTwitter = new System.Windows.Forms.TabPage();
            this.btnTwitterLogin = new System.Windows.Forms.Button();
            this.ucTwitterAccounts = new UploadersLib.AccountsControl();
            this.tpCustomUploaders = new System.Windows.Forms.TabPage();
            this.lblCustomUploaderImageUploader = new System.Windows.Forms.Label();
            this.btnCustomUploaderFileUploaderTest = new System.Windows.Forms.Button();
            this.lblCustomUploaderFileUploader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomUploaderImageUploaderTest = new System.Windows.Forms.Button();
            this.lblCustomUploaderRequestTypeHelp = new System.Windows.Forms.Label();
            this.lblCustomUploaderTestResult = new System.Windows.Forms.Label();
            this.txtCustomUploaderDeletionURL = new System.Windows.Forms.TextBox();
            this.cbCustomUploaderFileUploader = new System.Windows.Forms.ComboBox();
            this.lblCustomUploaderDeletionURL = new System.Windows.Forms.Label();
            this.btnCustomUploaderShowLastResponse = new System.Windows.Forms.Button();
            this.lblCustomUploaderResponseType = new System.Windows.Forms.Label();
            this.cbCustomUploaderURLShortener = new System.Windows.Forms.ComboBox();
            this.gbCustomUploaders = new System.Windows.Forms.GroupBox();
            this.lbCustomUploaderList = new System.Windows.Forms.ListBox();
            this.btnCustomUploaderRemove = new System.Windows.Forms.Button();
            this.btnCustomUploaderClear = new System.Windows.Forms.Button();
            this.btnCustomUploaderUpdate = new System.Windows.Forms.Button();
            this.txtCustomUploaderName = new System.Windows.Forms.TextBox();
            this.btnCustomUploaderAdd = new System.Windows.Forms.Button();
            this.lblCustomUploaderTextUploader = new System.Windows.Forms.Label();
            this.lblCustomUploaderRequestURL = new System.Windows.Forms.Label();
            this.btnCustomUploaderURLShortenerTest = new System.Windows.Forms.Button();
            this.gbCustomUploaderRegexp = new System.Windows.Forms.GroupBox();
            this.btnCustomUploaderRegexpEdit = new System.Windows.Forms.Button();
            this.txtCustomUploaderRegexp = new System.Windows.Forms.TextBox();
            this.lvCustomUploaderRegexps = new System.Windows.Forms.ListView();
            this.lvRegexpsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCustomUploaderRegexpRemove = new System.Windows.Forms.Button();
            this.btnCustomUploaderRegexpAdd = new System.Windows.Forms.Button();
            this.cbCustomUploaderTextUploader = new System.Windows.Forms.ComboBox();
            this.txtCustomUploaderThumbnailURL = new System.Windows.Forms.TextBox();
            this.lblCustomUploaderURLShortener = new System.Windows.Forms.Label();
            this.cbCustomUploaderResponseType = new System.Windows.Forms.ComboBox();
            this.btnCustomUploaderTextUploaderTest = new System.Windows.Forms.Button();
            this.txtCustomUploaderURL = new System.Windows.Forms.TextBox();
            this.cbCustomUploaderImageUploader = new System.Windows.Forms.ComboBox();
            this.txtCustomUploaderRequestURL = new System.Windows.Forms.TextBox();
            this.txtCustomUploaderLog = new System.Windows.Forms.RichTextBox();
            this.lblCustomUploaderThumbnailURL = new System.Windows.Forms.Label();
            this.lblCustomUploaderFileForm = new System.Windows.Forms.Label();
            this.lblCustomUploaderRequestType = new System.Windows.Forms.Label();
            this.cbCustomUploaderRequestType = new System.Windows.Forms.ComboBox();
            this.txtCustomUploaderFileForm = new System.Windows.Forms.TextBox();
            this.lblCustomUploaderURL = new System.Windows.Forms.Label();
            this.gbCustomUploaderArguments = new System.Windows.Forms.GroupBox();
            this.btnCustomUploaderArgEdit = new System.Windows.Forms.Button();
            this.txtCustomUploaderArgValue = new System.Windows.Forms.TextBox();
            this.btnCustomUploaderArgRemove = new System.Windows.Forms.Button();
            this.lvCustomUploaderArguments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCustomUploaderArgAdd = new System.Windows.Forms.Button();
            this.txtCustomUploaderArgName = new System.Windows.Forms.TextBox();
            this.txtRapidSharePremiumUserName = new System.Windows.Forms.TextBox();
            this.ttHelpTip = new System.Windows.Forms.ToolTip(this.components);
            this.actRapidShareAccountType = new UploadersLib.GUI.AccountTypeControl();
            this.tcUploaders.SuspendLayout();
            this.tpImageUploaders.SuspendLayout();
            this.tcImageUploaders.SuspendLayout();
            this.tpImageShack.SuspendLayout();
            this.tpTinyPic.SuspendLayout();
            this.tpImgur.SuspendLayout();
            this.tpFlickr.SuspendLayout();
            this.tpPhotobucket.SuspendLayout();
            this.gbPhotobucketAlbumPath.SuspendLayout();
            this.gbPhotobucketAlbums.SuspendLayout();
            this.gbPhotobucketUserAccount.SuspendLayout();
            this.tpTwitPic.SuspendLayout();
            this.tpTwitSnaps.SuspendLayout();
            this.tpYFrog.SuspendLayout();
            this.tpPicasa.SuspendLayout();
            this.tpTextUploaders.SuspendLayout();
            this.tcTextUploaders.SuspendLayout();
            this.tpPastebin.SuspendLayout();
            this.tpPaste_ee.SuspendLayout();
            this.tpFileUploaders.SuspendLayout();
            this.tcFileUploaders.SuspendLayout();
            this.tpDropbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDropboxLogo)).BeginInit();
            this.tpMega.SuspendLayout();
            this.pnlMegaLogin.SuspendLayout();
            this.tpFTP.SuspendLayout();
            this.tlpFtp.SuspendLayout();
            this.panelFtp.SuspendLayout();
            this.gbFtpSettings.SuspendLayout();
            this.tpBox.SuspendLayout();
            this.tpRapidShare.SuspendLayout();
            this.tpSendSpace.SuspendLayout();
            this.tpGe_tt.SuspendLayout();
            this.tpHostr.SuspendLayout();
            this.tpJira.SuspendLayout();
            this.gpJiraServer.SuspendLayout();
            this.tpGoogleDrive.SuspendLayout();
            this.tpMinus.SuspendLayout();
            this.gbMinusUserPass.SuspendLayout();
            this.gbMinusUpload.SuspendLayout();
            this.tpEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailSmtpPort)).BeginInit();
            this.tpSharedFolder.SuspendLayout();
            this.tlpSharedFolders.SuspendLayout();
            this.gbSharedFolder.SuspendLayout();
            this.tpURLShorteners.SuspendLayout();
            this.tcURLShorteners.SuspendLayout();
            this.tpGoogleURLShortener.SuspendLayout();
            this.tpSocialNetworkingServices.SuspendLayout();
            this.tcSocialNetworkingServices.SuspendLayout();
            this.tpTwitter.SuspendLayout();
            this.tpCustomUploaders.SuspendLayout();
            this.gbCustomUploaders.SuspendLayout();
            this.gbCustomUploaderRegexp.SuspendLayout();
            this.gbCustomUploaderArguments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUploaders
            // 
            this.tcUploaders.Controls.Add(this.tpImageUploaders);
            this.tcUploaders.Controls.Add(this.tpTextUploaders);
            this.tcUploaders.Controls.Add(this.tpFileUploaders);
            this.tcUploaders.Controls.Add(this.tpURLShorteners);
            this.tcUploaders.Controls.Add(this.tpSocialNetworkingServices);
            this.tcUploaders.Controls.Add(this.tpCustomUploaders);
            this.tcUploaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUploaders.Location = new System.Drawing.Point(3, 3);
            this.tcUploaders.Name = "tcUploaders";
            this.tcUploaders.SelectedIndex = 0;
            this.tcUploaders.Size = new System.Drawing.Size(826, 533);
            this.tcUploaders.TabIndex = 0;
            // 
            // tpImageUploaders
            // 
            this.tpImageUploaders.Controls.Add(this.tcImageUploaders);
            this.tpImageUploaders.Location = new System.Drawing.Point(4, 22);
            this.tpImageUploaders.Name = "tpImageUploaders";
            this.tpImageUploaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpImageUploaders.Size = new System.Drawing.Size(818, 507);
            this.tpImageUploaders.TabIndex = 0;
            this.tpImageUploaders.Text = "Image uploaders";
            this.tpImageUploaders.UseVisualStyleBackColor = true;
            // 
            // tcImageUploaders
            // 
            this.tcImageUploaders.Controls.Add(this.tpImageShack);
            this.tcImageUploaders.Controls.Add(this.tpTinyPic);
            this.tcImageUploaders.Controls.Add(this.tpImgur);
            this.tcImageUploaders.Controls.Add(this.tpFlickr);
            this.tcImageUploaders.Controls.Add(this.tpPhotobucket);
            this.tcImageUploaders.Controls.Add(this.tpTwitPic);
            this.tcImageUploaders.Controls.Add(this.tpTwitSnaps);
            this.tcImageUploaders.Controls.Add(this.tpYFrog);
            this.tcImageUploaders.Controls.Add(this.tpPicasa);
            this.tcImageUploaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcImageUploaders.Location = new System.Drawing.Point(3, 3);
            this.tcImageUploaders.MinimumSize = new System.Drawing.Size(780, 480);
            this.tcImageUploaders.Name = "tcImageUploaders";
            this.tcImageUploaders.SelectedIndex = 0;
            this.tcImageUploaders.Size = new System.Drawing.Size(812, 501);
            this.tcImageUploaders.TabIndex = 0;
            // 
            // tpImageShack
            // 
            this.tpImageShack.Controls.Add(this.atcImageShackAccountType);
            this.tpImageShack.Controls.Add(this.btnImageShackOpenPublicProfile);
            this.tpImageShack.Controls.Add(this.cbImageShackIsPublic);
            this.tpImageShack.Controls.Add(this.btnImageShackOpenMyImages);
            this.tpImageShack.Controls.Add(this.lblImageShackUsername);
            this.tpImageShack.Controls.Add(this.btnImageShackOpenRegistrationCode);
            this.tpImageShack.Controls.Add(this.txtImageShackUsername);
            this.tpImageShack.Controls.Add(this.txtImageShackRegistrationCode);
            this.tpImageShack.Controls.Add(this.lblImageShackRegistrationCode);
            this.tpImageShack.Location = new System.Drawing.Point(4, 22);
            this.tpImageShack.Name = "tpImageShack";
            this.tpImageShack.Padding = new System.Windows.Forms.Padding(3);
            this.tpImageShack.Size = new System.Drawing.Size(804, 475);
            this.tpImageShack.TabIndex = 0;
            this.tpImageShack.Text = "ImageShack";
            this.tpImageShack.UseVisualStyleBackColor = true;
            // 
            // atcImageShackAccountType
            // 
            this.atcImageShackAccountType.Location = new System.Drawing.Point(8, 16);
            this.atcImageShackAccountType.Name = "atcImageShackAccountType";
            this.atcImageShackAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.atcImageShackAccountType.Size = new System.Drawing.Size(272, 29);
            this.atcImageShackAccountType.TabIndex = 0;
            this.atcImageShackAccountType.AccountTypeChanged += new UploadersLib.GUI.AccountTypeControl.AccountTypeChangedEventHandler(this.atcImageShackAccountType_AccountTypeChanged);
            // 
            // btnImageShackOpenPublicProfile
            // 
            this.btnImageShackOpenPublicProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImageShackOpenPublicProfile.Location = new System.Drawing.Point(16, 232);
            this.btnImageShackOpenPublicProfile.Name = "btnImageShackOpenPublicProfile";
            this.btnImageShackOpenPublicProfile.Size = new System.Drawing.Size(200, 23);
            this.btnImageShackOpenPublicProfile.TabIndex = 7;
            this.btnImageShackOpenPublicProfile.Text = "Open public profile page...";
            this.btnImageShackOpenPublicProfile.UseVisualStyleBackColor = true;
            this.btnImageShackOpenPublicProfile.Click += new System.EventHandler(this.btnImageShackOpenPublicProfile_Click);
            // 
            // cbImageShackIsPublic
            // 
            this.cbImageShackIsPublic.AutoSize = true;
            this.cbImageShackIsPublic.Location = new System.Drawing.Point(16, 168);
            this.cbImageShackIsPublic.Name = "cbImageShackIsPublic";
            this.cbImageShackIsPublic.Size = new System.Drawing.Size(307, 17);
            this.cbImageShackIsPublic.TabIndex = 5;
            this.cbImageShackIsPublic.Text = "Show images uploaded to ImageShack in your public profile";
            this.cbImageShackIsPublic.UseVisualStyleBackColor = true;
            this.cbImageShackIsPublic.CheckedChanged += new System.EventHandler(this.cbImageShackIsPublic_CheckedChanged);
            // 
            // btnImageShackOpenMyImages
            // 
            this.btnImageShackOpenMyImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImageShackOpenMyImages.Location = new System.Drawing.Point(16, 264);
            this.btnImageShackOpenMyImages.Name = "btnImageShackOpenMyImages";
            this.btnImageShackOpenMyImages.Size = new System.Drawing.Size(200, 23);
            this.btnImageShackOpenMyImages.TabIndex = 8;
            this.btnImageShackOpenMyImages.Text = "Open my images page...";
            this.btnImageShackOpenMyImages.UseVisualStyleBackColor = true;
            this.btnImageShackOpenMyImages.Click += new System.EventHandler(this.btnImageShackOpenMyImages_Click);
            // 
            // lblImageShackUsername
            // 
            this.lblImageShackUsername.AutoSize = true;
            this.lblImageShackUsername.Location = new System.Drawing.Point(16, 112);
            this.lblImageShackUsername.Name = "lblImageShackUsername";
            this.lblImageShackUsername.Size = new System.Drawing.Size(246, 13);
            this.lblImageShackUsername.TabIndex = 3;
            this.lblImageShackUsername.Text = "Username (To be able to open public profile page):";
            // 
            // btnImageShackOpenRegistrationCode
            // 
            this.btnImageShackOpenRegistrationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImageShackOpenRegistrationCode.Location = new System.Drawing.Point(16, 200);
            this.btnImageShackOpenRegistrationCode.Name = "btnImageShackOpenRegistrationCode";
            this.btnImageShackOpenRegistrationCode.Size = new System.Drawing.Size(200, 23);
            this.btnImageShackOpenRegistrationCode.TabIndex = 6;
            this.btnImageShackOpenRegistrationCode.Text = "Open registration code page...";
            this.btnImageShackOpenRegistrationCode.UseVisualStyleBackColor = true;
            this.btnImageShackOpenRegistrationCode.Click += new System.EventHandler(this.btnImageShackOpenRegistrationCode_Click);
            // 
            // txtImageShackUsername
            // 
            this.txtImageShackUsername.Location = new System.Drawing.Point(16, 136);
            this.txtImageShackUsername.Name = "txtImageShackUsername";
            this.txtImageShackUsername.Size = new System.Drawing.Size(360, 20);
            this.txtImageShackUsername.TabIndex = 4;
            this.txtImageShackUsername.TextChanged += new System.EventHandler(this.txtImageShackUsername_TextChanged);
            // 
            // txtImageShackRegistrationCode
            // 
            this.txtImageShackRegistrationCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImageShackRegistrationCode.Location = new System.Drawing.Point(16, 80);
            this.txtImageShackRegistrationCode.Name = "txtImageShackRegistrationCode";
            this.txtImageShackRegistrationCode.Size = new System.Drawing.Size(392, 20);
            this.txtImageShackRegistrationCode.TabIndex = 2;
            this.txtImageShackRegistrationCode.TextChanged += new System.EventHandler(this.txtImageShackRegistrationCode_TextChanged);
            // 
            // lblImageShackRegistrationCode
            // 
            this.lblImageShackRegistrationCode.AutoSize = true;
            this.lblImageShackRegistrationCode.Location = new System.Drawing.Point(16, 56);
            this.lblImageShackRegistrationCode.Name = "lblImageShackRegistrationCode";
            this.lblImageShackRegistrationCode.Size = new System.Drawing.Size(93, 13);
            this.lblImageShackRegistrationCode.TabIndex = 1;
            this.lblImageShackRegistrationCode.Text = "Registration code:";
            // 
            // tpTinyPic
            // 
            this.tpTinyPic.Controls.Add(this.atcTinyPicAccountType);
            this.tpTinyPic.Controls.Add(this.btnTinyPicLogin);
            this.tpTinyPic.Controls.Add(this.txtTinyPicPassword);
            this.tpTinyPic.Controls.Add(this.lblTinyPicPassword);
            this.tpTinyPic.Controls.Add(this.txtTinyPicUsername);
            this.tpTinyPic.Controls.Add(this.lblTinyPicUsername);
            this.tpTinyPic.Controls.Add(this.btnTinyPicOpenMyImages);
            this.tpTinyPic.Controls.Add(this.cbTinyPicRememberUsernamePassword);
            this.tpTinyPic.Controls.Add(this.lblTinyPicRegistrationCode);
            this.tpTinyPic.Controls.Add(this.txtTinyPicRegistrationCode);
            this.tpTinyPic.Location = new System.Drawing.Point(4, 22);
            this.tpTinyPic.Name = "tpTinyPic";
            this.tpTinyPic.Padding = new System.Windows.Forms.Padding(3);
            this.tpTinyPic.Size = new System.Drawing.Size(804, 475);
            this.tpTinyPic.TabIndex = 1;
            this.tpTinyPic.Text = "TinyPic";
            this.tpTinyPic.UseVisualStyleBackColor = true;
            // 
            // atcTinyPicAccountType
            // 
            this.atcTinyPicAccountType.Location = new System.Drawing.Point(8, 16);
            this.atcTinyPicAccountType.Name = "atcTinyPicAccountType";
            this.atcTinyPicAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.atcTinyPicAccountType.Size = new System.Drawing.Size(272, 29);
            this.atcTinyPicAccountType.TabIndex = 0;
            this.atcTinyPicAccountType.AccountTypeChanged += new UploadersLib.GUI.AccountTypeControl.AccountTypeChangedEventHandler(this.atcTinyPicAccountType_AccountTypeChanged);
            // 
            // btnTinyPicLogin
            // 
            this.btnTinyPicLogin.Location = new System.Drawing.Point(16, 168);
            this.btnTinyPicLogin.Name = "btnTinyPicLogin";
            this.btnTinyPicLogin.Size = new System.Drawing.Size(80, 23);
            this.btnTinyPicLogin.TabIndex = 5;
            this.btnTinyPicLogin.Text = "Login";
            this.btnTinyPicLogin.UseVisualStyleBackColor = true;
            this.btnTinyPicLogin.Click += new System.EventHandler(this.btnTinyPicLogin_Click);
            // 
            // txtTinyPicPassword
            // 
            this.txtTinyPicPassword.Location = new System.Drawing.Point(16, 136);
            this.txtTinyPicPassword.Name = "txtTinyPicPassword";
            this.txtTinyPicPassword.PasswordChar = '*';
            this.txtTinyPicPassword.Size = new System.Drawing.Size(360, 20);
            this.txtTinyPicPassword.TabIndex = 4;
            this.txtTinyPicPassword.TextChanged += new System.EventHandler(this.txtTinyPicPassword_TextChanged);
            // 
            // lblTinyPicPassword
            // 
            this.lblTinyPicPassword.AutoSize = true;
            this.lblTinyPicPassword.Location = new System.Drawing.Point(16, 112);
            this.lblTinyPicPassword.Name = "lblTinyPicPassword";
            this.lblTinyPicPassword.Size = new System.Drawing.Size(56, 13);
            this.lblTinyPicPassword.TabIndex = 3;
            this.lblTinyPicPassword.Text = "Password:";
            // 
            // txtTinyPicUsername
            // 
            this.txtTinyPicUsername.Location = new System.Drawing.Point(16, 80);
            this.txtTinyPicUsername.Name = "txtTinyPicUsername";
            this.txtTinyPicUsername.Size = new System.Drawing.Size(360, 20);
            this.txtTinyPicUsername.TabIndex = 2;
            this.txtTinyPicUsername.TextChanged += new System.EventHandler(this.txtTinyPicUsername_TextChanged);
            // 
            // lblTinyPicUsername
            // 
            this.lblTinyPicUsername.AutoSize = true;
            this.lblTinyPicUsername.Location = new System.Drawing.Point(16, 56);
            this.lblTinyPicUsername.Name = "lblTinyPicUsername";
            this.lblTinyPicUsername.Size = new System.Drawing.Size(58, 13);
            this.lblTinyPicUsername.TabIndex = 1;
            this.lblTinyPicUsername.Text = "Username:";
            // 
            // btnTinyPicOpenMyImages
            // 
            this.btnTinyPicOpenMyImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinyPicOpenMyImages.Location = new System.Drawing.Point(16, 264);
            this.btnTinyPicOpenMyImages.Name = "btnTinyPicOpenMyImages";
            this.btnTinyPicOpenMyImages.Size = new System.Drawing.Size(200, 23);
            this.btnTinyPicOpenMyImages.TabIndex = 9;
            this.btnTinyPicOpenMyImages.Text = "Open my images page...";
            this.btnTinyPicOpenMyImages.UseVisualStyleBackColor = true;
            this.btnTinyPicOpenMyImages.Click += new System.EventHandler(this.btnTinyPicOpenMyImages_Click);
            // 
            // cbTinyPicRememberUsernamePassword
            // 
            this.cbTinyPicRememberUsernamePassword.AutoSize = true;
            this.cbTinyPicRememberUsernamePassword.Location = new System.Drawing.Point(112, 171);
            this.cbTinyPicRememberUsernamePassword.Name = "cbTinyPicRememberUsernamePassword";
            this.cbTinyPicRememberUsernamePassword.Size = new System.Drawing.Size(233, 17);
            this.cbTinyPicRememberUsernamePassword.TabIndex = 6;
            this.cbTinyPicRememberUsernamePassword.Text = "Remember TinyPic username and password";
            this.cbTinyPicRememberUsernamePassword.UseVisualStyleBackColor = true;
            this.cbTinyPicRememberUsernamePassword.CheckedChanged += new System.EventHandler(this.cbTinyPicRememberUsernamePassword_CheckedChanged);
            // 
            // lblTinyPicRegistrationCode
            // 
            this.lblTinyPicRegistrationCode.AutoSize = true;
            this.lblTinyPicRegistrationCode.Location = new System.Drawing.Point(16, 208);
            this.lblTinyPicRegistrationCode.Name = "lblTinyPicRegistrationCode";
            this.lblTinyPicRegistrationCode.Size = new System.Drawing.Size(335, 13);
            this.lblTinyPicRegistrationCode.TabIndex = 7;
            this.lblTinyPicRegistrationCode.Text = "Registration code (You must login for be able to get registration code):";
            // 
            // txtTinyPicRegistrationCode
            // 
            this.txtTinyPicRegistrationCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTinyPicRegistrationCode.BackColor = System.Drawing.Color.White;
            this.txtTinyPicRegistrationCode.Location = new System.Drawing.Point(16, 232);
            this.txtTinyPicRegistrationCode.Name = "txtTinyPicRegistrationCode";
            this.txtTinyPicRegistrationCode.ReadOnly = true;
            this.txtTinyPicRegistrationCode.Size = new System.Drawing.Size(392, 20);
            this.txtTinyPicRegistrationCode.TabIndex = 8;
            // 
            // tpImgur
            // 
            this.tpImgur.Controls.Add(this.oauth2Imgur);
            this.tpImgur.Controls.Add(this.txtImgurAlbumID);
            this.tpImgur.Controls.Add(this.lblImgurAlbumID);
            this.tpImgur.Controls.Add(this.lvImgurAlbumList);
            this.tpImgur.Controls.Add(this.btnImgurRefreshAlbumList);
            this.tpImgur.Controls.Add(this.cbImgurThumbnailType);
            this.tpImgur.Controls.Add(this.lblImgurThumbnailType);
            this.tpImgur.Controls.Add(this.atcImgurAccountType);
            this.tpImgur.Location = new System.Drawing.Point(4, 22);
            this.tpImgur.Name = "tpImgur";
            this.tpImgur.Padding = new System.Windows.Forms.Padding(3);
            this.tpImgur.Size = new System.Drawing.Size(804, 475);
            this.tpImgur.TabIndex = 2;
            this.tpImgur.Text = "Imgur";
            this.tpImgur.UseVisualStyleBackColor = true;
            // 
            // oauth2Imgur
            // 
            this.oauth2Imgur.Location = new System.Drawing.Point(464, 16);
            this.oauth2Imgur.LoginStatus = false;
            this.oauth2Imgur.Name = "oauth2Imgur";
            this.oauth2Imgur.Size = new System.Drawing.Size(328, 207);
            this.oauth2Imgur.Status = "Status: Login required.";
            this.oauth2Imgur.TabIndex = 6;
            this.oauth2Imgur.OpenButtonClicked += new UploadersLib.GUI.OAuth2Control.OpenButtonClickedEventHandler(this.oauth2Imgur_OpenButtonClicked);
            this.oauth2Imgur.CompleteButtonClicked += new UploadersLib.GUI.OAuth2Control.CompleteButtonClickedEventHandler(this.oauth2Imgur_CompleteButtonClicked);
            this.oauth2Imgur.RefreshButtonClicked += new UploadersLib.GUI.OAuth2Control.RefreshButtonClickedEventHandler(this.oauth2Imgur_RefreshButtonClicked);
            // 
            // txtImgurAlbumID
            // 
            this.txtImgurAlbumID.Location = new System.Drawing.Point(256, 84);
            this.txtImgurAlbumID.Name = "txtImgurAlbumID";
            this.txtImgurAlbumID.Size = new System.Drawing.Size(176, 20);
            this.txtImgurAlbumID.TabIndex = 4;
            this.txtImgurAlbumID.TextChanged += new System.EventHandler(this.txtImgurAlbumID_TextChanged);
            // 
            // lblImgurAlbumID
            // 
            this.lblImgurAlbumID.AutoSize = true;
            this.lblImgurAlbumID.Location = new System.Drawing.Point(16, 88);
            this.lblImgurAlbumID.Name = "lblImgurAlbumID";
            this.lblImgurAlbumID.Size = new System.Drawing.Size(233, 13);
            this.lblImgurAlbumID.TabIndex = 3;
            this.lblImgurAlbumID.Text = "Album ID for upload (Empty = No album upload):";
            // 
            // lvImgurAlbumList
            // 
            this.lvImgurAlbumList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chTitle,
            this.chDescription});
            this.lvImgurAlbumList.FullRowSelect = true;
            this.lvImgurAlbumList.Location = new System.Drawing.Point(16, 144);
            this.lvImgurAlbumList.MultiSelect = false;
            this.lvImgurAlbumList.Name = "lvImgurAlbumList";
            this.lvImgurAlbumList.Size = new System.Drawing.Size(432, 312);
            this.lvImgurAlbumList.TabIndex = 7;
            this.lvImgurAlbumList.UseCompatibleStateImageBehavior = false;
            this.lvImgurAlbumList.View = System.Windows.Forms.View.Details;
            this.lvImgurAlbumList.SelectedIndexChanged += new System.EventHandler(this.lvImgurAlbumList_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 70;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Title";
            this.chTitle.Width = 150;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 208;
            // 
            // btnImgurRefreshAlbumList
            // 
            this.btnImgurRefreshAlbumList.Enabled = false;
            this.btnImgurRefreshAlbumList.Location = new System.Drawing.Point(16, 112);
            this.btnImgurRefreshAlbumList.Name = "btnImgurRefreshAlbumList";
            this.btnImgurRefreshAlbumList.Size = new System.Drawing.Size(200, 23);
            this.btnImgurRefreshAlbumList.TabIndex = 5;
            this.btnImgurRefreshAlbumList.Text = "Refresh album list";
            this.btnImgurRefreshAlbumList.UseVisualStyleBackColor = true;
            this.btnImgurRefreshAlbumList.Click += new System.EventHandler(this.btnImgurRefreshAlbumList_Click);
            // 
            // cbImgurThumbnailType
            // 
            this.cbImgurThumbnailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImgurThumbnailType.FormattingEnabled = true;
            this.cbImgurThumbnailType.Location = new System.Drawing.Point(104, 52);
            this.cbImgurThumbnailType.Name = "cbImgurThumbnailType";
            this.cbImgurThumbnailType.Size = new System.Drawing.Size(168, 21);
            this.cbImgurThumbnailType.TabIndex = 2;
            this.cbImgurThumbnailType.SelectedIndexChanged += new System.EventHandler(this.cbImgurThumbnailType_SelectedIndexChanged);
            // 
            // lblImgurThumbnailType
            // 
            this.lblImgurThumbnailType.AutoSize = true;
            this.lblImgurThumbnailType.Location = new System.Drawing.Point(16, 56);
            this.lblImgurThumbnailType.Name = "lblImgurThumbnailType";
            this.lblImgurThumbnailType.Size = new System.Drawing.Size(82, 13);
            this.lblImgurThumbnailType.TabIndex = 1;
            this.lblImgurThumbnailType.Text = "Thumbnail type:";
            // 
            // atcImgurAccountType
            // 
            this.atcImgurAccountType.Location = new System.Drawing.Point(8, 16);
            this.atcImgurAccountType.Name = "atcImgurAccountType";
            this.atcImgurAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.atcImgurAccountType.Size = new System.Drawing.Size(272, 29);
            this.atcImgurAccountType.TabIndex = 0;
            this.atcImgurAccountType.AccountTypeChanged += new UploadersLib.GUI.AccountTypeControl.AccountTypeChangedEventHandler(this.atcImgurAccountType_AccountTypeChanged);
            // 
            // tpFlickr
            // 
            this.tpFlickr.Controls.Add(this.btnFlickrOpenImages);
            this.tpFlickr.Controls.Add(this.pgFlickrAuthInfo);
            this.tpFlickr.Controls.Add(this.pgFlickrSettings);
            this.tpFlickr.Controls.Add(this.btnFlickrCheckToken);
            this.tpFlickr.Controls.Add(this.btnFlickrCompleteAuth);
            this.tpFlickr.Controls.Add(this.btnFlickrOpenAuthorize);
            this.tpFlickr.Location = new System.Drawing.Point(4, 22);
            this.tpFlickr.Name = "tpFlickr";
            this.tpFlickr.Padding = new System.Windows.Forms.Padding(3);
            this.tpFlickr.Size = new System.Drawing.Size(804, 475);
            this.tpFlickr.TabIndex = 3;
            this.tpFlickr.Text = "Flickr";
            this.tpFlickr.UseVisualStyleBackColor = true;
            // 
            // btnFlickrOpenImages
            // 
            this.btnFlickrOpenImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlickrOpenImages.Location = new System.Drawing.Point(624, 213);
            this.btnFlickrOpenImages.Name = "btnFlickrOpenImages";
            this.btnFlickrOpenImages.Size = new System.Drawing.Size(168, 23);
            this.btnFlickrOpenImages.TabIndex = 5;
            this.btnFlickrOpenImages.Text = "Your photostream...";
            this.btnFlickrOpenImages.UseVisualStyleBackColor = true;
            this.btnFlickrOpenImages.Click += new System.EventHandler(this.btnFlickrOpenImages_Click);
            // 
            // pgFlickrAuthInfo
            // 
            this.pgFlickrAuthInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgFlickrAuthInfo.CommandsVisibleIfAvailable = false;
            this.pgFlickrAuthInfo.Location = new System.Drawing.Point(16, 16);
            this.pgFlickrAuthInfo.Name = "pgFlickrAuthInfo";
            this.pgFlickrAuthInfo.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgFlickrAuthInfo.Size = new System.Drawing.Size(594, 160);
            this.pgFlickrAuthInfo.TabIndex = 0;
            this.pgFlickrAuthInfo.ToolbarVisible = false;
            // 
            // pgFlickrSettings
            // 
            this.pgFlickrSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgFlickrSettings.CommandsVisibleIfAvailable = false;
            this.pgFlickrSettings.Location = new System.Drawing.Point(16, 184);
            this.pgFlickrSettings.Name = "pgFlickrSettings";
            this.pgFlickrSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgFlickrSettings.Size = new System.Drawing.Size(594, 275);
            this.pgFlickrSettings.TabIndex = 3;
            this.pgFlickrSettings.ToolbarVisible = false;
            // 
            // btnFlickrCheckToken
            // 
            this.btnFlickrCheckToken.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlickrCheckToken.Location = new System.Drawing.Point(624, 184);
            this.btnFlickrCheckToken.Name = "btnFlickrCheckToken";
            this.btnFlickrCheckToken.Size = new System.Drawing.Size(168, 23);
            this.btnFlickrCheckToken.TabIndex = 4;
            this.btnFlickrCheckToken.Text = "Check Token...";
            this.btnFlickrCheckToken.UseVisualStyleBackColor = true;
            this.btnFlickrCheckToken.Click += new System.EventHandler(this.btnFlickrCheckToken_Click);
            // 
            // btnFlickrCompleteAuth
            // 
            this.btnFlickrCompleteAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlickrCompleteAuth.Enabled = false;
            this.btnFlickrCompleteAuth.Location = new System.Drawing.Point(624, 47);
            this.btnFlickrCompleteAuth.Name = "btnFlickrCompleteAuth";
            this.btnFlickrCompleteAuth.Size = new System.Drawing.Size(168, 24);
            this.btnFlickrCompleteAuth.TabIndex = 2;
            this.btnFlickrCompleteAuth.Text = "Step 2. Complete authorization";
            this.btnFlickrCompleteAuth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlickrCompleteAuth.UseVisualStyleBackColor = true;
            this.btnFlickrCompleteAuth.Click += new System.EventHandler(this.btnFlickrCompleteAuth_Click);
            // 
            // btnFlickrOpenAuthorize
            // 
            this.btnFlickrOpenAuthorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlickrOpenAuthorize.Location = new System.Drawing.Point(624, 18);
            this.btnFlickrOpenAuthorize.Name = "btnFlickrOpenAuthorize";
            this.btnFlickrOpenAuthorize.Size = new System.Drawing.Size(168, 23);
            this.btnFlickrOpenAuthorize.TabIndex = 1;
            this.btnFlickrOpenAuthorize.Text = "Step 1. Open authorize page...";
            this.btnFlickrOpenAuthorize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlickrOpenAuthorize.UseVisualStyleBackColor = true;
            this.btnFlickrOpenAuthorize.Click += new System.EventHandler(this.btnFlickrOpenAuthorize_Click);
            // 
            // tpPhotobucket
            // 
            this.tpPhotobucket.Controls.Add(this.gbPhotobucketAlbumPath);
            this.tpPhotobucket.Controls.Add(this.gbPhotobucketAlbums);
            this.tpPhotobucket.Controls.Add(this.gbPhotobucketUserAccount);
            this.tpPhotobucket.Location = new System.Drawing.Point(4, 22);
            this.tpPhotobucket.Name = "tpPhotobucket";
            this.tpPhotobucket.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhotobucket.Size = new System.Drawing.Size(804, 475);
            this.tpPhotobucket.TabIndex = 4;
            this.tpPhotobucket.Text = "Photobucket";
            this.tpPhotobucket.UseVisualStyleBackColor = true;
            // 
            // gbPhotobucketAlbumPath
            // 
            this.gbPhotobucketAlbumPath.Controls.Add(this.btnPhotobucketAddAlbum);
            this.gbPhotobucketAlbumPath.Controls.Add(this.btnPhotobucketRemoveAlbum);
            this.gbPhotobucketAlbumPath.Controls.Add(this.cboPhotobucketAlbumPaths);
            this.gbPhotobucketAlbumPath.Location = new System.Drawing.Point(16, 208);
            this.gbPhotobucketAlbumPath.Name = "gbPhotobucketAlbumPath";
            this.gbPhotobucketAlbumPath.Size = new System.Drawing.Size(712, 64);
            this.gbPhotobucketAlbumPath.TabIndex = 1;
            this.gbPhotobucketAlbumPath.TabStop = false;
            this.gbPhotobucketAlbumPath.Text = "Upload images to";
            // 
            // btnPhotobucketAddAlbum
            // 
            this.btnPhotobucketAddAlbum.Location = new System.Drawing.Point(488, 24);
            this.btnPhotobucketAddAlbum.Name = "btnPhotobucketAddAlbum";
            this.btnPhotobucketAddAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnPhotobucketAddAlbum.TabIndex = 1;
            this.btnPhotobucketAddAlbum.Text = "Add album";
            this.btnPhotobucketAddAlbum.UseVisualStyleBackColor = true;
            this.btnPhotobucketAddAlbum.Click += new System.EventHandler(this.btnPhotobucketAddAlbum_Click);
            // 
            // btnPhotobucketRemoveAlbum
            // 
            this.btnPhotobucketRemoveAlbum.AutoSize = true;
            this.btnPhotobucketRemoveAlbum.Location = new System.Drawing.Point(568, 24);
            this.btnPhotobucketRemoveAlbum.Name = "btnPhotobucketRemoveAlbum";
            this.btnPhotobucketRemoveAlbum.Size = new System.Drawing.Size(104, 23);
            this.btnPhotobucketRemoveAlbum.TabIndex = 2;
            this.btnPhotobucketRemoveAlbum.Text = "Remove album";
            this.btnPhotobucketRemoveAlbum.UseVisualStyleBackColor = true;
            this.btnPhotobucketRemoveAlbum.Click += new System.EventHandler(this.btnPhotobucketRemoveAlbum_Click);
            // 
            // cboPhotobucketAlbumPaths
            // 
            this.cboPhotobucketAlbumPaths.FormattingEnabled = true;
            this.cboPhotobucketAlbumPaths.Location = new System.Drawing.Point(16, 24);
            this.cboPhotobucketAlbumPaths.Name = "cboPhotobucketAlbumPaths";
            this.cboPhotobucketAlbumPaths.Size = new System.Drawing.Size(456, 21);
            this.cboPhotobucketAlbumPaths.TabIndex = 0;
            this.cboPhotobucketAlbumPaths.SelectedIndexChanged += new System.EventHandler(this.cboPhotobucketAlbumPaths_SelectedIndexChanged);
            // 
            // gbPhotobucketAlbums
            // 
            this.gbPhotobucketAlbums.Controls.Add(this.lblPhotobucketNewAlbumName);
            this.gbPhotobucketAlbums.Controls.Add(this.lblPhotobucketParentAlbumPath);
            this.gbPhotobucketAlbums.Controls.Add(this.txtPhotobucketNewAlbumName);
            this.gbPhotobucketAlbums.Controls.Add(this.txtPhotobucketParentAlbumPath);
            this.gbPhotobucketAlbums.Controls.Add(this.btnPhotobucketCreateAlbum);
            this.gbPhotobucketAlbums.Location = new System.Drawing.Point(16, 280);
            this.gbPhotobucketAlbums.Name = "gbPhotobucketAlbums";
            this.gbPhotobucketAlbums.Size = new System.Drawing.Size(712, 128);
            this.gbPhotobucketAlbums.TabIndex = 2;
            this.gbPhotobucketAlbums.TabStop = false;
            this.gbPhotobucketAlbums.Text = "Create new album";
            // 
            // lblPhotobucketNewAlbumName
            // 
            this.lblPhotobucketNewAlbumName.AutoSize = true;
            this.lblPhotobucketNewAlbumName.Location = new System.Drawing.Point(16, 72);
            this.lblPhotobucketNewAlbumName.Name = "lblPhotobucketNewAlbumName";
            this.lblPhotobucketNewAlbumName.Size = new System.Drawing.Size(649, 13);
            this.lblPhotobucketNewAlbumName.TabIndex = 2;
            this.lblPhotobucketNewAlbumName.Text = "New album name ( must be between 2 and 50 characters. Valid characters are letter" +
    "s, numbers, underscore ( _ ), hyphen (-), and space )";
            // 
            // lblPhotobucketParentAlbumPath
            // 
            this.lblPhotobucketParentAlbumPath.AutoSize = true;
            this.lblPhotobucketParentAlbumPath.Location = new System.Drawing.Point(16, 24);
            this.lblPhotobucketParentAlbumPath.Name = "lblPhotobucketParentAlbumPath";
            this.lblPhotobucketParentAlbumPath.Size = new System.Drawing.Size(93, 13);
            this.lblPhotobucketParentAlbumPath.TabIndex = 0;
            this.lblPhotobucketParentAlbumPath.Text = "Parent album path";
            // 
            // txtPhotobucketNewAlbumName
            // 
            this.txtPhotobucketNewAlbumName.Location = new System.Drawing.Point(16, 88);
            this.txtPhotobucketNewAlbumName.Name = "txtPhotobucketNewAlbumName";
            this.txtPhotobucketNewAlbumName.Size = new System.Drawing.Size(216, 20);
            this.txtPhotobucketNewAlbumName.TabIndex = 3;
            // 
            // txtPhotobucketParentAlbumPath
            // 
            this.txtPhotobucketParentAlbumPath.Location = new System.Drawing.Point(16, 40);
            this.txtPhotobucketParentAlbumPath.Name = "txtPhotobucketParentAlbumPath";
            this.txtPhotobucketParentAlbumPath.Size = new System.Drawing.Size(448, 20);
            this.txtPhotobucketParentAlbumPath.TabIndex = 1;
            // 
            // btnPhotobucketCreateAlbum
            // 
            this.btnPhotobucketCreateAlbum.Location = new System.Drawing.Point(240, 88);
            this.btnPhotobucketCreateAlbum.Name = "btnPhotobucketCreateAlbum";
            this.btnPhotobucketCreateAlbum.Size = new System.Drawing.Size(128, 23);
            this.btnPhotobucketCreateAlbum.TabIndex = 4;
            this.btnPhotobucketCreateAlbum.Text = "Create album";
            this.btnPhotobucketCreateAlbum.UseVisualStyleBackColor = true;
            this.btnPhotobucketCreateAlbum.Click += new System.EventHandler(this.btnPhotobucketCreateAlbum_Click);
            // 
            // gbPhotobucketUserAccount
            // 
            this.gbPhotobucketUserAccount.Controls.Add(this.lblPhotobucketDefaultAlbumName);
            this.gbPhotobucketUserAccount.Controls.Add(this.btnPhotobucketAuthOpen);
            this.gbPhotobucketUserAccount.Controls.Add(this.txtPhotobucketDefaultAlbumName);
            this.gbPhotobucketUserAccount.Controls.Add(this.lblPhotobucketVerificationCode);
            this.gbPhotobucketUserAccount.Controls.Add(this.btnPhotobucketAuthComplete);
            this.gbPhotobucketUserAccount.Controls.Add(this.txtPhotobucketVerificationCode);
            this.gbPhotobucketUserAccount.Controls.Add(this.lblPhotobucketAccountStatus);
            this.gbPhotobucketUserAccount.Location = new System.Drawing.Point(16, 16);
            this.gbPhotobucketUserAccount.Name = "gbPhotobucketUserAccount";
            this.gbPhotobucketUserAccount.Size = new System.Drawing.Size(712, 184);
            this.gbPhotobucketUserAccount.TabIndex = 0;
            this.gbPhotobucketUserAccount.TabStop = false;
            this.gbPhotobucketUserAccount.Text = "User account";
            // 
            // lblPhotobucketDefaultAlbumName
            // 
            this.lblPhotobucketDefaultAlbumName.AutoSize = true;
            this.lblPhotobucketDefaultAlbumName.Location = new System.Drawing.Point(496, 128);
            this.lblPhotobucketDefaultAlbumName.Name = "lblPhotobucketDefaultAlbumName";
            this.lblPhotobucketDefaultAlbumName.Size = new System.Drawing.Size(104, 13);
            this.lblPhotobucketDefaultAlbumName.TabIndex = 4;
            this.lblPhotobucketDefaultAlbumName.Text = "Default Album Name";
            // 
            // btnPhotobucketAuthOpen
            // 
            this.btnPhotobucketAuthOpen.Location = new System.Drawing.Point(16, 24);
            this.btnPhotobucketAuthOpen.Name = "btnPhotobucketAuthOpen";
            this.btnPhotobucketAuthOpen.Size = new System.Drawing.Size(200, 23);
            this.btnPhotobucketAuthOpen.TabIndex = 0;
            this.btnPhotobucketAuthOpen.Text = "Step 1: Open authorize page...";
            this.btnPhotobucketAuthOpen.UseVisualStyleBackColor = true;
            this.btnPhotobucketAuthOpen.Click += new System.EventHandler(this.btnPhotobucketAuthOpen_Click);
            // 
            // txtPhotobucketDefaultAlbumName
            // 
            this.txtPhotobucketDefaultAlbumName.Location = new System.Drawing.Point(496, 144);
            this.txtPhotobucketDefaultAlbumName.Name = "txtPhotobucketDefaultAlbumName";
            this.txtPhotobucketDefaultAlbumName.ReadOnly = true;
            this.txtPhotobucketDefaultAlbumName.Size = new System.Drawing.Size(200, 20);
            this.txtPhotobucketDefaultAlbumName.TabIndex = 5;
            // 
            // lblPhotobucketVerificationCode
            // 
            this.lblPhotobucketVerificationCode.AutoSize = true;
            this.lblPhotobucketVerificationCode.Location = new System.Drawing.Point(16, 62);
            this.lblPhotobucketVerificationCode.Name = "lblPhotobucketVerificationCode";
            this.lblPhotobucketVerificationCode.Size = new System.Drawing.Size(292, 13);
            this.lblPhotobucketVerificationCode.TabIndex = 1;
            this.lblPhotobucketVerificationCode.Text = "Verification code (Get verification code from authorize page):";
            // 
            // btnPhotobucketAuthComplete
            // 
            this.btnPhotobucketAuthComplete.Location = new System.Drawing.Point(16, 112);
            this.btnPhotobucketAuthComplete.Name = "btnPhotobucketAuthComplete";
            this.btnPhotobucketAuthComplete.Size = new System.Drawing.Size(200, 23);
            this.btnPhotobucketAuthComplete.TabIndex = 3;
            this.btnPhotobucketAuthComplete.Text = "Step 2: Complete authorization";
            this.btnPhotobucketAuthComplete.UseVisualStyleBackColor = true;
            this.btnPhotobucketAuthComplete.Click += new System.EventHandler(this.btnPhotobucketAuthComplete_Click);
            // 
            // txtPhotobucketVerificationCode
            // 
            this.txtPhotobucketVerificationCode.Location = new System.Drawing.Point(16, 80);
            this.txtPhotobucketVerificationCode.Name = "txtPhotobucketVerificationCode";
            this.txtPhotobucketVerificationCode.Size = new System.Drawing.Size(360, 20);
            this.txtPhotobucketVerificationCode.TabIndex = 2;
            // 
            // lblPhotobucketAccountStatus
            // 
            this.lblPhotobucketAccountStatus.AutoSize = true;
            this.lblPhotobucketAccountStatus.Location = new System.Drawing.Point(24, 152);
            this.lblPhotobucketAccountStatus.Name = "lblPhotobucketAccountStatus";
            this.lblPhotobucketAccountStatus.Size = new System.Drawing.Size(77, 13);
            this.lblPhotobucketAccountStatus.TabIndex = 6;
            this.lblPhotobucketAccountStatus.Text = "Login required.";
            // 
            // tpTwitPic
            // 
            this.tpTwitPic.Controls.Add(this.lblTwitPicTip);
            this.tpTwitPic.Controls.Add(this.chkTwitPicShowFull);
            this.tpTwitPic.Controls.Add(this.cboTwitPicThumbnailMode);
            this.tpTwitPic.Controls.Add(this.lblTwitPicThumbnailMode);
            this.tpTwitPic.Location = new System.Drawing.Point(4, 22);
            this.tpTwitPic.Name = "tpTwitPic";
            this.tpTwitPic.Padding = new System.Windows.Forms.Padding(3);
            this.tpTwitPic.Size = new System.Drawing.Size(804, 475);
            this.tpTwitPic.TabIndex = 5;
            this.tpTwitPic.Text = "TwitPic";
            this.tpTwitPic.UseVisualStyleBackColor = true;
            // 
            // lblTwitPicTip
            // 
            this.lblTwitPicTip.AutoSize = true;
            this.lblTwitPicTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTwitPicTip.Location = new System.Drawing.Point(16, 16);
            this.lblTwitPicTip.Name = "lblTwitPicTip";
            this.lblTwitPicTip.Size = new System.Drawing.Size(343, 40);
            this.lblTwitPicTip.TabIndex = 0;
            this.lblTwitPicTip.Text = "TwitPic using Twitter settings for authentication.\r\nOther Services -> Twitter";
            // 
            // chkTwitPicShowFull
            // 
            this.chkTwitPicShowFull.AutoSize = true;
            this.chkTwitPicShowFull.Location = new System.Drawing.Point(24, 104);
            this.chkTwitPicShowFull.Name = "chkTwitPicShowFull";
            this.chkTwitPicShowFull.Size = new System.Drawing.Size(94, 17);
            this.chkTwitPicShowFull.TabIndex = 3;
            this.chkTwitPicShowFull.Text = "Show full URL";
            this.chkTwitPicShowFull.UseVisualStyleBackColor = true;
            this.chkTwitPicShowFull.CheckedChanged += new System.EventHandler(this.chkTwitPicShowFull_CheckedChanged);
            // 
            // cboTwitPicThumbnailMode
            // 
            this.cboTwitPicThumbnailMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTwitPicThumbnailMode.FormattingEnabled = true;
            this.cboTwitPicThumbnailMode.Location = new System.Drawing.Point(112, 68);
            this.cboTwitPicThumbnailMode.Name = "cboTwitPicThumbnailMode";
            this.cboTwitPicThumbnailMode.Size = new System.Drawing.Size(144, 21);
            this.cboTwitPicThumbnailMode.TabIndex = 2;
            this.cboTwitPicThumbnailMode.SelectedIndexChanged += new System.EventHandler(this.cboTwitPicThumbnailMode_SelectedIndexChanged);
            // 
            // lblTwitPicThumbnailMode
            // 
            this.lblTwitPicThumbnailMode.AutoSize = true;
            this.lblTwitPicThumbnailMode.Location = new System.Drawing.Point(24, 72);
            this.lblTwitPicThumbnailMode.Name = "lblTwitPicThumbnailMode";
            this.lblTwitPicThumbnailMode.Size = new System.Drawing.Size(82, 13);
            this.lblTwitPicThumbnailMode.TabIndex = 1;
            this.lblTwitPicThumbnailMode.Text = "Thumbnail type:";
            // 
            // tpTwitSnaps
            // 
            this.tpTwitSnaps.Controls.Add(this.lblTwitSnapsTip);
            this.tpTwitSnaps.Location = new System.Drawing.Point(4, 22);
            this.tpTwitSnaps.Name = "tpTwitSnaps";
            this.tpTwitSnaps.Padding = new System.Windows.Forms.Padding(3);
            this.tpTwitSnaps.Size = new System.Drawing.Size(804, 475);
            this.tpTwitSnaps.TabIndex = 6;
            this.tpTwitSnaps.Text = "TwitSnaps";
            this.tpTwitSnaps.UseVisualStyleBackColor = true;
            // 
            // lblTwitSnapsTip
            // 
            this.lblTwitSnapsTip.AutoSize = true;
            this.lblTwitSnapsTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTwitSnapsTip.Location = new System.Drawing.Point(16, 16);
            this.lblTwitSnapsTip.Name = "lblTwitSnapsTip";
            this.lblTwitSnapsTip.Size = new System.Drawing.Size(368, 40);
            this.lblTwitSnapsTip.TabIndex = 0;
            this.lblTwitSnapsTip.Text = "TwitSnaps using Twitter settings for authentication.\r\nOther Services -> Twitter";
            // 
            // tpYFrog
            // 
            this.tpYFrog.Controls.Add(this.lblYFrogPassword);
            this.tpYFrog.Controls.Add(this.lblYFrogUsername);
            this.tpYFrog.Controls.Add(this.txtYFrogPassword);
            this.tpYFrog.Controls.Add(this.txtYFrogUsername);
            this.tpYFrog.Location = new System.Drawing.Point(4, 22);
            this.tpYFrog.Name = "tpYFrog";
            this.tpYFrog.Padding = new System.Windows.Forms.Padding(3);
            this.tpYFrog.Size = new System.Drawing.Size(804, 475);
            this.tpYFrog.TabIndex = 7;
            this.tpYFrog.Text = "YFrog";
            this.tpYFrog.UseVisualStyleBackColor = true;
            // 
            // lblYFrogPassword
            // 
            this.lblYFrogPassword.AutoSize = true;
            this.lblYFrogPassword.Location = new System.Drawing.Point(24, 56);
            this.lblYFrogPassword.Name = "lblYFrogPassword";
            this.lblYFrogPassword.Size = new System.Drawing.Size(56, 13);
            this.lblYFrogPassword.TabIndex = 2;
            this.lblYFrogPassword.Text = "Password:";
            // 
            // lblYFrogUsername
            // 
            this.lblYFrogUsername.AutoSize = true;
            this.lblYFrogUsername.Location = new System.Drawing.Point(24, 24);
            this.lblYFrogUsername.Name = "lblYFrogUsername";
            this.lblYFrogUsername.Size = new System.Drawing.Size(58, 13);
            this.lblYFrogUsername.TabIndex = 0;
            this.lblYFrogUsername.Text = "Username:";
            // 
            // txtYFrogPassword
            // 
            this.txtYFrogPassword.Location = new System.Drawing.Point(88, 52);
            this.txtYFrogPassword.Name = "txtYFrogPassword";
            this.txtYFrogPassword.PasswordChar = '*';
            this.txtYFrogPassword.Size = new System.Drawing.Size(160, 20);
            this.txtYFrogPassword.TabIndex = 3;
            this.txtYFrogPassword.TextChanged += new System.EventHandler(this.txtYFrogPassword_TextChanged);
            // 
            // txtYFrogUsername
            // 
            this.txtYFrogUsername.Location = new System.Drawing.Point(88, 20);
            this.txtYFrogUsername.Name = "txtYFrogUsername";
            this.txtYFrogUsername.Size = new System.Drawing.Size(160, 20);
            this.txtYFrogUsername.TabIndex = 1;
            this.txtYFrogUsername.TextChanged += new System.EventHandler(this.txtYFrogUsername_TextChanged);
            // 
            // tpPicasa
            // 
            this.tpPicasa.Controls.Add(this.txtPicasaAlbumID);
            this.tpPicasa.Controls.Add(this.lblPicasaAlbumID);
            this.tpPicasa.Controls.Add(this.lvPicasaAlbumList);
            this.tpPicasa.Controls.Add(this.btnPicasaRefreshAlbumList);
            this.tpPicasa.Controls.Add(this.oauth2Picasa);
            this.tpPicasa.Location = new System.Drawing.Point(4, 22);
            this.tpPicasa.Name = "tpPicasa";
            this.tpPicasa.Padding = new System.Windows.Forms.Padding(3);
            this.tpPicasa.Size = new System.Drawing.Size(804, 475);
            this.tpPicasa.TabIndex = 8;
            this.tpPicasa.Text = "Picasa";
            this.tpPicasa.UseVisualStyleBackColor = true;
            // 
            // txtPicasaAlbumID
            // 
            this.txtPicasaAlbumID.Location = new System.Drawing.Point(592, 16);
            this.txtPicasaAlbumID.Name = "txtPicasaAlbumID";
            this.txtPicasaAlbumID.Size = new System.Drawing.Size(176, 20);
            this.txtPicasaAlbumID.TabIndex = 2;
            this.txtPicasaAlbumID.TextChanged += new System.EventHandler(this.txtPicasaAlbumID_TextChanged);
            // 
            // lblPicasaAlbumID
            // 
            this.lblPicasaAlbumID.AutoSize = true;
            this.lblPicasaAlbumID.Location = new System.Drawing.Point(352, 20);
            this.lblPicasaAlbumID.Name = "lblPicasaAlbumID";
            this.lblPicasaAlbumID.Size = new System.Drawing.Size(233, 13);
            this.lblPicasaAlbumID.TabIndex = 1;
            this.lblPicasaAlbumID.Text = "Album ID for upload (Empty = No album upload):";
            // 
            // lvPicasaAlbumList
            // 
            this.lvPicasaAlbumList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPicasaAlbumList.FullRowSelect = true;
            this.lvPicasaAlbumList.Location = new System.Drawing.Point(352, 76);
            this.lvPicasaAlbumList.MultiSelect = false;
            this.lvPicasaAlbumList.Name = "lvPicasaAlbumList";
            this.lvPicasaAlbumList.Size = new System.Drawing.Size(432, 312);
            this.lvPicasaAlbumList.TabIndex = 4;
            this.lvPicasaAlbumList.UseCompatibleStateImageBehavior = false;
            this.lvPicasaAlbumList.View = System.Windows.Forms.View.Details;
            this.lvPicasaAlbumList.SelectedIndexChanged += new System.EventHandler(this.lvPicasaAlbumList_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Description";
            this.columnHeader5.Width = 143;
            // 
            // btnPicasaRefreshAlbumList
            // 
            this.btnPicasaRefreshAlbumList.Enabled = false;
            this.btnPicasaRefreshAlbumList.Location = new System.Drawing.Point(352, 44);
            this.btnPicasaRefreshAlbumList.Name = "btnPicasaRefreshAlbumList";
            this.btnPicasaRefreshAlbumList.Size = new System.Drawing.Size(200, 23);
            this.btnPicasaRefreshAlbumList.TabIndex = 3;
            this.btnPicasaRefreshAlbumList.Text = "Refresh album list";
            this.btnPicasaRefreshAlbumList.UseVisualStyleBackColor = true;
            this.btnPicasaRefreshAlbumList.Click += new System.EventHandler(this.btnPicasaRefreshAlbumList_Click);
            // 
            // oauth2Picasa
            // 
            this.oauth2Picasa.Location = new System.Drawing.Point(16, 16);
            this.oauth2Picasa.LoginStatus = false;
            this.oauth2Picasa.Name = "oauth2Picasa";
            this.oauth2Picasa.Size = new System.Drawing.Size(328, 207);
            this.oauth2Picasa.Status = "Login required.";
            this.oauth2Picasa.TabIndex = 0;
            this.oauth2Picasa.OpenButtonClicked += new UploadersLib.GUI.OAuth2Control.OpenButtonClickedEventHandler(this.oauth2Picasa_OpenButtonClicked);
            this.oauth2Picasa.CompleteButtonClicked += new UploadersLib.GUI.OAuth2Control.CompleteButtonClickedEventHandler(this.oauth2Picasa_CompleteButtonClicked);
            this.oauth2Picasa.RefreshButtonClicked += new UploadersLib.GUI.OAuth2Control.RefreshButtonClickedEventHandler(this.oauth2Picasa_RefreshButtonClicked);
            // 
            // tpTextUploaders
            // 
            this.tpTextUploaders.Controls.Add(this.tcTextUploaders);
            this.tpTextUploaders.Location = new System.Drawing.Point(4, 22);
            this.tpTextUploaders.Name = "tpTextUploaders";
            this.tpTextUploaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpTextUploaders.Size = new System.Drawing.Size(818, 507);
            this.tpTextUploaders.TabIndex = 1;
            this.tpTextUploaders.Text = "Text uploaders";
            this.tpTextUploaders.UseVisualStyleBackColor = true;
            // 
            // tcTextUploaders
            // 
            this.tcTextUploaders.Controls.Add(this.tpPastebin);
            this.tcTextUploaders.Controls.Add(this.tpPaste_ee);
            this.tcTextUploaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTextUploaders.Location = new System.Drawing.Point(3, 3);
            this.tcTextUploaders.Name = "tcTextUploaders";
            this.tcTextUploaders.SelectedIndex = 0;
            this.tcTextUploaders.Size = new System.Drawing.Size(812, 501);
            this.tcTextUploaders.TabIndex = 0;
            // 
            // tpPastebin
            // 
            this.tpPastebin.Controls.Add(this.btnPastebinLogin);
            this.tpPastebin.Controls.Add(this.pgPastebinSettings);
            this.tpPastebin.Location = new System.Drawing.Point(4, 22);
            this.tpPastebin.Name = "tpPastebin";
            this.tpPastebin.Padding = new System.Windows.Forms.Padding(3);
            this.tpPastebin.Size = new System.Drawing.Size(804, 475);
            this.tpPastebin.TabIndex = 0;
            this.tpPastebin.Text = "Pastebin";
            this.tpPastebin.UseVisualStyleBackColor = true;
            // 
            // btnPastebinLogin
            // 
            this.btnPastebinLogin.Location = new System.Drawing.Point(520, 8);
            this.btnPastebinLogin.Name = "btnPastebinLogin";
            this.btnPastebinLogin.Size = new System.Drawing.Size(88, 23);
            this.btnPastebinLogin.TabIndex = 1;
            this.btnPastebinLogin.Text = "Login";
            this.btnPastebinLogin.UseVisualStyleBackColor = true;
            this.btnPastebinLogin.Click += new System.EventHandler(this.btnPastebinLogin_Click);
            // 
            // pgPastebinSettings
            // 
            this.pgPastebinSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pgPastebinSettings.Location = new System.Drawing.Point(3, 3);
            this.pgPastebinSettings.Name = "pgPastebinSettings";
            this.pgPastebinSettings.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.pgPastebinSettings.Size = new System.Drawing.Size(504, 469);
            this.pgPastebinSettings.TabIndex = 0;
            // 
            // tpPaste_ee
            // 
            this.tpPaste_ee.Controls.Add(this.lblPaste_eeUserAPIKey);
            this.tpPaste_ee.Controls.Add(this.txtPaste_eeUserAPIKey);
            this.tpPaste_ee.Location = new System.Drawing.Point(4, 22);
            this.tpPaste_ee.Name = "tpPaste_ee";
            this.tpPaste_ee.Padding = new System.Windows.Forms.Padding(3);
            this.tpPaste_ee.Size = new System.Drawing.Size(804, 475);
            this.tpPaste_ee.TabIndex = 1;
            this.tpPaste_ee.Text = "Paste.ee";
            this.tpPaste_ee.UseVisualStyleBackColor = true;
            // 
            // lblPaste_eeUserAPIKey
            // 
            this.lblPaste_eeUserAPIKey.AutoSize = true;
            this.lblPaste_eeUserAPIKey.Location = new System.Drawing.Point(16, 24);
            this.lblPaste_eeUserAPIKey.Name = "lblPaste_eeUserAPIKey";
            this.lblPaste_eeUserAPIKey.Size = new System.Drawing.Size(72, 13);
            this.lblPaste_eeUserAPIKey.TabIndex = 0;
            this.lblPaste_eeUserAPIKey.Text = "User API key:";
            // 
            // txtPaste_eeUserAPIKey
            // 
            this.txtPaste_eeUserAPIKey.Location = new System.Drawing.Point(96, 20);
            this.txtPaste_eeUserAPIKey.Name = "txtPaste_eeUserAPIKey";
            this.txtPaste_eeUserAPIKey.Size = new System.Drawing.Size(296, 20);
            this.txtPaste_eeUserAPIKey.TabIndex = 1;
            this.txtPaste_eeUserAPIKey.TextChanged += new System.EventHandler(this.txtPaste_eeUserAPIKey_TextChanged);
            // 
            // tpFileUploaders
            // 
            this.tpFileUploaders.Controls.Add(this.tcFileUploaders);
            this.tpFileUploaders.Location = new System.Drawing.Point(4, 22);
            this.tpFileUploaders.Name = "tpFileUploaders";
            this.tpFileUploaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpFileUploaders.Size = new System.Drawing.Size(818, 507);
            this.tpFileUploaders.TabIndex = 2;
            this.tpFileUploaders.Text = "File uploaders";
            this.tpFileUploaders.UseVisualStyleBackColor = true;
            // 
            // tcFileUploaders
            // 
            this.tcFileUploaders.Controls.Add(this.tpDropbox);
            this.tcFileUploaders.Controls.Add(this.tpMega);
            this.tcFileUploaders.Controls.Add(this.tpFTP);
            this.tcFileUploaders.Controls.Add(this.tpBox);
            this.tcFileUploaders.Controls.Add(this.tpRapidShare);
            this.tcFileUploaders.Controls.Add(this.tpSendSpace);
            this.tcFileUploaders.Controls.Add(this.tpGe_tt);
            this.tcFileUploaders.Controls.Add(this.tpHostr);
            this.tcFileUploaders.Controls.Add(this.tpJira);
            this.tcFileUploaders.Controls.Add(this.tpGoogleDrive);
            this.tcFileUploaders.Controls.Add(this.tpMinus);
            this.tcFileUploaders.Controls.Add(this.tpEmail);
            this.tcFileUploaders.Controls.Add(this.tpSharedFolder);
            this.tcFileUploaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFileUploaders.Location = new System.Drawing.Point(3, 3);
            this.tcFileUploaders.Name = "tcFileUploaders";
            this.tcFileUploaders.SelectedIndex = 0;
            this.tcFileUploaders.Size = new System.Drawing.Size(812, 501);
            this.tcFileUploaders.TabIndex = 0;
            // 
            // tpDropbox
            // 
            this.tpDropbox.Controls.Add(this.cbDropboxShortURL);
            this.tpDropbox.Controls.Add(this.cbDropboxAutoCreateShareableLink);
            this.tpDropbox.Controls.Add(this.btnDropboxShowFiles);
            this.tpDropbox.Controls.Add(this.btnDropboxCompleteAuth);
            this.tpDropbox.Controls.Add(this.pbDropboxLogo);
            this.tpDropbox.Controls.Add(this.btnDropboxRegister);
            this.tpDropbox.Controls.Add(this.lblDropboxStatus);
            this.tpDropbox.Controls.Add(this.lblDropboxPathTip);
            this.tpDropbox.Controls.Add(this.lblDropboxPath);
            this.tpDropbox.Controls.Add(this.btnDropboxOpenAuthorize);
            this.tpDropbox.Controls.Add(this.txtDropboxPath);
            this.tpDropbox.Location = new System.Drawing.Point(4, 22);
            this.tpDropbox.Name = "tpDropbox";
            this.tpDropbox.Padding = new System.Windows.Forms.Padding(3);
            this.tpDropbox.Size = new System.Drawing.Size(804, 475);
            this.tpDropbox.TabIndex = 0;
            this.tpDropbox.Text = "Dropbox";
            this.tpDropbox.UseVisualStyleBackColor = true;
            // 
            // cbDropboxShortURL
            // 
            this.cbDropboxShortURL.AutoSize = true;
            this.cbDropboxShortURL.Location = new System.Drawing.Point(160, 152);
            this.cbDropboxShortURL.Name = "cbDropboxShortURL";
            this.cbDropboxShortURL.Size = new System.Drawing.Size(137, 17);
            this.cbDropboxShortURL.TabIndex = 8;
            this.cbDropboxShortURL.Text = "Shorten shareable URL";
            this.cbDropboxShortURL.UseVisualStyleBackColor = true;
            this.cbDropboxShortURL.CheckedChanged += new System.EventHandler(this.cbDropboxShortURL_CheckedChanged);
            // 
            // cbDropboxAutoCreateShareableLink
            // 
            this.cbDropboxAutoCreateShareableLink.AutoSize = true;
            this.cbDropboxAutoCreateShareableLink.Location = new System.Drawing.Point(18, 152);
            this.cbDropboxAutoCreateShareableLink.Name = "cbDropboxAutoCreateShareableLink";
            this.cbDropboxAutoCreateShareableLink.Size = new System.Drawing.Size(131, 17);
            this.cbDropboxAutoCreateShareableLink.TabIndex = 7;
            this.cbDropboxAutoCreateShareableLink.Text = "Create shareable URL";
            this.cbDropboxAutoCreateShareableLink.UseVisualStyleBackColor = true;
            this.cbDropboxAutoCreateShareableLink.CheckedChanged += new System.EventHandler(this.cbDropboxAutoCreateShareableLink_CheckedChanged);
            // 
            // btnDropboxShowFiles
            // 
            this.btnDropboxShowFiles.Enabled = false;
            this.btnDropboxShowFiles.Location = new System.Drawing.Point(344, 120);
            this.btnDropboxShowFiles.Name = "btnDropboxShowFiles";
            this.btnDropboxShowFiles.Size = new System.Drawing.Size(64, 24);
            this.btnDropboxShowFiles.TabIndex = 5;
            this.btnDropboxShowFiles.Text = "Select...";
            this.btnDropboxShowFiles.UseVisualStyleBackColor = true;
            this.btnDropboxShowFiles.Click += new System.EventHandler(this.btnDropboxShowFiles_Click);
            // 
            // btnDropboxCompleteAuth
            // 
            this.btnDropboxCompleteAuth.Enabled = false;
            this.btnDropboxCompleteAuth.Location = new System.Drawing.Point(176, 88);
            this.btnDropboxCompleteAuth.Name = "btnDropboxCompleteAuth";
            this.btnDropboxCompleteAuth.Size = new System.Drawing.Size(152, 24);
            this.btnDropboxCompleteAuth.TabIndex = 2;
            this.btnDropboxCompleteAuth.Text = "2. Complete authorization";
            this.btnDropboxCompleteAuth.UseVisualStyleBackColor = true;
            this.btnDropboxCompleteAuth.Click += new System.EventHandler(this.btnDropboxAuthComplete_Click);
            // 
            // pbDropboxLogo
            // 
            this.pbDropboxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDropboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbDropboxLogo.Image")));
            this.pbDropboxLogo.Location = new System.Drawing.Point(16, 16);
            this.pbDropboxLogo.Name = "pbDropboxLogo";
            this.pbDropboxLogo.Size = new System.Drawing.Size(248, 64);
            this.pbDropboxLogo.TabIndex = 19;
            this.pbDropboxLogo.TabStop = false;
            this.pbDropboxLogo.Click += new System.EventHandler(this.pbDropboxLogo_Click);
            // 
            // btnDropboxRegister
            // 
            this.btnDropboxRegister.Location = new System.Drawing.Point(272, 16);
            this.btnDropboxRegister.Name = "btnDropboxRegister";
            this.btnDropboxRegister.Size = new System.Drawing.Size(96, 24);
            this.btnDropboxRegister.TabIndex = 0;
            this.btnDropboxRegister.Text = "Register...";
            this.btnDropboxRegister.UseVisualStyleBackColor = true;
            this.btnDropboxRegister.Click += new System.EventHandler(this.btnDropboxRegister_Click);
            // 
            // lblDropboxStatus
            // 
            this.lblDropboxStatus.AutoSize = true;
            this.lblDropboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDropboxStatus.Location = new System.Drawing.Point(16, 176);
            this.lblDropboxStatus.Name = "lblDropboxStatus";
            this.lblDropboxStatus.Size = new System.Drawing.Size(82, 16);
            this.lblDropboxStatus.TabIndex = 9;
            this.lblDropboxStatus.Text = "Login status:";
            // 
            // lblDropboxPathTip
            // 
            this.lblDropboxPathTip.AutoSize = true;
            this.lblDropboxPathTip.Location = new System.Drawing.Point(416, 126);
            this.lblDropboxPathTip.Name = "lblDropboxPathTip";
            this.lblDropboxPathTip.Size = new System.Drawing.Size(208, 13);
            this.lblDropboxPathTip.TabIndex = 6;
            this.lblDropboxPathTip.Text = "Use \"Public\" folder for be able to get URL.";
            // 
            // lblDropboxPath
            // 
            this.lblDropboxPath.AutoSize = true;
            this.lblDropboxPath.Location = new System.Drawing.Point(16, 126);
            this.lblDropboxPath.Name = "lblDropboxPath";
            this.lblDropboxPath.Size = new System.Drawing.Size(68, 13);
            this.lblDropboxPath.TabIndex = 3;
            this.lblDropboxPath.Text = "Upload path:";
            // 
            // btnDropboxOpenAuthorize
            // 
            this.btnDropboxOpenAuthorize.Location = new System.Drawing.Point(16, 88);
            this.btnDropboxOpenAuthorize.Name = "btnDropboxOpenAuthorize";
            this.btnDropboxOpenAuthorize.Size = new System.Drawing.Size(152, 24);
            this.btnDropboxOpenAuthorize.TabIndex = 1;
            this.btnDropboxOpenAuthorize.Text = "1. Open authorize page...";
            this.btnDropboxOpenAuthorize.UseVisualStyleBackColor = true;
            this.btnDropboxOpenAuthorize.Click += new System.EventHandler(this.btnDropboxAuthOpen_Click);
            // 
            // txtDropboxPath
            // 
            this.txtDropboxPath.Location = new System.Drawing.Point(88, 122);
            this.txtDropboxPath.Name = "txtDropboxPath";
            this.txtDropboxPath.Size = new System.Drawing.Size(248, 20);
            this.txtDropboxPath.TabIndex = 4;
            this.txtDropboxPath.TextChanged += new System.EventHandler(this.txtDropboxPath_TextChanged);
            // 
            // tpMega
            // 
            this.tpMega.Controls.Add(this.atcMegaAccountType);
            this.tpMega.Controls.Add(this.lblMegaStatus);
            this.tpMega.Controls.Add(this.pnlMegaLogin);
            this.tpMega.Controls.Add(this.lblMegaStatusTitle);
            this.tpMega.Location = new System.Drawing.Point(4, 22);
            this.tpMega.Name = "tpMega";
            this.tpMega.Size = new System.Drawing.Size(804, 475);
            this.tpMega.TabIndex = 12;
            this.tpMega.Text = "Mega";
            this.tpMega.UseVisualStyleBackColor = true;
            // 
            // atcMegaAccountType
            // 
            this.atcMegaAccountType.Location = new System.Drawing.Point(16, 34);
            this.atcMegaAccountType.Name = "atcMegaAccountType";
            this.atcMegaAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.atcMegaAccountType.Size = new System.Drawing.Size(214, 29);
            this.atcMegaAccountType.TabIndex = 14;
            // 
            // lblMegaStatus
            // 
            this.lblMegaStatus.AutoSize = true;
            this.lblMegaStatus.Location = new System.Drawing.Point(70, 17);
            this.lblMegaStatus.Name = "lblMegaStatus";
            this.lblMegaStatus.Size = new System.Drawing.Size(186, 13);
            this.lblMegaStatus.TabIndex = 13;
            this.lblMegaStatus.Text = "CONFIGURED / NOT CONFIGURED";
            // 
            // pnlMegaLogin
            // 
            this.pnlMegaLogin.Controls.Add(this.btnMegaRefreshFolders);
            this.pnlMegaLogin.Controls.Add(this.btnMegaRegister);
            this.pnlMegaLogin.Controls.Add(this.lblMegaFolder);
            this.pnlMegaLogin.Controls.Add(this.cbMegaFolder);
            this.pnlMegaLogin.Controls.Add(this.lblMegaEmail);
            this.pnlMegaLogin.Controls.Add(this.txtMegaEmail);
            this.pnlMegaLogin.Controls.Add(this.lblMegaPassword);
            this.pnlMegaLogin.Controls.Add(this.txtMegaPassword);
            this.pnlMegaLogin.Controls.Add(this.btnMegaLogin);
            this.pnlMegaLogin.Location = new System.Drawing.Point(12, 67);
            this.pnlMegaLogin.Name = "pnlMegaLogin";
            this.pnlMegaLogin.Size = new System.Drawing.Size(378, 226);
            this.pnlMegaLogin.TabIndex = 11;
            // 
            // btnMegaRefreshFolders
            // 
            this.btnMegaRefreshFolders.Location = new System.Drawing.Point(152, 132);
            this.btnMegaRefreshFolders.Name = "btnMegaRefreshFolders";
            this.btnMegaRefreshFolders.Size = new System.Drawing.Size(96, 24);
            this.btnMegaRefreshFolders.TabIndex = 16;
            this.btnMegaRefreshFolders.Text = "Refresh folders";
            this.btnMegaRefreshFolders.UseVisualStyleBackColor = true;
            this.btnMegaRefreshFolders.Click += new System.EventHandler(this.btnMegaRefreshFolders_Click);
            // 
            // btnMegaRegister
            // 
            this.btnMegaRegister.Location = new System.Drawing.Point(264, 8);
            this.btnMegaRegister.Name = "btnMegaRegister";
            this.btnMegaRegister.Size = new System.Drawing.Size(96, 24);
            this.btnMegaRegister.TabIndex = 15;
            this.btnMegaRegister.Text = "Register...";
            this.btnMegaRegister.UseVisualStyleBackColor = true;
            this.btnMegaRegister.Click += new System.EventHandler(this.btnMegaRegister_Click);
            // 
            // lblMegaFolder
            // 
            this.lblMegaFolder.AutoSize = true;
            this.lblMegaFolder.Location = new System.Drawing.Point(12, 109);
            this.lblMegaFolder.Name = "lblMegaFolder";
            this.lblMegaFolder.Size = new System.Drawing.Size(39, 13);
            this.lblMegaFolder.TabIndex = 11;
            this.lblMegaFolder.Text = "Folder:";
            // 
            // cbMegaFolder
            // 
            this.cbMegaFolder.DisplayMember = "DisplayName";
            this.cbMegaFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMegaFolder.FormattingEnabled = true;
            this.cbMegaFolder.Location = new System.Drawing.Point(72, 105);
            this.cbMegaFolder.Name = "cbMegaFolder";
            this.cbMegaFolder.Size = new System.Drawing.Size(176, 21);
            this.cbMegaFolder.TabIndex = 10;
            this.cbMegaFolder.ValueMember = "Node";
            this.cbMegaFolder.SelectedIndexChanged += new System.EventHandler(this.cbMegaFolder_SelectedIndexChanged);
            // 
            // lblMegaEmail
            // 
            this.lblMegaEmail.AutoSize = true;
            this.lblMegaEmail.Location = new System.Drawing.Point(12, 14);
            this.lblMegaEmail.Name = "lblMegaEmail";
            this.lblMegaEmail.Size = new System.Drawing.Size(35, 13);
            this.lblMegaEmail.TabIndex = 5;
            this.lblMegaEmail.Text = "Email:";
            // 
            // txtMegaEmail
            // 
            this.txtMegaEmail.Location = new System.Drawing.Point(72, 10);
            this.txtMegaEmail.Name = "txtMegaEmail";
            this.txtMegaEmail.Size = new System.Drawing.Size(176, 20);
            this.txtMegaEmail.TabIndex = 6;
            // 
            // lblMegaPassword
            // 
            this.lblMegaPassword.AutoSize = true;
            this.lblMegaPassword.Location = new System.Drawing.Point(12, 38);
            this.lblMegaPassword.Name = "lblMegaPassword";
            this.lblMegaPassword.Size = new System.Drawing.Size(56, 13);
            this.lblMegaPassword.TabIndex = 7;
            this.lblMegaPassword.Text = "Password:";
            // 
            // txtMegaPassword
            // 
            this.txtMegaPassword.Location = new System.Drawing.Point(72, 34);
            this.txtMegaPassword.Name = "txtMegaPassword";
            this.txtMegaPassword.PasswordChar = '*';
            this.txtMegaPassword.Size = new System.Drawing.Size(176, 20);
            this.txtMegaPassword.TabIndex = 8;
            // 
            // btnMegaLogin
            // 
            this.btnMegaLogin.Location = new System.Drawing.Point(168, 64);
            this.btnMegaLogin.Name = "btnMegaLogin";
            this.btnMegaLogin.Size = new System.Drawing.Size(80, 24);
            this.btnMegaLogin.TabIndex = 9;
            this.btnMegaLogin.Text = "Login";
            this.btnMegaLogin.UseVisualStyleBackColor = true;
            this.btnMegaLogin.Click += new System.EventHandler(this.btnMegaLogin_Click);
            // 
            // lblMegaStatusTitle
            // 
            this.lblMegaStatusTitle.AutoSize = true;
            this.lblMegaStatusTitle.Location = new System.Drawing.Point(24, 17);
            this.lblMegaStatusTitle.Name = "lblMegaStatusTitle";
            this.lblMegaStatusTitle.Size = new System.Drawing.Size(43, 13);
            this.lblMegaStatusTitle.TabIndex = 12;
            this.lblMegaStatusTitle.Text = "Status: ";
            // 
            // tpFTP
            // 
            this.tpFTP.Controls.Add(this.tlpFtp);
            this.tpFTP.Location = new System.Drawing.Point(4, 22);
            this.tpFTP.Name = "tpFTP";
            this.tpFTP.Padding = new System.Windows.Forms.Padding(3);
            this.tpFTP.Size = new System.Drawing.Size(804, 475);
            this.tpFTP.TabIndex = 4;
            this.tpFTP.Text = "FTP";
            this.tpFTP.UseVisualStyleBackColor = true;
            // 
            // tlpFtp
            // 
            this.tlpFtp.ColumnCount = 1;
            this.tlpFtp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFtp.Controls.Add(this.panelFtp, 0, 0);
            this.tlpFtp.Controls.Add(this.gbFtpSettings, 0, 1);
            this.tlpFtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFtp.Location = new System.Drawing.Point(3, 3);
            this.tlpFtp.Name = "tlpFtp";
            this.tlpFtp.RowCount = 2;
            this.tlpFtp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpFtp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFtp.Size = new System.Drawing.Size(798, 469);
            this.tlpFtp.TabIndex = 0;
            // 
            // panelFtp
            // 
            this.panelFtp.Controls.Add(this.btnFtpClient);
            this.panelFtp.Controls.Add(this.btnFTPExport);
            this.panelFtp.Controls.Add(this.btnFTPImport);
            this.panelFtp.Controls.Add(this.btnFtpHelp);
            this.panelFtp.Controls.Add(this.ucFTPAccounts);
            this.panelFtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFtp.Location = new System.Drawing.Point(3, 3);
            this.panelFtp.Name = "panelFtp";
            this.panelFtp.Size = new System.Drawing.Size(792, 345);
            this.panelFtp.TabIndex = 0;
            // 
            // btnFtpClient
            // 
            this.btnFtpClient.Location = new System.Drawing.Point(448, 7);
            this.btnFtpClient.Name = "btnFtpClient";
            this.btnFtpClient.Size = new System.Drawing.Size(64, 24);
            this.btnFtpClient.TabIndex = 2;
            this.btnFtpClient.Text = "Client...";
            this.btnFtpClient.UseVisualStyleBackColor = true;
            this.btnFtpClient.Click += new System.EventHandler(this.btnFtpClient_Click);
            // 
            // btnFTPExport
            // 
            this.btnFTPExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTPExport.AutoSize = true;
            this.btnFTPExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFTPExport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFTPExport.Location = new System.Drawing.Point(650, 8);
            this.btnFTPExport.Name = "btnFTPExport";
            this.btnFTPExport.Size = new System.Drawing.Size(127, 23);
            this.btnFTPExport.TabIndex = 4;
            this.btnFTPExport.Text = "Export FTP Accounts...";
            this.btnFTPExport.UseVisualStyleBackColor = true;
            this.btnFTPExport.Click += new System.EventHandler(this.btnFTPExport_Click);
            // 
            // btnFTPImport
            // 
            this.btnFTPImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFTPImport.AutoSize = true;
            this.btnFTPImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFTPImport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFTPImport.Location = new System.Drawing.Point(518, 8);
            this.btnFTPImport.Name = "btnFTPImport";
            this.btnFTPImport.Size = new System.Drawing.Size(126, 23);
            this.btnFTPImport.TabIndex = 3;
            this.btnFTPImport.Text = "Import FTP Accounts...";
            this.btnFTPImport.UseVisualStyleBackColor = true;
            this.btnFTPImport.Click += new System.EventHandler(this.btnFTPImport_Click);
            // 
            // btnFtpHelp
            // 
            this.btnFtpHelp.Location = new System.Drawing.Point(378, 7);
            this.btnFtpHelp.Name = "btnFtpHelp";
            this.btnFtpHelp.Size = new System.Drawing.Size(64, 24);
            this.btnFtpHelp.TabIndex = 1;
            this.btnFtpHelp.Text = "Help...";
            this.btnFtpHelp.UseVisualStyleBackColor = true;
            this.btnFtpHelp.Visible = false;
            this.btnFtpHelp.Click += new System.EventHandler(this.btnFtpHelp_Click);
            // 
            // ucFTPAccounts
            // 
            this.ucFTPAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucFTPAccounts.Location = new System.Drawing.Point(0, 0);
            this.ucFTPAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.ucFTPAccounts.Name = "ucFTPAccounts";
            this.ucFTPAccounts.Size = new System.Drawing.Size(792, 345);
            this.ucFTPAccounts.TabIndex = 0;
            // 
            // gbFtpSettings
            // 
            this.gbFtpSettings.Controls.Add(this.lblFtpFiles);
            this.gbFtpSettings.Controls.Add(this.lblFtpText);
            this.gbFtpSettings.Controls.Add(this.lblFtpImages);
            this.gbFtpSettings.Controls.Add(this.cboFtpFiles);
            this.gbFtpSettings.Controls.Add(this.cboFtpText);
            this.gbFtpSettings.Controls.Add(this.cboFtpImages);
            this.gbFtpSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFtpSettings.Location = new System.Drawing.Point(3, 354);
            this.gbFtpSettings.Name = "gbFtpSettings";
            this.gbFtpSettings.Size = new System.Drawing.Size(792, 112);
            this.gbFtpSettings.TabIndex = 1;
            this.gbFtpSettings.TabStop = false;
            this.gbFtpSettings.Text = "FTP Settings";
            // 
            // lblFtpFiles
            // 
            this.lblFtpFiles.AutoSize = true;
            this.lblFtpFiles.Location = new System.Drawing.Point(29, 75);
            this.lblFtpFiles.Name = "lblFtpFiles";
            this.lblFtpFiles.Size = new System.Drawing.Size(28, 13);
            this.lblFtpFiles.TabIndex = 4;
            this.lblFtpFiles.Text = "Files";
            // 
            // lblFtpText
            // 
            this.lblFtpText.AutoSize = true;
            this.lblFtpText.Location = new System.Drawing.Point(29, 49);
            this.lblFtpText.Name = "lblFtpText";
            this.lblFtpText.Size = new System.Drawing.Size(28, 13);
            this.lblFtpText.TabIndex = 2;
            this.lblFtpText.Text = "Text";
            // 
            // lblFtpImages
            // 
            this.lblFtpImages.AutoSize = true;
            this.lblFtpImages.Location = new System.Drawing.Point(16, 24);
            this.lblFtpImages.Name = "lblFtpImages";
            this.lblFtpImages.Size = new System.Drawing.Size(41, 13);
            this.lblFtpImages.TabIndex = 0;
            this.lblFtpImages.Text = "Images";
            // 
            // cboFtpFiles
            // 
            this.cboFtpFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFtpFiles.FormattingEnabled = true;
            this.cboFtpFiles.Location = new System.Drawing.Point(69, 69);
            this.cboFtpFiles.Name = "cboFtpFiles";
            this.cboFtpFiles.Size = new System.Drawing.Size(272, 21);
            this.cboFtpFiles.TabIndex = 5;
            this.cboFtpFiles.SelectedIndexChanged += new System.EventHandler(this.cboFtpFiles_SelectedIndexChanged);
            // 
            // cboFtpText
            // 
            this.cboFtpText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFtpText.FormattingEnabled = true;
            this.cboFtpText.Location = new System.Drawing.Point(69, 45);
            this.cboFtpText.Name = "cboFtpText";
            this.cboFtpText.Size = new System.Drawing.Size(272, 21);
            this.cboFtpText.TabIndex = 3;
            this.cboFtpText.SelectedIndexChanged += new System.EventHandler(this.cboFtpText_SelectedIndexChanged);
            // 
            // cboFtpImages
            // 
            this.cboFtpImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFtpImages.FormattingEnabled = true;
            this.cboFtpImages.Location = new System.Drawing.Point(69, 21);
            this.cboFtpImages.Name = "cboFtpImages";
            this.cboFtpImages.Size = new System.Drawing.Size(272, 21);
            this.cboFtpImages.TabIndex = 1;
            this.cboFtpImages.SelectedIndexChanged += new System.EventHandler(this.cboFtpImages_SelectedIndexChanged);
            // 
            // tpBox
            // 
            this.tpBox.Controls.Add(this.txtBoxFolderID);
            this.tpBox.Controls.Add(this.lblBoxFolderID);
            this.tpBox.Controls.Add(this.btnBoxRefreshFolders);
            this.tpBox.Controls.Add(this.tvBoxFolders);
            this.tpBox.Controls.Add(this.btnBoxCompleteAuth);
            this.tpBox.Controls.Add(this.btnBoxOpenAuthorize);
            this.tpBox.Location = new System.Drawing.Point(4, 22);
            this.tpBox.Name = "tpBox";
            this.tpBox.Padding = new System.Windows.Forms.Padding(3);
            this.tpBox.Size = new System.Drawing.Size(804, 475);
            this.tpBox.TabIndex = 2;
            this.tpBox.Text = "Box";
            this.tpBox.UseVisualStyleBackColor = true;
            // 
            // txtBoxFolderID
            // 
            this.txtBoxFolderID.Location = new System.Drawing.Point(128, 52);
            this.txtBoxFolderID.Name = "txtBoxFolderID";
            this.txtBoxFolderID.Size = new System.Drawing.Size(88, 20);
            this.txtBoxFolderID.TabIndex = 3;
            this.txtBoxFolderID.TextChanged += new System.EventHandler(this.txtBoxFolderID_TextChanged);
            // 
            // lblBoxFolderID
            // 
            this.lblBoxFolderID.AutoSize = true;
            this.lblBoxFolderID.Location = new System.Drawing.Point(16, 56);
            this.lblBoxFolderID.Name = "lblBoxFolderID";
            this.lblBoxFolderID.Size = new System.Drawing.Size(103, 13);
            this.lblBoxFolderID.TabIndex = 2;
            this.lblBoxFolderID.Text = "Folder ID for upload:";
            // 
            // btnBoxRefreshFolders
            // 
            this.btnBoxRefreshFolders.Location = new System.Drawing.Point(16, 80);
            this.btnBoxRefreshFolders.Name = "btnBoxRefreshFolders";
            this.btnBoxRefreshFolders.Size = new System.Drawing.Size(128, 23);
            this.btnBoxRefreshFolders.TabIndex = 4;
            this.btnBoxRefreshFolders.Text = "Refresh folders list";
            this.btnBoxRefreshFolders.UseVisualStyleBackColor = true;
            this.btnBoxRefreshFolders.Click += new System.EventHandler(this.btnBoxRefreshFolders_Click);
            // 
            // tvBoxFolders
            // 
            this.tvBoxFolders.Location = new System.Drawing.Point(16, 112);
            this.tvBoxFolders.Name = "tvBoxFolders";
            this.tvBoxFolders.Size = new System.Drawing.Size(440, 312);
            this.tvBoxFolders.TabIndex = 5;
            this.tvBoxFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBoxFolders_AfterSelect);
            // 
            // btnBoxCompleteAuth
            // 
            this.btnBoxCompleteAuth.Enabled = false;
            this.btnBoxCompleteAuth.Location = new System.Drawing.Point(192, 16);
            this.btnBoxCompleteAuth.Name = "btnBoxCompleteAuth";
            this.btnBoxCompleteAuth.Size = new System.Drawing.Size(168, 23);
            this.btnBoxCompleteAuth.TabIndex = 1;
            this.btnBoxCompleteAuth.Text = "2. Complete authorization";
            this.btnBoxCompleteAuth.UseVisualStyleBackColor = true;
            this.btnBoxCompleteAuth.Click += new System.EventHandler(this.btnBoxCompleteAuth_Click);
            // 
            // btnBoxOpenAuthorize
            // 
            this.btnBoxOpenAuthorize.Location = new System.Drawing.Point(16, 16);
            this.btnBoxOpenAuthorize.Name = "btnBoxOpenAuthorize";
            this.btnBoxOpenAuthorize.Size = new System.Drawing.Size(168, 23);
            this.btnBoxOpenAuthorize.TabIndex = 0;
            this.btnBoxOpenAuthorize.Text = "1. Open authorize page...";
            this.btnBoxOpenAuthorize.UseVisualStyleBackColor = true;
            this.btnBoxOpenAuthorize.Click += new System.EventHandler(this.btnBoxOpenAuthorize_Click);
            // 
            // tpRapidShare
            // 
            this.tpRapidShare.Controls.Add(this.txtRapidShareFolderID);
            this.tpRapidShare.Controls.Add(this.lblRapidShareFolderID);
            this.tpRapidShare.Controls.Add(this.btnRapidShareRefreshFolders);
            this.tpRapidShare.Controls.Add(this.tvRapidShareFolders);
            this.tpRapidShare.Controls.Add(this.lblRapidSharePassword);
            this.tpRapidShare.Controls.Add(this.lblRapidSharePremiumUsername);
            this.tpRapidShare.Controls.Add(this.txtRapidSharePassword);
            this.tpRapidShare.Controls.Add(this.txtRapidShareUsername);
            this.tpRapidShare.Location = new System.Drawing.Point(4, 22);
            this.tpRapidShare.Name = "tpRapidShare";
            this.tpRapidShare.Padding = new System.Windows.Forms.Padding(3);
            this.tpRapidShare.Size = new System.Drawing.Size(804, 475);
            this.tpRapidShare.TabIndex = 5;
            this.tpRapidShare.Text = "RapidShare";
            this.tpRapidShare.UseVisualStyleBackColor = true;
            // 
            // txtRapidShareFolderID
            // 
            this.txtRapidShareFolderID.Location = new System.Drawing.Point(128, 84);
            this.txtRapidShareFolderID.Name = "txtRapidShareFolderID";
            this.txtRapidShareFolderID.Size = new System.Drawing.Size(88, 20);
            this.txtRapidShareFolderID.TabIndex = 5;
            this.txtRapidShareFolderID.TextChanged += new System.EventHandler(this.txtRapidShareFolderID_TextChanged);
            // 
            // lblRapidShareFolderID
            // 
            this.lblRapidShareFolderID.AutoSize = true;
            this.lblRapidShareFolderID.Location = new System.Drawing.Point(16, 88);
            this.lblRapidShareFolderID.Name = "lblRapidShareFolderID";
            this.lblRapidShareFolderID.Size = new System.Drawing.Size(103, 13);
            this.lblRapidShareFolderID.TabIndex = 4;
            this.lblRapidShareFolderID.Text = "Folder ID for upload:";
            // 
            // btnRapidShareRefreshFolders
            // 
            this.btnRapidShareRefreshFolders.Location = new System.Drawing.Point(16, 112);
            this.btnRapidShareRefreshFolders.Name = "btnRapidShareRefreshFolders";
            this.btnRapidShareRefreshFolders.Size = new System.Drawing.Size(128, 23);
            this.btnRapidShareRefreshFolders.TabIndex = 6;
            this.btnRapidShareRefreshFolders.Text = "Refresh folders list";
            this.btnRapidShareRefreshFolders.UseVisualStyleBackColor = true;
            this.btnRapidShareRefreshFolders.Click += new System.EventHandler(this.btnRapidShareRefreshFolders_Click);
            // 
            // tvRapidShareFolders
            // 
            this.tvRapidShareFolders.Location = new System.Drawing.Point(16, 144);
            this.tvRapidShareFolders.Name = "tvRapidShareFolders";
            this.tvRapidShareFolders.Size = new System.Drawing.Size(440, 312);
            this.tvRapidShareFolders.TabIndex = 7;
            this.tvRapidShareFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRapidShareFolders_AfterSelect);
            // 
            // lblRapidSharePassword
            // 
            this.lblRapidSharePassword.AutoSize = true;
            this.lblRapidSharePassword.Location = new System.Drawing.Point(16, 56);
            this.lblRapidSharePassword.Name = "lblRapidSharePassword";
            this.lblRapidSharePassword.Size = new System.Drawing.Size(56, 13);
            this.lblRapidSharePassword.TabIndex = 2;
            this.lblRapidSharePassword.Text = "Password:";
            // 
            // lblRapidSharePremiumUsername
            // 
            this.lblRapidSharePremiumUsername.AutoSize = true;
            this.lblRapidSharePremiumUsername.Location = new System.Drawing.Point(16, 24);
            this.lblRapidSharePremiumUsername.Name = "lblRapidSharePremiumUsername";
            this.lblRapidSharePremiumUsername.Size = new System.Drawing.Size(58, 13);
            this.lblRapidSharePremiumUsername.TabIndex = 0;
            this.lblRapidSharePremiumUsername.Text = "Username:";
            // 
            // txtRapidSharePassword
            // 
            this.txtRapidSharePassword.Location = new System.Drawing.Point(80, 52);
            this.txtRapidSharePassword.Name = "txtRapidSharePassword";
            this.txtRapidSharePassword.PasswordChar = '*';
            this.txtRapidSharePassword.Size = new System.Drawing.Size(136, 20);
            this.txtRapidSharePassword.TabIndex = 3;
            this.txtRapidSharePassword.TextChanged += new System.EventHandler(this.txtRapidSharePassword_TextChanged);
            // 
            // txtRapidShareUsername
            // 
            this.txtRapidShareUsername.Location = new System.Drawing.Point(80, 20);
            this.txtRapidShareUsername.Name = "txtRapidShareUsername";
            this.txtRapidShareUsername.Size = new System.Drawing.Size(136, 20);
            this.txtRapidShareUsername.TabIndex = 1;
            this.txtRapidShareUsername.TextChanged += new System.EventHandler(this.txtRapidShareUsername_TextChanged);
            // 
            // tpSendSpace
            // 
            this.tpSendSpace.Controls.Add(this.btnSendSpaceRegister);
            this.tpSendSpace.Controls.Add(this.lblSendSpacePassword);
            this.tpSendSpace.Controls.Add(this.lblSendSpaceUsername);
            this.tpSendSpace.Controls.Add(this.txtSendSpacePassword);
            this.tpSendSpace.Controls.Add(this.txtSendSpaceUserName);
            this.tpSendSpace.Controls.Add(this.atcSendSpaceAccountType);
            this.tpSendSpace.Location = new System.Drawing.Point(4, 22);
            this.tpSendSpace.Name = "tpSendSpace";
            this.tpSendSpace.Padding = new System.Windows.Forms.Padding(3);
            this.tpSendSpace.Size = new System.Drawing.Size(804, 475);
            this.tpSendSpace.TabIndex = 6;
            this.tpSendSpace.Text = "SendSpace";
            this.tpSendSpace.UseVisualStyleBackColor = true;
            // 
            // btnSendSpaceRegister
            // 
            this.btnSendSpaceRegister.Location = new System.Drawing.Point(232, 19);
            this.btnSendSpaceRegister.Name = "btnSendSpaceRegister";
            this.btnSendSpaceRegister.Size = new System.Drawing.Size(75, 23);
            this.btnSendSpaceRegister.TabIndex = 1;
            this.btnSendSpaceRegister.Text = "&Register...";
            this.btnSendSpaceRegister.UseVisualStyleBackColor = true;
            this.btnSendSpaceRegister.Click += new System.EventHandler(this.btnSendSpaceRegister_Click);
            // 
            // lblSendSpacePassword
            // 
            this.lblSendSpacePassword.AutoSize = true;
            this.lblSendSpacePassword.Location = new System.Drawing.Point(16, 88);
            this.lblSendSpacePassword.Name = "lblSendSpacePassword";
            this.lblSendSpacePassword.Size = new System.Drawing.Size(53, 13);
            this.lblSendSpacePassword.TabIndex = 4;
            this.lblSendSpacePassword.Text = "Password";
            // 
            // lblSendSpaceUsername
            // 
            this.lblSendSpaceUsername.AutoSize = true;
            this.lblSendSpaceUsername.Location = new System.Drawing.Point(16, 56);
            this.lblSendSpaceUsername.Name = "lblSendSpaceUsername";
            this.lblSendSpaceUsername.Size = new System.Drawing.Size(55, 13);
            this.lblSendSpaceUsername.TabIndex = 2;
            this.lblSendSpaceUsername.Text = "Username";
            // 
            // txtSendSpacePassword
            // 
            this.txtSendSpacePassword.Location = new System.Drawing.Point(80, 84);
            this.txtSendSpacePassword.Name = "txtSendSpacePassword";
            this.txtSendSpacePassword.PasswordChar = '*';
            this.txtSendSpacePassword.Size = new System.Drawing.Size(136, 20);
            this.txtSendSpacePassword.TabIndex = 5;
            this.txtSendSpacePassword.TextChanged += new System.EventHandler(this.txtSendSpacePassword_TextChanged);
            // 
            // txtSendSpaceUserName
            // 
            this.txtSendSpaceUserName.Location = new System.Drawing.Point(80, 52);
            this.txtSendSpaceUserName.Name = "txtSendSpaceUserName";
            this.txtSendSpaceUserName.Size = new System.Drawing.Size(136, 20);
            this.txtSendSpaceUserName.TabIndex = 3;
            this.txtSendSpaceUserName.TextChanged += new System.EventHandler(this.txtSendSpaceUserName_TextChanged);
            // 
            // atcSendSpaceAccountType
            // 
            this.atcSendSpaceAccountType.Location = new System.Drawing.Point(8, 16);
            this.atcSendSpaceAccountType.Name = "atcSendSpaceAccountType";
            this.atcSendSpaceAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.atcSendSpaceAccountType.Size = new System.Drawing.Size(214, 29);
            this.atcSendSpaceAccountType.TabIndex = 0;
            this.atcSendSpaceAccountType.AccountTypeChanged += new UploadersLib.GUI.AccountTypeControl.AccountTypeChangedEventHandler(this.atcSendSpaceAccountType_AccountTypeChanged);
            // 
            // tpGe_tt
            // 
            this.tpGe_tt.Controls.Add(this.lblGe_ttAccessToken);
            this.tpGe_tt.Controls.Add(this.lblGe_ttPassword);
            this.tpGe_tt.Controls.Add(this.lblGe_ttEmail);
            this.tpGe_tt.Controls.Add(this.btnGe_ttLogin);
            this.tpGe_tt.Controls.Add(this.txtGe_ttPassword);
            this.tpGe_tt.Controls.Add(this.txtGe_ttEmail);
            this.tpGe_tt.Location = new System.Drawing.Point(4, 22);
            this.tpGe_tt.Name = "tpGe_tt";
            this.tpGe_tt.Padding = new System.Windows.Forms.Padding(3);
            this.tpGe_tt.Size = new System.Drawing.Size(804, 475);
            this.tpGe_tt.TabIndex = 7;
            this.tpGe_tt.Text = "Ge.tt";
            this.tpGe_tt.UseVisualStyleBackColor = true;
            // 
            // lblGe_ttAccessToken
            // 
            this.lblGe_ttAccessToken.AutoSize = true;
            this.lblGe_ttAccessToken.Location = new System.Drawing.Point(24, 112);
            this.lblGe_ttAccessToken.Name = "lblGe_ttAccessToken";
            this.lblGe_ttAccessToken.Size = new System.Drawing.Size(75, 13);
            this.lblGe_ttAccessToken.TabIndex = 5;
            this.lblGe_ttAccessToken.Text = "Access token:";
            // 
            // lblGe_ttPassword
            // 
            this.lblGe_ttPassword.AutoSize = true;
            this.lblGe_ttPassword.Location = new System.Drawing.Point(24, 48);
            this.lblGe_ttPassword.Name = "lblGe_ttPassword";
            this.lblGe_ttPassword.Size = new System.Drawing.Size(56, 13);
            this.lblGe_ttPassword.TabIndex = 2;
            this.lblGe_ttPassword.Text = "Password:";
            // 
            // lblGe_ttEmail
            // 
            this.lblGe_ttEmail.AutoSize = true;
            this.lblGe_ttEmail.Location = new System.Drawing.Point(24, 24);
            this.lblGe_ttEmail.Name = "lblGe_ttEmail";
            this.lblGe_ttEmail.Size = new System.Drawing.Size(35, 13);
            this.lblGe_ttEmail.TabIndex = 0;
            this.lblGe_ttEmail.Text = "Email:";
            // 
            // btnGe_ttLogin
            // 
            this.btnGe_ttLogin.Location = new System.Drawing.Point(184, 72);
            this.btnGe_ttLogin.Name = "btnGe_ttLogin";
            this.btnGe_ttLogin.Size = new System.Drawing.Size(75, 23);
            this.btnGe_ttLogin.TabIndex = 4;
            this.btnGe_ttLogin.Text = "Login";
            this.btnGe_ttLogin.UseVisualStyleBackColor = true;
            this.btnGe_ttLogin.Click += new System.EventHandler(this.btnGe_ttLogin_Click);
            // 
            // txtGe_ttPassword
            // 
            this.txtGe_ttPassword.Location = new System.Drawing.Point(88, 44);
            this.txtGe_ttPassword.Name = "txtGe_ttPassword";
            this.txtGe_ttPassword.PasswordChar = '*';
            this.txtGe_ttPassword.Size = new System.Drawing.Size(168, 20);
            this.txtGe_ttPassword.TabIndex = 3;
            // 
            // txtGe_ttEmail
            // 
            this.txtGe_ttEmail.Location = new System.Drawing.Point(88, 20);
            this.txtGe_ttEmail.Name = "txtGe_ttEmail";
            this.txtGe_ttEmail.Size = new System.Drawing.Size(168, 20);
            this.txtGe_ttEmail.TabIndex = 1;
            // 
            // tpHostr
            // 
            this.tpHostr.Controls.Add(this.cbLocalhostrDirectURL);
            this.tpHostr.Controls.Add(this.lblLocalhostrPassword);
            this.tpHostr.Controls.Add(this.lblLocalhostrEmail);
            this.tpHostr.Controls.Add(this.txtLocalhostrPassword);
            this.tpHostr.Controls.Add(this.txtLocalhostrEmail);
            this.tpHostr.Location = new System.Drawing.Point(4, 22);
            this.tpHostr.Name = "tpHostr";
            this.tpHostr.Padding = new System.Windows.Forms.Padding(3);
            this.tpHostr.Size = new System.Drawing.Size(804, 475);
            this.tpHostr.TabIndex = 8;
            this.tpHostr.Text = "Hostr";
            this.tpHostr.UseVisualStyleBackColor = true;
            // 
            // cbLocalhostrDirectURL
            // 
            this.cbLocalhostrDirectURL.AutoSize = true;
            this.cbLocalhostrDirectURL.Location = new System.Drawing.Point(26, 72);
            this.cbLocalhostrDirectURL.Name = "cbLocalhostrDirectURL";
            this.cbLocalhostrDirectURL.Size = new System.Drawing.Size(131, 17);
            this.cbLocalhostrDirectURL.TabIndex = 4;
            this.cbLocalhostrDirectURL.Text = "Use direct URL if exist";
            this.cbLocalhostrDirectURL.UseVisualStyleBackColor = true;
            this.cbLocalhostrDirectURL.CheckedChanged += new System.EventHandler(this.cbLocalhostrDirectURL_CheckedChanged);
            // 
            // lblLocalhostrPassword
            // 
            this.lblLocalhostrPassword.AutoSize = true;
            this.lblLocalhostrPassword.Location = new System.Drawing.Point(24, 48);
            this.lblLocalhostrPassword.Name = "lblLocalhostrPassword";
            this.lblLocalhostrPassword.Size = new System.Drawing.Size(56, 13);
            this.lblLocalhostrPassword.TabIndex = 2;
            this.lblLocalhostrPassword.Text = "Password:";
            // 
            // lblLocalhostrEmail
            // 
            this.lblLocalhostrEmail.AutoSize = true;
            this.lblLocalhostrEmail.Location = new System.Drawing.Point(24, 24);
            this.lblLocalhostrEmail.Name = "lblLocalhostrEmail";
            this.lblLocalhostrEmail.Size = new System.Drawing.Size(35, 13);
            this.lblLocalhostrEmail.TabIndex = 0;
            this.lblLocalhostrEmail.Text = "Email:";
            // 
            // txtLocalhostrPassword
            // 
            this.txtLocalhostrPassword.Location = new System.Drawing.Point(88, 44);
            this.txtLocalhostrPassword.Name = "txtLocalhostrPassword";
            this.txtLocalhostrPassword.PasswordChar = '*';
            this.txtLocalhostrPassword.Size = new System.Drawing.Size(168, 20);
            this.txtLocalhostrPassword.TabIndex = 3;
            this.txtLocalhostrPassword.TextChanged += new System.EventHandler(this.txtLocalhostrPassword_TextChanged);
            // 
            // txtLocalhostrEmail
            // 
            this.txtLocalhostrEmail.Location = new System.Drawing.Point(88, 20);
            this.txtLocalhostrEmail.Name = "txtLocalhostrEmail";
            this.txtLocalhostrEmail.Size = new System.Drawing.Size(168, 20);
            this.txtLocalhostrEmail.TabIndex = 1;
            this.txtLocalhostrEmail.TextChanged += new System.EventHandler(this.txtLocalhostrEmail_TextChanged);
            // 
            // tpJira
            // 
            this.tpJira.Controls.Add(this.txtJiraIssuePrefix);
            this.tpJira.Controls.Add(this.lblJiraIssuePrefix);
            this.tpJira.Controls.Add(this.gpJiraServer);
            this.tpJira.Controls.Add(this.oAuthJira);
            this.tpJira.Location = new System.Drawing.Point(4, 22);
            this.tpJira.Name = "tpJira";
            this.tpJira.Size = new System.Drawing.Size(804, 475);
            this.tpJira.TabIndex = 11;
            this.tpJira.Text = "Atlassian Jira";
            this.tpJira.UseVisualStyleBackColor = true;
            // 
            // txtJiraIssuePrefix
            // 
            this.txtJiraIssuePrefix.Location = new System.Drawing.Point(560, 226);
            this.txtJiraIssuePrefix.Name = "txtJiraIssuePrefix";
            this.txtJiraIssuePrefix.Size = new System.Drawing.Size(117, 20);
            this.txtJiraIssuePrefix.TabIndex = 3;
            this.txtJiraIssuePrefix.Text = "PROJECT-";
            this.txtJiraIssuePrefix.TextChanged += new System.EventHandler(this.txtJiraIssuePrefix_TextChanged);
            // 
            // lblJiraIssuePrefix
            // 
            this.lblJiraIssuePrefix.AutoSize = true;
            this.lblJiraIssuePrefix.Location = new System.Drawing.Point(473, 229);
            this.lblJiraIssuePrefix.Name = "lblJiraIssuePrefix";
            this.lblJiraIssuePrefix.Size = new System.Drawing.Size(81, 13);
            this.lblJiraIssuePrefix.TabIndex = 2;
            this.lblJiraIssuePrefix.Text = "Jira issue prefix:";
            // 
            // gpJiraServer
            // 
            this.gpJiraServer.Controls.Add(this.txtJiraConfigHelp);
            this.gpJiraServer.Controls.Add(this.txtJiraHost);
            this.gpJiraServer.Controls.Add(this.lblJiraHost);
            this.gpJiraServer.Location = new System.Drawing.Point(13, 13);
            this.gpJiraServer.Name = "gpJiraServer";
            this.gpJiraServer.Size = new System.Drawing.Size(454, 358);
            this.gpJiraServer.TabIndex = 0;
            this.gpJiraServer.TabStop = false;
            this.gpJiraServer.Text = "Jira server";
            // 
            // txtJiraConfigHelp
            // 
            this.txtJiraConfigHelp.BackColor = System.Drawing.SystemColors.Window;
            this.txtJiraConfigHelp.Location = new System.Drawing.Point(8, 45);
            this.txtJiraConfigHelp.Multiline = true;
            this.txtJiraConfigHelp.Name = "txtJiraConfigHelp";
            this.txtJiraConfigHelp.ReadOnly = true;
            this.txtJiraConfigHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJiraConfigHelp.Size = new System.Drawing.Size(440, 307);
            this.txtJiraConfigHelp.TabIndex = 2;
            this.txtJiraConfigHelp.Text = "Template";
            // 
            // txtJiraHost
            // 
            this.txtJiraHost.Location = new System.Drawing.Point(63, 19);
            this.txtJiraHost.Name = "txtJiraHost";
            this.txtJiraHost.Size = new System.Drawing.Size(385, 20);
            this.txtJiraHost.TabIndex = 1;
            this.txtJiraHost.Text = "http://";
            this.txtJiraHost.TextChanged += new System.EventHandler(this.txtJiraHost_TextChanged);
            // 
            // lblJiraHost
            // 
            this.lblJiraHost.AutoSize = true;
            this.lblJiraHost.Location = new System.Drawing.Point(5, 22);
            this.lblJiraHost.Name = "lblJiraHost";
            this.lblJiraHost.Size = new System.Drawing.Size(52, 13);
            this.lblJiraHost.TabIndex = 0;
            this.lblJiraHost.Text = "Jira host: ";
            // 
            // oAuthJira
            // 
            this.oAuthJira.Location = new System.Drawing.Point(473, 13);
            this.oAuthJira.LoginStatus = false;
            this.oAuthJira.Name = "oAuthJira";
            this.oAuthJira.Size = new System.Drawing.Size(328, 207);
            this.oAuthJira.Status = "Status: Login required.";
            this.oAuthJira.TabIndex = 1;
            this.oAuthJira.OpenButtonClicked += new UploadersLib.GUI.OAuth2Control.OpenButtonClickedEventHandler(this.oAuthJira_OpenButtonClicked);
            this.oAuthJira.CompleteButtonClicked += new UploadersLib.GUI.OAuth2Control.CompleteButtonClickedEventHandler(this.oAuthJira_CompleteButtonClicked);
            this.oAuthJira.RefreshButtonClicked += new UploadersLib.GUI.OAuth2Control.RefreshButtonClickedEventHandler(this.oAuthJira_RefreshButtonClicked);
            // 
            // tpGoogleDrive
            // 
            this.tpGoogleDrive.Controls.Add(this.oauth2GoogleDrive);
            this.tpGoogleDrive.Location = new System.Drawing.Point(4, 22);
            this.tpGoogleDrive.Name = "tpGoogleDrive";
            this.tpGoogleDrive.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoogleDrive.Size = new System.Drawing.Size(804, 475);
            this.tpGoogleDrive.TabIndex = 1;
            this.tpGoogleDrive.Text = "Google Drive";
            this.tpGoogleDrive.UseVisualStyleBackColor = true;
            // 
            // oauth2GoogleDrive
            // 
            this.oauth2GoogleDrive.Location = new System.Drawing.Point(16, 16);
            this.oauth2GoogleDrive.LoginStatus = false;
            this.oauth2GoogleDrive.Name = "oauth2GoogleDrive";
            this.oauth2GoogleDrive.Size = new System.Drawing.Size(328, 207);
            this.oauth2GoogleDrive.Status = "Status: Login required.";
            this.oauth2GoogleDrive.TabIndex = 0;
            this.oauth2GoogleDrive.OpenButtonClicked += new UploadersLib.GUI.OAuth2Control.OpenButtonClickedEventHandler(this.oauth2GoogleDrive_OpenButtonClicked);
            this.oauth2GoogleDrive.CompleteButtonClicked += new UploadersLib.GUI.OAuth2Control.CompleteButtonClickedEventHandler(this.oauth2GoogleDrive_CompleteButtonClicked);
            this.oauth2GoogleDrive.RefreshButtonClicked += new UploadersLib.GUI.OAuth2Control.RefreshButtonClickedEventHandler(this.oauth2GoogleDrive_RefreshButtonClicked);
            // 
            // tpMinus
            // 
            this.tpMinus.Controls.Add(this.gbMinusUserPass);
            this.tpMinus.Controls.Add(this.gbMinusUpload);
            this.tpMinus.Controls.Add(this.lblMinusAuthStatus);
            this.tpMinus.Location = new System.Drawing.Point(4, 22);
            this.tpMinus.Name = "tpMinus";
            this.tpMinus.Padding = new System.Windows.Forms.Padding(3);
            this.tpMinus.Size = new System.Drawing.Size(804, 475);
            this.tpMinus.TabIndex = 3;
            this.tpMinus.Text = "Minus";
            this.tpMinus.UseVisualStyleBackColor = true;
            // 
            // gbMinusUserPass
            // 
            this.gbMinusUserPass.Controls.Add(this.btnAuthRefresh);
            this.gbMinusUserPass.Controls.Add(this.lblMinusPassword);
            this.gbMinusUserPass.Controls.Add(this.lblMinusUsername);
            this.gbMinusUserPass.Controls.Add(this.txtMinusPassword);
            this.gbMinusUserPass.Controls.Add(this.txtMinusUsername);
            this.gbMinusUserPass.Controls.Add(this.btnMinusAuth);
            this.gbMinusUserPass.Location = new System.Drawing.Point(16, 16);
            this.gbMinusUserPass.Name = "gbMinusUserPass";
            this.gbMinusUserPass.Size = new System.Drawing.Size(712, 88);
            this.gbMinusUserPass.TabIndex = 0;
            this.gbMinusUserPass.TabStop = false;
            this.gbMinusUserPass.Text = "Authentication";
            // 
            // btnAuthRefresh
            // 
            this.btnAuthRefresh.Location = new System.Drawing.Point(552, 16);
            this.btnAuthRefresh.Name = "btnAuthRefresh";
            this.btnAuthRefresh.Size = new System.Drawing.Size(144, 24);
            this.btnAuthRefresh.TabIndex = 3;
            this.btnAuthRefresh.Text = "Refresh Authorization";
            this.btnAuthRefresh.UseVisualStyleBackColor = true;
            this.btnAuthRefresh.Click += new System.EventHandler(this.btnAuthRefresh_Click);
            // 
            // lblMinusPassword
            // 
            this.lblMinusPassword.AutoSize = true;
            this.lblMinusPassword.Location = new System.Drawing.Point(8, 56);
            this.lblMinusPassword.Name = "lblMinusPassword";
            this.lblMinusPassword.Size = new System.Drawing.Size(56, 13);
            this.lblMinusPassword.TabIndex = 4;
            this.lblMinusPassword.Text = "Password:";
            // 
            // lblMinusUsername
            // 
            this.lblMinusUsername.AutoSize = true;
            this.lblMinusUsername.Location = new System.Drawing.Point(8, 24);
            this.lblMinusUsername.Name = "lblMinusUsername";
            this.lblMinusUsername.Size = new System.Drawing.Size(58, 13);
            this.lblMinusUsername.TabIndex = 0;
            this.lblMinusUsername.Text = "Username:";
            // 
            // txtMinusPassword
            // 
            this.txtMinusPassword.Location = new System.Drawing.Point(72, 52);
            this.txtMinusPassword.Name = "txtMinusPassword";
            this.txtMinusPassword.PasswordChar = '*';
            this.txtMinusPassword.Size = new System.Drawing.Size(136, 20);
            this.txtMinusPassword.TabIndex = 5;
            // 
            // txtMinusUsername
            // 
            this.txtMinusUsername.Location = new System.Drawing.Point(72, 20);
            this.txtMinusUsername.Name = "txtMinusUsername";
            this.txtMinusUsername.Size = new System.Drawing.Size(136, 20);
            this.txtMinusUsername.TabIndex = 1;
            // 
            // btnMinusAuth
            // 
            this.btnMinusAuth.Location = new System.Drawing.Point(400, 16);
            this.btnMinusAuth.Name = "btnMinusAuth";
            this.btnMinusAuth.Size = new System.Drawing.Size(144, 24);
            this.btnMinusAuth.TabIndex = 2;
            this.btnMinusAuth.Text = "Authorize";
            this.btnMinusAuth.UseVisualStyleBackColor = true;
            this.btnMinusAuth.Click += new System.EventHandler(this.btnMinusAuth_Click);
            // 
            // gbMinusUpload
            // 
            this.gbMinusUpload.Controls.Add(this.lblMinusURLType);
            this.gbMinusUpload.Controls.Add(this.cbMinusURLType);
            this.gbMinusUpload.Controls.Add(this.btnMinusReadFolderList);
            this.gbMinusUpload.Controls.Add(this.chkMinusPublic);
            this.gbMinusUpload.Controls.Add(this.btnMinusFolderAdd);
            this.gbMinusUpload.Controls.Add(this.btnMinusFolderRemove);
            this.gbMinusUpload.Controls.Add(this.cboMinusFolders);
            this.gbMinusUpload.Location = new System.Drawing.Point(16, 112);
            this.gbMinusUpload.Name = "gbMinusUpload";
            this.gbMinusUpload.Size = new System.Drawing.Size(712, 88);
            this.gbMinusUpload.TabIndex = 1;
            this.gbMinusUpload.TabStop = false;
            this.gbMinusUpload.Text = "Upload images to";
            // 
            // lblMinusURLType
            // 
            this.lblMinusURLType.AutoSize = true;
            this.lblMinusURLType.Location = new System.Drawing.Point(16, 56);
            this.lblMinusURLType.Name = "lblMinusURLType";
            this.lblMinusURLType.Size = new System.Drawing.Size(55, 13);
            this.lblMinusURLType.TabIndex = 4;
            this.lblMinusURLType.Text = "URL type:";
            // 
            // cbMinusURLType
            // 
            this.cbMinusURLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinusURLType.FormattingEnabled = true;
            this.cbMinusURLType.Location = new System.Drawing.Point(80, 52);
            this.cbMinusURLType.Name = "cbMinusURLType";
            this.cbMinusURLType.Size = new System.Drawing.Size(88, 21);
            this.cbMinusURLType.TabIndex = 6;
            this.cbMinusURLType.SelectedIndexChanged += new System.EventHandler(this.cbMinusURLType_SelectedIndexChanged);
            // 
            // btnMinusReadFolderList
            // 
            this.btnMinusReadFolderList.AutoSize = true;
            this.btnMinusReadFolderList.Location = new System.Drawing.Point(512, 48);
            this.btnMinusReadFolderList.Name = "btnMinusReadFolderList";
            this.btnMinusReadFolderList.Size = new System.Drawing.Size(184, 23);
            this.btnMinusReadFolderList.TabIndex = 5;
            this.btnMinusReadFolderList.Text = "Reload folder list";
            this.btnMinusReadFolderList.UseVisualStyleBackColor = true;
            this.btnMinusReadFolderList.Click += new System.EventHandler(this.btnMinusReadFolderList_Click);
            // 
            // chkMinusPublic
            // 
            this.chkMinusPublic.AutoSize = true;
            this.chkMinusPublic.Location = new System.Drawing.Point(416, 26);
            this.chkMinusPublic.Name = "chkMinusPublic";
            this.chkMinusPublic.Size = new System.Drawing.Size(55, 17);
            this.chkMinusPublic.TabIndex = 3;
            this.chkMinusPublic.Text = "Public";
            this.chkMinusPublic.UseVisualStyleBackColor = true;
            // 
            // btnMinusFolderAdd
            // 
            this.btnMinusFolderAdd.Location = new System.Drawing.Point(512, 16);
            this.btnMinusFolderAdd.Name = "btnMinusFolderAdd";
            this.btnMinusFolderAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMinusFolderAdd.TabIndex = 0;
            this.btnMinusFolderAdd.Text = "Add folder";
            this.btnMinusFolderAdd.UseVisualStyleBackColor = true;
            this.btnMinusFolderAdd.Click += new System.EventHandler(this.btnMinusFolderAdd_Click);
            // 
            // btnMinusFolderRemove
            // 
            this.btnMinusFolderRemove.AutoSize = true;
            this.btnMinusFolderRemove.Location = new System.Drawing.Point(592, 16);
            this.btnMinusFolderRemove.Name = "btnMinusFolderRemove";
            this.btnMinusFolderRemove.Size = new System.Drawing.Size(104, 23);
            this.btnMinusFolderRemove.TabIndex = 1;
            this.btnMinusFolderRemove.Text = "Remove folder";
            this.btnMinusFolderRemove.UseVisualStyleBackColor = true;
            this.btnMinusFolderRemove.Click += new System.EventHandler(this.btnMinusFolderRemove_Click);
            // 
            // cboMinusFolders
            // 
            this.cboMinusFolders.FormattingEnabled = true;
            this.cboMinusFolders.Location = new System.Drawing.Point(16, 24);
            this.cboMinusFolders.Name = "cboMinusFolders";
            this.cboMinusFolders.Size = new System.Drawing.Size(392, 21);
            this.cboMinusFolders.TabIndex = 2;
            this.cboMinusFolders.SelectedIndexChanged += new System.EventHandler(this.cboMinusFolders_SelectedIndexChanged);
            // 
            // lblMinusAuthStatus
            // 
            this.lblMinusAuthStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMinusAuthStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMinusAuthStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMinusAuthStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinusAuthStatus.Location = new System.Drawing.Point(3, 453);
            this.lblMinusAuthStatus.Name = "lblMinusAuthStatus";
            this.lblMinusAuthStatus.Size = new System.Drawing.Size(798, 19);
            this.lblMinusAuthStatus.TabIndex = 2;
            this.lblMinusAuthStatus.Text = "Login status:";
            // 
            // tpEmail
            // 
            this.tpEmail.Controls.Add(this.chkEmailConfirm);
            this.tpEmail.Controls.Add(this.lblEmailSmtpServer);
            this.tpEmail.Controls.Add(this.lblEmailPassword);
            this.tpEmail.Controls.Add(this.cbEmailRememberLastTo);
            this.tpEmail.Controls.Add(this.txtEmailFrom);
            this.tpEmail.Controls.Add(this.txtEmailPassword);
            this.tpEmail.Controls.Add(this.txtEmailDefaultBody);
            this.tpEmail.Controls.Add(this.lblEmailFrom);
            this.tpEmail.Controls.Add(this.txtEmailSmtpServer);
            this.tpEmail.Controls.Add(this.lblEmailDefaultSubject);
            this.tpEmail.Controls.Add(this.lblEmailDefaultBody);
            this.tpEmail.Controls.Add(this.nudEmailSmtpPort);
            this.tpEmail.Controls.Add(this.lblEmailSmtpPort);
            this.tpEmail.Controls.Add(this.txtEmailDefaultSubject);
            this.tpEmail.Location = new System.Drawing.Point(4, 22);
            this.tpEmail.Name = "tpEmail";
            this.tpEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmail.Size = new System.Drawing.Size(804, 475);
            this.tpEmail.TabIndex = 10;
            this.tpEmail.Text = "Email";
            this.tpEmail.UseVisualStyleBackColor = true;
            // 
            // chkEmailConfirm
            // 
            this.chkEmailConfirm.AutoSize = true;
            this.chkEmailConfirm.Location = new System.Drawing.Point(216, 96);
            this.chkEmailConfirm.Name = "chkEmailConfirm";
            this.chkEmailConfirm.Size = new System.Drawing.Size(134, 17);
            this.chkEmailConfirm.TabIndex = 9;
            this.chkEmailConfirm.Text = "Confirm before sending";
            this.chkEmailConfirm.UseVisualStyleBackColor = true;
            this.chkEmailConfirm.CheckedChanged += new System.EventHandler(this.chkEmailConfirm_CheckedChanged);
            // 
            // lblEmailSmtpServer
            // 
            this.lblEmailSmtpServer.AutoSize = true;
            this.lblEmailSmtpServer.Location = new System.Drawing.Point(16, 16);
            this.lblEmailSmtpServer.Name = "lblEmailSmtpServer";
            this.lblEmailSmtpServer.Size = new System.Drawing.Size(72, 13);
            this.lblEmailSmtpServer.TabIndex = 0;
            this.lblEmailSmtpServer.Text = "SMTP server:";
            // 
            // lblEmailPassword
            // 
            this.lblEmailPassword.AutoSize = true;
            this.lblEmailPassword.Location = new System.Drawing.Point(16, 64);
            this.lblEmailPassword.Name = "lblEmailPassword";
            this.lblEmailPassword.Size = new System.Drawing.Size(56, 13);
            this.lblEmailPassword.TabIndex = 6;
            this.lblEmailPassword.Text = "Password:";
            // 
            // cbEmailRememberLastTo
            // 
            this.cbEmailRememberLastTo.AutoSize = true;
            this.cbEmailRememberLastTo.Location = new System.Drawing.Point(16, 96);
            this.cbEmailRememberLastTo.Name = "cbEmailRememberLastTo";
            this.cbEmailRememberLastTo.Size = new System.Drawing.Size(179, 17);
            this.cbEmailRememberLastTo.TabIndex = 8;
            this.cbEmailRememberLastTo.Text = "Remember last recipient address";
            this.cbEmailRememberLastTo.UseVisualStyleBackColor = true;
            this.cbEmailRememberLastTo.CheckedChanged += new System.EventHandler(this.cbRememberLastToEmail_CheckedChanged);
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(96, 36);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(200, 20);
            this.txtEmailFrom.TabIndex = 5;
            this.txtEmailFrom.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Location = new System.Drawing.Point(96, 60);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '*';
            this.txtEmailPassword.Size = new System.Drawing.Size(200, 20);
            this.txtEmailPassword.TabIndex = 7;
            this.txtEmailPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmailDefaultBody
            // 
            this.txtEmailDefaultBody.Location = new System.Drawing.Point(16, 192);
            this.txtEmailDefaultBody.Multiline = true;
            this.txtEmailDefaultBody.Name = "txtEmailDefaultBody";
            this.txtEmailDefaultBody.Size = new System.Drawing.Size(400, 128);
            this.txtEmailDefaultBody.TabIndex = 13;
            this.txtEmailDefaultBody.TextChanged += new System.EventHandler(this.txtDefaultBody_TextChanged);
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Location = new System.Drawing.Point(16, 40);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(35, 13);
            this.lblEmailFrom.TabIndex = 4;
            this.lblEmailFrom.Text = "Email:";
            // 
            // txtEmailSmtpServer
            // 
            this.txtEmailSmtpServer.Location = new System.Drawing.Point(96, 12);
            this.txtEmailSmtpServer.Name = "txtEmailSmtpServer";
            this.txtEmailSmtpServer.Size = new System.Drawing.Size(200, 20);
            this.txtEmailSmtpServer.TabIndex = 1;
            this.txtEmailSmtpServer.TextChanged += new System.EventHandler(this.txtSmtpServer_TextChanged);
            // 
            // lblEmailDefaultSubject
            // 
            this.lblEmailDefaultSubject.AutoSize = true;
            this.lblEmailDefaultSubject.Location = new System.Drawing.Point(16, 126);
            this.lblEmailDefaultSubject.Name = "lblEmailDefaultSubject";
            this.lblEmailDefaultSubject.Size = new System.Drawing.Size(81, 13);
            this.lblEmailDefaultSubject.TabIndex = 10;
            this.lblEmailDefaultSubject.Text = "Default subject:";
            // 
            // lblEmailDefaultBody
            // 
            this.lblEmailDefaultBody.AutoSize = true;
            this.lblEmailDefaultBody.Location = new System.Drawing.Point(16, 174);
            this.lblEmailDefaultBody.Name = "lblEmailDefaultBody";
            this.lblEmailDefaultBody.Size = new System.Drawing.Size(89, 13);
            this.lblEmailDefaultBody.TabIndex = 12;
            this.lblEmailDefaultBody.Text = "Default message:";
            // 
            // nudEmailSmtpPort
            // 
            this.nudEmailSmtpPort.Location = new System.Drawing.Point(344, 12);
            this.nudEmailSmtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEmailSmtpPort.Name = "nudEmailSmtpPort";
            this.nudEmailSmtpPort.Size = new System.Drawing.Size(64, 20);
            this.nudEmailSmtpPort.TabIndex = 3;
            this.nudEmailSmtpPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEmailSmtpPort.Value = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudEmailSmtpPort.ValueChanged += new System.EventHandler(this.nudSmtpPort_ValueChanged);
            // 
            // lblEmailSmtpPort
            // 
            this.lblEmailSmtpPort.AutoSize = true;
            this.lblEmailSmtpPort.Location = new System.Drawing.Point(304, 16);
            this.lblEmailSmtpPort.Name = "lblEmailSmtpPort";
            this.lblEmailSmtpPort.Size = new System.Drawing.Size(29, 13);
            this.lblEmailSmtpPort.TabIndex = 2;
            this.lblEmailSmtpPort.Text = "Port:";
            // 
            // txtEmailDefaultSubject
            // 
            this.txtEmailDefaultSubject.Location = new System.Drawing.Point(16, 144);
            this.txtEmailDefaultSubject.Name = "txtEmailDefaultSubject";
            this.txtEmailDefaultSubject.Size = new System.Drawing.Size(400, 20);
            this.txtEmailDefaultSubject.TabIndex = 11;
            this.txtEmailDefaultSubject.TextChanged += new System.EventHandler(this.txtDefaultSubject_TextChanged);
            // 
            // tpSharedFolder
            // 
            this.tpSharedFolder.Controls.Add(this.tlpSharedFolders);
            this.tpSharedFolder.Location = new System.Drawing.Point(4, 22);
            this.tpSharedFolder.Name = "tpSharedFolder";
            this.tpSharedFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tpSharedFolder.Size = new System.Drawing.Size(804, 475);
            this.tpSharedFolder.TabIndex = 9;
            this.tpSharedFolder.Text = "Shared folder";
            this.tpSharedFolder.UseVisualStyleBackColor = true;
            // 
            // tlpSharedFolders
            // 
            this.tlpSharedFolders.ColumnCount = 1;
            this.tlpSharedFolders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSharedFolders.Controls.Add(this.ucLocalhostAccounts, 0, 0);
            this.tlpSharedFolders.Controls.Add(this.gbSharedFolder, 0, 1);
            this.tlpSharedFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSharedFolders.Location = new System.Drawing.Point(3, 3);
            this.tlpSharedFolders.Name = "tlpSharedFolders";
            this.tlpSharedFolders.RowCount = 2;
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSharedFolders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSharedFolders.Size = new System.Drawing.Size(798, 469);
            this.tlpSharedFolders.TabIndex = 0;
            // 
            // ucLocalhostAccounts
            // 
            this.ucLocalhostAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLocalhostAccounts.Location = new System.Drawing.Point(4, 4);
            this.ucLocalhostAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.ucLocalhostAccounts.Name = "ucLocalhostAccounts";
            this.ucLocalhostAccounts.Size = new System.Drawing.Size(790, 343);
            this.ucLocalhostAccounts.TabIndex = 0;
            // 
            // gbSharedFolder
            // 
            this.gbSharedFolder.Controls.Add(this.lblSharedFolderFiles);
            this.gbSharedFolder.Controls.Add(this.lblSharedFolderText);
            this.gbSharedFolder.Controls.Add(this.lblSharedFolderImages);
            this.gbSharedFolder.Controls.Add(this.cboSharedFolderFiles);
            this.gbSharedFolder.Controls.Add(this.cboSharedFolderText);
            this.gbSharedFolder.Controls.Add(this.cboSharedFolderImages);
            this.gbSharedFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSharedFolder.Location = new System.Drawing.Point(3, 354);
            this.gbSharedFolder.Name = "gbSharedFolder";
            this.gbSharedFolder.Size = new System.Drawing.Size(792, 112);
            this.gbSharedFolder.TabIndex = 1;
            this.gbSharedFolder.TabStop = false;
            this.gbSharedFolder.Text = "Settings";
            // 
            // lblSharedFolderFiles
            // 
            this.lblSharedFolderFiles.AutoSize = true;
            this.lblSharedFolderFiles.Location = new System.Drawing.Point(24, 78);
            this.lblSharedFolderFiles.Name = "lblSharedFolderFiles";
            this.lblSharedFolderFiles.Size = new System.Drawing.Size(28, 13);
            this.lblSharedFolderFiles.TabIndex = 4;
            this.lblSharedFolderFiles.Text = "Files";
            // 
            // lblSharedFolderText
            // 
            this.lblSharedFolderText.AutoSize = true;
            this.lblSharedFolderText.Location = new System.Drawing.Point(24, 52);
            this.lblSharedFolderText.Name = "lblSharedFolderText";
            this.lblSharedFolderText.Size = new System.Drawing.Size(28, 13);
            this.lblSharedFolderText.TabIndex = 2;
            this.lblSharedFolderText.Text = "Text";
            // 
            // lblSharedFolderImages
            // 
            this.lblSharedFolderImages.AutoSize = true;
            this.lblSharedFolderImages.Location = new System.Drawing.Point(11, 27);
            this.lblSharedFolderImages.Name = "lblSharedFolderImages";
            this.lblSharedFolderImages.Size = new System.Drawing.Size(41, 13);
            this.lblSharedFolderImages.TabIndex = 0;
            this.lblSharedFolderImages.Text = "Images";
            // 
            // cboSharedFolderFiles
            // 
            this.cboSharedFolderFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharedFolderFiles.FormattingEnabled = true;
            this.cboSharedFolderFiles.Location = new System.Drawing.Point(64, 72);
            this.cboSharedFolderFiles.Name = "cboSharedFolderFiles";
            this.cboSharedFolderFiles.Size = new System.Drawing.Size(472, 21);
            this.cboSharedFolderFiles.TabIndex = 5;
            this.cboSharedFolderFiles.SelectedIndexChanged += new System.EventHandler(this.cboSharedFolderFiles_SelectedIndexChanged);
            // 
            // cboSharedFolderText
            // 
            this.cboSharedFolderText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharedFolderText.FormattingEnabled = true;
            this.cboSharedFolderText.Location = new System.Drawing.Point(64, 48);
            this.cboSharedFolderText.Name = "cboSharedFolderText";
            this.cboSharedFolderText.Size = new System.Drawing.Size(472, 21);
            this.cboSharedFolderText.TabIndex = 3;
            this.cboSharedFolderText.SelectedIndexChanged += new System.EventHandler(this.cboSharedFolderText_SelectedIndexChanged);
            // 
            // cboSharedFolderImages
            // 
            this.cboSharedFolderImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSharedFolderImages.FormattingEnabled = true;
            this.cboSharedFolderImages.Location = new System.Drawing.Point(64, 24);
            this.cboSharedFolderImages.Name = "cboSharedFolderImages";
            this.cboSharedFolderImages.Size = new System.Drawing.Size(472, 21);
            this.cboSharedFolderImages.TabIndex = 1;
            this.cboSharedFolderImages.SelectedIndexChanged += new System.EventHandler(this.cboSharedFolderImages_SelectedIndexChanged);
            // 
            // tpURLShorteners
            // 
            this.tpURLShorteners.Controls.Add(this.tcURLShorteners);
            this.tpURLShorteners.Location = new System.Drawing.Point(4, 22);
            this.tpURLShorteners.Name = "tpURLShorteners";
            this.tpURLShorteners.Padding = new System.Windows.Forms.Padding(3);
            this.tpURLShorteners.Size = new System.Drawing.Size(818, 507);
            this.tpURLShorteners.TabIndex = 3;
            this.tpURLShorteners.Text = "URL shorteners";
            this.tpURLShorteners.UseVisualStyleBackColor = true;
            // 
            // tcURLShorteners
            // 
            this.tcURLShorteners.Controls.Add(this.tpGoogleURLShortener);
            this.tcURLShorteners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcURLShorteners.Location = new System.Drawing.Point(3, 3);
            this.tcURLShorteners.Name = "tcURLShorteners";
            this.tcURLShorteners.SelectedIndex = 0;
            this.tcURLShorteners.Size = new System.Drawing.Size(812, 501);
            this.tcURLShorteners.TabIndex = 0;
            // 
            // tpGoogleURLShortener
            // 
            this.tpGoogleURLShortener.Controls.Add(this.oauth2GoogleURLShortener);
            this.tpGoogleURLShortener.Controls.Add(this.atcGoogleURLShortenerAccountType);
            this.tpGoogleURLShortener.Location = new System.Drawing.Point(4, 22);
            this.tpGoogleURLShortener.Name = "tpGoogleURLShortener";
            this.tpGoogleURLShortener.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoogleURLShortener.Size = new System.Drawing.Size(804, 475);
            this.tpGoogleURLShortener.TabIndex = 0;
            this.tpGoogleURLShortener.Text = "Google";
            this.tpGoogleURLShortener.UseVisualStyleBackColor = true;
            // 
            // oauth2GoogleURLShortener
            // 
            this.oauth2GoogleURLShortener.Location = new System.Drawing.Point(16, 56);
            this.oauth2GoogleURLShortener.LoginStatus = false;
            this.oauth2GoogleURLShortener.Name = "oauth2GoogleURLShortener";
            this.oauth2GoogleURLShortener.Size = new System.Drawing.Size(328, 207);
            this.oauth2GoogleURLShortener.Status = "Status: Login required.";
            this.oauth2GoogleURLShortener.TabIndex = 1;
            this.oauth2GoogleURLShortener.OpenButtonClicked += new UploadersLib.GUI.OAuth2Control.OpenButtonClickedEventHandler(this.oauth2GoogleURLShortener_OpenButtonClicked);
            this.oauth2GoogleURLShortener.CompleteButtonClicked += new UploadersLib.GUI.OAuth2Control.CompleteButtonClickedEventHandler(this.oauth2GoogleURLShortener_CompleteButtonClicked);
            this.oauth2GoogleURLShortener.RefreshButtonClicked += new UploadersLib.GUI.OAuth2Control.RefreshButtonClickedEventHandler(this.oauth2GoogleURLShortener_RefreshButtonClicked);
            // 
            // atcGoogleURLShortenerAccountType
            // 
            this.atcGoogleURLShortenerAccountType.Location = new System.Drawing.Point(8, 16);
            this.atcGoogleURLShortenerAccountType.Name = "atcGoogleURLShortenerAccountType";
            this.atcGoogleURLShortenerAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.atcGoogleURLShortenerAccountType.Size = new System.Drawing.Size(214, 29);
            this.atcGoogleURLShortenerAccountType.TabIndex = 0;
            this.atcGoogleURLShortenerAccountType.AccountTypeChanged += new UploadersLib.GUI.AccountTypeControl.AccountTypeChangedEventHandler(this.atcGoogleURLShortenerAccountType_AccountTypeChanged);
            // 
            // tpSocialNetworkingServices
            // 
            this.tpSocialNetworkingServices.Controls.Add(this.tcSocialNetworkingServices);
            this.tpSocialNetworkingServices.Location = new System.Drawing.Point(4, 22);
            this.tpSocialNetworkingServices.Name = "tpSocialNetworkingServices";
            this.tpSocialNetworkingServices.Padding = new System.Windows.Forms.Padding(3);
            this.tpSocialNetworkingServices.Size = new System.Drawing.Size(818, 507);
            this.tpSocialNetworkingServices.TabIndex = 4;
            this.tpSocialNetworkingServices.Text = "Social networking services";
            this.tpSocialNetworkingServices.UseVisualStyleBackColor = true;
            // 
            // tcSocialNetworkingServices
            // 
            this.tcSocialNetworkingServices.Controls.Add(this.tpTwitter);
            this.tcSocialNetworkingServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSocialNetworkingServices.Location = new System.Drawing.Point(3, 3);
            this.tcSocialNetworkingServices.Name = "tcSocialNetworkingServices";
            this.tcSocialNetworkingServices.SelectedIndex = 0;
            this.tcSocialNetworkingServices.Size = new System.Drawing.Size(812, 501);
            this.tcSocialNetworkingServices.TabIndex = 0;
            // 
            // tpTwitter
            // 
            this.tpTwitter.Controls.Add(this.btnTwitterLogin);
            this.tpTwitter.Controls.Add(this.ucTwitterAccounts);
            this.tpTwitter.Location = new System.Drawing.Point(4, 22);
            this.tpTwitter.Name = "tpTwitter";
            this.tpTwitter.Padding = new System.Windows.Forms.Padding(3);
            this.tpTwitter.Size = new System.Drawing.Size(804, 475);
            this.tpTwitter.TabIndex = 0;
            this.tpTwitter.Text = "Twitter";
            this.tpTwitter.UseVisualStyleBackColor = true;
            // 
            // btnTwitterLogin
            // 
            this.btnTwitterLogin.Location = new System.Drawing.Point(224, 11);
            this.btnTwitterLogin.Name = "btnTwitterLogin";
            this.btnTwitterLogin.Size = new System.Drawing.Size(60, 24);
            this.btnTwitterLogin.TabIndex = 1;
            this.btnTwitterLogin.Text = "Login";
            this.btnTwitterLogin.UseVisualStyleBackColor = true;
            this.btnTwitterLogin.Click += new System.EventHandler(this.btnTwitterLogin_Click);
            // 
            // ucTwitterAccounts
            // 
            this.ucTwitterAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTwitterAccounts.Location = new System.Drawing.Point(3, 3);
            this.ucTwitterAccounts.Name = "ucTwitterAccounts";
            this.ucTwitterAccounts.Size = new System.Drawing.Size(798, 469);
            this.ucTwitterAccounts.TabIndex = 0;
            // 
            // tpCustomUploaders
            // 
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderImageUploader);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderFileUploaderTest);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderFileUploader);
            this.tpCustomUploaders.Controls.Add(this.label1);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderImageUploaderTest);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderRequestTypeHelp);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderTestResult);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderDeletionURL);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderFileUploader);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderDeletionURL);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderShowLastResponse);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderResponseType);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderURLShortener);
            this.tpCustomUploaders.Controls.Add(this.gbCustomUploaders);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderTextUploader);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderRequestURL);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderURLShortenerTest);
            this.tpCustomUploaders.Controls.Add(this.gbCustomUploaderRegexp);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderTextUploader);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderThumbnailURL);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderURLShortener);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderResponseType);
            this.tpCustomUploaders.Controls.Add(this.btnCustomUploaderTextUploaderTest);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderURL);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderImageUploader);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderRequestURL);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderLog);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderThumbnailURL);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderFileForm);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderRequestType);
            this.tpCustomUploaders.Controls.Add(this.cbCustomUploaderRequestType);
            this.tpCustomUploaders.Controls.Add(this.txtCustomUploaderFileForm);
            this.tpCustomUploaders.Controls.Add(this.lblCustomUploaderURL);
            this.tpCustomUploaders.Controls.Add(this.gbCustomUploaderArguments);
            this.tpCustomUploaders.Location = new System.Drawing.Point(4, 22);
            this.tpCustomUploaders.Name = "tpCustomUploaders";
            this.tpCustomUploaders.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomUploaders.Size = new System.Drawing.Size(818, 507);
            this.tpCustomUploaders.TabIndex = 5;
            this.tpCustomUploaders.Text = "Custom uploaders";
            this.tpCustomUploaders.UseVisualStyleBackColor = true;
            // 
            // lblCustomUploaderImageUploader
            // 
            this.lblCustomUploaderImageUploader.AutoSize = true;
            this.lblCustomUploaderImageUploader.Location = new System.Drawing.Point(16, 392);
            this.lblCustomUploaderImageUploader.Name = "lblCustomUploaderImageUploader";
            this.lblCustomUploaderImageUploader.Size = new System.Drawing.Size(83, 13);
            this.lblCustomUploaderImageUploader.TabIndex = 21;
            this.lblCustomUploaderImageUploader.Text = "Image uploader:";
            // 
            // btnCustomUploaderFileUploaderTest
            // 
            this.btnCustomUploaderFileUploaderTest.Location = new System.Drawing.Point(264, 436);
            this.btnCustomUploaderFileUploaderTest.Name = "btnCustomUploaderFileUploaderTest";
            this.btnCustomUploaderFileUploaderTest.Size = new System.Drawing.Size(48, 24);
            this.btnCustomUploaderFileUploaderTest.TabIndex = 29;
            this.btnCustomUploaderFileUploaderTest.Text = "Test";
            this.btnCustomUploaderFileUploaderTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderFileUploaderTest.Click += new System.EventHandler(this.btnCustomUploaderFileUploaderTest_Click);
            // 
            // lblCustomUploaderFileUploader
            // 
            this.lblCustomUploaderFileUploader.AutoSize = true;
            this.lblCustomUploaderFileUploader.Location = new System.Drawing.Point(16, 440);
            this.lblCustomUploaderFileUploader.Name = "lblCustomUploaderFileUploader";
            this.lblCustomUploaderFileUploader.Size = new System.Drawing.Size(70, 13);
            this.lblCustomUploaderFileUploader.TabIndex = 27;
            this.lblCustomUploaderFileUploader.Text = "File uploader:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(688, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttHelpTip.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // btnCustomUploaderImageUploaderTest
            // 
            this.btnCustomUploaderImageUploaderTest.Location = new System.Drawing.Point(264, 388);
            this.btnCustomUploaderImageUploaderTest.Name = "btnCustomUploaderImageUploaderTest";
            this.btnCustomUploaderImageUploaderTest.Size = new System.Drawing.Size(48, 24);
            this.btnCustomUploaderImageUploaderTest.TabIndex = 23;
            this.btnCustomUploaderImageUploaderTest.Text = "Test";
            this.btnCustomUploaderImageUploaderTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderImageUploaderTest.Click += new System.EventHandler(this.btnCustomUploaderImageUploaderTest_Click);
            // 
            // lblCustomUploaderRequestTypeHelp
            // 
            this.lblCustomUploaderRequestTypeHelp.BackColor = System.Drawing.Color.White;
            this.lblCustomUploaderRequestTypeHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomUploaderRequestTypeHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomUploaderRequestTypeHelp.Location = new System.Drawing.Point(424, 22);
            this.lblCustomUploaderRequestTypeHelp.Name = "lblCustomUploaderRequestTypeHelp";
            this.lblCustomUploaderRequestTypeHelp.Size = new System.Drawing.Size(24, 24);
            this.lblCustomUploaderRequestTypeHelp.TabIndex = 4;
            this.lblCustomUploaderRequestTypeHelp.Text = "?";
            this.lblCustomUploaderRequestTypeHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttHelpTip.SetToolTip(this.lblCustomUploaderRequestTypeHelp, resources.GetString("lblCustomUploaderRequestTypeHelp.ToolTip"));
            // 
            // lblCustomUploaderTestResult
            // 
            this.lblCustomUploaderTestResult.AutoSize = true;
            this.lblCustomUploaderTestResult.Location = new System.Drawing.Point(328, 384);
            this.lblCustomUploaderTestResult.Name = "lblCustomUploaderTestResult";
            this.lblCustomUploaderTestResult.Size = new System.Drawing.Size(59, 13);
            this.lblCustomUploaderTestResult.TabIndex = 19;
            this.lblCustomUploaderTestResult.Text = "Test result:";
            // 
            // txtCustomUploaderDeletionURL
            // 
            this.txtCustomUploaderDeletionURL.Location = new System.Drawing.Point(536, 344);
            this.txtCustomUploaderDeletionURL.Name = "txtCustomUploaderDeletionURL";
            this.txtCustomUploaderDeletionURL.Size = new System.Drawing.Size(248, 20);
            this.txtCustomUploaderDeletionURL.TabIndex = 18;
            // 
            // cbCustomUploaderFileUploader
            // 
            this.cbCustomUploaderFileUploader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderFileUploader.FormattingEnabled = true;
            this.cbCustomUploaderFileUploader.Location = new System.Drawing.Point(104, 436);
            this.cbCustomUploaderFileUploader.Name = "cbCustomUploaderFileUploader";
            this.cbCustomUploaderFileUploader.Size = new System.Drawing.Size(152, 21);
            this.cbCustomUploaderFileUploader.TabIndex = 28;
            this.cbCustomUploaderFileUploader.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderFileUploader_SelectedIndexChanged);
            // 
            // lblCustomUploaderDeletionURL
            // 
            this.lblCustomUploaderDeletionURL.AutoSize = true;
            this.lblCustomUploaderDeletionURL.Location = new System.Drawing.Point(536, 328);
            this.lblCustomUploaderDeletionURL.Name = "lblCustomUploaderDeletionURL";
            this.lblCustomUploaderDeletionURL.Size = new System.Drawing.Size(74, 13);
            this.lblCustomUploaderDeletionURL.TabIndex = 17;
            this.lblCustomUploaderDeletionURL.Text = "Deletion URL:";
            // 
            // btnCustomUploaderShowLastResponse
            // 
            this.btnCustomUploaderShowLastResponse.Enabled = false;
            this.btnCustomUploaderShowLastResponse.Location = new System.Drawing.Point(648, 376);
            this.btnCustomUploaderShowLastResponse.Name = "btnCustomUploaderShowLastResponse";
            this.btnCustomUploaderShowLastResponse.Size = new System.Drawing.Size(136, 23);
            this.btnCustomUploaderShowLastResponse.TabIndex = 20;
            this.btnCustomUploaderShowLastResponse.Text = "Show last response";
            this.btnCustomUploaderShowLastResponse.UseVisualStyleBackColor = true;
            this.btnCustomUploaderShowLastResponse.Click += new System.EventHandler(this.btnCustomUploaderShowLastResponse_Click);
            // 
            // lblCustomUploaderResponseType
            // 
            this.lblCustomUploaderResponseType.AutoSize = true;
            this.lblCustomUploaderResponseType.Location = new System.Drawing.Point(536, 8);
            this.lblCustomUploaderResponseType.Name = "lblCustomUploaderResponseType";
            this.lblCustomUploaderResponseType.Size = new System.Drawing.Size(81, 13);
            this.lblCustomUploaderResponseType.TabIndex = 2;
            this.lblCustomUploaderResponseType.Text = "Response type:";
            // 
            // cbCustomUploaderURLShortener
            // 
            this.cbCustomUploaderURLShortener.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderURLShortener.FormattingEnabled = true;
            this.cbCustomUploaderURLShortener.Location = new System.Drawing.Point(104, 460);
            this.cbCustomUploaderURLShortener.Name = "cbCustomUploaderURLShortener";
            this.cbCustomUploaderURLShortener.Size = new System.Drawing.Size(152, 21);
            this.cbCustomUploaderURLShortener.TabIndex = 32;
            this.cbCustomUploaderURLShortener.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderURLShortener_SelectedIndexChanged);
            // 
            // gbCustomUploaders
            // 
            this.gbCustomUploaders.Controls.Add(this.lbCustomUploaderList);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderRemove);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderClear);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderUpdate);
            this.gbCustomUploaders.Controls.Add(this.txtCustomUploaderName);
            this.gbCustomUploaders.Controls.Add(this.btnCustomUploaderAdd);
            this.gbCustomUploaders.Location = new System.Drawing.Point(8, 8);
            this.gbCustomUploaders.Name = "gbCustomUploaders";
            this.gbCustomUploaders.Size = new System.Drawing.Size(248, 360);
            this.gbCustomUploaders.TabIndex = 0;
            this.gbCustomUploaders.TabStop = false;
            this.gbCustomUploaders.Text = "Uploaders";
            // 
            // lbCustomUploaderList
            // 
            this.lbCustomUploaderList.FormattingEnabled = true;
            this.lbCustomUploaderList.IntegralHeight = false;
            this.lbCustomUploaderList.Location = new System.Drawing.Point(8, 72);
            this.lbCustomUploaderList.Name = "lbCustomUploaderList";
            this.lbCustomUploaderList.Size = new System.Drawing.Size(232, 248);
            this.lbCustomUploaderList.TabIndex = 4;
            this.lbCustomUploaderList.SelectedIndexChanged += new System.EventHandler(this.lbCustomUploaderList_SelectedIndexChanged);
            // 
            // btnCustomUploaderRemove
            // 
            this.btnCustomUploaderRemove.Location = new System.Drawing.Point(88, 40);
            this.btnCustomUploaderRemove.Name = "btnCustomUploaderRemove";
            this.btnCustomUploaderRemove.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderRemove.TabIndex = 2;
            this.btnCustomUploaderRemove.Text = "Remove";
            this.btnCustomUploaderRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRemove.Click += new System.EventHandler(this.btnCustomUploaderRemove_Click);
            // 
            // btnCustomUploaderClear
            // 
            this.btnCustomUploaderClear.Location = new System.Drawing.Point(152, 328);
            this.btnCustomUploaderClear.Name = "btnCustomUploaderClear";
            this.btnCustomUploaderClear.Size = new System.Drawing.Size(88, 24);
            this.btnCustomUploaderClear.TabIndex = 5;
            this.btnCustomUploaderClear.Text = "Clear fields ->";
            this.btnCustomUploaderClear.UseVisualStyleBackColor = true;
            this.btnCustomUploaderClear.Click += new System.EventHandler(this.btnCustomUploaderClear_Click);
            // 
            // btnCustomUploaderUpdate
            // 
            this.btnCustomUploaderUpdate.Location = new System.Drawing.Point(168, 40);
            this.btnCustomUploaderUpdate.Name = "btnCustomUploaderUpdate";
            this.btnCustomUploaderUpdate.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderUpdate.TabIndex = 3;
            this.btnCustomUploaderUpdate.Text = "Update";
            this.btnCustomUploaderUpdate.UseVisualStyleBackColor = true;
            this.btnCustomUploaderUpdate.Click += new System.EventHandler(this.btnCustomUploaderUpdate_Click);
            // 
            // txtCustomUploaderName
            // 
            this.txtCustomUploaderName.Location = new System.Drawing.Point(8, 16);
            this.txtCustomUploaderName.Name = "txtCustomUploaderName";
            this.txtCustomUploaderName.Size = new System.Drawing.Size(232, 20);
            this.txtCustomUploaderName.TabIndex = 0;
            // 
            // btnCustomUploaderAdd
            // 
            this.btnCustomUploaderAdd.Location = new System.Drawing.Point(8, 40);
            this.btnCustomUploaderAdd.Name = "btnCustomUploaderAdd";
            this.btnCustomUploaderAdd.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderAdd.TabIndex = 1;
            this.btnCustomUploaderAdd.Text = "Add";
            this.btnCustomUploaderAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderAdd.Click += new System.EventHandler(this.btnCustomUploaderAdd_Click);
            // 
            // lblCustomUploaderTextUploader
            // 
            this.lblCustomUploaderTextUploader.AutoSize = true;
            this.lblCustomUploaderTextUploader.Location = new System.Drawing.Point(16, 416);
            this.lblCustomUploaderTextUploader.Name = "lblCustomUploaderTextUploader";
            this.lblCustomUploaderTextUploader.Size = new System.Drawing.Size(75, 13);
            this.lblCustomUploaderTextUploader.TabIndex = 24;
            this.lblCustomUploaderTextUploader.Text = "Text uploader:";
            // 
            // lblCustomUploaderRequestURL
            // 
            this.lblCustomUploaderRequestURL.AutoSize = true;
            this.lblCustomUploaderRequestURL.Location = new System.Drawing.Point(272, 56);
            this.lblCustomUploaderRequestURL.Name = "lblCustomUploaderRequestURL";
            this.lblCustomUploaderRequestURL.Size = new System.Drawing.Size(75, 13);
            this.lblCustomUploaderRequestURL.TabIndex = 7;
            this.lblCustomUploaderRequestURL.Text = "Request URL:";
            // 
            // btnCustomUploaderURLShortenerTest
            // 
            this.btnCustomUploaderURLShortenerTest.Location = new System.Drawing.Point(264, 460);
            this.btnCustomUploaderURLShortenerTest.Name = "btnCustomUploaderURLShortenerTest";
            this.btnCustomUploaderURLShortenerTest.Size = new System.Drawing.Size(48, 24);
            this.btnCustomUploaderURLShortenerTest.TabIndex = 33;
            this.btnCustomUploaderURLShortenerTest.Text = "Test";
            this.btnCustomUploaderURLShortenerTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderURLShortenerTest.Click += new System.EventHandler(this.btnCustomUploaderURLShortenerTest_Click);
            // 
            // gbCustomUploaderRegexp
            // 
            this.gbCustomUploaderRegexp.Controls.Add(this.btnCustomUploaderRegexpEdit);
            this.gbCustomUploaderRegexp.Controls.Add(this.txtCustomUploaderRegexp);
            this.gbCustomUploaderRegexp.Controls.Add(this.lvCustomUploaderRegexps);
            this.gbCustomUploaderRegexp.Controls.Add(this.btnCustomUploaderRegexpRemove);
            this.gbCustomUploaderRegexp.Controls.Add(this.btnCustomUploaderRegexpAdd);
            this.gbCustomUploaderRegexp.Location = new System.Drawing.Point(536, 56);
            this.gbCustomUploaderRegexp.Name = "gbCustomUploaderRegexp";
            this.gbCustomUploaderRegexp.Size = new System.Drawing.Size(248, 184);
            this.gbCustomUploaderRegexp.TabIndex = 11;
            this.gbCustomUploaderRegexp.TabStop = false;
            this.gbCustomUploaderRegexp.Text = "Regex from response";
            // 
            // btnCustomUploaderRegexpEdit
            // 
            this.btnCustomUploaderRegexpEdit.Location = new System.Drawing.Point(168, 40);
            this.btnCustomUploaderRegexpEdit.Name = "btnCustomUploaderRegexpEdit";
            this.btnCustomUploaderRegexpEdit.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderRegexpEdit.TabIndex = 3;
            this.btnCustomUploaderRegexpEdit.Text = "Update";
            this.btnCustomUploaderRegexpEdit.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexpEdit.Click += new System.EventHandler(this.btnCustomUploaderRegexpEdit_Click);
            // 
            // txtCustomUploaderRegexp
            // 
            this.txtCustomUploaderRegexp.Location = new System.Drawing.Point(8, 16);
            this.txtCustomUploaderRegexp.Name = "txtCustomUploaderRegexp";
            this.txtCustomUploaderRegexp.Size = new System.Drawing.Size(232, 20);
            this.txtCustomUploaderRegexp.TabIndex = 0;
            // 
            // lvCustomUploaderRegexps
            // 
            this.lvCustomUploaderRegexps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvRegexpsColumn});
            this.lvCustomUploaderRegexps.FullRowSelect = true;
            this.lvCustomUploaderRegexps.GridLines = true;
            this.lvCustomUploaderRegexps.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCustomUploaderRegexps.HideSelection = false;
            this.lvCustomUploaderRegexps.Location = new System.Drawing.Point(8, 72);
            this.lvCustomUploaderRegexps.MultiSelect = false;
            this.lvCustomUploaderRegexps.Name = "lvCustomUploaderRegexps";
            this.lvCustomUploaderRegexps.Scrollable = false;
            this.lvCustomUploaderRegexps.Size = new System.Drawing.Size(232, 104);
            this.lvCustomUploaderRegexps.TabIndex = 4;
            this.lvCustomUploaderRegexps.UseCompatibleStateImageBehavior = false;
            this.lvCustomUploaderRegexps.View = System.Windows.Forms.View.Details;
            this.lvCustomUploaderRegexps.SelectedIndexChanged += new System.EventHandler(this.lvCustomUploaderRegexps_SelectedIndexChanged);
            // 
            // lvRegexpsColumn
            // 
            this.lvRegexpsColumn.Width = 227;
            // 
            // btnCustomUploaderRegexpRemove
            // 
            this.btnCustomUploaderRegexpRemove.Location = new System.Drawing.Point(88, 40);
            this.btnCustomUploaderRegexpRemove.Name = "btnCustomUploaderRegexpRemove";
            this.btnCustomUploaderRegexpRemove.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderRegexpRemove.TabIndex = 2;
            this.btnCustomUploaderRegexpRemove.Text = "Remove";
            this.btnCustomUploaderRegexpRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexpRemove.Click += new System.EventHandler(this.btnCustomUploaderRegexpRemove_Click);
            // 
            // btnCustomUploaderRegexpAdd
            // 
            this.btnCustomUploaderRegexpAdd.Location = new System.Drawing.Point(8, 40);
            this.btnCustomUploaderRegexpAdd.Name = "btnCustomUploaderRegexpAdd";
            this.btnCustomUploaderRegexpAdd.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderRegexpAdd.TabIndex = 1;
            this.btnCustomUploaderRegexpAdd.Text = "Add";
            this.btnCustomUploaderRegexpAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderRegexpAdd.Click += new System.EventHandler(this.btnCustomUploaderRegexpAdd_Click);
            // 
            // cbCustomUploaderTextUploader
            // 
            this.cbCustomUploaderTextUploader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderTextUploader.FormattingEnabled = true;
            this.cbCustomUploaderTextUploader.Location = new System.Drawing.Point(104, 412);
            this.cbCustomUploaderTextUploader.Name = "cbCustomUploaderTextUploader";
            this.cbCustomUploaderTextUploader.Size = new System.Drawing.Size(152, 21);
            this.cbCustomUploaderTextUploader.TabIndex = 25;
            this.cbCustomUploaderTextUploader.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderTextUploader_SelectedIndexChanged);
            // 
            // txtCustomUploaderThumbnailURL
            // 
            this.txtCustomUploaderThumbnailURL.Location = new System.Drawing.Point(536, 304);
            this.txtCustomUploaderThumbnailURL.Name = "txtCustomUploaderThumbnailURL";
            this.txtCustomUploaderThumbnailURL.Size = new System.Drawing.Size(248, 20);
            this.txtCustomUploaderThumbnailURL.TabIndex = 16;
            // 
            // lblCustomUploaderURLShortener
            // 
            this.lblCustomUploaderURLShortener.AutoSize = true;
            this.lblCustomUploaderURLShortener.Location = new System.Drawing.Point(16, 464);
            this.lblCustomUploaderURLShortener.Name = "lblCustomUploaderURLShortener";
            this.lblCustomUploaderURLShortener.Size = new System.Drawing.Size(79, 13);
            this.lblCustomUploaderURLShortener.TabIndex = 30;
            this.lblCustomUploaderURLShortener.Text = "URL shortener:";
            // 
            // cbCustomUploaderResponseType
            // 
            this.cbCustomUploaderResponseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderResponseType.FormattingEnabled = true;
            this.cbCustomUploaderResponseType.Location = new System.Drawing.Point(536, 24);
            this.cbCustomUploaderResponseType.Name = "cbCustomUploaderResponseType";
            this.cbCustomUploaderResponseType.Size = new System.Drawing.Size(144, 21);
            this.cbCustomUploaderResponseType.TabIndex = 5;
            // 
            // btnCustomUploaderTextUploaderTest
            // 
            this.btnCustomUploaderTextUploaderTest.Location = new System.Drawing.Point(264, 412);
            this.btnCustomUploaderTextUploaderTest.Name = "btnCustomUploaderTextUploaderTest";
            this.btnCustomUploaderTextUploaderTest.Size = new System.Drawing.Size(48, 24);
            this.btnCustomUploaderTextUploaderTest.TabIndex = 26;
            this.btnCustomUploaderTextUploaderTest.Text = "Test";
            this.btnCustomUploaderTextUploaderTest.UseVisualStyleBackColor = true;
            this.btnCustomUploaderTextUploaderTest.Click += new System.EventHandler(this.btnCustomUploaderTextUploaderTest_Click);
            // 
            // txtCustomUploaderURL
            // 
            this.txtCustomUploaderURL.Location = new System.Drawing.Point(536, 264);
            this.txtCustomUploaderURL.Name = "txtCustomUploaderURL";
            this.txtCustomUploaderURL.Size = new System.Drawing.Size(248, 20);
            this.txtCustomUploaderURL.TabIndex = 14;
            // 
            // cbCustomUploaderImageUploader
            // 
            this.cbCustomUploaderImageUploader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderImageUploader.FormattingEnabled = true;
            this.cbCustomUploaderImageUploader.Location = new System.Drawing.Point(104, 388);
            this.cbCustomUploaderImageUploader.Name = "cbCustomUploaderImageUploader";
            this.cbCustomUploaderImageUploader.Size = new System.Drawing.Size(152, 21);
            this.cbCustomUploaderImageUploader.TabIndex = 22;
            this.cbCustomUploaderImageUploader.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderImageUploader_SelectedIndexChanged);
            // 
            // txtCustomUploaderRequestURL
            // 
            this.txtCustomUploaderRequestURL.Location = new System.Drawing.Point(272, 72);
            this.txtCustomUploaderRequestURL.Name = "txtCustomUploaderRequestURL";
            this.txtCustomUploaderRequestURL.Size = new System.Drawing.Size(248, 20);
            this.txtCustomUploaderRequestURL.TabIndex = 8;
            // 
            // txtCustomUploaderLog
            // 
            this.txtCustomUploaderLog.Location = new System.Drawing.Point(328, 408);
            this.txtCustomUploaderLog.Name = "txtCustomUploaderLog";
            this.txtCustomUploaderLog.Size = new System.Drawing.Size(456, 80);
            this.txtCustomUploaderLog.TabIndex = 31;
            this.txtCustomUploaderLog.Text = "";
            this.txtCustomUploaderLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtCustomUploaderLog_LinkClicked);
            // 
            // lblCustomUploaderThumbnailURL
            // 
            this.lblCustomUploaderThumbnailURL.AutoSize = true;
            this.lblCustomUploaderThumbnailURL.Location = new System.Drawing.Point(536, 288);
            this.lblCustomUploaderThumbnailURL.Name = "lblCustomUploaderThumbnailURL";
            this.lblCustomUploaderThumbnailURL.Size = new System.Drawing.Size(84, 13);
            this.lblCustomUploaderThumbnailURL.TabIndex = 15;
            this.lblCustomUploaderThumbnailURL.Text = "Thumbnail URL:";
            // 
            // lblCustomUploaderFileForm
            // 
            this.lblCustomUploaderFileForm.AutoSize = true;
            this.lblCustomUploaderFileForm.Location = new System.Drawing.Point(272, 96);
            this.lblCustomUploaderFileForm.Name = "lblCustomUploaderFileForm";
            this.lblCustomUploaderFileForm.Size = new System.Drawing.Size(78, 13);
            this.lblCustomUploaderFileForm.TabIndex = 9;
            this.lblCustomUploaderFileForm.Text = "File form name:";
            // 
            // lblCustomUploaderRequestType
            // 
            this.lblCustomUploaderRequestType.AutoSize = true;
            this.lblCustomUploaderRequestType.Location = new System.Drawing.Point(272, 8);
            this.lblCustomUploaderRequestType.Name = "lblCustomUploaderRequestType";
            this.lblCustomUploaderRequestType.Size = new System.Drawing.Size(73, 13);
            this.lblCustomUploaderRequestType.TabIndex = 1;
            this.lblCustomUploaderRequestType.Text = "Request type:";
            // 
            // cbCustomUploaderRequestType
            // 
            this.cbCustomUploaderRequestType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomUploaderRequestType.FormattingEnabled = true;
            this.cbCustomUploaderRequestType.Location = new System.Drawing.Point(272, 24);
            this.cbCustomUploaderRequestType.Name = "cbCustomUploaderRequestType";
            this.cbCustomUploaderRequestType.Size = new System.Drawing.Size(144, 21);
            this.cbCustomUploaderRequestType.TabIndex = 3;
            this.cbCustomUploaderRequestType.SelectedIndexChanged += new System.EventHandler(this.cbCustomUploaderRequestType_SelectedIndexChanged);
            // 
            // txtCustomUploaderFileForm
            // 
            this.txtCustomUploaderFileForm.Location = new System.Drawing.Point(272, 112);
            this.txtCustomUploaderFileForm.Name = "txtCustomUploaderFileForm";
            this.txtCustomUploaderFileForm.Size = new System.Drawing.Size(248, 20);
            this.txtCustomUploaderFileForm.TabIndex = 10;
            // 
            // lblCustomUploaderURL
            // 
            this.lblCustomUploaderURL.AutoSize = true;
            this.lblCustomUploaderURL.Location = new System.Drawing.Point(536, 248);
            this.lblCustomUploaderURL.Name = "lblCustomUploaderURL";
            this.lblCustomUploaderURL.Size = new System.Drawing.Size(32, 13);
            this.lblCustomUploaderURL.TabIndex = 13;
            this.lblCustomUploaderURL.Text = "URL:";
            // 
            // gbCustomUploaderArguments
            // 
            this.gbCustomUploaderArguments.Controls.Add(this.btnCustomUploaderArgEdit);
            this.gbCustomUploaderArguments.Controls.Add(this.txtCustomUploaderArgValue);
            this.gbCustomUploaderArguments.Controls.Add(this.btnCustomUploaderArgRemove);
            this.gbCustomUploaderArguments.Controls.Add(this.lvCustomUploaderArguments);
            this.gbCustomUploaderArguments.Controls.Add(this.btnCustomUploaderArgAdd);
            this.gbCustomUploaderArguments.Controls.Add(this.txtCustomUploaderArgName);
            this.gbCustomUploaderArguments.Location = new System.Drawing.Point(272, 136);
            this.gbCustomUploaderArguments.Name = "gbCustomUploaderArguments";
            this.gbCustomUploaderArguments.Size = new System.Drawing.Size(248, 232);
            this.gbCustomUploaderArguments.TabIndex = 12;
            this.gbCustomUploaderArguments.TabStop = false;
            this.gbCustomUploaderArguments.Text = "Arguments";
            // 
            // btnCustomUploaderArgEdit
            // 
            this.btnCustomUploaderArgEdit.Location = new System.Drawing.Point(168, 40);
            this.btnCustomUploaderArgEdit.Name = "btnCustomUploaderArgEdit";
            this.btnCustomUploaderArgEdit.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderArgEdit.TabIndex = 4;
            this.btnCustomUploaderArgEdit.Text = "Update";
            this.btnCustomUploaderArgEdit.UseVisualStyleBackColor = true;
            this.btnCustomUploaderArgEdit.Click += new System.EventHandler(this.btnCustomUploaderArgEdit_Click);
            // 
            // txtCustomUploaderArgValue
            // 
            this.txtCustomUploaderArgValue.Location = new System.Drawing.Point(128, 16);
            this.txtCustomUploaderArgValue.Name = "txtCustomUploaderArgValue";
            this.txtCustomUploaderArgValue.Size = new System.Drawing.Size(112, 20);
            this.txtCustomUploaderArgValue.TabIndex = 1;
            // 
            // btnCustomUploaderArgRemove
            // 
            this.btnCustomUploaderArgRemove.Location = new System.Drawing.Point(88, 40);
            this.btnCustomUploaderArgRemove.Name = "btnCustomUploaderArgRemove";
            this.btnCustomUploaderArgRemove.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderArgRemove.TabIndex = 3;
            this.btnCustomUploaderArgRemove.Text = "Remove";
            this.btnCustomUploaderArgRemove.UseVisualStyleBackColor = true;
            this.btnCustomUploaderArgRemove.Click += new System.EventHandler(this.btnCustomUploaderArgRemove_Click);
            // 
            // lvCustomUploaderArguments
            // 
            this.lvCustomUploaderArguments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvCustomUploaderArguments.FullRowSelect = true;
            this.lvCustomUploaderArguments.GridLines = true;
            this.lvCustomUploaderArguments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCustomUploaderArguments.HideSelection = false;
            this.lvCustomUploaderArguments.Location = new System.Drawing.Point(8, 72);
            this.lvCustomUploaderArguments.MultiSelect = false;
            this.lvCustomUploaderArguments.Name = "lvCustomUploaderArguments";
            this.lvCustomUploaderArguments.Size = new System.Drawing.Size(232, 152);
            this.lvCustomUploaderArguments.TabIndex = 5;
            this.lvCustomUploaderArguments.UseCompatibleStateImageBehavior = false;
            this.lvCustomUploaderArguments.View = System.Windows.Forms.View.Details;
            this.lvCustomUploaderArguments.SelectedIndexChanged += new System.EventHandler(this.lvCustomUploaderArguments_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 113;
            // 
            // btnCustomUploaderArgAdd
            // 
            this.btnCustomUploaderArgAdd.Location = new System.Drawing.Point(8, 40);
            this.btnCustomUploaderArgAdd.Name = "btnCustomUploaderArgAdd";
            this.btnCustomUploaderArgAdd.Size = new System.Drawing.Size(72, 24);
            this.btnCustomUploaderArgAdd.TabIndex = 2;
            this.btnCustomUploaderArgAdd.Text = "Add";
            this.btnCustomUploaderArgAdd.UseVisualStyleBackColor = true;
            this.btnCustomUploaderArgAdd.Click += new System.EventHandler(this.btnCustomUploaderArgAdd_Click);
            // 
            // txtCustomUploaderArgName
            // 
            this.txtCustomUploaderArgName.Location = new System.Drawing.Point(8, 16);
            this.txtCustomUploaderArgName.Name = "txtCustomUploaderArgName";
            this.txtCustomUploaderArgName.Size = new System.Drawing.Size(112, 20);
            this.txtCustomUploaderArgName.TabIndex = 0;
            // 
            // txtRapidSharePremiumUserName
            // 
            this.txtRapidSharePremiumUserName.Location = new System.Drawing.Point(88, 84);
            this.txtRapidSharePremiumUserName.Name = "txtRapidSharePremiumUserName";
            this.txtRapidSharePremiumUserName.Size = new System.Drawing.Size(120, 20);
            this.txtRapidSharePremiumUserName.TabIndex = 11;
            // 
            // ttHelpTip
            // 
            this.ttHelpTip.AutomaticDelay = 0;
            this.ttHelpTip.AutoPopDelay = 30000;
            this.ttHelpTip.BackColor = System.Drawing.Color.White;
            this.ttHelpTip.InitialDelay = 10;
            this.ttHelpTip.IsBalloon = true;
            this.ttHelpTip.ReshowDelay = 10;
            this.ttHelpTip.ShowAlways = true;
            this.ttHelpTip.UseAnimation = false;
            this.ttHelpTip.UseFading = false;
            // 
            // actRapidShareAccountType
            // 
            this.actRapidShareAccountType.Location = new System.Drawing.Point(8, 16);
            this.actRapidShareAccountType.Name = "actRapidShareAccountType";
            this.actRapidShareAccountType.SelectedAccountType = UploadersLib.AccountType.Anonymous;
            this.actRapidShareAccountType.Size = new System.Drawing.Size(214, 29);
            this.actRapidShareAccountType.TabIndex = 16;
            // 
            // UploadersConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 539);
            this.Controls.Add(this.tcUploaders);
            this.MinimumSize = new System.Drawing.Size(840, 572);
            this.Name = "UploadersConfigForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outputs Configuration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UploadersConfigForm_FormClosed);
            this.Resize += new System.EventHandler(this.UploadersConfigForm_Resize);
            this.tcUploaders.ResumeLayout(false);
            this.tpImageUploaders.ResumeLayout(false);
            this.tcImageUploaders.ResumeLayout(false);
            this.tpImageShack.ResumeLayout(false);
            this.tpImageShack.PerformLayout();
            this.tpTinyPic.ResumeLayout(false);
            this.tpTinyPic.PerformLayout();
            this.tpImgur.ResumeLayout(false);
            this.tpImgur.PerformLayout();
            this.tpFlickr.ResumeLayout(false);
            this.tpPhotobucket.ResumeLayout(false);
            this.gbPhotobucketAlbumPath.ResumeLayout(false);
            this.gbPhotobucketAlbumPath.PerformLayout();
            this.gbPhotobucketAlbums.ResumeLayout(false);
            this.gbPhotobucketAlbums.PerformLayout();
            this.gbPhotobucketUserAccount.ResumeLayout(false);
            this.gbPhotobucketUserAccount.PerformLayout();
            this.tpTwitPic.ResumeLayout(false);
            this.tpTwitPic.PerformLayout();
            this.tpTwitSnaps.ResumeLayout(false);
            this.tpTwitSnaps.PerformLayout();
            this.tpYFrog.ResumeLayout(false);
            this.tpYFrog.PerformLayout();
            this.tpPicasa.ResumeLayout(false);
            this.tpPicasa.PerformLayout();
            this.tpTextUploaders.ResumeLayout(false);
            this.tcTextUploaders.ResumeLayout(false);
            this.tpPastebin.ResumeLayout(false);
            this.tpPaste_ee.ResumeLayout(false);
            this.tpPaste_ee.PerformLayout();
            this.tpFileUploaders.ResumeLayout(false);
            this.tcFileUploaders.ResumeLayout(false);
            this.tpDropbox.ResumeLayout(false);
            this.tpDropbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDropboxLogo)).EndInit();
            this.tpMega.ResumeLayout(false);
            this.tpMega.PerformLayout();
            this.pnlMegaLogin.ResumeLayout(false);
            this.pnlMegaLogin.PerformLayout();
            this.tpFTP.ResumeLayout(false);
            this.tlpFtp.ResumeLayout(false);
            this.panelFtp.ResumeLayout(false);
            this.panelFtp.PerformLayout();
            this.gbFtpSettings.ResumeLayout(false);
            this.gbFtpSettings.PerformLayout();
            this.tpBox.ResumeLayout(false);
            this.tpBox.PerformLayout();
            this.tpRapidShare.ResumeLayout(false);
            this.tpRapidShare.PerformLayout();
            this.tpSendSpace.ResumeLayout(false);
            this.tpSendSpace.PerformLayout();
            this.tpGe_tt.ResumeLayout(false);
            this.tpGe_tt.PerformLayout();
            this.tpHostr.ResumeLayout(false);
            this.tpHostr.PerformLayout();
            this.tpJira.ResumeLayout(false);
            this.tpJira.PerformLayout();
            this.gpJiraServer.ResumeLayout(false);
            this.gpJiraServer.PerformLayout();
            this.tpGoogleDrive.ResumeLayout(false);
            this.tpMinus.ResumeLayout(false);
            this.gbMinusUserPass.ResumeLayout(false);
            this.gbMinusUserPass.PerformLayout();
            this.gbMinusUpload.ResumeLayout(false);
            this.gbMinusUpload.PerformLayout();
            this.tpEmail.ResumeLayout(false);
            this.tpEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmailSmtpPort)).EndInit();
            this.tpSharedFolder.ResumeLayout(false);
            this.tlpSharedFolders.ResumeLayout(false);
            this.gbSharedFolder.ResumeLayout(false);
            this.gbSharedFolder.PerformLayout();
            this.tpURLShorteners.ResumeLayout(false);
            this.tcURLShorteners.ResumeLayout(false);
            this.tpGoogleURLShortener.ResumeLayout(false);
            this.tpSocialNetworkingServices.ResumeLayout(false);
            this.tcSocialNetworkingServices.ResumeLayout(false);
            this.tpTwitter.ResumeLayout(false);
            this.tpCustomUploaders.ResumeLayout(false);
            this.tpCustomUploaders.PerformLayout();
            this.gbCustomUploaders.ResumeLayout(false);
            this.gbCustomUploaders.PerformLayout();
            this.gbCustomUploaderRegexp.ResumeLayout(false);
            this.gbCustomUploaderRegexp.PerformLayout();
            this.gbCustomUploaderArguments.ResumeLayout(false);
            this.gbCustomUploaderArguments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpImageUploaders;
        private System.Windows.Forms.TabPage tpTextUploaders;
        private System.Windows.Forms.TabPage tpURLShorteners;
        private System.Windows.Forms.TabPage tpSocialNetworkingServices;
        private System.Windows.Forms.TabControl tcImageUploaders;
        private System.Windows.Forms.TabPage tpImageShack;
        private System.Windows.Forms.TabPage tpTinyPic;
        private System.Windows.Forms.TabPage tpImgur;
        private System.Windows.Forms.TabPage tpFlickr;
        private System.Windows.Forms.TabPage tpTwitPic;
        private System.Windows.Forms.TabPage tpTwitSnaps;
        private System.Windows.Forms.Label lblTwitSnapsTip;
        private System.Windows.Forms.TabPage tpYFrog;
        private System.Windows.Forms.TabPage tpRapidShare;
        private System.Windows.Forms.TabPage tpDropbox;
        private System.Windows.Forms.TabPage tpSendSpace;
        private System.Windows.Forms.TabControl tcTextUploaders;
        private System.Windows.Forms.TabPage tpPastebin;
        private System.Windows.Forms.TabControl tcURLShorteners;
        private System.Windows.Forms.TabPage tpGoogleURLShortener;
        private System.Windows.Forms.TabControl tcSocialNetworkingServices;
        private System.Windows.Forms.TabPage tpTwitter;
        internal System.Windows.Forms.Button btnImageShackOpenPublicProfile;
        internal System.Windows.Forms.CheckBox cbImageShackIsPublic;
        internal System.Windows.Forms.Button btnImageShackOpenMyImages;
        internal System.Windows.Forms.Label lblImageShackUsername;
        internal System.Windows.Forms.Button btnImageShackOpenRegistrationCode;
        internal System.Windows.Forms.TextBox txtImageShackUsername;
        internal System.Windows.Forms.TextBox txtImageShackRegistrationCode;
        internal System.Windows.Forms.Label lblImageShackRegistrationCode;
        internal System.Windows.Forms.Button btnTinyPicOpenMyImages;
        internal System.Windows.Forms.CheckBox cbTinyPicRememberUsernamePassword;
        internal System.Windows.Forms.Label lblTinyPicRegistrationCode;
        internal System.Windows.Forms.TextBox txtTinyPicRegistrationCode;
        private System.Windows.Forms.TextBox txtTinyPicPassword;
        private System.Windows.Forms.Label lblTinyPicPassword;
        private System.Windows.Forms.TextBox txtTinyPicUsername;
        private System.Windows.Forms.Label lblTinyPicUsername;
        private System.Windows.Forms.Button btnTinyPicLogin;
        private System.Windows.Forms.Button btnDropboxCompleteAuth;
        private System.Windows.Forms.PictureBox pbDropboxLogo;
        private System.Windows.Forms.Button btnDropboxRegister;
        private System.Windows.Forms.Label lblDropboxPathTip;
        private System.Windows.Forms.Label lblDropboxPath;
        private System.Windows.Forms.Button btnDropboxOpenAuthorize;
        private System.Windows.Forms.TextBox txtDropboxPath;
        private System.Windows.Forms.TableLayoutPanel tlpFtp;
        private System.Windows.Forms.GroupBox gbFtpSettings;
        private System.Windows.Forms.Label lblFtpFiles;
        private System.Windows.Forms.Label lblFtpText;
        private System.Windows.Forms.Label lblFtpImages;
        private System.Windows.Forms.ComboBox cboFtpFiles;
        private System.Windows.Forms.ComboBox cboFtpText;
        private System.Windows.Forms.ComboBox cboFtpImages;
        private System.Windows.Forms.Panel panelFtp;
        private AccountsControl ucFTPAccounts;
        private System.Windows.Forms.Button btnFtpHelp;
        internal System.Windows.Forms.Button btnFTPExport;
        internal System.Windows.Forms.Button btnFTPImport;
        private System.Windows.Forms.Label lblRapidSharePassword;
        private System.Windows.Forms.Label lblRapidSharePremiumUsername;
        private System.Windows.Forms.TextBox txtRapidSharePassword;
        private System.Windows.Forms.TextBox txtRapidShareUsername;
        private System.Windows.Forms.Button btnSendSpaceRegister;
        private System.Windows.Forms.Label lblSendSpacePassword;
        private System.Windows.Forms.Label lblSendSpaceUsername;
        private System.Windows.Forms.TextBox txtSendSpacePassword;
        private System.Windows.Forms.TextBox txtSendSpaceUserName;
        private System.Windows.Forms.PropertyGrid pgPastebinSettings;
        private System.Windows.Forms.Button btnPastebinLogin;
        internal AccountsControl ucLocalhostAccounts;
        private System.Windows.Forms.Button btnFlickrOpenImages;
        private System.Windows.Forms.PropertyGrid pgFlickrAuthInfo;
        private System.Windows.Forms.PropertyGrid pgFlickrSettings;
        private System.Windows.Forms.Button btnFlickrCheckToken;
        private System.Windows.Forms.Button btnFlickrCompleteAuth;
        private System.Windows.Forms.Button btnFlickrOpenAuthorize;
        private System.Windows.Forms.Button btnTwitterLogin;
        private AccountsControl ucTwitterAccounts;
        internal System.Windows.Forms.RichTextBox txtCustomUploaderLog;
        internal System.Windows.Forms.Button btnCustomUploaderImageUploaderTest;
        internal System.Windows.Forms.TextBox txtCustomUploaderURL;
        internal System.Windows.Forms.TextBox txtCustomUploaderThumbnailURL;
        internal System.Windows.Forms.Label lblCustomUploaderURL;
        internal System.Windows.Forms.Label lblCustomUploaderThumbnailURL;
        internal System.Windows.Forms.GroupBox gbCustomUploaders;
        internal System.Windows.Forms.ListBox lbCustomUploaderList;
        internal System.Windows.Forms.Button btnCustomUploaderClear;
        internal System.Windows.Forms.Button btnCustomUploaderRemove;
        internal System.Windows.Forms.Button btnCustomUploaderUpdate;
        internal System.Windows.Forms.TextBox txtCustomUploaderName;
        internal System.Windows.Forms.Button btnCustomUploaderAdd;
        internal System.Windows.Forms.GroupBox gbCustomUploaderRegexp;
        internal System.Windows.Forms.Button btnCustomUploaderRegexpEdit;
        internal System.Windows.Forms.TextBox txtCustomUploaderRegexp;
        internal System.Windows.Forms.ListView lvCustomUploaderRegexps;
        internal System.Windows.Forms.ColumnHeader lvRegexpsColumn;
        internal System.Windows.Forms.Button btnCustomUploaderRegexpRemove;
        internal System.Windows.Forms.Button btnCustomUploaderRegexpAdd;
        internal System.Windows.Forms.TextBox txtCustomUploaderFileForm;
        internal System.Windows.Forms.Label lblCustomUploaderFileForm;
        internal System.Windows.Forms.Label lblCustomUploaderRequestURL;
        internal System.Windows.Forms.TextBox txtCustomUploaderRequestURL;
        internal System.Windows.Forms.GroupBox gbCustomUploaderArguments;
        internal System.Windows.Forms.Button btnCustomUploaderArgEdit;
        internal System.Windows.Forms.TextBox txtCustomUploaderArgValue;
        internal System.Windows.Forms.Button btnCustomUploaderArgRemove;
        internal System.Windows.Forms.ListView lvCustomUploaderArguments;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.Button btnCustomUploaderArgAdd;
        internal System.Windows.Forms.TextBox txtCustomUploaderArgName;
        private System.Windows.Forms.CheckBox chkTwitPicShowFull;
        private System.Windows.Forms.ComboBox cboTwitPicThumbnailMode;
        private System.Windows.Forms.Label lblTwitPicThumbnailMode;
        private System.Windows.Forms.Button btnDropboxShowFiles;
        private System.Windows.Forms.Label lblDropboxStatus;
        private System.Windows.Forms.Label lblYFrogPassword;
        private System.Windows.Forms.Label lblYFrogUsername;
        private System.Windows.Forms.TextBox txtYFrogPassword;
        private System.Windows.Forms.TextBox txtYFrogUsername;
        private GUI.AccountTypeControl atcImageShackAccountType;
        private GUI.AccountTypeControl atcTinyPicAccountType;
        private GUI.AccountTypeControl atcImgurAccountType;
        private GUI.AccountTypeControl atcSendSpaceAccountType;
        private System.Windows.Forms.TextBox txtRapidSharePremiumUserName;
        private GUI.AccountTypeControl actRapidShareAccountType;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.Label lblEmailPassword;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.NumericUpDown nudEmailSmtpPort;
        private System.Windows.Forms.Label lblEmailSmtpPort;
        private System.Windows.Forms.TextBox txtEmailSmtpServer;
        private System.Windows.Forms.Label lblEmailSmtpServer;
        private System.Windows.Forms.TextBox txtEmailDefaultBody;
        private System.Windows.Forms.Label lblEmailDefaultBody;
        private System.Windows.Forms.TextBox txtEmailDefaultSubject;
        private System.Windows.Forms.Label lblEmailDefaultSubject;
        private System.Windows.Forms.CheckBox cbEmailRememberLastTo;
        public System.Windows.Forms.TabControl tcUploaders;
        public System.Windows.Forms.TabControl tcFileUploaders;
        public System.Windows.Forms.TabPage tpFTP;
        public System.Windows.Forms.TabPage tpFileUploaders;
        private System.Windows.Forms.ComboBox cbImgurThumbnailType;
        private System.Windows.Forms.Label lblImgurThumbnailType;
        private GUI.AccountTypeControl atcGoogleURLShortenerAccountType;
        private System.Windows.Forms.TabPage tpPhotobucket;
        private System.Windows.Forms.GroupBox gbPhotobucketUserAccount;
        private System.Windows.Forms.Button btnPhotobucketAuthOpen;
        private System.Windows.Forms.Label lblPhotobucketVerificationCode;
        private System.Windows.Forms.Button btnPhotobucketAuthComplete;
        private System.Windows.Forms.TextBox txtPhotobucketVerificationCode;
        private System.Windows.Forms.Label lblPhotobucketAccountStatus;
        private System.Windows.Forms.GroupBox gbPhotobucketAlbums;
        private System.Windows.Forms.TextBox txtPhotobucketDefaultAlbumName;
        private System.Windows.Forms.Button btnPhotobucketCreateAlbum;
        private System.Windows.Forms.GroupBox gbPhotobucketAlbumPath;
        private System.Windows.Forms.ComboBox cboPhotobucketAlbumPaths;
        private System.Windows.Forms.Label lblPhotobucketNewAlbumName;
        private System.Windows.Forms.Label lblPhotobucketParentAlbumPath;
        private System.Windows.Forms.TextBox txtPhotobucketNewAlbumName;
        private System.Windows.Forms.TextBox txtPhotobucketParentAlbumPath;
        private System.Windows.Forms.Label lblPhotobucketDefaultAlbumName;
        private System.Windows.Forms.Button btnPhotobucketRemoveAlbum;
        private System.Windows.Forms.Button btnPhotobucketAddAlbum;
        private System.Windows.Forms.TabPage tpMinus;
        private System.Windows.Forms.Label lblMinusAuthStatus;
        private System.Windows.Forms.Button btnMinusAuth;
        private System.Windows.Forms.Label lblMinusPassword;
        private System.Windows.Forms.Label lblMinusUsername;
        private System.Windows.Forms.TextBox txtMinusPassword;
        private System.Windows.Forms.TextBox txtMinusUsername;
        private System.Windows.Forms.GroupBox gbMinusUpload;
        private System.Windows.Forms.Button btnMinusFolderAdd;
        private System.Windows.Forms.Button btnMinusFolderRemove;
        private System.Windows.Forms.ComboBox cboMinusFolders;
        private System.Windows.Forms.CheckBox chkMinusPublic;
        private System.Windows.Forms.Button btnMinusReadFolderList;
        private System.Windows.Forms.Button btnAuthRefresh;
        private System.Windows.Forms.GroupBox gbMinusUserPass;
        private System.Windows.Forms.CheckBox chkEmailConfirm;
        private System.Windows.Forms.TableLayoutPanel tlpSharedFolders;
        private System.Windows.Forms.GroupBox gbSharedFolder;
        private System.Windows.Forms.Label lblSharedFolderFiles;
        private System.Windows.Forms.Label lblSharedFolderText;
        private System.Windows.Forms.Label lblSharedFolderImages;
        private System.Windows.Forms.ComboBox cboSharedFolderFiles;
        private System.Windows.Forms.ComboBox cboSharedFolderText;
        private System.Windows.Forms.ComboBox cboSharedFolderImages;
        private System.Windows.Forms.Button btnRapidShareRefreshFolders;
        private System.Windows.Forms.TreeView tvRapidShareFolders;
        private System.Windows.Forms.TextBox txtRapidShareFolderID;
        private System.Windows.Forms.Label lblRapidShareFolderID;
        private System.Windows.Forms.TabPage tpBox;
        private System.Windows.Forms.Button btnBoxCompleteAuth;
        private System.Windows.Forms.Button btnBoxOpenAuthorize;
        private System.Windows.Forms.TextBox txtBoxFolderID;
        private System.Windows.Forms.Label lblBoxFolderID;
        private System.Windows.Forms.Button btnBoxRefreshFolders;
        private System.Windows.Forms.TreeView tvBoxFolders;
        private System.Windows.Forms.CheckBox cbDropboxAutoCreateShareableLink;
        private System.Windows.Forms.Label lblTwitPicTip;
        private System.Windows.Forms.TabPage tpSharedFolder;
        private System.Windows.Forms.TabPage tpEmail;
        private System.Windows.Forms.TabPage tpPaste_ee;
        private System.Windows.Forms.Label lblPaste_eeUserAPIKey;
        private System.Windows.Forms.TextBox txtPaste_eeUserAPIKey;
        private System.Windows.Forms.TabPage tpGe_tt;
        private System.Windows.Forms.Label lblGe_ttAccessToken;
        private System.Windows.Forms.Label lblGe_ttPassword;
        private System.Windows.Forms.Label lblGe_ttEmail;
        private System.Windows.Forms.Button btnGe_ttLogin;
        private System.Windows.Forms.TextBox txtGe_ttPassword;
        private System.Windows.Forms.TextBox txtGe_ttEmail;
        private System.Windows.Forms.TabPage tpPicasa;
        private System.Windows.Forms.Button btnFtpClient;
        private System.Windows.Forms.Label lblMinusURLType;
        private System.Windows.Forms.ComboBox cbMinusURLType;
        internal System.Windows.Forms.Button btnCustomUploaderTextUploaderTest;
        internal System.Windows.Forms.Button btnCustomUploaderFileUploaderTest;
        internal System.Windows.Forms.Button btnCustomUploaderURLShortenerTest;
        private System.Windows.Forms.Label lblCustomUploaderURLShortener;
        private System.Windows.Forms.Label lblCustomUploaderFileUploader;
        private System.Windows.Forms.Label lblCustomUploaderTextUploader;
        private System.Windows.Forms.Label lblCustomUploaderImageUploader;
        private System.Windows.Forms.ComboBox cbCustomUploaderURLShortener;
        private System.Windows.Forms.ComboBox cbCustomUploaderFileUploader;
        private System.Windows.Forms.ComboBox cbCustomUploaderTextUploader;
        private System.Windows.Forms.ComboBox cbCustomUploaderImageUploader;
        private System.Windows.Forms.Label lblCustomUploaderResponseType;
        private System.Windows.Forms.ComboBox cbCustomUploaderResponseType;
        private System.Windows.Forms.Label lblCustomUploaderRequestType;
        private System.Windows.Forms.ComboBox cbCustomUploaderRequestType;
        private System.Windows.Forms.TabPage tpCustomUploaders;
        internal System.Windows.Forms.TextBox txtCustomUploaderDeletionURL;
        internal System.Windows.Forms.Label lblCustomUploaderDeletionURL;
        private System.Windows.Forms.Label lblCustomUploaderTestResult;
        private System.Windows.Forms.Button btnCustomUploaderShowLastResponse;
        private System.Windows.Forms.ToolTip ttHelpTip;
        private System.Windows.Forms.Label lblCustomUploaderRequestTypeHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpHostr;
        private System.Windows.Forms.Label lblLocalhostrPassword;
        private System.Windows.Forms.Label lblLocalhostrEmail;
        private System.Windows.Forms.TextBox txtLocalhostrPassword;
        private System.Windows.Forms.TextBox txtLocalhostrEmail;
        private System.Windows.Forms.CheckBox cbLocalhostrDirectURL;
        private System.Windows.Forms.Button btnImgurRefreshAlbumList;
        private System.Windows.Forms.TextBox txtImgurAlbumID;
        private System.Windows.Forms.Label lblImgurAlbumID;
        private System.Windows.Forms.ListView lvImgurAlbumList;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.TabPage tpGoogleDrive;
        private GUI.OAuth2Control oauth2GoogleDrive;
        private GUI.OAuth2Control oauth2Imgur;
        private GUI.OAuth2Control oauth2GoogleURLShortener;
        private GUI.OAuth2Control oauth2Picasa;
        private System.Windows.Forms.ListView lvPicasaAlbumList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnPicasaRefreshAlbumList;
        private System.Windows.Forms.TextBox txtPicasaAlbumID;
        private System.Windows.Forms.Label lblPicasaAlbumID;
        private System.Windows.Forms.TabPage tpJira;
        private GUI.OAuth2Control oAuthJira;
        private System.Windows.Forms.TextBox txtJiraHost;
        private System.Windows.Forms.Label lblJiraHost;
        private System.Windows.Forms.GroupBox gpJiraServer;
        private System.Windows.Forms.TextBox txtJiraConfigHelp;
        private System.Windows.Forms.TextBox txtJiraIssuePrefix;
        private System.Windows.Forms.Label lblJiraIssuePrefix;
        private System.Windows.Forms.CheckBox cbDropboxShortURL;
        private System.Windows.Forms.TabPage tpMega;
        private System.Windows.Forms.Label lblMegaPassword;
        private System.Windows.Forms.Label lblMegaEmail;
        private System.Windows.Forms.Button btnMegaLogin;
        private System.Windows.Forms.TextBox txtMegaPassword;
        private System.Windows.Forms.TextBox txtMegaEmail;
        private System.Windows.Forms.Panel pnlMegaLogin;
        private System.Windows.Forms.Label lblMegaFolder;
        private System.Windows.Forms.ComboBox cbMegaFolder;
        private System.Windows.Forms.Label lblMegaStatusTitle;
        private System.Windows.Forms.Label lblMegaStatus;
        private GUI.AccountTypeControl atcMegaAccountType;
        private System.Windows.Forms.Button btnMegaRegister;
        private System.Windows.Forms.Button btnMegaRefreshFolders;
    }
}