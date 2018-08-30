<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblKWCost = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.rbRefrigerator = New System.Windows.Forms.RadioButton()
        Me.rbTV = New System.Windows.Forms.RadioButton()
        Me.rbSpaceHeater = New System.Windows.Forms.RadioButton()
        Me.rbFan = New System.Windows.Forms.RadioButton()
        Me.rbDryer = New System.Windows.Forms.RadioButton()
        Me.rbOven = New System.Windows.Forms.RadioButton()
        Me.lblKWPower = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.lblUse = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.rbWasher = New System.Windows.Forms.RadioButton()
        Me.lblCPG = New System.Windows.Forms.Label()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.txtCPG = New System.Windows.Forms.TextBox()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lstAppliances = New System.Windows.Forms.ListBox()
        Me.txtAllTotal = New System.Windows.Forms.TextBox()
        Me.lblAppliances = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblKWCost
        '
        Me.lblKWCost.AutoSize = True
        Me.lblKWCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblKWCost.Location = New System.Drawing.Point(12, 120)
        Me.lblKWCost.Name = "lblKWCost"
        Me.lblKWCost.Size = New System.Drawing.Size(236, 18)
        Me.lblKWCost.TabIndex = 0
        Me.lblKWCost.Text = "What is the cost per kilowatt hour?"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(275, 121)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(120, 20)
        Me.txtCost.TabIndex = 1
        Me.txtCost.Text = "Kilowatt Hour Cost"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(15, 576)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 13
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(597, 576)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblAppliance.Location = New System.Drawing.Point(12, 163)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(139, 18)
        Me.lblAppliance.TabIndex = 4
        Me.lblAppliance.Text = "Select an appliance:"
        '
        'rbRefrigerator
        '
        Me.rbRefrigerator.AutoSize = True
        Me.rbRefrigerator.Location = New System.Drawing.Point(15, 205)
        Me.rbRefrigerator.Name = "rbRefrigerator"
        Me.rbRefrigerator.Size = New System.Drawing.Size(80, 17)
        Me.rbRefrigerator.TabIndex = 2
        Me.rbRefrigerator.TabStop = True
        Me.rbRefrigerator.Text = "Refrigerator"
        Me.rbRefrigerator.UseVisualStyleBackColor = True
        '
        'rbTV
        '
        Me.rbTV.AutoSize = True
        Me.rbTV.Location = New System.Drawing.Point(15, 228)
        Me.rbTV.Name = "rbTV"
        Me.rbTV.Size = New System.Drawing.Size(39, 17)
        Me.rbTV.TabIndex = 3
        Me.rbTV.TabStop = True
        Me.rbTV.Text = "TV"
        Me.rbTV.UseVisualStyleBackColor = True
        '
        'rbSpaceHeater
        '
        Me.rbSpaceHeater.AutoSize = True
        Me.rbSpaceHeater.Location = New System.Drawing.Point(15, 251)
        Me.rbSpaceHeater.Name = "rbSpaceHeater"
        Me.rbSpaceHeater.Size = New System.Drawing.Size(91, 17)
        Me.rbSpaceHeater.TabIndex = 4
        Me.rbSpaceHeater.TabStop = True
        Me.rbSpaceHeater.Text = "Space Heater"
        Me.rbSpaceHeater.UseVisualStyleBackColor = True
        '
        'rbFan
        '
        Me.rbFan.AutoSize = True
        Me.rbFan.Location = New System.Drawing.Point(15, 274)
        Me.rbFan.Name = "rbFan"
        Me.rbFan.Size = New System.Drawing.Size(43, 17)
        Me.rbFan.TabIndex = 5
        Me.rbFan.TabStop = True
        Me.rbFan.Text = "Fan"
        Me.rbFan.UseVisualStyleBackColor = True
        '
        'rbDryer
        '
        Me.rbDryer.AutoSize = True
        Me.rbDryer.Location = New System.Drawing.Point(15, 297)
        Me.rbDryer.Name = "rbDryer"
        Me.rbDryer.Size = New System.Drawing.Size(50, 17)
        Me.rbDryer.TabIndex = 6
        Me.rbDryer.TabStop = True
        Me.rbDryer.Text = "Dryer"
        Me.rbDryer.UseVisualStyleBackColor = True
        '
        'rbOven
        '
        Me.rbOven.AutoSize = True
        Me.rbOven.Location = New System.Drawing.Point(15, 320)
        Me.rbOven.Name = "rbOven"
        Me.rbOven.Size = New System.Drawing.Size(51, 17)
        Me.rbOven.TabIndex = 7
        Me.rbOven.TabStop = True
        Me.rbOven.Text = "Oven"
        Me.rbOven.UseVisualStyleBackColor = True
        '
        'lblKWPower
        '
        Me.lblKWPower.AutoSize = True
        Me.lblKWPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblKWPower.Location = New System.Drawing.Point(12, 476)
        Me.lblKWPower.Name = "lblKWPower"
        Me.lblKWPower.Size = New System.Drawing.Size(51, 18)
        Me.lblKWPower.TabIndex = 11
        Me.lblKWPower.Text = "Label2"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(275, 477)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(120, 20)
        Me.txtPower.TabIndex = 11
        Me.txtPower.Text = "Kilowatt Usage"
        '
        'lblUse
        '
        Me.lblUse.AutoSize = True
        Me.lblUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblUse.Location = New System.Drawing.Point(12, 542)
        Me.lblUse.Name = "lblUse"
        Me.lblUse.Size = New System.Drawing.Size(243, 18)
        Me.lblUse.TabIndex = 13
        Me.lblUse.Text = "How many hours per day is it used?"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(275, 543)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(120, 20)
        Me.txtHours.TabIndex = 12
        Me.txtHours.Text = "Hours Used Per Day"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblMessage.Location = New System.Drawing.Point(12, 9)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(51, 18)
        Me.lblMessage.TabIndex = 15
        Me.lblMessage.Text = "Label1"
        '
        'rbWasher
        '
        Me.rbWasher.AutoSize = True
        Me.rbWasher.Location = New System.Drawing.Point(15, 343)
        Me.rbWasher.Name = "rbWasher"
        Me.rbWasher.Size = New System.Drawing.Size(103, 17)
        Me.rbWasher.TabIndex = 8
        Me.rbWasher.TabStop = True
        Me.rbWasher.Text = "Laundry Washer"
        Me.rbWasher.UseVisualStyleBackColor = True
        '
        'lblCPG
        '
        Me.lblCPG.AutoSize = True
        Me.lblCPG.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblCPG.Location = New System.Drawing.Point(12, 388)
        Me.lblCPG.Name = "lblCPG"
        Me.lblCPG.Size = New System.Drawing.Size(191, 18)
        Me.lblCPG.TabIndex = 16
        Me.lblCPG.Text = "What is the cost per gallon?"
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblGallons.Location = New System.Drawing.Point(12, 432)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(214, 18)
        Me.lblGallons.TabIndex = 17
        Me.lblGallons.Text = "How many gallons does it use?"
        '
        'txtCPG
        '
        Me.txtCPG.Enabled = False
        Me.txtCPG.Location = New System.Drawing.Point(275, 389)
        Me.txtCPG.Name = "txtCPG"
        Me.txtCPG.Size = New System.Drawing.Size(120, 20)
        Me.txtCPG.TabIndex = 9
        Me.txtCPG.Text = "Enter Cost Per Gallon"
        '
        'txtGallons
        '
        Me.txtGallons.Enabled = False
        Me.txtGallons.Location = New System.Drawing.Point(275, 433)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(120, 20)
        Me.txtGallons.TabIndex = 10
        Me.txtGallons.Text = "Enter Gallons Per Hour"
        '
        'lstAppliances
        '
        Me.lstAppliances.FormattingEnabled = True
        Me.lstAppliances.Location = New System.Drawing.Point(416, 146)
        Me.lstAppliances.Name = "lstAppliances"
        Me.lstAppliances.Size = New System.Drawing.Size(256, 381)
        Me.lstAppliances.TabIndex = 18
        '
        'txtAllTotal
        '
        Me.txtAllTotal.Enabled = False
        Me.txtAllTotal.Location = New System.Drawing.Point(416, 543)
        Me.txtAllTotal.Name = "txtAllTotal"
        Me.txtAllTotal.Size = New System.Drawing.Size(256, 20)
        Me.txtAllTotal.TabIndex = 19
        '
        'lblAppliances
        '
        Me.lblAppliances.AutoSize = True
        Me.lblAppliances.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblAppliances.Location = New System.Drawing.Point(413, 120)
        Me.lblAppliances.Name = "lblAppliances"
        Me.lblAppliances.Size = New System.Drawing.Size(138, 18)
        Me.lblAppliances.TabIndex = 20
        Me.lblAppliances.Text = "Entered Appliances:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(160, 576)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(310, 576)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 15
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(456, 576)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear List"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblAppliances)
        Me.Controls.Add(Me.txtAllTotal)
        Me.Controls.Add(Me.lstAppliances)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.txtCPG)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.lblCPG)
        Me.Controls.Add(Me.rbWasher)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblUse)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.lblKWPower)
        Me.Controls.Add(Me.rbOven)
        Me.Controls.Add(Me.rbDryer)
        Me.Controls.Add(Me.rbFan)
        Me.Controls.Add(Me.rbSpaceHeater)
        Me.Controls.Add(Me.rbTV)
        Me.Controls.Add(Me.rbRefrigerator)
        Me.Controls.Add(Me.lblAppliance)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lblKWCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Utility Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblKWCost As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAppliance As Label
    Friend WithEvents rbRefrigerator As RadioButton
    Friend WithEvents rbTV As RadioButton
    Friend WithEvents rbSpaceHeater As RadioButton
    Friend WithEvents rbFan As RadioButton
    Friend WithEvents rbDryer As RadioButton
    Friend WithEvents rbOven As RadioButton
    Friend WithEvents lblKWPower As Label
    Friend WithEvents txtPower As TextBox
    Friend WithEvents lblUse As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents rbWasher As RadioButton
    Friend WithEvents lblCPG As Label
    Friend WithEvents lblGallons As Label
    Friend WithEvents txtCPG As TextBox
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents lstAppliances As ListBox
    Friend WithEvents txtAllTotal As TextBox
    Friend WithEvents lblAppliances As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnClear As Button
End Class
