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
        btnAdd = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnDivide = New Button()
        btnMultiplication = New Button()
        btnsubtract = New Button()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(465, 255)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 0
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 1
        Label1.Text = "Enter number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(224, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(224, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(296, 255)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(75, 23)
        btnDivide.TabIndex = 4
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplication
        ' 
        btnMultiplication.Location = New Point(133, 255)
        btnMultiplication.Name = "btnMultiplication"
        btnMultiplication.Size = New Size(75, 23)
        btnMultiplication.TabIndex = 5
        btnMultiplication.Text = "*"
        btnMultiplication.UseVisualStyleBackColor = True
        ' 
        ' btnsubtract
        ' 
        btnsubtract.Location = New Point(21, 255)
        btnsubtract.Name = "btnsubtract"
        btnsubtract.Size = New Size(75, 23)
        btnsubtract.TabIndex = 6
        btnsubtract.Text = "-"
        btnsubtract.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnsubtract)
        Controls.Add(btnMultiplication)
        Controls.Add(btnDivide)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnsubtract As Button
End Class
