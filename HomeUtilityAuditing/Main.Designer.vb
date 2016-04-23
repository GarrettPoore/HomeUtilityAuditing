<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCostPerKWH = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtHoursPerDay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPowerRating = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAppliance = New System.Windows.Forms.ComboBox()
        Me.grpWasher = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtWaterCost = New System.Windows.Forms.TextBox()
        Me.txtWaterUse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblKWHTotal = New System.Windows.Forms.Label()
        Me.lbxListing = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsStatusBar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnReportCreation = New System.Windows.Forms.Button()
        Me.chkChangeDefaults = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.grpWasher.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 25)
        Me.Label1.MaximumSize = New System.Drawing.Size(75, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost per Kilowatt-Hour (kWH)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCostPerKWH
        '
        Me.txtCostPerKWH.Location = New System.Drawing.Point(354, 34)
        Me.txtCostPerKWH.Name = "txtCostPerKWH"
        Me.txtCostPerKWH.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerKWH.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtHoursPerDay)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtPowerRating)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 87)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Needed Information"
        '
        'txtHoursPerDay
        '
        Me.txtHoursPerDay.Location = New System.Drawing.Point(121, 60)
        Me.txtHoursPerDay.Name = "txtHoursPerDay"
        Me.txtHoursPerDay.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursPerDay.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Hours Per Day)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPowerRating
        '
        Me.txtPowerRating.Location = New System.Drawing.Point(121, 19)
        Me.txtPowerRating.Name = "txtPowerRating"
        Me.txtPowerRating.Size = New System.Drawing.Size(100, 20)
        Me.txtPowerRating.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 22)
        Me.Label2.MaximumSize = New System.Drawing.Size(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Power Rating"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(332, 439)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "E&xit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "$"
        '
        'cboAppliance
        '
        Me.cboAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppliance.FormattingEnabled = True
        Me.cboAppliance.Items.AddRange(New Object() {"Refridgerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Cloth Washer"})
        Me.cboAppliance.Location = New System.Drawing.Point(96, 87)
        Me.cboAppliance.Name = "cboAppliance"
        Me.cboAppliance.Size = New System.Drawing.Size(121, 21)
        Me.cboAppliance.TabIndex = 8
        '
        'grpWasher
        '
        Me.grpWasher.Controls.Add(Me.Label12)
        Me.grpWasher.Controls.Add(Me.Label6)
        Me.grpWasher.Controls.Add(Me.Label5)
        Me.grpWasher.Controls.Add(Me.txtWaterCost)
        Me.grpWasher.Controls.Add(Me.txtWaterUse)
        Me.grpWasher.Location = New System.Drawing.Point(50, 147)
        Me.grpWasher.Name = "grpWasher"
        Me.grpWasher.Size = New System.Drawing.Size(213, 100)
        Me.grpWasher.TabIndex = 9
        Me.grpWasher.TabStop = False
        Me.grpWasher.Text = "Cloth Washer - Water Use"
        Me.grpWasher.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(85, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Cost per Gallon"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 22)
        Me.Label5.MaximumSize = New System.Drawing.Size(100, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Gallons of Water Per Hour of Use"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWaterCost
        '
        Me.txtWaterCost.Location = New System.Drawing.Point(104, 58)
        Me.txtWaterCost.Name = "txtWaterCost"
        Me.txtWaterCost.Size = New System.Drawing.Size(100, 20)
        Me.txtWaterCost.TabIndex = 1
        '
        'txtWaterUse
        '
        Me.txtWaterUse.Location = New System.Drawing.Point(104, 25)
        Me.txtWaterUse.Name = "txtWaterUse"
        Me.txtWaterUse.Size = New System.Drawing.Size(100, 20)
        Me.txtWaterUse.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Appliance Selection"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total Cost:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKWHTotal
        '
        Me.lblKWHTotal.AutoSize = True
        Me.lblKWHTotal.Location = New System.Drawing.Point(352, 197)
        Me.lblKWHTotal.Name = "lblKWHTotal"
        Me.lblKWHTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblKWHTotal.TabIndex = 14
        Me.lblKWHTotal.Text = "$0.00"
        Me.lblKWHTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbxListing
        '
        Me.lbxListing.Enabled = False
        Me.lbxListing.FormattingEnabled = True
        Me.lbxListing.Location = New System.Drawing.Point(110, 273)
        Me.lbxListing.Name = "lbxListing"
        Me.lbxListing.Size = New System.Drawing.Size(503, 134)
        Me.lbxListing.TabIndex = 15
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsStatusBar, Me.stsLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 465)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(722, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsStatusBar
        '
        Me.stsStatusBar.Name = "stsStatusBar"
        Me.stsStatusBar.Size = New System.Drawing.Size(0, 17)
        '
        'stsLabel
        '
        Me.stsLabel.Name = "stsLabel"
        Me.stsLabel.Size = New System.Drawing.Size(0, 17)
        '
        'btnReportCreation
        '
        Me.btnReportCreation.Location = New System.Drawing.Point(223, 439)
        Me.btnReportCreation.Name = "btnReportCreation"
        Me.btnReportCreation.Size = New System.Drawing.Size(82, 23)
        Me.btnReportCreation.TabIndex = 17
        Me.btnReportCreation.Text = "Create Report"
        Me.btnReportCreation.UseVisualStyleBackColor = True
        '
        'chkChangeDefaults
        '
        Me.chkChangeDefaults.AutoSize = True
        Me.chkChangeDefaults.Checked = True
        Me.chkChangeDefaults.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChangeDefaults.Location = New System.Drawing.Point(441, 443)
        Me.chkChangeDefaults.Name = "chkChangeDefaults"
        Me.chkChangeDefaults.Size = New System.Drawing.Size(172, 17)
        Me.chkChangeDefaults.TabIndex = 18
        Me.chkChangeDefaults.Text = "Change Default Power Ratings"
        Me.chkChangeDefaults.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(110, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Individual Results:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 487)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.chkChangeDefaults)
        Me.Controls.Add(Me.btnReportCreation)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbxListing)
        Me.Controls.Add(Me.lblKWHTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grpWasher)
        Me.Controls.Add(Me.cboAppliance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCostPerKWH)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmMain"
        Me.Text = "Home Utility Audit Program"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grpWasher.ResumeLayout(False)
        Me.grpWasher.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCostPerKWH As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHoursPerDay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPowerRating As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents grpWasher As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtWaterCost As System.Windows.Forms.TextBox
    Friend WithEvents txtWaterUse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblKWHTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lbxListing As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsStatusBar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnReportCreation As System.Windows.Forms.Button
    Friend WithEvents chkChangeDefaults As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
