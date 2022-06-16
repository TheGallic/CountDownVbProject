Public Class Form1
    Public pbValue As Long
    Public cdTimestamp As Long
    Public formatedTime As String
    Public pctProgress As Integer

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        If NupHours.Value = 0 And NupMinutes.Value = 0 And NupSecondes.Value = 0 Then
            MessageBox.Show("Sélectionner une valeur !!")
        Else
            BtnStart.Enabled = False
            TimerCountDown.Enabled = True
            If BtnPause.Enabled = True Then
                ' On récupere la valeur des listes numerique pour les formater puis les convertir en secondes
                formatedTime = NupHours.Value & ":" & NupMinutes.Value & ":" & NupSecondes.Value
                cdTimestamp = TimeSpan.Parse(formatedTime).TotalSeconds

                CpbCountDown.Maximum = cdTimestamp
                pbValue = cdTimestamp
            End If
            TimerCountDown.Start()
        End If
    End Sub

    Private Sub BtnPause_Click(sender As Object, e As EventArgs) Handles BtnPause.Click
        BtnStart.Enabled = True
        BtnPause.Enabled = False
        BtnStart.Text = "Redémarrer"
        TimerCountDown.Stop()
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        StopChrono()
    End Sub

    Private Sub TimerCountDown_Tick(sender As Object, e As EventArgs) Handles TimerCountDown.Tick
        If pbValue >= 0 Then
            CpbCountDown.Value = pbValue

            pctProgress = (pbValue / cdTimestamp) * 100
            ' On change la couleur de la barre de progression suivant son état d'avancement
            If pctProgress > 75 Then
                CpbCountDown.ProgressColor = Color.Green
            ElseIf pctProgress < 75 And pctProgress > 50 Then
                CpbCountDown.ProgressColor = Color.Blue
            ElseIf pctProgress < 50 And pctProgress > 25 Then
                CpbCountDown.ProgressColor = Color.Orange
            ElseIf pctProgress < 25 Then
                CpbCountDown.ProgressColor = Color.Red
            End If
            'On convertie les secondes en heures minutes secondes grace a la fonction TimeSpan
            CpbCountDown.Text = TimeSpan.FromSeconds(pbValue).ToString("hh\:mm\:ss")
            'On décremente le compteur
            pbValue -= 1
        Else
            StopChrono()
            Exit Sub
        End If
    End Sub


    'On réinitialise tout
    Private Sub StopChrono()
        TimerCountDown.Stop()
        TimerCountDown.Dispose()
        TimerCountDown.Enabled = False
        MessageBox.Show("Compte à rebours términé !!!", CStr(MessageBoxIcon.Information))
        CpbCountDown.Text = "00:00:00"
        CpbCountDown.Value = 0
        NupHours.Value = 0
        NupMinutes.Value = 0
        NupSecondes.Value = 0
        pbValue = 0
        cdTimestamp = 0
        BtnStart.Enabled = True
        BtnPause.Enabled = True
        BtnStart.Text = "Démarrer"

    End Sub
End Class
