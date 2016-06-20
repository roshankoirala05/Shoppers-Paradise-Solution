<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
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
        Me.membershiptypegroupbox = New System.Windows.Forms.GroupBox()
        Me.Premiumradiobutton = New System.Windows.Forms.RadioButton()
        Me.Standardradiobutton = New System.Windows.Forms.RadioButton()
        Me.Basicradiobutton = New System.Windows.Forms.RadioButton()
        Me.Totalmonthlypurchaselabel = New System.Windows.Forms.Label()
        Me.Totalmonthlypurchasetextbox = New System.Windows.Forms.TextBox()
        Me.Rewardpointslabel = New System.Windows.Forms.Label()
        Me.Displaylabel = New System.Windows.Forms.Label()
        Me.Calculaterewardpointbutton = New System.Windows.Forms.Button()
        Me.Exitbutton = New System.Windows.Forms.Button()
        Me.Dollarlabel = New System.Windows.Forms.Label()
        Me.membershiptypegroupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'membershiptypegroupbox
        '
        Me.membershiptypegroupbox.Controls.Add(Me.Premiumradiobutton)
        Me.membershiptypegroupbox.Controls.Add(Me.Standardradiobutton)
        Me.membershiptypegroupbox.Controls.Add(Me.Basicradiobutton)
        Me.membershiptypegroupbox.Location = New System.Drawing.Point(17, 14)
        Me.membershiptypegroupbox.Name = "membershiptypegroupbox"
        Me.membershiptypegroupbox.Size = New System.Drawing.Size(154, 124)
        Me.membershiptypegroupbox.TabIndex = 0
        Me.membershiptypegroupbox.TabStop = False
        Me.membershiptypegroupbox.Text = "Membership type"
        '
        'Premiumradiobutton
        '
        Me.Premiumradiobutton.AutoSize = True
        Me.Premiumradiobutton.Location = New System.Drawing.Point(21, 98)
        Me.Premiumradiobutton.Name = "Premiumradiobutton"
        Me.Premiumradiobutton.Size = New System.Drawing.Size(65, 17)
        Me.Premiumradiobutton.TabIndex = 2
        Me.Premiumradiobutton.TabStop = True
        Me.Premiumradiobutton.Text = "Premium"
        Me.Premiumradiobutton.UseVisualStyleBackColor = True
        '
        'Standardradiobutton
        '
        Me.Standardradiobutton.AutoSize = True
        Me.Standardradiobutton.Location = New System.Drawing.Point(21, 64)
        Me.Standardradiobutton.Name = "Standardradiobutton"
        Me.Standardradiobutton.Size = New System.Drawing.Size(68, 17)
        Me.Standardradiobutton.TabIndex = 1
        Me.Standardradiobutton.TabStop = True
        Me.Standardradiobutton.Text = "Standard"
        Me.Standardradiobutton.UseVisualStyleBackColor = True
        '
        'Basicradiobutton
        '
        Me.Basicradiobutton.AutoSize = True
        Me.Basicradiobutton.Location = New System.Drawing.Point(21, 32)
        Me.Basicradiobutton.Name = "Basicradiobutton"
        Me.Basicradiobutton.Size = New System.Drawing.Size(51, 17)
        Me.Basicradiobutton.TabIndex = 0
        Me.Basicradiobutton.TabStop = True
        Me.Basicradiobutton.Text = "Basic"
        Me.Basicradiobutton.UseVisualStyleBackColor = True
        '
        'Totalmonthlypurchaselabel
        '
        Me.Totalmonthlypurchaselabel.AutoSize = True
        Me.Totalmonthlypurchaselabel.Location = New System.Drawing.Point(25, 194)
        Me.Totalmonthlypurchaselabel.Name = "Totalmonthlypurchaselabel"
        Me.Totalmonthlypurchaselabel.Size = New System.Drawing.Size(120, 13)
        Me.Totalmonthlypurchaselabel.TabIndex = 1
        Me.Totalmonthlypurchaselabel.Text = "Total monthly purchase:"
        '
        'Totalmonthlypurchasetextbox
        '
        Me.Totalmonthlypurchasetextbox.Location = New System.Drawing.Point(28, 215)
        Me.Totalmonthlypurchasetextbox.Name = "Totalmonthlypurchasetextbox"
        Me.Totalmonthlypurchasetextbox.Size = New System.Drawing.Size(100, 20)
        Me.Totalmonthlypurchasetextbox.TabIndex = 2
        '
        'Rewardpointslabel
        '
        Me.Rewardpointslabel.AutoSize = True
        Me.Rewardpointslabel.Location = New System.Drawing.Point(251, 21)
        Me.Rewardpointslabel.Name = "Rewardpointslabel"
        Me.Rewardpointslabel.Size = New System.Drawing.Size(78, 13)
        Me.Rewardpointslabel.TabIndex = 3
        Me.Rewardpointslabel.Text = "Reward points:"
        '
        'Displaylabel
        '
        Me.Displaylabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Displaylabel.Location = New System.Drawing.Point(254, 46)
        Me.Displaylabel.Name = "Displaylabel"
        Me.Displaylabel.Size = New System.Drawing.Size(132, 92)
        Me.Displaylabel.TabIndex = 4
        '
        'Calculaterewardpointbutton
        '
        Me.Calculaterewardpointbutton.Location = New System.Drawing.Point(254, 170)
        Me.Calculaterewardpointbutton.Name = "Calculaterewardpointbutton"
        Me.Calculaterewardpointbutton.Size = New System.Drawing.Size(132, 23)
        Me.Calculaterewardpointbutton.TabIndex = 5
        Me.Calculaterewardpointbutton.Text = "Calculate Reward Points"
        Me.Calculaterewardpointbutton.UseVisualStyleBackColor = True
        '
        'Exitbutton
        '
        Me.Exitbutton.Location = New System.Drawing.Point(254, 212)
        Me.Exitbutton.Name = "Exitbutton"
        Me.Exitbutton.Size = New System.Drawing.Size(132, 23)
        Me.Exitbutton.TabIndex = 6
        Me.Exitbutton.Text = "Exit"
        Me.Exitbutton.UseVisualStyleBackColor = True
        '
        'Dollarlabel
        '
        Me.Dollarlabel.AutoSize = True
        Me.Dollarlabel.Location = New System.Drawing.Point(14, 215)
        Me.Dollarlabel.Name = "Dollarlabel"
        Me.Dollarlabel.Size = New System.Drawing.Size(13, 13)
        Me.Dollarlabel.TabIndex = 7
        Me.Dollarlabel.Text = "$"
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 246)
        Me.Controls.Add(Me.Dollarlabel)
        Me.Controls.Add(Me.Exitbutton)
        Me.Controls.Add(Me.Calculaterewardpointbutton)
        Me.Controls.Add(Me.Displaylabel)
        Me.Controls.Add(Me.Rewardpointslabel)
        Me.Controls.Add(Me.Totalmonthlypurchasetextbox)
        Me.Controls.Add(Me.Totalmonthlypurchaselabel)
        Me.Controls.Add(Me.membershiptypegroupbox)
        Me.Name = "Mainform"
        Me.Text = "Shoppers Parardise"
        Me.membershiptypegroupbox.ResumeLayout(False)
        Me.membershiptypegroupbox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents membershiptypegroupbox As System.Windows.Forms.GroupBox
    Friend WithEvents Premiumradiobutton As System.Windows.Forms.RadioButton
    Friend WithEvents Standardradiobutton As System.Windows.Forms.RadioButton
    Friend WithEvents Basicradiobutton As System.Windows.Forms.RadioButton
    Friend WithEvents Totalmonthlypurchaselabel As System.Windows.Forms.Label
    Friend WithEvents Totalmonthlypurchasetextbox As System.Windows.Forms.TextBox
    Friend WithEvents Rewardpointslabel As System.Windows.Forms.Label
    Friend WithEvents Displaylabel As System.Windows.Forms.Label
    Friend WithEvents Calculaterewardpointbutton As System.Windows.Forms.Button
    Friend WithEvents Exitbutton As System.Windows.Forms.Button
    Friend WithEvents Dollarlabel As System.Windows.Forms.Label

End Class
