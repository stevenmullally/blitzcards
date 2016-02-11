# Introduction #

The BlitzCards library is meant to be used as an open-source alternative to Microsoft's cards.dll. It is used in the same manner that MS's library is used. The library contains a standard deck, 2 through 10, Jack, Queen, King, Ace. There is an invert option to mimic a "highlighted" card. At the moment, there is only one deck pattern availible but can be customized if you choose to add new image resources to the library and recompile.

# Using BlitzCards In Your Project #

## Public Methods ##
  * **InitCards**
    * _Type: Function_
    * _Returns: Boolean_
    * _Arguments: None_
    * _Use: Setups the card's dimensions publicly._
  * **DrawCard**
    * _Type: Sub_
    * _Returns: Nothing_
    * _Arguments:_
      * drawingSurface
        * _Type: Graphics_
      * xLoc
        * _Type: Integer_
      * yLoc
        * _Type: Integer_
      * card
        * _Type: Byte_
      * type
        * _Type: Byte_
    * _Use: Draws a card on the given device context._

## Examples ##
### _VB.Net_ ###
```
Imports BlitzCards.CardGraphics

Public Sub InitializeCards()
   If BlitzCards.InitCards Then
      ' Cards library succesfully initialized.
      ' You can now pull card dimensions from the library.
      Dim cardHeight = BlitzCards.CardHeight
      Dim cardWidth = BlitzCards.CardWidth
   Else
      'Failed to initialize library.
   End If
End Sub

Private Sub MainForm_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
   ' Draws an Ace of Clubs at the top, left part of the form.
   BlitzCards.DrawCard(e.Graphics, 0, 0, 0, 0)
   
   ' Draws an inverted Two of Clubs at location 50, 50 on the form.
   BlitzCards.DrawCard(e.Graphics, 50, 50, 4, 1)
End Sub
```