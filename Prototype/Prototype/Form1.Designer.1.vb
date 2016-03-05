<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.comStandard = New System.Windows.Forms.ComboBox()
        Me.comOrientation = New System.Windows.Forms.ComboBox()
        Me.comBarColor = New System.Windows.Forms.ComboBox()
        Me.comDigColor = New System.Windows.Forms.ComboBox()
        Me.comDecimal = New System.Windows.Forms.ComboBox()
        Me.comSTPTColor = New System.Windows.Forms.ComboBox()
        Me.comAlarmSetPoint = New System.Windows.Forms.ComboBox()
        Me.comSwitches = New System.Windows.Forms.ComboBox()
        Me.comBarStart = New System.Windows.Forms.ComboBox()
        Me.comPower = New System.Windows.Forms.ComboBox()
        Me.comSignalUnits = New System.Windows.Forms.ComboBox()
        Me.comSignalType = New System.Windows.Forms.ComboBox()
        Me.comConformal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.comOptionBoard = New System.Windows.Forms.ComboBox()
        Me.comSignalLinearity = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
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
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.comModel = New System.Windows.Forms.ComboBox()
        Me.grpDesign = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.grpFeatures = New System.Windows.Forms.GroupBox()
        Me.btnCreateForm = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.seriesNum = New System.Windows.Forms.Label()
        Me.conformalNum = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.startNum = New System.Windows.Forms.Label()
        Me.optionNum = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.unitsNum = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.linearityNum = New System.Windows.Forms.Label()
        Me.typeNum = New System.Windows.Forms.Label()
        Me.powerNum = New System.Windows.Forms.Label()
        Me.switchesNum = New System.Windows.Forms.Label()
        Me.alarmNum = New System.Windows.Forms.Label()
        Me.decimalNum = New System.Windows.Forms.Label()
        Me.stptNum = New System.Windows.Forms.Label()
        Me.digColorNum = New System.Windows.Forms.Label()
        Me.barColorNum = New System.Windows.Forms.Label()
        Me.orientationNum = New System.Windows.Forms.Label()
        Me.modelNum = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpModel.SuspendLayout()
        Me.grpDesign.SuspendLayout()
        Me.grpFeatures.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comStandard
        '
        Me.comStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comStandard.FormattingEnabled = True
        Me.comStandard.Items.AddRange(New Object() {"Q"})
        Me.comStandard.Location = New System.Drawing.Point(37, 50)
        Me.comStandard.Name = "comStandard"
        Me.comStandard.Size = New System.Drawing.Size(121, 32)
        Me.comStandard.TabIndex = 1
        '
        'comOrientation
        '
        Me.comOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comOrientation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comOrientation.FormattingEnabled = True
        Me.comOrientation.Items.AddRange(New Object() {"Horizontal", "Vertical"})
        Me.comOrientation.Location = New System.Drawing.Point(37, 236)
        Me.comOrientation.Name = "comOrientation"
        Me.comOrientation.Size = New System.Drawing.Size(121, 32)
        Me.comOrientation.TabIndex = 2
        '
        'comBarColor
        '
        Me.comBarColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBarColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBarColor.FormattingEnabled = True
        Me.comBarColor.Items.AddRange(New Object() {"Red (Default)", "Green", "Amber", "Mixed", "Tricolor"})
        Me.comBarColor.Location = New System.Drawing.Point(42, 43)
        Me.comBarColor.Name = "comBarColor"
        Me.comBarColor.Size = New System.Drawing.Size(121, 32)
        Me.comBarColor.TabIndex = 3
        '
        'comDigColor
        '
        Me.comDigColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comDigColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comDigColor.FormattingEnabled = True
        Me.comDigColor.Items.AddRange(New Object() {"Red (Default)", "Amber", "Green", "None"})
        Me.comDigColor.Location = New System.Drawing.Point(42, 130)
        Me.comDigColor.Name = "comDigColor"
        Me.comDigColor.Size = New System.Drawing.Size(121, 32)
        Me.comDigColor.TabIndex = 4
        '
        'comDecimal
        '
        Me.comDecimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comDecimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comDecimal.FormattingEnabled = True
        Me.comDecimal.Items.AddRange(New Object() {"000.0", "00.00", "0.000", "0000 (None)"})
        Me.comDecimal.Location = New System.Drawing.Point(174, 202)
        Me.comDecimal.Name = "comDecimal"
        Me.comDecimal.Size = New System.Drawing.Size(121, 32)
        Me.comDecimal.TabIndex = 5
        '
        'comSTPTColor
        '
        Me.comSTPTColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSTPTColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSTPTColor.FormattingEnabled = True
        Me.comSTPTColor.Items.AddRange(New Object() {"Red", "Green", "Amber", "Special", "None"})
        Me.comSTPTColor.Location = New System.Drawing.Point(42, 206)
        Me.comSTPTColor.Name = "comSTPTColor"
        Me.comSTPTColor.Size = New System.Drawing.Size(121, 32)
        Me.comSTPTColor.TabIndex = 6
        '
        'comAlarmSetPoint
        '
        Me.comAlarmSetPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comAlarmSetPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comAlarmSetPoint.FormattingEnabled = True
        Me.comAlarmSetPoint.Items.AddRange(New Object() {"HI/HI", "LO/LO", "HI/LO", "None"})
        Me.comAlarmSetPoint.Location = New System.Drawing.Point(28, 50)
        Me.comAlarmSetPoint.Name = "comAlarmSetPoint"
        Me.comAlarmSetPoint.Size = New System.Drawing.Size(121, 32)
        Me.comAlarmSetPoint.TabIndex = 7
        '
        'comSwitches
        '
        Me.comSwitches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSwitches.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSwitches.FormattingEnabled = True
        Me.comSwitches.Items.AddRange(New Object() {"Yes (Default)", "None"})
        Me.comSwitches.Location = New System.Drawing.Point(28, 126)
        Me.comSwitches.Name = "comSwitches"
        Me.comSwitches.Size = New System.Drawing.Size(121, 32)
        Me.comSwitches.TabIndex = 8
        '
        'comBarStart
        '
        Me.comBarStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comBarStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comBarStart.FormattingEnabled = True
        Me.comBarStart.Items.AddRange(New Object() {"Bottom", "Center", "Top", "Offset", "Dot Mode 1", "Dot Mode 3", "Dot Mode 5"})
        Me.comBarStart.Location = New System.Drawing.Point(324, 126)
        Me.comBarStart.Name = "comBarStart"
        Me.comBarStart.Size = New System.Drawing.Size(121, 32)
        Me.comBarStart.TabIndex = 9
        '
        'comPower
        '
        Me.comPower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPower.FormattingEnabled = True
        Me.comPower.Items.AddRange(New Object() {"115 VAC", "230 VAC", "5 VDC", "12 VDC", "24 VDC", "48 VDC"})
        Me.comPower.Location = New System.Drawing.Point(28, 278)
        Me.comPower.Name = "comPower"
        Me.comPower.Size = New System.Drawing.Size(121, 32)
        Me.comPower.TabIndex = 10
        '
        'comSignalUnits
        '
        Me.comSignalUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSignalUnits.DropDownWidth = 150
        Me.comSignalUnits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSignalUnits.FormattingEnabled = True
        Me.comSignalUnits.Items.AddRange(New Object() {"Amperes", "Millivolts", "Centigrade", "Fahrenheit", "Milliamperes", "Microamperes", "Volts", "Other"})
        Me.comSignalUnits.Location = New System.Drawing.Point(174, 50)
        Me.comSignalUnits.Name = "comSignalUnits"
        Me.comSignalUnits.Size = New System.Drawing.Size(121, 32)
        Me.comSignalUnits.TabIndex = 11
        '
        'comSignalType
        '
        Me.comSignalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSignalType.DropDownWidth = 180
        Me.comSignalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSignalType.FormattingEnabled = True
        Me.comSignalType.Items.AddRange(New Object() {"A/C", "D/C", "Other (RTD and T/C)"})
        Me.comSignalType.Location = New System.Drawing.Point(174, 126)
        Me.comSignalType.Name = "comSignalType"
        Me.comSignalType.Size = New System.Drawing.Size(121, 32)
        Me.comSignalType.TabIndex = 12
        '
        'comConformal
        '
        Me.comConformal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comConformal.DropDownWidth = 270
        Me.comConformal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comConformal.FormattingEnabled = True
        Me.comConformal.Items.AddRange(New Object() {"None, Standard Terminals", "Yes, Standard Terminals", "Barrier Strip Terminals", "Endcap", "Special (Combination of above)"})
        Me.comConformal.Location = New System.Drawing.Point(28, 202)
        Me.comConformal.Name = "comConformal"
        Me.comConformal.Size = New System.Drawing.Size(121, 32)
        Me.comConformal.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Standard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Orientation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(194, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Decimal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Dig Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 24)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Bar Color"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Switches"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 24)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Alarm Set Point"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 24)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ST PT Color"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(181, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 24)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Signal Type"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(181, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 24)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Signal Units"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(56, 244)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 24)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Power"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(66, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 24)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Artwork"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 24)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Conformal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(345, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 24)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Bar Start"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(320, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 24)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Option Board"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(311, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 24)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Signal Linearity"
        '
        'comOptionBoard
        '
        Me.comOptionBoard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comOptionBoard.DropDownWidth = 440
        Me.comOptionBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comOptionBoard.FormattingEnabled = True
        Me.comOptionBoard.Items.AddRange(New Object() {"Isolated 2-Wire Retransmission", "Auxiliary Power Supply, Regulated 10 VDC", "Auxiliary Power Supply, 28 VDC", "Auxiliary Power Supply, REgulated 24 VDC", "Serial Communications, Receive Only (RS-422)", "Serial Communications, Receive/Transmit (RS-422)", "AC/DC Converter", "DC Gain", "Special", "None"})
        Me.comOptionBoard.Location = New System.Drawing.Point(323, 51)
        Me.comOptionBoard.Name = "comOptionBoard"
        Me.comOptionBoard.Size = New System.Drawing.Size(123, 32)
        Me.comOptionBoard.TabIndex = 32
        '
        'comSignalLinearity
        '
        Me.comSignalLinearity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comSignalLinearity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comSignalLinearity.FormattingEnabled = True
        Me.comSignalLinearity.Items.AddRange(New Object() {"Linear", "Square Root", "Nonlinear (RTD and T/C)"})
        Me.comSignalLinearity.Location = New System.Drawing.Point(324, 202)
        Me.comSignalLinearity.Name = "comSignalLinearity"
        Me.comSignalLinearity.Size = New System.Drawing.Size(121, 32)
        Me.comSignalLinearity.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(320, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(350, 39)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Bar Graph Generator"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ExportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(989, 24)
        Me.MenuStrip1.TabIndex = 35
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
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateFormToolStripMenuItem, Me.PDFToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'CreateFormToolStripMenuItem
        '
        Me.CreateFormToolStripMenuItem.Name = "CreateFormToolStripMenuItem"
        Me.CreateFormToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CreateFormToolStripMenuItem.Text = "Email"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.comModel)
        Me.grpModel.Controls.Add(Me.Label1)
        Me.grpModel.Controls.Add(Me.comStandard)
        Me.grpModel.Controls.Add(Me.comOrientation)
        Me.grpModel.Controls.Add(Me.Label2)
        Me.grpModel.Controls.Add(Me.Label3)
        Me.grpModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpModel.Location = New System.Drawing.Point(14, 78)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(200, 331)
        Me.grpModel.TabIndex = 36
        Me.grpModel.TabStop = False
        Me.grpModel.Text = "Model"
        '
        'comModel
        '
        Me.comModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comModel.FormattingEnabled = True
        Me.comModel.Items.AddRange(New Object() {"BB101PV", "BB202PH", "BB202PV", "BG.H202P", "BJ.N101PV MS", "BJ.N101PV TB", "BJ.N202PV MS", "BJ.N202PV TB", "BK051P", "BL101PV", "BL202PV", "BS101PV BS", "BS101PV TB", "BS202PV BS", "BS202PV TB", "BT033P", "BT071PV", "BTW71PV", "BW051PV", "SA101PH", "SA101PV", "SA202PH", "SA202PV"})
        Me.comModel.Location = New System.Drawing.Point(19, 140)
        Me.comModel.Name = "comModel"
        Me.comModel.Size = New System.Drawing.Size(157, 32)
        Me.comModel.TabIndex = 17
        '
        'grpDesign
        '
        Me.grpDesign.Controls.Add(Me.radNo)
        Me.grpDesign.Controls.Add(Me.radYes)
        Me.grpDesign.Controls.Add(Me.Label6)
        Me.grpDesign.Controls.Add(Me.comBarColor)
        Me.grpDesign.Controls.Add(Me.Label5)
        Me.grpDesign.Controls.Add(Me.comDigColor)
        Me.grpDesign.Controls.Add(Me.Label9)
        Me.grpDesign.Controls.Add(Me.comSTPTColor)
        Me.grpDesign.Controls.Add(Me.Label13)
        Me.grpDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDesign.Location = New System.Drawing.Point(241, 78)
        Me.grpDesign.Name = "grpDesign"
        Me.grpDesign.Size = New System.Drawing.Size(200, 331)
        Me.grpDesign.TabIndex = 37
        Me.grpDesign.TabStop = False
        Me.grpDesign.Text = "Design"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(124, 286)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(47, 24)
        Me.radNo.TabIndex = 28
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(33, 286)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(55, 24)
        Me.radYes.TabIndex = 27
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'grpFeatures
        '
        Me.grpFeatures.Controls.Add(Me.Label16)
        Me.grpFeatures.Controls.Add(Me.comAlarmSetPoint)
        Me.grpFeatures.Controls.Add(Me.comSignalUnits)
        Me.grpFeatures.Controls.Add(Me.Label8)
        Me.grpFeatures.Controls.Add(Me.comSignalLinearity)
        Me.grpFeatures.Controls.Add(Me.Label11)
        Me.grpFeatures.Controls.Add(Me.Label17)
        Me.grpFeatures.Controls.Add(Me.Label12)
        Me.grpFeatures.Controls.Add(Me.comOptionBoard)
        Me.grpFeatures.Controls.Add(Me.comPower)
        Me.grpFeatures.Controls.Add(Me.Label14)
        Me.grpFeatures.Controls.Add(Me.Label4)
        Me.grpFeatures.Controls.Add(Me.Label15)
        Me.grpFeatures.Controls.Add(Me.comDecimal)
        Me.grpFeatures.Controls.Add(Me.comConformal)
        Me.grpFeatures.Controls.Add(Me.comSwitches)
        Me.grpFeatures.Controls.Add(Me.comBarStart)
        Me.grpFeatures.Controls.Add(Me.Label10)
        Me.grpFeatures.Controls.Add(Me.comSignalType)
        Me.grpFeatures.Controls.Add(Me.Label7)
        Me.grpFeatures.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFeatures.Location = New System.Drawing.Point(485, 78)
        Me.grpFeatures.Name = "grpFeatures"
        Me.grpFeatures.Size = New System.Drawing.Size(472, 331)
        Me.grpFeatures.TabIndex = 38
        Me.grpFeatures.TabStop = False
        Me.grpFeatures.Text = "Features"
        '
        'btnCreateForm
        '
        Me.btnCreateForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateForm.Location = New System.Drawing.Point(19, 19)
        Me.btnCreateForm.Name = "btnCreateForm"
        Me.btnCreateForm.Size = New System.Drawing.Size(157, 51)
        Me.btnCreateForm.TabIndex = 39
        Me.btnCreateForm.Text = "Create Form"
        Me.btnCreateForm.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(241, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(157, 51)
        Me.btnReset.TabIndex = 40
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.btnQuit)
        Me.GroupBox4.Controls.Add(Me.btnCreateForm)
        Me.GroupBox4.Controls.Add(Me.btnReset)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 452)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(943, 91)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.temp1
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
        Me.btnQuit.Location = New System.Drawing.Point(463, 19)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(157, 51)
        Me.btnQuit.TabIndex = 41
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'seriesNum
        '
        Me.seriesNum.AutoSize = True
        Me.seriesNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seriesNum.Location = New System.Drawing.Point(434, 423)
        Me.seriesNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.seriesNum.Name = "seriesNum"
        Me.seriesNum.Size = New System.Drawing.Size(18, 20)
        Me.seriesNum.TabIndex = 34
        Me.seriesNum.Text = "0"
        '
        'conformalNum
        '
        Me.conformalNum.AutoSize = True
        Me.conformalNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conformalNum.Location = New System.Drawing.Point(724, 423)
        Me.conformalNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.conformalNum.Name = "conformalNum"
        Me.conformalNum.Size = New System.Drawing.Size(18, 20)
        Me.conformalNum.TabIndex = 35
        Me.conformalNum.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(744, 423)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 20)
        Me.Label21.TabIndex = 36
        Me.Label21.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(763, 423)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 20)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "0"
        '
        'startNum
        '
        Me.startNum.AutoSize = True
        Me.startNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startNum.Location = New System.Drawing.Point(705, 423)
        Me.startNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.startNum.Name = "startNum"
        Me.startNum.Size = New System.Drawing.Size(18, 20)
        Me.startNum.TabIndex = 38
        Me.startNum.Text = "0"
        '
        'optionNum
        '
        Me.optionNum.AutoSize = True
        Me.optionNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionNum.Location = New System.Drawing.Point(686, 423)
        Me.optionNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.optionNum.Name = "optionNum"
        Me.optionNum.Size = New System.Drawing.Size(18, 20)
        Me.optionNum.TabIndex = 39
        Me.optionNum.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(821, 423)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 20)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(782, 423)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(18, 20)
        Me.Label26.TabIndex = 41
        Me.Label26.Text = "0"
        '
        'unitsNum
        '
        Me.unitsNum.AutoSize = True
        Me.unitsNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitsNum.Location = New System.Drawing.Point(628, 423)
        Me.unitsNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.unitsNum.Name = "unitsNum"
        Me.unitsNum.Size = New System.Drawing.Size(18, 20)
        Me.unitsNum.TabIndex = 42
        Me.unitsNum.Text = "0"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(802, 423)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(18, 20)
        Me.Label28.TabIndex = 43
        Me.Label28.Text = "0"
        '
        'linearityNum
        '
        Me.linearityNum.AutoSize = True
        Me.linearityNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linearityNum.Location = New System.Drawing.Point(668, 423)
        Me.linearityNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.linearityNum.Name = "linearityNum"
        Me.linearityNum.Size = New System.Drawing.Size(18, 20)
        Me.linearityNum.TabIndex = 44
        Me.linearityNum.Text = "0"
        '
        'typeNum
        '
        Me.typeNum.AutoSize = True
        Me.typeNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeNum.Location = New System.Drawing.Point(647, 423)
        Me.typeNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.typeNum.Name = "typeNum"
        Me.typeNum.Size = New System.Drawing.Size(18, 20)
        Me.typeNum.TabIndex = 45
        Me.typeNum.Text = "0"
        '
        'powerNum
        '
        Me.powerNum.AutoSize = True
        Me.powerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.powerNum.Location = New System.Drawing.Point(608, 423)
        Me.powerNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.powerNum.Name = "powerNum"
        Me.powerNum.Size = New System.Drawing.Size(18, 20)
        Me.powerNum.TabIndex = 46
        Me.powerNum.Text = "0"
        '
        'switchesNum
        '
        Me.switchesNum.AutoSize = True
        Me.switchesNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.switchesNum.Location = New System.Drawing.Point(589, 423)
        Me.switchesNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.switchesNum.Name = "switchesNum"
        Me.switchesNum.Size = New System.Drawing.Size(18, 20)
        Me.switchesNum.TabIndex = 47
        Me.switchesNum.Text = "0"
        '
        'alarmNum
        '
        Me.alarmNum.AutoSize = True
        Me.alarmNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alarmNum.Location = New System.Drawing.Point(570, 423)
        Me.alarmNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.alarmNum.Name = "alarmNum"
        Me.alarmNum.Size = New System.Drawing.Size(18, 20)
        Me.alarmNum.TabIndex = 48
        Me.alarmNum.Text = "0"
        '
        'decimalNum
        '
        Me.decimalNum.AutoSize = True
        Me.decimalNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decimalNum.Location = New System.Drawing.Point(531, 423)
        Me.decimalNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.decimalNum.Name = "decimalNum"
        Me.decimalNum.Size = New System.Drawing.Size(18, 20)
        Me.decimalNum.TabIndex = 49
        Me.decimalNum.Text = "0"
        '
        'stptNum
        '
        Me.stptNum.AutoSize = True
        Me.stptNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stptNum.Location = New System.Drawing.Point(550, 423)
        Me.stptNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.stptNum.Name = "stptNum"
        Me.stptNum.Size = New System.Drawing.Size(18, 20)
        Me.stptNum.TabIndex = 50
        Me.stptNum.Text = "0"
        '
        'digColorNum
        '
        Me.digColorNum.AutoSize = True
        Me.digColorNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.digColorNum.Location = New System.Drawing.Point(512, 423)
        Me.digColorNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.digColorNum.Name = "digColorNum"
        Me.digColorNum.Size = New System.Drawing.Size(18, 20)
        Me.digColorNum.TabIndex = 51
        Me.digColorNum.Text = "0"
        '
        'barColorNum
        '
        Me.barColorNum.AutoSize = True
        Me.barColorNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barColorNum.Location = New System.Drawing.Point(492, 423)
        Me.barColorNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.barColorNum.Name = "barColorNum"
        Me.barColorNum.Size = New System.Drawing.Size(18, 20)
        Me.barColorNum.TabIndex = 52
        Me.barColorNum.Text = "0"
        '
        'orientationNum
        '
        Me.orientationNum.AutoSize = True
        Me.orientationNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orientationNum.Location = New System.Drawing.Point(473, 423)
        Me.orientationNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.orientationNum.Name = "orientationNum"
        Me.orientationNum.Size = New System.Drawing.Size(18, 20)
        Me.orientationNum.TabIndex = 53
        Me.orientationNum.Text = "0"
        '
        'modelNum
        '
        Me.modelNum.AutoSize = True
        Me.modelNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelNum.Location = New System.Drawing.Point(454, 423)
        Me.modelNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.modelNum.Name = "modelNum"
        Me.modelNum.Size = New System.Drawing.Size(18, 20)
        Me.modelNum.TabIndex = 54
        Me.modelNum.Text = "0"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(238, 423)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(98, 20)
        Me.Label40.TabIndex = 55
        Me.Label40.Text = "Part Number"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 548)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.grpFeatures)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.grpDesign)
        Me.Controls.Add(Me.grpModel)
        Me.Controls.Add(Me.linearityNum)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.optionNum)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.seriesNum)
        Me.Controls.Add(Me.decimalNum)
        Me.Controls.Add(Me.typeNum)
        Me.Controls.Add(Me.stptNum)
        Me.Controls.Add(Me.digColorNum)
        Me.Controls.Add(Me.powerNum)
        Me.Controls.Add(Me.modelNum)
        Me.Controls.Add(Me.barColorNum)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.orientationNum)
        Me.Controls.Add(Me.unitsNum)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.alarmNum)
        Me.Controls.Add(Me.switchesNum)
        Me.Controls.Add(Me.startNum)
        Me.Controls.Add(Me.conformalNum)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bar Graph Generator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        Me.grpDesign.ResumeLayout(False)
        Me.grpDesign.PerformLayout()
        Me.grpFeatures.ResumeLayout(False)
        Me.grpFeatures.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comStandard As System.Windows.Forms.ComboBox
    Friend WithEvents comOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents comBarColor As System.Windows.Forms.ComboBox
    Friend WithEvents comDigColor As System.Windows.Forms.ComboBox
    Friend WithEvents comDecimal As System.Windows.Forms.ComboBox
    Friend WithEvents comSTPTColor As System.Windows.Forms.ComboBox
    Friend WithEvents comAlarmSetPoint As System.Windows.Forms.ComboBox
    Friend WithEvents comSwitches As System.Windows.Forms.ComboBox
    Friend WithEvents comBarStart As System.Windows.Forms.ComboBox
    Friend WithEvents comPower As System.Windows.Forms.ComboBox
    Friend WithEvents comSignalUnits As System.Windows.Forms.ComboBox
    Friend WithEvents comSignalType As System.Windows.Forms.ComboBox
    Friend WithEvents comConformal As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents comOptionBoard As System.Windows.Forms.ComboBox
    Friend WithEvents comSignalLinearity As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpModel As System.Windows.Forms.GroupBox
    Friend WithEvents grpDesign As System.Windows.Forms.GroupBox
    Friend WithEvents grpFeatures As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateForm As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents radNo As System.Windows.Forms.RadioButton
    Friend WithEvents radYes As System.Windows.Forms.RadioButton
    Friend WithEvents comModel As System.Windows.Forms.ComboBox
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents seriesNum As System.Windows.Forms.Label
    Friend WithEvents conformalNum As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents startNum As System.Windows.Forms.Label
    Friend WithEvents optionNum As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents unitsNum As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents linearityNum As System.Windows.Forms.Label
    Friend WithEvents typeNum As System.Windows.Forms.Label
    Friend WithEvents powerNum As System.Windows.Forms.Label
    Friend WithEvents switchesNum As System.Windows.Forms.Label
    Friend WithEvents alarmNum As System.Windows.Forms.Label
    Friend WithEvents decimalNum As System.Windows.Forms.Label
    Friend WithEvents stptNum As System.Windows.Forms.Label
    Friend WithEvents digColorNum As System.Windows.Forms.Label
    Friend WithEvents barColorNum As System.Windows.Forms.Label
    Friend WithEvents orientationNum As System.Windows.Forms.Label
    Friend WithEvents modelNum As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label

End Class
