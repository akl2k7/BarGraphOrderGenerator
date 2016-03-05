<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.components = New System.ComponentModel.Container()
        Dim Completion_Assembly_NumberLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim lblScaleNum As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim lblManual As System.Windows.Forms.Label
        Me.Compln_DisplayDataSet = New WindowsApplication1.Compln_DisplayDataSet()
        Me.COMPDISPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMPDISPTableAdapter = New WindowsApplication1.Compln_DisplayDataSetTableAdapters.COMPDISPTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Compln_DisplayDataSetTableAdapters.TableAdapterManager()
        Me.txtbxCompAssem = New System.Windows.Forms.TextBox()
        Me.finalAssemNum = New System.Windows.Forms.TextBox()
        Me.txtbxScaleNuber = New System.Windows.Forms.TextBox()
        Me.txtbxManual = New System.Windows.Forms.TextBox()
        Completion_Assembly_NumberLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        lblScaleNum = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        lblManual = New System.Windows.Forms.Label()
        CType(Me.Compln_DisplayDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMPDISPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Completion_Assembly_NumberLabel
        '
        Completion_Assembly_NumberLabel.AutoSize = True
        Completion_Assembly_NumberLabel.Location = New System.Drawing.Point(31, 148)
        Completion_Assembly_NumberLabel.Name = "Completion_Assembly_NumberLabel"
        Completion_Assembly_NumberLabel.Size = New System.Drawing.Size(309, 26)
        Completion_Assembly_NumberLabel.TabIndex = 3
        Completion_Assembly_NumberLabel.Text = "Completion Assembly Number"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(33, 278)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(245, 26)
        Label1.TabIndex = 6
        Label1.Text = "Final Assembly Number"
        '
        'Compln_DisplayDataSet
        '
        Me.Compln_DisplayDataSet.DataSetName = "Compln_DisplayDataSet"
        Me.Compln_DisplayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMPDISPBindingSource
        '
        Me.COMPDISPBindingSource.DataMember = "COMPDISP"
        Me.COMPDISPBindingSource.DataSource = Me.Compln_DisplayDataSet
        '
        'COMPDISPTableAdapter
        '
        Me.COMPDISPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.COMPDISPTableAdapter = Me.COMPDISPTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Compln_DisplayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtbxCompAssem
        '
        Me.txtbxCompAssem.Location = New System.Drawing.Point(38, 177)
        Me.txtbxCompAssem.Name = "txtbxCompAssem"
        Me.txtbxCompAssem.Size = New System.Drawing.Size(426, 32)
        Me.txtbxCompAssem.TabIndex = 4
        '
        'finalAssemNum
        '
        Me.finalAssemNum.Location = New System.Drawing.Point(40, 311)
        Me.finalAssemNum.Name = "finalAssemNum"
        Me.finalAssemNum.Size = New System.Drawing.Size(426, 32)
        Me.finalAssemNum.TabIndex = 5
        '
        'lblScaleNum
        '
        lblScaleNum.AutoSize = True
        lblScaleNum.Location = New System.Drawing.Point(33, 412)
        lblScaleNum.Name = "lblScaleNum"
        lblScaleNum.Size = New System.Drawing.Size(151, 26)
        lblScaleNum.TabIndex = 8
        lblScaleNum.Text = "Scale Number"
        '
        'txtbxScaleNuber
        '
        Me.txtbxScaleNuber.Location = New System.Drawing.Point(40, 445)
        Me.txtbxScaleNuber.Name = "txtbxScaleNuber"
        Me.txtbxScaleNuber.Size = New System.Drawing.Size(426, 32)
        Me.txtbxScaleNuber.TabIndex = 7
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(112, 50)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(272, 31)
        Label2.TabIndex = 9
        Label2.Text = "Assemblies Needed"
        '
        'lblManual
        '
        lblManual.AutoSize = True
        lblManual.Location = New System.Drawing.Point(33, 552)
        lblManual.Name = "lblManual"
        lblManual.Size = New System.Drawing.Size(83, 26)
        lblManual.TabIndex = 11
        lblManual.Text = "Manual"
        '
        'txtbxManual
        '
        Me.txtbxManual.Location = New System.Drawing.Point(40, 579)
        Me.txtbxManual.Name = "txtbxManual"
        Me.txtbxManual.Size = New System.Drawing.Size(426, 32)
        Me.txtbxManual.TabIndex = 10
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 702)
        Me.Controls.Add(lblManual)
        Me.Controls.Add(Me.txtbxManual)
        Me.Controls.Add(Label2)
        Me.Controls.Add(lblScaleNum)
        Me.Controls.Add(Me.txtbxScaleNuber)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.finalAssemNum)
        Me.Controls.Add(Me.txtbxCompAssem)
        Me.Controls.Add(Completion_Assembly_NumberLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmSales"
        Me.Text = "frmSales"
        CType(Me.Compln_DisplayDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMPDISPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Compln_DisplayDataSet As WindowsApplication1.Compln_DisplayDataSet
    Friend WithEvents COMPDISPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMPDISPTableAdapter As WindowsApplication1.Compln_DisplayDataSetTableAdapters.COMPDISPTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Compln_DisplayDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtbxCompAssem As System.Windows.Forms.TextBox
    Friend WithEvents finalAssemNum As System.Windows.Forms.TextBox
    Friend WithEvents txtbxScaleNuber As System.Windows.Forms.TextBox
    Friend WithEvents txtbxManual As System.Windows.Forms.TextBox
End Class
