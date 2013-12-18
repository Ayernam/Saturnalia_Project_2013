Public Class Form1
    <System.Runtime.InteropServices.DllImport("User32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Dim pencil As System.Drawing.Graphics
    Dim chariot As New Point(0, 250)
    Dim enemy(4) As Point
    Dim rndm As New Random
    Dim counter, health, distance, time(1), speed As Integer
    Dim birds, clouds, rocks, plane, meteor As Boolean
    Dim playerName, hitCause As String
    Dim font1 As New Font("Arial", 13)

    ' This SoundPlayer plays a sound whenever the player fails the game.
    Private startSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\chord.wav")
    ' This SoundPlayer plays a sound when the player wins the game.
    Private finishSoundPlayer = New System.Media.SoundPlayer("C:\Windows\Media\tada.wav")

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load components
        pencil = Me.CreateGraphics
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Begin game
        Timer1.Enabled = True
        playerName = TextBox1.Text
        GroupBox1.Hide()

        'Reset variables
        chariot.X =
        chariot.Y = 250
        counter = 0
        If Easy.Checked Then
            health = 3
            speed = 8
        End If

        If Medium.Checked Then
            health = 2
            speed = 6
        End If

        If Hard.Checked Then
            health = 1
            speed = 4
        End If
        distance = 1000
        time(0) = 0
        time(1) = 0
        birds = False
        clouds = False
        rocks = False
        plane = False
        meteor = False
    End Sub

    Private Sub reset(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Label2.Text = "Health: 3 lives"
        Label3.Text = "Distance left: 1000 m"
        Label4.Text = "Time: 0:00"
        ProgressBar1.Value = 0
        pencil.Clear(Me.BackColor)
        GroupBox1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'In game actions
        drawBackground()
        drawChariot()
        drawEnemy()
        checkHits()
        updatePanel()

        checkKeys()

        spawnEnemy()

        If counter <= 1000 Then counter += 1 Else counter = 0
    End Sub

    Public Sub drawChariot()
        'Character
        pencil.FillRectangle(Brushes.PeachPuff, chariot.X + 20, chariot.Y - 10, 10, 10)
        'Chariot
        pencil.FillRectangle(Brushes.Maroon, chariot.X, chariot.Y, 50, 20)
        'Sun
        pencil.FillEllipse(Brushes.Goldenrod, chariot.X - 120, chariot.Y - 50, 100, 100)
        'Rope
        pencil.DrawLine(Pens.Brown, chariot.X - 20, chariot.Y + 10, chariot.X, chariot.Y + 10)
    End Sub

    Public Sub drawBackground()
        Select Case distance
            Case 900 To 1000
                pencil.FillRectangle(Brushes.Black, 0, 0, 600, 500)
            Case 800 To 900
                pencil.FillRectangle(Brushes.DarkSlateBlue, 0, 0, 600, 500)
            Case 700 To 800
                pencil.FillRectangle(Brushes.DarkViolet, 0, 0, 600, 500)
            Case 600 To 700
                pencil.FillRectangle(Brushes.MediumVioletRed, 0, 0, 600, 500)
            Case 500 To 600
                pencil.FillRectangle(Brushes.PaleVioletRed, 0, 0, 600, 500)
            Case 400 To 500
                pencil.FillRectangle(Brushes.IndianRed, 0, 0, 600, 500)
            Case 300 To 400
                pencil.FillRectangle(Brushes.Orange, 0, 0, 600, 500)
            Case 200 To 300
                pencil.FillRectangle(Brushes.OrangeRed, 0, 0, 600, 500)
            Case 100 To 200
                pencil.FillRectangle(Brushes.LightSkyBlue, 0, 0, 600, 500)
            Case 0 To 100
                pencil.FillRectangle(Brushes.SkyBlue, 0, 0, 600, 500)
        End Select

        'Update distance and time
        If counter Mod 2 = 0 Then distance -= 1
        ProgressBar1.Value = 100 - (distance * (100 / 1000))
        time(0) = 12 - (distance * (12 / 1000))
        time(1) = 60 - ((distance Mod (83.3)) * (60 / (83.3)))

        If distance = 0 Then
            Timer1.Stop()
            MsgBox("Congratulations " & playerName & "!  You have brought light to the land!  Let there be a glorious new year!")
        End If
    End Sub

    Public Sub checkKeys()
        'Check arrow keys
        If GetAsyncKeyState(Keys.Down) And chariot.Y < 430 Then
            chariot.Y += speed
        End If
        If GetAsyncKeyState(Keys.Up) And chariot.Y > 20 Then
            chariot.Y -= speed
        End If
        If GetAsyncKeyState(Keys.Left) And chariot.X > 0 Then
            chariot.X -= speed
        End If
        If GetAsyncKeyState(Keys.Right) And chariot.X < 550 Then
            chariot.X += speed
        End If
    End Sub

    Public Sub updatePanel()
        If health = 1 Then Label2.Text = "Health: " & health & " life" Else Label2.Text = "Health: " & health & " lives"
        Label3.Text = "Distance left: " & distance & " m"
        If time(1) < 10 Then Label4.Text = "Time: " & time(0) & ":0" & time(1) Else Label4.Text = "Time: " & time(0) & ":" & time(1)
    End Sub

    Public Sub spawnEnemy()
        'If counter = 1000 Then
        Select Case rndm.Next(0, 5)
            Case 0
                If birds = False Then
                    birds = True
                    enemy(0).X = 700
                    enemy(0).Y = rndm.Next(20, 400)
                End If
            Case 1
                If clouds = False Then
                    clouds = True
                    enemy(1).X = 700
                    enemy(1).Y = rndm.Next(20, 400)
                End If
            Case 2
                If rocks = False Then
                    rocks = True
                    enemy(2).X = 700
                    enemy(2).Y = rndm.Next(20, 400)
                End If
            Case 3
                If plane = False Then
                    plane = True
                    enemy(3).X = 700
                    enemy(3).Y = rndm.Next(20, 400)
                End If
            Case 4
                If meteor = False Then
                    meteor = True
                    enemy(4).X = 700
                    enemy(4).Y = rndm.Next(20, 400)
                End If
        End Select
        'End If
    End Sub

    Public Sub drawEnemy()
        If birds = True Then
            pencil.FillRectangle(Brushes.Brown, enemy(0).X, enemy(0).Y, 10, 10)
            pencil.FillRectangle(Brushes.Brown, enemy(0).X + 30, enemy(0).Y - 15, 10, 10)
            pencil.FillRectangle(Brushes.Brown, enemy(0).X + 30, enemy(0).Y + 15, 10, 10)
            pencil.FillRectangle(Brushes.Brown, enemy(0).X + 60, enemy(0).Y - 30, 10, 10)
            pencil.FillRectangle(Brushes.Brown, enemy(0).X + 60, enemy(0).Y + 30, 10, 10)
            pencil.FillRectangle(Brushes.Brown, enemy(0).X + 90, enemy(0).Y - 45, 10, 10)
            pencil.FillRectangle(Brushes.Brown, enemy(0).X + 90, enemy(0).Y + 45, 10, 10)

            If enemy(0).X > -100 Then enemy(0).X -= 5 Else birds = False
        End If

        If clouds = True Then
            pencil.FillRectangle(Brushes.White, enemy(1).X, enemy(1).Y, 100, 50)
            pencil.FillRectangle(Brushes.White, enemy(1).X + 20, enemy(1).Y + 30, 100, 50)
            pencil.FillRectangle(Brushes.White, enemy(1).X + 50, enemy(1).Y - 10, 100, 50)
            pencil.FillRectangle(Brushes.White, enemy(1).X + 30, enemy(1).Y + 20, 100, 50)

            If enemy(1).X > -250 Then enemy(1).X -= 3 Else clouds = False
        End If

        If rocks = True Then
            pencil.FillRectangle(Brushes.SaddleBrown, enemy(2).X, enemy(2).Y, 50, 50)
            pencil.FillRectangle(Brushes.SaddleBrown, enemy(2).X + 70, enemy(2).Y - 30, 50, 50)
            pencil.FillRectangle(Brushes.SaddleBrown, enemy(2).X + 40, enemy(2).Y + 60, 50, 50)
            pencil.FillRectangle(Brushes.SaddleBrown, enemy(2).X + 110, enemy(2).Y + 30, 50, 50)

            If enemy(2).X > -500 Then enemy(2).X -= 4 Else rocks = False
        End If

        If plane = True Then
            pencil.FillRectangle(Brushes.LightSlateGray, enemy(3).X, enemy(3).Y, 200, 50)
            pencil.FillRectangle(Brushes.LightSlateGray, enemy(3).X + 80, enemy(3).Y - 50, 50, 150)
            pencil.FillRectangle(Brushes.LightSlateGray, enemy(3).X + 180, enemy(3).Y - 20, 30, 90)
            pencil.FillRectangle(Brushes.LightSlateGray, enemy(3).X + 180, enemy(3).Y + 10, 50, 30)
            pencil.DrawString("Time Travel Inc.", font1, Brushes.Black, enemy(3).X + 30, enemy(3).Y + 15)

            If enemy(3).X > -800 Then enemy(3).X -= 2 Else plane = False
        End If

        If meteor = True Then
            pencil.FillRectangle(Brushes.DarkGray, enemy(4).X, enemy(4).Y, 200, 200)
            pencil.FillRectangle(Brushes.OrangeRed, enemy(4).X + 50, enemy(4).Y + 30, 50, 50)
            pencil.FillRectangle(Brushes.Orange, enemy(4).X + 120, enemy(4).Y + 50, 50, 50)
            pencil.FillRectangle(Brushes.Yellow, enemy(4).X + 60, enemy(4).Y + 100, 50, 50)

            If enemy(4).X > -1000 Then enemy(4).X -= 1 Else meteor = False
        End If
    End Sub

    Public Sub checkHits()
        If birds = True Then
            If chariot.X + 25 > enemy(0).X And chariot.X + 25 < enemy(0).X + 90 And chariot.Y + 10 > enemy(0).Y - 45 And chariot.Y + 10 < enemy(0).Y + 45 Then
                health -= 1
                birds = False
                hitCause = "birds"
            End If
        End If

        If clouds = True Then
            If chariot.X + 25 > enemy(1).X And chariot.X + 25 < enemy(1).X + 150 And chariot.Y + 10 > enemy(1).Y - 10 And chariot.Y + 10 < enemy(1).Y + 80 Then
                health -= 1
                clouds = False
                hitCause = "clouds"
            End If
        End If

        If rocks = True Then
            If chariot.X + 25 > enemy(2).X And chariot.X + 25 < enemy(2).X + 160 And chariot.Y + 10 > enemy(2).Y - 30 And chariot.Y + 10 < enemy(2).Y + 110 Then
                health -= 1
                rocks = False
                hitCause = "rocks"
            End If
        End If

        If plane = True Then
            If chariot.X + 25 > enemy(3).X And chariot.X + 25 < enemy(3).X + 230 And chariot.Y + 10 > enemy(3).Y - 50 And chariot.Y + 10 < enemy(3).Y + 50 Then
                health -= 1
                plane = False
                hitCause = "plane"
            End If
        End If

        If meteor = True Then
            If chariot.X + 25 > enemy(4).X And chariot.X + 25 < enemy(4).X + 200 And chariot.Y + 10 > enemy(4).Y And chariot.Y + 10 < enemy(4).Y + 200 Then
                health -= 1
                meteor = False
                hitCause = "meteor"
            End If
        End If

        If health <= 0 Then
            'End game
            Timer1.Stop()
            Select Case hitCause
                Case "birds"
                    MsgBox(playerName & " was pecked to death by birds!")
                Case "clouds"
                    MsgBox(playerName & " was blinded by clouds!")
                Case "rocks"
                    MsgBox(playerName & " was pummeled by rocks!")
                Case "plane"
                    MsgBox(playerName & " crashed into a plane!")
                Case "meteor"
                    MsgBox(playerName & " was struck by a meteor!")
            End Select
            MsgBox("The land was thrown into eternal darkness!  Oh no!" & vbNewLine & "Press the restart button to try again.")
        End If
    End Sub

    Private Sub Pause(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Text = "Pause" Then
            Timer1.Stop()
            Button3.Text = "Unpause"
        ElseIf Button3.Text = "Unpause" Then
            Timer1.Start()
            Button3.Text = "Pause"
        End If
    End Sub
End Class
