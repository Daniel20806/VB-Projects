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
        components = New ComponentModel.Container()
        DiceTimer1 = New Timer(components)
        DiceTimer2 = New Timer(components)
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' DiceTimer1
        ' 
        ' 
        ' DiceTimer2
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(435, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "a, 123"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(401, 228)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(47, 23)
        TextBox1.TabIndex = 1
        TextBox1.Text = "a"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(401, 257)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "確認步數"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(454, 228)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(42, 23)
        TextBox2.TabIndex = 3
        TextBox2.Text = "123"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(401, 286)
        Button3.Name = "Button3"
        Button3.Size = New Size(117, 23)
        Button3.TabIndex = 4
        Button3.Text = "玩家一獲取監獄卡"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 466)
        Controls.Add(Button3)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DiceTimer1 As Timer
    Friend WithEvents DiceTimer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button

End Class
