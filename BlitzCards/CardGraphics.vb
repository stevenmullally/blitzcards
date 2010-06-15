'    Copyright (C) 2010  Ryan Skeldon <psykad@gmail.com>
'
'    This program is free software; you can redistribute it and/or modify
'    it under the terms of the GNU General Public License as published by
'    the Free Software Foundation; either version 2 of the License, or
'    (at your option) any later version.
'
'    This program is distributed in the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty of
'    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License for more details.
'
'    You should have received a copy of the GNU General Public License
'    along with this program; if not, write to the Free Software
'    Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
Option Explicit On
Imports System.Drawing

Public Module CardGraphics

#Region "Properties"
    ''' <summary>
    ''' Gets the height of the card images.
    ''' </summary>
    ''' <remarks></remarks>
    Private _cardHeight As Integer
    Public ReadOnly Property CardHeight() As Integer
        Get
            Return _cardHeight
        End Get
    End Property

    ''' <summary>
    ''' Gets the width of the card images.
    ''' </summary>
    ''' <remarks></remarks>
    Private _cardWidth As Integer
    Public ReadOnly Property CardWidth() As Integer
        Get
            Return _cardWidth
        End Get
    End Property
#End Region

#Region "Public Methods"
    ''' <summary>
    ''' Draws a card of the given ID at a user specified X and Y location.
    ''' </summary>
    ''' <param name="drawingSurface">Graphics object used for drawing the card.</param>
    ''' <param name="xLoc">X location of the card.</param>
    ''' <param name="yLoc">Y location of the card.</param>
    ''' <param name="card">ID of the card to be drawn.</param>
    ''' <param name="type">Inversion status of the card.</param>
    ''' <remarks></remarks>
    Public Sub DrawCard(ByVal drawingSurface As Graphics, ByVal xLoc As Integer, ByVal yLoc As Integer, ByVal card As Byte, ByVal type As Byte)
        Dim invert As Boolean

        Select Case type
            Case 0 ' Card front
                invert = False
            Case 1 ' Card back
                invert = False
            Case 2 ' Card inverted
                invert = True
        End Select

        Dim srcBmp As New Bitmap(getCard(card, invert))

        drawingSurface.DrawImage(srcBmp, xLoc, yLoc)
    End Sub

    ''' <summary>
    ''' Initializes card library
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InitCards() As Boolean
        Try
            Dim tempCard As New Bitmap(My.Resources.blueback)

            _cardHeight = tempCard.Height
            _cardWidth = tempCard.Width

            tempCard = Nothing
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "Private Methods"
    ''' <summary>
    ''' Gets the graphic resource associated with the given ID.
    ''' </summary>
    ''' <param name="cardID">Card ID.</param>
    ''' <param name="cardInvert">Inversion status of the card.</param>
    ''' <returns>A bitmap of the card ID.</returns>
    ''' <remarks></remarks>
    Private Function getCard(ByVal cardID As Byte, ByVal cardInvert As Boolean) As Bitmap
        Select Case cardID
            Case 0
                If cardInvert Then
                    Return My.Resources.aceclubsi
                Else
                    Return My.Resources.aceclubs
                End If
            Case 1
                If cardInvert Then
                    Return My.Resources.acediamondsi
                Else
                    Return My.Resources.acediamonds
                End If
            Case 2
                If cardInvert Then
                    Return My.Resources.aceheartsi
                Else
                    Return My.Resources.acehearts
                End If
            Case 3
                If cardInvert Then
                    Return My.Resources.acespadesi
                Else
                    Return My.Resources.acespades
                End If
            Case 4
                If cardInvert Then
                    Return My.Resources.twoclubsi
                Else
                    Return My.Resources.twoclubs
                End If
            Case 5
                If cardInvert Then
                    Return My.Resources.twodiamondsi
                Else
                    Return My.Resources.twodiamonds
                End If
            Case 6
                If cardInvert Then
                    Return My.Resources.twoheartsi
                Else
                    Return My.Resources.twohearts
                End If
            Case 7
                If cardInvert Then
                    Return My.Resources.twospadesi
                Else
                    Return My.Resources.twospades
                End If
            Case 8
                If cardInvert Then
                    Return My.Resources.threeclubsi
                Else
                    Return My.Resources.threeclubs
                End If
            Case 9
                If cardInvert Then
                    Return My.Resources.threediamondsi
                Else
                    Return My.Resources.threediamonds
                End If
            Case 10
                If cardInvert Then
                    Return My.Resources.threeheartsi
                Else
                    Return My.Resources.threehearts
                End If
            Case 11
                If cardInvert Then
                    Return My.Resources.threespadesi
                Else
                    Return My.Resources.threespades
                End If
            Case 12
                If cardInvert Then
                    Return My.Resources.fourclubsi
                Else
                    Return My.Resources.fourclubs
                End If
            Case 13
                If cardInvert Then
                    Return My.Resources.fourdiamondsi
                Else
                    Return My.Resources.fourdiamonds
                End If
            Case 14
                If cardInvert Then
                    Return My.Resources.fourheartsi
                Else
                    Return My.Resources.fourhearts
                End If
            Case 15
                If cardInvert Then
                    Return My.Resources.fourspadesi
                Else
                    Return My.Resources.fourspades
                End If
            Case 16
                If cardInvert Then
                    Return My.Resources.fiveclubsi
                Else
                    Return My.Resources.fiveclubs
                End If
            Case 17
                If cardInvert Then
                    Return My.Resources.fivediamondsi
                Else
                    Return My.Resources.fivediamonds
                End If
            Case 18
                If cardInvert Then
                    Return My.Resources.fiveheartsi
                Else
                    Return My.Resources.fivehearts
                End If
            Case 19
                If cardInvert Then
                    Return My.Resources.fivespadesi
                Else
                    Return My.Resources.fivespades
                End If
            Case 20
                If cardInvert Then
                    Return My.Resources.sixclubsi
                Else
                    Return My.Resources.sixclubs
                End If
            Case 21
                If cardInvert Then
                    Return My.Resources.sixdiamondsi
                Else
                    Return My.Resources.sixdiamonds
                End If
            Case 22
                If cardInvert Then
                    Return My.Resources.sixheartsi
                Else
                    Return My.Resources.sixhearts
                End If
            Case 23
                If cardInvert Then
                    Return My.Resources.sixspadesi
                Else
                    Return My.Resources.sixspades
                End If
            Case 24
                If cardInvert Then
                    Return My.Resources.sevenclubsi
                Else
                    Return My.Resources.sevenclubs
                End If
            Case 25
                If cardInvert Then
                    Return My.Resources.sevendiamondsi
                Else
                    Return My.Resources.sevendiamonds
                End If
            Case 26
                If cardInvert Then
                    Return My.Resources.sevenheartsi
                Else
                    Return My.Resources.sevenhearts
                End If
            Case 27
                If cardInvert Then
                    Return My.Resources.sevenspadesi
                Else
                    Return My.Resources.sevenspades
                End If
            Case 28
                If cardInvert Then
                    Return My.Resources.eightclubsi
                Else
                    Return My.Resources.eightclubs
                End If
            Case 29
                If cardInvert Then
                    Return My.Resources.eightdiamondsi
                Else
                    Return My.Resources.eightdiamonds
                End If
            Case 30
                If cardInvert Then
                    Return My.Resources.eightheartsi
                Else
                    Return My.Resources.eighthearts
                End If
            Case 31
                If cardInvert Then
                    Return My.Resources.eightspadesi
                Else
                    Return My.Resources.eightspades
                End If
            Case 32
                If cardInvert Then
                    Return My.Resources.nineclubsi
                Else
                    Return My.Resources.nineclubs
                End If
            Case 33
                If cardInvert Then
                    Return My.Resources.ninediamondsi
                Else
                    Return My.Resources.ninediamonds
                End If
            Case 34
                If cardInvert Then
                    Return My.Resources.nineheartsi
                Else
                    Return My.Resources.ninehearts
                End If
            Case 35
                If cardInvert Then
                    Return My.Resources.ninespadesi
                Else
                    Return My.Resources.ninespades
                End If
            Case 36
                If cardInvert Then
                    Return My.Resources.tenclubsi
                Else
                    Return My.Resources.tenclubs
                End If
            Case 37
                If cardInvert Then
                    Return My.Resources.tendiamondsi
                Else
                    Return My.Resources.tendiamonds
                End If
            Case 38
                If cardInvert Then
                    Return My.Resources.tenheartsi
                Else
                    Return My.Resources.tenhearts
                End If
            Case 39
                If cardInvert Then
                    Return My.Resources.tenspadesi
                Else
                    Return My.Resources.tenspades
                End If
            Case 40
                If cardInvert Then
                    Return My.Resources.jackclubsi
                Else
                    Return My.Resources.jackclubs
                End If
            Case 41
                If cardInvert Then
                    Return My.Resources.jackdiamondsi
                Else
                    Return My.Resources.jackdiamonds
                End If
            Case 42
                If cardInvert Then
                    Return My.Resources.jackheartsi
                Else
                    Return My.Resources.jackhearts
                End If
            Case 43
                If cardInvert Then
                    Return My.Resources.jackspadesi
                Else
                    Return My.Resources.jackspades
                End If
            Case 44
                If cardInvert Then
                    Return My.Resources.queenclubsi
                Else
                    Return My.Resources.queenclubs
                End If
            Case 45
                If cardInvert Then
                    Return My.Resources.queendiamondsi
                Else
                    Return My.Resources.queendiamonds
                End If
            Case 46
                If cardInvert Then
                    Return My.Resources.queenheartsi
                Else
                    Return My.Resources.queenhearts
                End If
            Case 47
                If cardInvert Then
                    Return My.Resources.queenspadesi
                Else
                    Return My.Resources.queenspades
                End If
            Case 48
                If cardInvert Then
                    Return My.Resources.kingclubsi
                Else
                    Return My.Resources.kingclubs
                End If
            Case 49
                If cardInvert Then
                    Return My.Resources.kingdiamondsi
                Else
                    Return My.Resources.kingdiamonds
                End If
            Case 50
                If cardInvert Then
                    Return My.Resources.kingheartsi
                Else
                    Return My.Resources.kinghearts
                End If
            Case 51
                If cardInvert Then
                    Return My.Resources.kingspadesi
                Else
                    Return My.Resources.kingspades
                End If
            Case 52
                If cardInvert Then
                    Return My.Resources.bluebacki
                Else
                    Return My.Resources.blueback
                End If
        End Select

        Return Nothing
    End Function
#End Region
End Module
