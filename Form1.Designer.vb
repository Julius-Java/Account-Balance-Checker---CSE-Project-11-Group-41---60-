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
        btnCalculateAccountBalance = New Button()
        txtInitialBalance = New TextBox()
        lblInitialBalance = New Label()
        txtDeposit = New TextBox()
        lblDeposit = New Label()
        lblWithdrawal = New Label()
        lblWithdrawalAmount = New Label()
        txtWithdrawalAmount = New TextBox()
        btnContributors = New Button()
        SuspendLayout()
        ' 
        ' btnCalculateAccountBalance
        ' 
        btnCalculateAccountBalance.Location = New Point(297, 297)
        btnCalculateAccountBalance.Name = "btnCalculateAccountBalance"
        btnCalculateAccountBalance.Size = New Size(167, 44)
        btnCalculateAccountBalance.TabIndex = 0
        btnCalculateAccountBalance.Text = "Calculate Balance"
        btnCalculateAccountBalance.UseVisualStyleBackColor = True
        ' 
        ' txtInitialBalance
        ' 
        txtInitialBalance.Location = New Point(297, 64)
        txtInitialBalance.Name = "txtInitialBalance"
        txtInitialBalance.Size = New Size(167, 23)
        txtInitialBalance.TabIndex = 1
        ' 
        ' lblInitialBalance
        ' 
        lblInitialBalance.AutoSize = True
        lblInitialBalance.Location = New Point(297, 46)
        lblInitialBalance.Name = "lblInitialBalance"
        lblInitialBalance.Size = New Size(117, 15)
        lblInitialBalance.TabIndex = 2
        lblInitialBalance.Text = "Initial Balance (NGN)"
        ' 
        ' txtDeposit
        ' 
        txtDeposit.Location = New Point(297, 142)
        txtDeposit.Name = "txtDeposit"
        txtDeposit.Size = New Size(167, 23)
        txtDeposit.TabIndex = 3
        ' 
        ' lblDeposit
        ' 
        lblDeposit.AutoSize = True
        lblDeposit.Location = New Point(297, 124)
        lblDeposit.Name = "lblDeposit"
        lblDeposit.Size = New Size(84, 15)
        lblDeposit.TabIndex = 4
        lblDeposit.Text = "Deposit (NGN)"
        ' 
        ' lblWithdrawal
        ' 
        lblWithdrawal.AutoSize = True
        lblWithdrawal.Location = New Point(297, 200)
        lblWithdrawal.Name = "lblWithdrawal"
        lblWithdrawal.Size = New Size(0, 15)
        lblWithdrawal.TabIndex = 6
        ' 
        ' lblWithdrawalAmount
        ' 
        lblWithdrawalAmount.AutoSize = True
        lblWithdrawalAmount.Location = New Point(297, 200)
        lblWithdrawalAmount.Name = "lblWithdrawalAmount"
        lblWithdrawalAmount.Size = New Size(151, 15)
        lblWithdrawalAmount.TabIndex = 7
        lblWithdrawalAmount.Text = "Withdrawal Amount (NGN)"
        ' 
        ' txtWithdrawalAmount
        ' 
        txtWithdrawalAmount.Location = New Point(297, 218)
        txtWithdrawalAmount.Name = "txtWithdrawalAmount"
        txtWithdrawalAmount.Size = New Size(167, 23)
        txtWithdrawalAmount.TabIndex = 8
        ' 
        ' btnContributors
        ' 
        btnContributors.Location = New Point(535, 372)
        btnContributors.Name = "btnContributors"
        btnContributors.Size = New Size(189, 35)
        btnContributors.TabIndex = 9
        btnContributors.Text = "Project Contributors"
        btnContributors.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 450)
        Controls.Add(btnContributors)
        Controls.Add(txtWithdrawalAmount)
        Controls.Add(lblWithdrawalAmount)
        Controls.Add(lblWithdrawal)
        Controls.Add(lblDeposit)
        Controls.Add(txtDeposit)
        Controls.Add(lblInitialBalance)
        Controls.Add(txtInitialBalance)
        Controls.Add(btnCalculateAccountBalance)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculateAccountBalance As Button
    Friend WithEvents txtInitialBalance As TextBox
    Friend WithEvents lblInitialBalance As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents lblDeposit As Label
    Friend WithEvents lblWithdrawal As Label
    Friend WithEvents lblWithdrawalAmount As Label
    Friend WithEvents txtWithdrawalAmount As TextBox
    Friend WithEvents btnContributors As Button

End Class
