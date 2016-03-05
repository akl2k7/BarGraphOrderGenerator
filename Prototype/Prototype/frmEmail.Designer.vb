<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtbxCustomerEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtbxEmployeeEmail = New System.Windows.Forms.TextBox()
        Me.rtxtbxEmailBody = New System.Windows.Forms.RichTextBox()
        Me.lblCustomerEmailAddress = New System.Windows.Forms.Label()
        Me.lblEmployeeEmail = New System.Windows.Forms.Label()
        Me.lblEmailBody = New System.Windows.Forms.Label()
        Me.txtbxEmailSubject = New System.Windows.Forms.TextBox()
        Me.lblEmailSubject = New System.Windows.Forms.Label()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.btnCancelEmail = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyPartNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbxCustomerEmailAddress
        '
        Me.txtbxCustomerEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCustomerEmailAddress.Location = New System.Drawing.Point(278, 67)
        Me.txtbxCustomerEmailAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxCustomerEmailAddress.Name = "txtbxCustomerEmailAddress"
        Me.txtbxCustomerEmailAddress.Size = New System.Drawing.Size(618, 28)
        Me.txtbxCustomerEmailAddress.TabIndex = 0
        '
        'txtbxEmployeeEmail
        '
        Me.txtbxEmployeeEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmployeeEmail.Location = New System.Drawing.Point(278, 110)
        Me.txtbxEmployeeEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxEmployeeEmail.Name = "txtbxEmployeeEmail"
        Me.txtbxEmployeeEmail.Size = New System.Drawing.Size(618, 28)
        Me.txtbxEmployeeEmail.TabIndex = 1
        '
        'rtxtbxEmailBody
        '
        Me.rtxtbxEmailBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtbxEmailBody.Location = New System.Drawing.Point(278, 195)
        Me.rtxtbxEmailBody.Margin = New System.Windows.Forms.Padding(2)
        Me.rtxtbxEmailBody.Name = "rtxtbxEmailBody"
        Me.rtxtbxEmailBody.Size = New System.Drawing.Size(618, 247)
        Me.rtxtbxEmailBody.TabIndex = 2
        Me.rtxtbxEmailBody.Text = ""
        '
        'lblCustomerEmailAddress
        '
        Me.lblCustomerEmailAddress.AutoSize = True
        Me.lblCustomerEmailAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerEmailAddress.Location = New System.Drawing.Point(116, 69)
        Me.lblCustomerEmailAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomerEmailAddress.Name = "lblCustomerEmailAddress"
        Me.lblCustomerEmailAddress.Size = New System.Drawing.Size(160, 24)
        Me.lblCustomerEmailAddress.TabIndex = 3
        Me.lblCustomerEmailAddress.Text = "To Email Address"
        '
        'lblEmployeeEmail
        '
        Me.lblEmployeeEmail.AutoSize = True
        Me.lblEmployeeEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeEmail.Location = New System.Drawing.Point(96, 111)
        Me.lblEmployeeEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmployeeEmail.Name = "lblEmployeeEmail"
        Me.lblEmployeeEmail.Size = New System.Drawing.Size(182, 24)
        Me.lblEmployeeEmail.TabIndex = 4
        Me.lblEmployeeEmail.Text = "From Email Address"
        '
        'lblEmailBody
        '
        Me.lblEmailBody.AutoSize = True
        Me.lblEmailBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailBody.Location = New System.Drawing.Point(170, 195)
        Me.lblEmailBody.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailBody.Name = "lblEmailBody"
        Me.lblEmailBody.Size = New System.Drawing.Size(105, 24)
        Me.lblEmailBody.TabIndex = 5
        Me.lblEmailBody.Text = "Email Body"
        '
        'txtbxEmailSubject
        '
        Me.txtbxEmailSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmailSubject.Location = New System.Drawing.Point(278, 152)
        Me.txtbxEmailSubject.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbxEmailSubject.Name = "txtbxEmailSubject"
        Me.txtbxEmailSubject.Size = New System.Drawing.Size(618, 28)
        Me.txtbxEmailSubject.TabIndex = 6
        '
        'lblEmailSubject
        '
        Me.lblEmailSubject.AutoSize = True
        Me.lblEmailSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailSubject.Location = New System.Drawing.Point(150, 154)
        Me.lblEmailSubject.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmailSubject.Name = "lblEmailSubject"
        Me.lblEmailSubject.Size = New System.Drawing.Size(125, 24)
        Me.lblEmailSubject.TabIndex = 7
        Me.lblEmailSubject.Text = "Email Subject"
        '
        'btnSendEmail
        '
        Me.btnSendEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendEmail.Location = New System.Drawing.Point(278, 447)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(157, 51)
        Me.btnSendEmail.TabIndex = 9
        Me.btnSendEmail.Text = "Send Email"
        Me.btnSendEmail.UseVisualStyleBackColor = True
        '
        'btnCancelEmail
        '
        Me.btnCancelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelEmail.Location = New System.Drawing.Point(739, 447)
        Me.btnCancelEmail.Name = "btnCancelEmail"
        Me.btnCancelEmail.Size = New System.Drawing.Size(157, 51)
        Me.btnCancelEmail.TabIndex = 10
        Me.btnCancelEmail.Text = "Cancel Email "
        Me.btnCancelEmail.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.NavigationToolStripMenuItem, Me.ExportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(973, 24)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarGraphToolStripMenuItem, Me.CustomerToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'BarGraphToolStripMenuItem
        '
        Me.BarGraphToolStripMenuItem.Name = "BarGraphToolStripMenuItem"
        Me.BarGraphToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BarGraphToolStripMenuItem.Text = "Bar Graph"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyPartNumberToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CopyPartNumberToolStripMenuItem
        '
        Me.CopyPartNumberToolStripMenuItem.Name = "CopyPartNumberToolStripMenuItem"
        Me.CopyPartNumberToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CopyPartNumberToolStripMenuItem.Text = "Copy Part Number"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        Me.ViewToolStripMenuItem.Visible = False
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.SearchToolStripMenuItem, Me.EmailToolStripMenuItem})
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.NavigationToolStripMenuItem.Text = "&Navigation"
        Me.NavigationToolStripMenuItem.Visible = False
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.HomeToolStripMenuItem.Text = "&Home"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Enabled = False
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateFormToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "&Export"
        '
        'CreateFormToolStripMenuItem
        '
        Me.CreateFormToolStripMenuItem.Name = "CreateFormToolStripMenuItem"
        Me.CreateFormToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CreateFormToolStripMenuItem.Text = "&Email"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PDFToolStripMenuItem.Text = "&PDF"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSearch)
        Me.GroupBox4.Controls.Add(Me.btnHome)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.btnQuit)
        Me.GroupBox4.Controls.Add(Me.btnReset)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 504)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(943, 91)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(397, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(157, 51)
        Me.btnSearch.TabIndex = 44
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(208, 19)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(157, 51)
        Me.btnHome.TabIndex = 43
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(755, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 50)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(586, 19)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(157, 51)
        Me.btnQuit.TabIndex = 41
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(19, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(157, 51)
        Me.btnReset.TabIndex = 40
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 607)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnCancelEmail)
        Me.Controls.Add(Me.btnSendEmail)
        Me.Controls.Add(Me.lblEmailSubject)
        Me.Controls.Add(Me.txtbxEmailSubject)
        Me.Controls.Add(Me.lblEmailBody)
        Me.Controls.Add(Me.lblEmployeeEmail)
        Me.Controls.Add(Me.lblCustomerEmailAddress)
        Me.Controls.Add(Me.rtxtbxEmailBody)
        Me.Controls.Add(Me.txtbxEmployeeEmail)
        Me.Controls.Add(Me.txtbxCustomerEmailAddress)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEmail"
        Me.Text = "frmEmail"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbxCustomerEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtbxEmployeeEmail As System.Windows.Forms.TextBox
    Friend WithEvents rtxtbxEmailBody As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCustomerEmailAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeEmail As System.Windows.Forms.Label
    Friend WithEvents lblEmailBody As System.Windows.Forms.Label
    Friend WithEvents txtbxEmailSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailSubject As System.Windows.Forms.Label
    Friend WithEvents btnSendEmail As System.Windows.Forms.Button
    Friend WithEvents btnCancelEmail As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents CopyPartNumberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
