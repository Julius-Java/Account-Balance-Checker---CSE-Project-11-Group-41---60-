Public Class Form1
    Private Sub btnCalculateAccountBalance_Click(sender As Object, e As EventArgs) Handles btnCalculateAccountBalance.Click
        Dim stAccountHolder As String
        Dim dmInitialAccountBalance As Decimal
        Dim dmDeposit As Decimal
        Dim dmWithdrawalAmount As Decimal
        Dim dmFinalAccountBalance As Decimal
        Dim thisDay As Date
        Dim thisTime As Date

        dmInitialAccountBalance = txtInitialBalance.Text
        dmDeposit = txtDeposit.Text
        dmWithdrawalAmount = txtWithdrawalAmount.Text
        thisDay = Today
        thisTime = TimeOfDay

        dmFinalAccountBalance = dmInitialAccountBalance + dmDeposit - dmWithdrawalAmount

        stAccountHolder = InputBox("Please enter account name: ")
        MessageBox.Show(stAccountHolder & " your account balance is NGN" & dmFinalAccountBalance & " as at " _
                        & thisTime & " on " & thisDay
                        )
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnContributors_Click(sender As Object, e As EventArgs) Handles btnContributors.Click
        MessageBox.Show("Olaniran Olumide ayomide 220115060" _
                        & vbCrLf & vbCrLf & "Julius Emmanuel Oyigocho 220115044" _
                        & vbCrLf & vbCrLf & "Marcus Oluwadunsin Enoch 220115047" _
                        & vbCrLf & vbCrLf & "Ojodun Emmanuel Oluwaseun 220115054" _
                        & vbCrLf & vbCrLf & "Obafemi Oluwadamilare Joshua 220115050" _
                        & vbCrLf & vbCrLf & "Okeyode Eniola Maryam 220115056" _
                        & vbCrLf & vbCrLf & "Igoche Praise Ojochide 220115041" _
                        & vbCrLf & vbCrLf & "Olajire Esther Tosin 220115058" _
                        & vbCrLf & vbCrLf & "Olajolo Olayemi olaoluwa 220115059" _
                        & vbCrLf & vbCrLf & "Ogunbiyi Israel ayomide 220115053" _
                        & vbCrLf & vbCrLf & "Ogbonnah Chukwuebuka Richard 220115052" _
                        & vbCrLf & vbCrLf & "Mashonwo Farid Mayowa  220115048" _
                        & vbCrLf & vbCrLf & "Mahmud Abdulbasit Ayomide  220115046" _
                        & vbCrLf & vbCrLf & "NWILE OSINACHUKWU EMMANUEL 220115049" _
                        & vbCrLf & vbCrLf & "Isaac kelvin Osemudiame 220115042" _
                        & vbCrLf & vbCrLf & "John-Adeyemi Samuel Adewale 220115043" _
                        & vbCrLf & vbCrLf & "Ojuku Tochi chikaodi 220115055" _
                        & vbCrLf & vbCrLf & "Kuku Abdulrahman Oluwaseyi 220115045")
    End Sub
End Class
