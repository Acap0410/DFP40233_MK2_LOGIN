<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtId = New TextBox()
        txtPass = New TextBox()
        id = New Label()
        pass = New Label()
        BtnLogin = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(30, 106)
        txtId.Margin = New Padding(4, 3, 4, 3)
        txtId.Name = "txtId"
        txtId.Size = New Size(282, 30)
        txtId.TabIndex = 0
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(30, 168)
        txtPass.Margin = New Padding(4, 3, 4, 3)
        txtPass.Name = "txtPass"
        txtPass.Size = New Size(282, 30)
        txtPass.TabIndex = 1
        ' 
        ' id
        ' 
        id.AutoSize = True
        id.Location = New Point(117, 81)
        id.Margin = New Padding(4, 0, 4, 0)
        id.Name = "id"
        id.Size = New Size(112, 23)
        id.TabIndex = 2
        id.Text = "ID Pengguna"
        ' 
        ' pass
        ' 
        pass.AutoSize = True
        pass.Location = New Point(118, 142)
        pass.Margin = New Padding(4, 0, 4, 0)
        pass.Name = "pass"
        pass.Size = New Size(103, 23)
        pass.TabIndex = 3
        pass.Text = "Kata Laluan"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = SystemColors.ActiveCaption
        BtnLogin.Location = New Point(118, 223)
        BtnLogin.Margin = New Padding(4, 3, 4, 3)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(118, 33)
        BtnLogin.TabIndex = 4
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 20)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 38)
        Label3.TabIndex = 5
        Label3.Text = "LOG MASUK"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(342, 283)
        Controls.Add(Label3)
        Controls.Add(BtnLogin)
        Controls.Add(pass)
        Controls.Add(id)
        Controls.Add(txtPass)
        Controls.Add(txtId)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents id As Label
    Friend WithEvents pass As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Label3 As Label

End Class
