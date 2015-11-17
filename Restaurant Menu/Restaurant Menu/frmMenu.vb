' Program Name: Restaurant Menu
' Author:       Ryan Trad
' Date:         September 22, 2010
' Purpose:      The purpose of this application is to 
'               allow costumers to order their food from 
'               an electronic menu rather than having a 
'               waiter come by and take you order.

Imports System.Net.Mail

Public Class frmMenu
    ' These are the declarations for the radio buttons
    ' so that the state can be saved.
    Dim blnAddCola As Boolean
    Dim blnAddLemonLime As Boolean
    Dim blnAddGrape As Boolean
    Dim blnAddOrange As Boolean
    Dim blnAddApple As Boolean
    Dim blnAddLemonade As Boolean
    Dim blnAddCheesePizza As Boolean
    Dim blnAddPepperoniPizza As Boolean
    Dim blnAddVegetable As Boolean
    Dim blnAddPepperoniCalzone As Boolean
    Dim blnAddSausage As Boolean
    Dim blnAddCheeseCalzone As Boolean
    Dim blnAddRavioli As Boolean
    Dim blnAddSpaghetti As Boolean
    Dim blnAddFettuccini As Boolean
    Dim blnAddChefs As Boolean
    Dim blnAddGreek As Boolean
    Dim blnAddItalian As Boolean
    Dim blnAddCannoli As Boolean
    Dim blnAddTiramisu As Boolean
    Dim blnAddCheesecake As Boolean

    ' These are the declarations for each item price
    ' and the total price.
    Dim decCola As Decimal
    Dim decLemonLime As Decimal
    Dim decGrape As Decimal
    Dim decOrange As Decimal
    Dim decApple As Decimal
    Dim decLemonade As Decimal
    Dim decCheesePizza As Decimal
    Dim decPepperoniPizza As Decimal
    Dim decVegetable As Decimal
    Dim decPepperoniCalzone As Decimal
    Dim decSausageCalzone As Decimal
    Dim decCheeseCalzone As Decimal
    Dim decRavioli As Decimal
    Dim decSpaghetti As Decimal
    Dim decFettuccini As Decimal
    Dim decChefs As Decimal
    Dim decGreek As Decimal
    Dim decItalian As Decimal
    Dim decCannoli As Decimal
    Dim decTiramisu As Decimal
    Dim decCheesecake As Decimal
    Dim decTotalPrice As Decimal

    ' This is the declaration for Speech.
    Dim Speech

    ' These are the declarations for the quantity
    Dim intColaQuantity As Int32
    Dim intLemonLimeQuantity As Int32
    Dim intGrapeQuantity As Int32
    Dim intOrangeQuantity As Int32
    Dim intAppleQuantity As Int32
    Dim intLemonadeQuantity As Int32
    Dim intCheesePizzaQuantity As Int32
    Dim intPepperoniPizzaQuantity As Int32
    Dim intVegetableQuantity As Int32
    Dim intPepperoniCalzoneQuantity As Int32
    Dim intSausageQuantity As Int32
    Dim intCheeseCalzoneQuantity As Int32
    Dim intRavioliQuantity As Int32
    Dim intSpaghettiQuantity As Int32
    Dim intFettucciniQuantity As Int32
    Dim intChefsQuantity As Int32
    Dim intGreekQuantity As Int32
    Dim intItalianQuantity As Int32
    Dim intCannoliQuantity As Int32
    Dim intTiramisuQuantity As Int32
    Dim intCheesecakeQuantity As Int32

    Private Sub btnBeverages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeverages.Click
        ' This code is executed when the user clicks the
        ' Beverages button. It makes the drink selections
        ' visible and everything else invisible.

        Me.pnlWaterNote.Visible = True
        Me.lblWaterNote.Visible = True
        Me.pnlBeverages.Visible = True
        Me.lblSodas.Visible = True
        Me.lblSodaMessage.Visible = True
        Me.lblJuices.Visible = True
        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCola.Visible = False
        Me.lblLemonLime.Visible = False
        Me.lblGrape.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.lblOrange.Visible = False
        Me.lblApple.Visible = False
        Me.lblLemonade.Visible = False
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.pnlEntrees.Visible = False
        Me.lblPizza.Visible = False
        Me.lblClazone.Visible = False
        Me.lblPasta.Visible = False
        Me.lblSalad.Visible = False
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.lblRavioli.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.pnlDesserts.Visible = False
        Me.lblCannoli.Visible = False
        Me.picCannoli.Visible = False
        Me.lblTiramisu.Visible = False
        Me.picTiramisu.Visible = False
        Me.lblCheesecake.Visible = False
        Me.picCheesecake.Visible = False
        Me.radAddCola.Visible = False
        Me.radAddLemonLime.Visible = False
        Me.radAddGrape.Visible = False
        Me.radAddOrange.Visible = False
        Me.radAddApple.Visible = False
        Me.radAddLemonade.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblSodas_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSodas.MouseHover
        ' This code is executed when the user hovers over
        ' the Sodas label. It displays the types of sodas
        ' and makes the juices invisible.

        Me.pnlSodasAndPizzas.Visible = True
        Me.lblCola.Visible = True
        Me.lblLemonLime.Visible = True
        Me.lblGrape.Visible = True
        Me.lblCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.lblOrange.Visible = False
        Me.lblApple.Visible = False
        Me.lblLemonade.Visible = False
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.radAddCola.Visible = False
        Me.radAddLemonLime.Visible = False
        Me.radAddGrape.Visible = False
        Me.radAddOrange.Visible = False
        Me.radAddApple.Visible = False
        Me.radAddLemonade.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblJuices_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblJuices.MouseHover
        ' This code is executed when the user hovers over
        ' the Juices label. It displays the types of juices
        ' and makes the sodas invisible.

        Me.pnlJuicesAndPastas.Visible = True
        Me.lblOrange.Visible = True
        Me.lblApple.Visible = True
        Me.lblLemonade.Visible = True
        Me.lblRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCola.Visible = False
        Me.lblLemonLime.Visible = False
        Me.lblGrape.Visible = False
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.radAddCola.Visible = False
        Me.radAddLemonLime.Visible = False
        Me.radAddGrape.Visible = False
        Me.radAddOrange.Visible = False
        Me.radAddApple.Visible = False
        Me.radAddLemonade.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblCola_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCola.MouseHover
        ' This code is executed when the user hovers over
        ' the Cola label. It makes the other pictures 
        ' invisible and makes the Cola pictures visible
        ' along with the Add To Receipt button.

        Me.picCola2.Visible = True
        Me.picCola.Visible = True
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.radAddCola.Visible = True
        Me.radAddLemonLime.Visible = False
        Me.radAddGrape.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCola = True Then
            Me.radAddCola.Enabled = False
        End If
        If Me.blnAddLemonLime = True Then
            Me.radAddLemonLime.Enabled = False
        End If
        If Me.blnAddGrape = True Then
            Me.radAddGrape.Enabled = False
        End If

    End Sub

    Private Sub lblLemonLime_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLemonLime.MouseHover
        ' This code is executed when the user hovers over
        ' the Lemon-Lime label. It makes the other pictures
        ' invisible and makes the Lemon-Lime pictures visible 
        ' along with the Add To Receipt button.

        Me.picLemonLime2.Visible = True
        Me.picLemonLime.Visible = True
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.radAddLemonLime.Visible = True
        Me.radAddCola.Visible = False
        Me.radAddGrape.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCola = True Then
            Me.radAddCola.Enabled = False
        End If
        If Me.blnAddLemonLime = True Then
            Me.radAddLemonLime.Enabled = False
        End If
        If Me.blnAddGrape = True Then
            Me.radAddGrape.Enabled = False
        End If

    End Sub

    Private Sub lblGrape_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGrape.MouseHover
        ' This code is executed when the user hovers over
        ' the Grape label. It makes the other pictures
        ' invisible and makes the Grape pictures visible 
        ' along with the Add To Receipt button.

        Me.picGrape2.Visible = True
        Me.picGrape.Visible = True
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.radAddGrape.Visible = True
        Me.radAddCola.Visible = False
        Me.radAddLemonLime.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCola = True Then
            Me.radAddCola.Enabled = False
        End If
        If Me.blnAddLemonLime = True Then
            Me.radAddLemonLime.Enabled = False
        End If
        If Me.blnAddGrape = True Then
            Me.radAddGrape.Enabled = False
        End If

    End Sub

    Private Sub lblOrange_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblOrange.MouseHover
        ' This code is executed when the user hovers over
        ' the Orange label. It makes the other pictures
        ' invisible and makes the Orange pictures visible 
        ' along with the Add To Receipt button.

        Me.picOrange2.Visible = True
        Me.picOrange.Visible = True
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.radAddOrange.Visible = True
        Me.radAddApple.Visible = False
        Me.radAddLemonade.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddOrange = True Then
            Me.radAddOrange.Enabled = False
        End If
        If Me.blnAddApple = True Then
            Me.radAddApple.Enabled = False
        End If
        If Me.blnAddLemonade = True Then
            Me.radAddLemonade.Enabled = False
        End If

    End Sub

    Private Sub lblApple_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblApple.MouseHover
        ' This code is executed when the user hovers over
        ' the Apple label. It makes the other pictures
        ' invisible and makes the Apple picture visible 
        ' along with the Add To Receipt button.

        Me.picApple.Visible = True
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picLemonade.Visible = False
        Me.radAddApple.Visible = True
        Me.radAddOrange.Visible = False
        Me.radAddLemonade.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddOrange = True Then
            Me.radAddOrange.Enabled = False
        End If
        If Me.blnAddApple = True Then
            Me.radAddApple.Enabled = False
        End If
        If Me.blnAddLemonade = True Then
            Me.radAddLemonade.Enabled = False
        End If

    End Sub

    Private Sub lblLemonade_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLemonade.MouseHover
        ' This code is executed when the user hovers over
        ' the Lemonade label. It makes the other pictures
        ' invisible and makes the Lemonade picture visible 
        ' along with the Add To Receipt button.

        Me.picLemonade.Visible = True
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.radAddLemonade.Visible = True
        Me.radAddOrange.Visible = False
        Me.radAddApple.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddOrange = True Then
            Me.radAddOrange.Enabled = False
        End If
        If Me.blnAddApple = True Then
            Me.radAddApple.Enabled = False
        End If
        If Me.blnAddLemonade = True Then
            Me.radAddLemonade.Enabled = False
        End If

    End Sub

    Private Sub btnEntrees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrees.Click
        ' This code is executed when the user clicks the
        ' Entrees button. It makes the food selections
        ' visible and everything else invisible.

        Me.pnlEntrees.Visible = True
        Me.lblPizza.Visible = True
        Me.lblClazone.Visible = True
        Me.lblPasta.Visible = True
        Me.lblSalad.Visible = True
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.lblRavioli.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.pnlWaterNote.Visible = False
        Me.lblWaterNote.Visible = False
        Me.pnlBeverages.Visible = False
        Me.lblSodas.Visible = False
        Me.lblSodaMessage.Visible = False
        Me.lblJuices.Visible = False
        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCola.Visible = False
        Me.lblLemonLime.Visible = False
        Me.lblGrape.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.lblOrange.Visible = False
        Me.lblApple.Visible = False
        Me.lblLemonade.Visible = False
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.pnlDesserts.Visible = False
        Me.lblCannoli.Visible = False
        Me.picCannoli.Visible = False
        Me.lblTiramisu.Visible = False
        Me.picTiramisu.Visible = False
        Me.lblCheesecake.Visible = False
        Me.picCheesecake.Visible = False
        Me.radAddCola.Visible = False
        Me.radAddLemonLime.Visible = False
        Me.radAddGrape.Visible = False
        Me.radAddOrange.Visible = False
        Me.radAddApple.Visible = False
        Me.radAddLemonade.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblPizza_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPizza.MouseHover
        ' This code is executed when the user hovers over
        ' the Pizza label. It displays the types of pizzas
        ' and makes the rest invisible.

        Me.pnlSodasAndPizzas.Visible = True
        Me.lblCola.Visible = False
        Me.lblLemonLime.Visible = False
        Me.lblGrape.Visible = False
        Me.lblCheesePizza.Visible = True
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = True
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = True
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.lblRavioli.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblClazone_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblClazone.MouseHover
        ' This code is executed when the user hovers over
        ' the Calzone label. It displays the types of calzones
        ' and makes the rest invisible.

        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = True
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = True
        Me.lblPepperoniCalzone.Visible = True
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = True
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = True
        Me.picCheeseCalzone.Visible = False
        Me.lblRavioli.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblPasta_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPasta.MouseHover
        ' This code is executed when the user hovers over
        ' the Pasta label. It displays the types of pastas
        ' and makes the rest invisible.

        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.pnlJuicesAndPastas.Visible = True
        Me.lblRavioli.Visible = True
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = True
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = True
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblSalad_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSalad.MouseHover
        ' This code is executed when the user hovers over
        ' the Salad label. It displays the types of salads
        ' and makes the rest invisible.

        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.lblRavioli.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = True
        Me.lblChefs.Visible = True
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = True
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = True
        Me.picItalian.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblCheesePizza_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCheesePizza.MouseHover
        ' This code is executed when the user hovers over
        ' the Cheese label. It makes the other pictures
        ' invisible and makes the Cheese picture visible 
        ' along with the Add To Receipt button.

        Me.picCheesePizza.Visible = True
        Me.picPepperoniPizza.Visible = False
        Me.picVegetable.Visible = False
        Me.radAddCheesePizza.Visible = True
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCheesePizza = True Then
            Me.radAddCheesePizza.Enabled = False
        End If
        If Me.blnAddPepperoniPizza = True Then
            Me.radAddPepperoniPizza.Enabled = False
        End If
        If Me.blnAddVegetable = True Then
            Me.radAddVegetable.Enabled = False
        End If

    End Sub

    Private Sub lblPepperoniPizza_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPepperoniPizza.MouseHover
        ' This code is executed when the user hovers over
        ' the Pepperoni label. It makes the other pictures
        ' invisible and makes the Pepperoni picture visible 
        ' along with the Add To Receipt button.

        Me.picPepperoniPizza.Visible = True
        Me.picCheesePizza.Visible = False
        Me.picVegetable.Visible = False
        Me.radAddPepperoniPizza.Visible = True
        Me.radAddCheesePizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCheesePizza = True Then
            Me.radAddCheesePizza.Enabled = False
        End If
        If Me.blnAddPepperoniPizza = True Then
            Me.radAddPepperoniPizza.Enabled = False
        End If
        If Me.blnAddVegetable = True Then
            Me.radAddVegetable.Enabled = False
        End If

    End Sub

    Private Sub lblVegetable_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblVegetable.MouseHover
        ' This code is executed when the user hovers over
        ' the Vegetable label. It makes the other pictures
        ' invisible and makes the Vegetable picture visible 
        ' along with the Add To Receipt button.

        Me.picVegetable.Visible = True
        Me.picCheesePizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = True
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCheesePizza = True Then
            Me.radAddCheesePizza.Enabled = False
        End If
        If Me.blnAddPepperoniPizza = True Then
            Me.radAddPepperoniPizza.Enabled = False
        End If
        If Me.blnAddVegetable = True Then
            Me.radAddVegetable.Enabled = False
        End If

    End Sub

    Private Sub lblPepperoniCalzone_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPepperoniCalzone.MouseHover
        ' This code is executed when the user hovers over
        ' the Pepperoni label. It makes the other pictures
        ' invisible and makes the Pepperoni picture visible 
        ' along with the Add To Receipt button.

        Me.picPepperoniCalzone.Visible = True
        Me.picSausage.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.radAddPepperoniCalzone.Visible = True
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddPepperoniCalzone = True Then
            Me.radAddPepperoniCalzone.Enabled = False
        End If
        If Me.blnAddSausage = True Then
            Me.radAddSausage.Enabled = False
        End If
        If Me.blnAddCheesePizza = True Then
            Me.radAddCheesePizza.Enabled = False
        End If

    End Sub

    Private Sub lblSausage_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSausage.MouseHover
        ' This code is executed when the user hovers over
        ' the Sausage label. It makes the other pictures
        ' invisible and makes the Sausage picture visible 
        ' along with the Add To Receipt button.

        Me.picSausage.Visible = True
        Me.picPepperoniCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.radAddSausage.Visible = True
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddPepperoniCalzone = True Then
            Me.radAddPepperoniCalzone.Enabled = False
        End If
        If Me.blnAddSausage = True Then
            Me.radAddSausage.Enabled = False
        End If
        If Me.blnAddCheesePizza = True Then
            Me.radAddCheesePizza.Enabled = False
        End If

    End Sub

    Private Sub lblCheeseCalzone_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCheeseCalzone.MouseHover
        ' This code is executed when the user hovers over
        ' the Cheese label. It makes the other pictures
        ' invisible and makes the Cheese picture visible 
        ' along with the Add To Receipt button.

        Me.picCheeseCalzone.Visible = True
        Me.picPepperoniCalzone.Visible = False
        Me.picSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = True
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddPepperoniCalzone = True Then
            Me.radAddPepperoniCalzone.Enabled = False
        End If
        If Me.blnAddSausage = True Then
            Me.radAddSausage.Enabled = False
        End If
        If Me.blnAddCheesePizza = True Then
            Me.radAddCheesePizza.Enabled = False
        End If

    End Sub

    Private Sub lblRavioli_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRavioli.MouseHover
        ' This code is executed when the user hovers over
        ' the Ravioli label. It makes the other pictures
        ' invisible and makes the Ravioli picture visible 
        ' along with the Add To Receipt button.

        Me.picRavioli.Visible = True
        Me.picSpaghetti.Visible = False
        Me.picFettuccini.Visible = False
        Me.radAddRavioli.Visible = True
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddRavioli = True Then
            Me.radAddRavioli.Enabled = False
        End If
        If Me.blnAddSpaghetti = True Then
            Me.radAddSpaghetti.Enabled = False
        End If
        If Me.blnAddFettuccini = True Then
            Me.radAddFettuccini.Enabled = False
        End If

    End Sub

    Private Sub lblSpaghetti_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSpaghetti.MouseHover
        ' This code is executed when the user hovers over
        ' the Spaghetti label. It makes the other pictures
        ' invisible and makes the Spaghetti picture visible 
        ' along with the Add To Receipt button.

        Me.picSpaghetti.Visible = True
        Me.picRavioli.Visible = False
        Me.picFettuccini.Visible = False
        Me.radAddSpaghetti.Visible = True
        Me.radAddRavioli.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddRavioli = True Then
            Me.radAddRavioli.Enabled = False
        End If
        If Me.blnAddSpaghetti = True Then
            Me.radAddSpaghetti.Enabled = False
        End If
        If Me.blnAddFettuccini = True Then
            Me.radAddFettuccini.Enabled = False
        End If

    End Sub

    Private Sub lblFettucini_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblFettucini.MouseHover
        ' This code is executed when the user hovers over
        ' the Fettuccini label. It makes the other pictures
        ' invisible and makes the Fettuccini picture visible 
        ' along with the Add To Receipt button.

        Me.picFettuccini.Visible = True
        Me.picRavioli.Visible = False
        Me.picSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = True
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddRavioli = True Then
            Me.radAddRavioli.Enabled = False
        End If
        If Me.blnAddSpaghetti = True Then
            Me.radAddSpaghetti.Enabled = False
        End If
        If Me.blnAddFettuccini = True Then
            Me.radAddFettuccini.Enabled = False
        End If

    End Sub

    Private Sub lblChefs_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblChefs.MouseHover
        ' This code is executed when the user hovers over
        ' the Chef's Salad label. It makes the other pictures
        ' invisible and makes the Chef's Salad picture visible 
        ' along with the Add To Receipt button.

        Me.picChefs.Visible = True
        Me.picGreek.Visible = False
        Me.picItalian.Visible = False
        Me.radAddChefs.Visible = True
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddChefs = True Then
            Me.radAddChefs.Enabled = False
        End If
        If Me.blnAddGreek = True Then
            Me.radAddGreek.Enabled = False
        End If
        If Me.blnAddItalian = True Then
            Me.radAddItalian.Enabled = False
        End If

    End Sub

    Private Sub lblGreek_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGreek.MouseHover
        ' This code is executed when the user hovers over
        ' the Greek Salad label. It makes the other pictures
        ' invisible and makes the Greek Salad picture visible 
        ' along with the Add To Receipt button.

        Me.picGreek.Visible = True
        Me.picChefs.Visible = False
        Me.picItalian.Visible = False
        Me.radAddGreek.Visible = True
        Me.radAddChefs.Visible = False
        Me.radAddItalian.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddChefs = True Then
            Me.radAddChefs.Enabled = False
        End If
        If Me.blnAddGreek = True Then
            Me.radAddGreek.Enabled = False
        End If
        If Me.blnAddItalian = True Then
            Me.radAddItalian.Enabled = False
        End If

    End Sub

    Private Sub lblItalian_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblItalian.MouseHover
        ' This code is executed when the user hovers over
        ' the Italian Salad label. It makes the other pictures
        ' invisible and makes the Italian Salad picture visible 
        ' along with the Add To Receipt button.

        Me.picItalian.Visible = True
        Me.picChefs.Visible = False
        Me.picGreek.Visible = False
        Me.radAddItalian.Visible = True
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddChefs = True Then
            Me.radAddChefs.Enabled = False
        End If
        If Me.blnAddGreek = True Then
            Me.radAddGreek.Enabled = False
        End If
        If Me.blnAddItalian = True Then
            Me.radAddItalian.Enabled = False
        End If

    End Sub

    Private Sub btnDesserts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesserts.Click
        ' This code is executed when the user clicks the
        ' Desserts button. It makes the dessert selections
        ' visible and everything else invisible.

        Me.pnlDesserts.Visible = True
        Me.lblCannoli.Visible = True
        Me.picCannoli.Visible = False
        Me.lblTiramisu.Visible = True
        Me.picTiramisu.Visible = False
        Me.lblCheesecake.Visible = True
        Me.picCheesecake.Visible = False
        Me.pnlWaterNote.Visible = False
        Me.lblWaterNote.Visible = False
        Me.pnlBeverages.Visible = False
        Me.lblSodas.Visible = False
        Me.lblSodaMessage.Visible = False
        Me.lblJuices.Visible = False
        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCola.Visible = False
        Me.lblLemonLime.Visible = False
        Me.lblGrape.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.lblOrange.Visible = False
        Me.lblApple.Visible = False
        Me.lblLemonade.Visible = False
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.pnlEntrees.Visible = False
        Me.lblPizza.Visible = False
        Me.lblClazone.Visible = False
        Me.lblPasta.Visible = False
        Me.lblSalad.Visible = False
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.lblRavioli.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.radAddCola.Visible = False
        Me.radAddLemonLime.Visible = False
        Me.radAddGrape.Visible = False
        Me.radAddOrange.Visible = False
        Me.radAddApple.Visible = False
        Me.radAddLemonade.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False

    End Sub

    Private Sub lblCannoli_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCannoli.MouseHover
        ' This code is executed when the user hovers over
        ' the Cannoli label. It makes the other pictures
        ' invisible and makes the Cannoli picture visible 
        ' along with the Add To Receipt button.

        Me.picCannoli.Visible = True
        Me.picTiramisu.Visible = False
        Me.picCheesecake.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = True
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCannoli = True Then
            Me.radAddCannoli.Enabled = False
        End If
        If Me.blnAddTiramisu = True Then
            Me.radAddTiramisu.Enabled = False
        End If
        If Me.blnAddCheesecake = True Then
            Me.radAddCheesecake.Enabled = False
        End If

    End Sub

    Private Sub lblTiramisu_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTiramisu.MouseHover
        ' This code is executed when the user hovers over
        ' the Tiramisu label. It makes the other pictures
        ' invisible and makes the Cannoli picture visible 
        ' along with the Add To Receipt button.

        Me.picTiramisu.Visible = True
        Me.picCannoli.Visible = False
        Me.picCheesecake.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = True
        Me.radAddCheesecake.Visible = False
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCannoli = True Then
            Me.radAddCannoli.Enabled = False
        End If
        If Me.blnAddTiramisu = True Then
            Me.radAddTiramisu.Enabled = False
        End If
        If Me.blnAddCheesecake = True Then
            Me.radAddCheesecake.Enabled = False
        End If

    End Sub

    Private Sub lblCheesecake_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblCheesecake.MouseHover
        ' This code is executed when the user hovers over
        ' the Cannoli label. It makes the other pictures
        ' invisible and makes the Cannoli picture visible 
        ' along with the Add To Receipt button.

        Me.picCheesecake.Visible = True
        Me.picCannoli.Visible = False
        Me.picTiramisu.Visible = False
        Me.radAddCheesePizza.Visible = False
        Me.radAddPepperoniPizza.Visible = False
        Me.radAddVegetable.Visible = False
        Me.radAddPepperoniCalzone.Visible = False
        Me.radAddSausage.Visible = False
        Me.radAddCheeseCalzone.Visible = False
        Me.radAddRavioli.Visible = False
        Me.radAddSpaghetti.Visible = False
        Me.radAddFettuccini.Visible = False
        Me.radAddChefs.Visible = False
        Me.radAddGreek.Visible = False
        Me.radAddItalian.Visible = False
        Me.radAddCannoli.Visible = False
        Me.radAddTiramisu.Visible = False
        Me.radAddCheesecake.Visible = True
        Me.lblQuantity.Visible = True
        Me.nudQuantity.Visible = True
        Me.nudQuantity.Value = 1

        If Me.blnAddCannoli = True Then
            Me.radAddCannoli.Enabled = False
        End If
        If Me.blnAddTiramisu = True Then
            Me.radAddTiramisu.Enabled = False
        End If
        If Me.blnAddCheesecake = True Then
            Me.radAddCheesecake.Enabled = False
        End If

    End Sub

    Private Sub radAddCola_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddCola.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddCola.Checked = True Then
            blnAddCola = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                intColaQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                intColaQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                intColaQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                Me.lstReceipt.Items.Add("Cola.....................$1.99")
                intColaQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Cola......................$1.99")
                Me.lstReceipt.Items.Add("Cola......................$1.99")
                Me.lstReceipt.Items.Add("Cola......................$1.99")
                Me.lstReceipt.Items.Add("Cola......................$1.99")
                Me.lstReceipt.Items.Add("Cola......................$1.99")
                intColaQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddLemonLime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddLemonLime.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddLemonLime.Checked = True Then
            blnAddLemonLime = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                intLemonLimeQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                intLemonLimeQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                intLemonLimeQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                intLemonLimeQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                Me.lstReceipt.Items.Add("Lemon-Lime.........$1.99")
                intLemonLimeQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddGrape_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddGrape.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddGrape.Checked = True Then
            blnAddGrape = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                intGrapeQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                intGrapeQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                intGrapeQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                intGrapeQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                Me.lstReceipt.Items.Add("Grape..................$1.99")
                intGrapeQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddOrange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddOrange.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddOrange.Checked = True Then
            blnAddOrange = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Orange................$1.49")
                intOrangeQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                intOrangeQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                intOrangeQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                intOrangeQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                Me.lstReceipt.Items.Add("Orange................$1.49")
                intOrangeQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddApple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddApple.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.


        If Me.radAddApple.Checked = True Then
            blnAddApple = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                intAppleQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                intAppleQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                intAppleQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                intAppleQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                Me.lstReceipt.Items.Add("Apple...................$1.49")
                intAppleQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddLemonade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddLemonade.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddLemonade.Checked = True Then
            blnAddLemonade = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                intLemonadeQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                intLemonadeQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                intLemonadeQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                intLemonadeQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                Me.lstReceipt.Items.Add("Lemonade...........$1.49")
                intLemonadeQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddCheesePizza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddCheesePizza.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddCheesePizza.Checked = True Then
            blnAddCheesePizza = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                intCheesePizzaQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                intCheesePizzaQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                intCheesePizzaQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                intCheesePizzaQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                Me.lstReceipt.Items.Add("CheesePizza.....$10.99")
                intCheesePizzaQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddPepperoniPizza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddPepperoniPizza.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddPepperoniPizza.Checked = True Then
            blnAddPepperoniPizza = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                intPepperoniPizzaQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                intPepperoniPizzaQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                intPepperoniPizzaQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                intPepperoniPizzaQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                Me.lstReceipt.Items.Add("PepperoniPizza..$10.99")
                intPepperoniPizzaQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddVegetable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddVegetable.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddVegetable.Checked = True Then
            blnAddVegetable = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                intVegetableQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                intVegetableQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                intVegetableQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                intVegetableQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                Me.lstReceipt.Items.Add("VegetablePizza..$10.99")
                intVegetableQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddPepperoniCalzone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddPepperoniCalzone.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddPepperoniCalzone.Checked = True Then
            blnAddPepperoniCalzone = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                intPepperoniCalzoneQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                intPepperoniCalzoneQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                intPepperoniCalzoneQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                intPepperoniCalzoneQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                Me.lstReceipt.Items.Add("PepperoniCalzone$6.99")
                intPepperoniCalzoneQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddSausage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddSausage.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddSausage.Checked = True Then
            blnAddSausage = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                intSausageQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                intSausageQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                intSausageQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                intSausageQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                Me.lstReceipt.Items.Add("SausageCalzone..$6.99")
                intSausageQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddCheeseCalzone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddCheeseCalzone.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddCheeseCalzone.Checked = True Then
            blnAddCheeseCalzone = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                intCheeseCalzoneQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                intCheeseCalzoneQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                intCheeseCalzoneQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                intCheeseCalzoneQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                Me.lstReceipt.Items.Add("CheeseCalzone....$6.99")
                intCheeseCalzoneQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddRavioli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddRavioli.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddRavioli.Checked = True Then
            blnAddRavioli = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                intRavioliQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                intRavioliQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                intRavioliQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                intRavioliQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                Me.lstReceipt.Items.Add("Ravioli..................$5.49")
                intRavioliQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddSpaghetti_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddSpaghetti.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddSpaghetti.Checked = True Then
            blnAddSpaghetti = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                intSpaghettiQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                intSpaghettiQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                intSpaghettiQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                intSpaghettiQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                Me.lstReceipt.Items.Add("Spaghetti..............$5.49")
                intSpaghettiQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddFettuccini_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddFettuccini.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddFettuccini.Checked = True Then
            blnAddFettuccini = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                intFettucciniQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                intFettucciniQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                intFettucciniQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                intFettucciniQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                Me.lstReceipt.Items.Add("Fettuccini..............$5.49")
                intFettucciniQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddChefs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddChefs.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.


        If Me.radAddChefs.Checked = True Then
            blnAddChefs = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                intChefsQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                intChefsQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                intChefsQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                intChefsQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                Me.lstReceipt.Items.Add("Chef'sSalad..........$4.49")
                intChefsQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddGreek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddGreek.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddGreek.Checked = True Then
            blnAddGreek = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                intGreekQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                intGreekQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                intGreekQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                intGreekQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                Me.lstReceipt.Items.Add("GreekSalad..........$4.49")
                intGreekQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddItalian_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddItalian.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddItalian.Checked = True Then
            blnAddItalian = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                intItalianQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                intItalianQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                intItalianQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                intItalianQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                Me.lstReceipt.Items.Add("ItalianSalad..........$4.49")
                intItalianQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddCannoli_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddCannoli.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddCannoli.Checked = True Then
            blnAddCannoli = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                intCannoliQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                intCannoliQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                intCannoliQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                intCannoliQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                Me.lstReceipt.Items.Add("Cannoli.................$2.50")
                intCannoliQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddTiramisu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddTiramisu.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddTiramisu.Checked = True Then
            blnAddTiramisu = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                intTiramisuQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                intTiramisuQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                intTiramisuQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                intTiramisuQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                Me.lstReceipt.Items.Add("Tiramisu................$2.90")
                intTiramisuQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub radAddCheesecake_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddCheesecake.CheckedChanged
        ' This code is executed when the user clicks the
        ' Add to receipt button. It adds the item to the 
        ' list on the right and also displays the price
        ' and quantity.

        If Me.radAddCheesecake.Checked = True Then
            blnAddCheesecake = True

            If Me.nudQuantity.Value = 1 Then
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                intCheesecakeQuantity = 1
            ElseIf Me.nudQuantity.Value = 2 Then
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                intCheesecakeQuantity = 2
            ElseIf Me.nudQuantity.Value = 3 Then
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                intCheesecakeQuantity = 3
            ElseIf Me.nudQuantity.Value = 4 Then
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                intCheesecakeQuantity = 4
            ElseIf Me.nudQuantity.Value = 5 Then
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                Me.lstReceipt.Items.Add("Cheesecake.........$2.90")
                intCheesecakeQuantity = 5
            End If
            Me.btnSend.Enabled = False

        End If
    End Sub

    Private Sub btnClearReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearReceipt.Click
        ' This code is executed when the user clicks the
        ' Clear button. It clears the items in the 
        ' list on the right.

        Me.lstReceipt.Items.Clear()
        Me.radAddCola.Checked = False
        Me.blnAddCola = False
        Me.radAddCola.Enabled = True
        Me.radAddGrape.Checked = False
        Me.blnAddGrape = False
        Me.radAddGrape.Enabled = True
        Me.radAddLemonLime.Checked = False
        Me.blnAddLemonLime = False
        Me.radAddLemonLime.Enabled = True
        Me.radAddOrange.Checked = False
        Me.blnAddOrange = False
        Me.radAddOrange.Enabled = True
        Me.radAddApple.Checked = False
        Me.blnAddApple = False
        Me.radAddApple.Enabled = True
        Me.radAddLemonade.Checked = False
        Me.blnAddLemonade = False
        Me.radAddLemonade.Enabled = True
        Me.radAddCheesePizza.Checked = False
        Me.blnAddCheesePizza = False
        Me.radAddCheesePizza.Enabled = True
        Me.radAddPepperoniPizza.Checked = False
        Me.blnAddPepperoniPizza = False
        Me.radAddPepperoniPizza.Enabled = True
        Me.radAddVegetable.Checked = False
        Me.blnAddVegetable = False
        Me.radAddVegetable.Enabled = True
        Me.radAddPepperoniCalzone.Checked = False
        Me.blnAddPepperoniCalzone = False
        Me.radAddPepperoniCalzone.Enabled = True
        Me.radAddSausage.Checked = False
        Me.blnAddSausage = False
        Me.radAddSausage.Enabled = True
        Me.radAddCheeseCalzone.Checked = False
        Me.blnAddCheeseCalzone = False
        Me.radAddCheeseCalzone.Enabled = True
        Me.radAddRavioli.Checked = False
        Me.blnAddRavioli = False
        Me.radAddRavioli.Enabled = True
        Me.radAddSpaghetti.Checked = False
        Me.blnAddSpaghetti = False
        Me.radAddSpaghetti.Enabled = True
        Me.radAddFettuccini.Checked = False
        Me.blnAddFettuccini = False
        Me.radAddFettuccini.Enabled = True
        Me.radAddChefs.Checked = False
        Me.blnAddChefs = False
        Me.radAddChefs.Enabled = True
        Me.radAddGreek.Checked = False
        Me.blnAddGreek = False
        Me.radAddGreek.Enabled = True
        Me.radAddItalian.Checked = False
        Me.blnAddItalian = False
        Me.radAddItalian.Enabled = True
        Me.radAddCannoli.Checked = False
        Me.blnAddCannoli = False
        Me.radAddCannoli.Enabled = True
        Me.radAddTiramisu.Checked = False
        Me.blnAddTiramisu = False
        Me.radAddTiramisu.Enabled = True
        Me.radAddCheesecake.Checked = False
        Me.blnAddCheesecake = False
        Me.radAddCheesecake.Enabled = True
        decCola = 0D
        decLemonLime = 0D
        decGrape = 0D
        decOrange = 0D
        decApple = 0D
        decLemonade = 0D
        decCheesePizza = 0D
        decPepperoniPizza = 0D
        decVegetable = 0D
        decPepperoniCalzone = 0D
        decSausageCalzone = 0D
        decCheeseCalzone = 0D
        decRavioli = 0D
        decSpaghetti = 0D
        decFettuccini = 0D
        decChefs = 0D
        decGreek = 0D
        decItalian = 0D
        decCannoli = 0D
        decTiramisu = 0D
        decCheesecake = 0D
        intColaQuantity = 0
        intLemonLimeQuantity = 0
        intGrapeQuantity = 0
        intOrangeQuantity = 0
        intAppleQuantity = 0
        intLemonadeQuantity = 0
        intCheesePizzaQuantity = 0
        intPepperoniPizzaQuantity = 0
        intVegetableQuantity = 0
        intPepperoniCalzoneQuantity = 0
        intSausageQuantity = 0
        intCheeseCalzoneQuantity = 0
        intRavioliQuantity = 0
        intSpaghettiQuantity = 0
        intFettucciniQuantity = 0
        intChefsQuantity = 0
        intGreekQuantity = 0
        intItalianQuantity = 0
        intCannoliQuantity = 0
        intTiramisuQuantity = 0
        intCheesecakeQuantity = 0
        Me.lblTotalPrice.Text = ("Total: $0.00")
        Me.btnSend.Enabled = False

    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        ' This code is executed when the user clicks
        ' the total button. It calculated to total of 
        ' the purchase and sends it to the label at the 
        ' bottom of the receipt.

        Dim decSoda As Decimal = 1.99D
        Dim decJuice As Decimal = 1.49D
        Dim decPizza As Decimal = 10.99D
        Dim decCalzone As Decimal = 6.99D
        Dim decPasta As Decimal = 5.49D
        Dim decSalad As Decimal = 4.45D
        Dim decCannoliPrice As Decimal = 2.5D
        Dim decTiramisuPrice As Decimal = 2.9D
        Dim decCheesecakePrice As Decimal = 2.5D

        If blnAddCola = True Then
            decCola = (decSoda * intColaQuantity)
        End If
        If blnAddLemonLime = True Then
            decLemonLime = (decSoda * intLemonLimeQuantity)
        End If
        If blnAddGrape = True Then
            decGrape = (decSoda * intGrapeQuantity)
        End If
        If blnAddOrange = True Then
            decOrange = (decJuice * intOrangeQuantity)
        End If
        If blnAddApple = True Then
            decOrange = (decJuice * intAppleQuantity)
        End If
        If blnAddLemonade = True Then
            decLemonade = (decJuice * intLemonadeQuantity)
        End If
        If blnAddCheesePizza = True Then
            decCheesePizza = (decPizza * intCheesePizzaQuantity)
        End If
        If blnAddPepperoniPizza = True Then
            decPepperoniPizza = (decPizza * intPepperoniPizzaQuantity)
        End If
        If blnAddVegetable = True Then
            decVegetable = (decPizza * intVegetableQuantity)
        End If
        If blnAddPepperoniCalzone = True Then
            decPepperoniCalzone = (decCalzone * intPepperoniCalzoneQuantity)
        End If
        If blnAddSausage = True Then
            decSausageCalzone = (decCalzone * intSausageQuantity)
        End If
        If blnAddCheeseCalzone = True Then
            decCheeseCalzone = (decCalzone * intCheeseCalzoneQuantity)
        End If
        If blnAddRavioli = True Then
            decRavioli = (decPasta * intRavioliQuantity)
        End If
        If blnAddSpaghetti = True Then
            decSpaghetti = (decPasta * intSpaghettiQuantity)
        End If
        If blnAddFettuccini = True Then
            decFettuccini = (decPasta * intFettucciniQuantity)
        End If
        If blnAddChefs = True Then
            decChefs = (decSalad * intChefsQuantity)
        End If
        If blnAddGreek = True Then
            decGreek = (decSalad * intGreekQuantity)
        End If
        If blnAddItalian = True Then
            decItalian = (decSalad * intItalianQuantity)
        End If
        If blnAddCannoli = True Then
            decCannoli = (decCannoliPrice * intCannoliQuantity)
        End If
        If blnAddTiramisu = True Then
            decTiramisu = (decTiramisuPrice * intTiramisuQuantity)
        End If
        If blnAddCheesecake = True Then
            decCheesecake = (decCheesecakePrice * intCheesecakeQuantity)
        End If
        decTotalPrice = decCola + decLemonLime + decGrape + decOrange + decApple + decLemonade + decCheesePizza + _
        decPepperoniPizza + decVegetable + decPepperoniCalzone + decSausageCalzone + decCheeseCalzone + decRavioli + _
        decSpaghetti + decFettuccini + decChefs + decGreek + decItalian + decCannoli + decTiramisu + decCheesecake
        Me.lblTotalPrice.Text = ("Total: ") & _
        decTotalPrice.ToString("C")
        Me.btnSend.Enabled = True

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        ' This code is executed when the user clicks 
        ' the send button. It sends and email to another
        ' computer.


        If MsgBox(frmInformation.txtName.Text.ToString() & _
                  ", are you sure you are done ordering and want to send your order to the kitchen?", MsgBoxStyle.YesNo, "Warning") = Windows.Forms.DialogResult.Yes Then
            Dim Order As New MailMessage
            Order.Subject = ("Table " & _
                frmInformation.numTable.Text.ToString() & _
                "'s Order: " & _
                frmInformation.txtName.Text)
            Order.To.Add("restaurantmenu.sfp@gmail.com")
            Order.From = New MailAddress("restaurantmenu.sfp@gmail.com")
            Order.Body = ("Cola: " & _
                intColaQuantity.ToString() & vbNewLine & "Lemon-Lime Soda: " & _
                intLemonLimeQuantity.ToString() & vbNewLine & "Grape Soda: " & _
                intGrapeQuantity.ToString() & vbNewLine & "Orange Juice: " & _
                intOrangeQuantity.ToString() & vbNewLine & "Apple Juice: " & _
                intAppleQuantity.ToString() & vbNewLine & "Lemonade: " & _
                intLemonadeQuantity.ToString() & vbNewLine & "Cheese Pizza: " & _
                intCheesePizzaQuantity.ToString() & vbNewLine & "Pepperoni Pizza: " & _
                intPepperoniPizzaQuantity.ToString() & vbNewLine & "Vegetable Pizza: " & _
                intVegetableQuantity.ToString() & vbNewLine & "Pepperoni Calzone: " & _
                intPepperoniCalzoneQuantity.ToString() & vbNewLine & "Sausage Calzone: " & _
                intSausageQuantity.ToString() & vbNewLine & "Cheese Calzone: " & _
                intCheeseCalzoneQuantity.ToString() & vbNewLine & "Ravioli: " & _
                intRavioliQuantity.ToString() & vbNewLine & "Spaghetti: " & _
                intSpaghettiQuantity.ToString() & vbNewLine & "Fettuccini: " & _
                intFettucciniQuantity.ToString() & vbNewLine & "Chef's Salad: " & _
                intChefsQuantity.ToString() & vbNewLine & "Greek Salad: " & _
                intGreekQuantity.ToString() & vbNewLine & "Italian Salad: " & _
                intItalianQuantity.ToString() & vbNewLine & "Cannoli: " & _
                intCannoliQuantity.ToString() & vbNewLine & "Tiramisu: " & _
                intTiramisuQuantity.ToString() & vbNewLine & "Cheesecake: " & _
                intCheesecakeQuantity.ToString() & vbNewLine & "Total: " & _
                decTotalPrice.ToString("C"))
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("restaurantmenu.sfp@gmail.com", "sciencefair")
            SMTP.Port = 587
            SMTP.Send(Order)

            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Thank you, your order will be delivered momentarily.")
        Else
            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Please continue your order. If you are done, press Total then Send.")

        End If
    End Sub

    Private Sub btnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDone.Click
        ' This code is executed when the user clicks
        ' the Done Ordering button. It exits back to 
        ' the first form.

        frmInformation.Text = ""
        frmInformation.numTable.Value = 1
        frmInformation.Show()
        Me.lblClickHere1.Visible = False
        Me.pnlWaterNote.Visible = False
        Me.lblWaterNote.Visible = False
        Me.pnlBeverages.Visible = False
        Me.lblSodas.Visible = False
        Me.lblSodaMessage.Visible = False
        Me.lblJuices.Visible = False
        Me.pnlSodasAndPizzas.Visible = False
        Me.lblCola.Visible = False
        Me.lblLemonLime.Visible = False
        Me.lblGrape.Visible = False
        Me.pnlJuicesAndPastas.Visible = False
        Me.lblOrange.Visible = False
        Me.lblApple.Visible = False
        Me.lblLemonade.Visible = False
        Me.picCola.Visible = False
        Me.picCola2.Visible = False
        Me.picLemonLime.Visible = False
        Me.picLemonLime2.Visible = False
        Me.picGrape.Visible = False
        Me.picGrape2.Visible = False
        Me.picOrange.Visible = False
        Me.picOrange2.Visible = False
        Me.picApple.Visible = False
        Me.picLemonade.Visible = False
        Me.pnlEntrees.Visible = False
        Me.lblPizza.Visible = False
        Me.lblClazone.Visible = False
        Me.lblPasta.Visible = False
        Me.lblSalad.Visible = False
        Me.lblCheesePizza.Visible = False
        Me.picCheesePizza.Visible = False
        Me.lblPepperoniPizza.Visible = False
        Me.picPepperoniPizza.Visible = False
        Me.lblVegetable.Visible = False
        Me.picVegetable.Visible = False
        Me.pnlCalzones.Visible = False
        Me.lblPepperoniCalzone.Visible = False
        Me.picPepperoniCalzone.Visible = False
        Me.lblSausage.Visible = False
        Me.picSausage.Visible = False
        Me.lblCheeseCalzone.Visible = False
        Me.picCheeseCalzone.Visible = False
        Me.lblRavioli.Visible = False
        Me.picRavioli.Visible = False
        Me.lblSpaghetti.Visible = False
        Me.picSpaghetti.Visible = False
        Me.lblFettucini.Visible = False
        Me.picFettuccini.Visible = False
        Me.pnlSalads.Visible = False
        Me.lblChefs.Visible = False
        Me.picChefs.Visible = False
        Me.lblGreek.Visible = False
        Me.picGreek.Visible = False
        Me.lblItalian.Visible = False
        Me.picItalian.Visible = False
        Me.pnlDesserts.Visible = False
        Me.lblCannoli.Visible = False
        Me.picCannoli.Visible = False
        Me.lblTiramisu.Visible = False
        Me.picTiramisu.Visible = False
        Me.lblCheesecake.Visible = False
        Me.picCheesecake.Visible = False
        Me.radAddCola.Checked = False
        Me.blnAddCola = False
        Me.radAddCola.Enabled = True
        Me.radAddGrape.Checked = False
        Me.blnAddGrape = False
        Me.radAddGrape.Enabled = True
        Me.radAddLemonLime.Checked = False
        Me.blnAddLemonLime = False
        Me.radAddLemonLime.Enabled = True
        Me.radAddOrange.Checked = False
        Me.blnAddOrange = False
        Me.radAddOrange.Enabled = True
        Me.radAddApple.Checked = False
        Me.blnAddApple = False
        Me.radAddApple.Enabled = True
        Me.radAddLemonade.Checked = False
        Me.blnAddLemonade = False
        Me.radAddLemonade.Enabled = True
        Me.radAddCheesePizza.Checked = False
        Me.blnAddCheesePizza = False
        Me.radAddCheesePizza.Enabled = True
        Me.radAddPepperoniPizza.Checked = False
        Me.blnAddPepperoniPizza = False
        Me.radAddPepperoniPizza.Enabled = True
        Me.radAddVegetable.Checked = False
        Me.blnAddVegetable = False
        Me.radAddVegetable.Enabled = True
        Me.radAddPepperoniCalzone.Checked = False
        Me.blnAddPepperoniCalzone = False
        Me.radAddPepperoniCalzone.Enabled = True
        Me.radAddSausage.Checked = False
        Me.blnAddSausage = False
        Me.radAddSausage.Enabled = True
        Me.radAddCheeseCalzone.Checked = False
        Me.blnAddCheeseCalzone = False
        Me.radAddCheeseCalzone.Enabled = True
        Me.radAddRavioli.Checked = False
        Me.blnAddRavioli = False
        Me.radAddRavioli.Enabled = True
        Me.radAddSpaghetti.Checked = False
        Me.blnAddSpaghetti = False
        Me.radAddSpaghetti.Enabled = True
        Me.radAddFettuccini.Checked = False
        Me.blnAddFettuccini = False
        Me.radAddFettuccini.Enabled = True
        Me.radAddChefs.Checked = False
        Me.blnAddChefs = False
        Me.radAddChefs.Enabled = True
        Me.radAddGreek.Checked = False
        Me.blnAddGreek = False
        Me.radAddGreek.Enabled = True
        Me.radAddItalian.Checked = False
        Me.blnAddItalian = False
        Me.radAddItalian.Enabled = True
        Me.radAddCannoli.Checked = False
        Me.blnAddCannoli = False
        Me.radAddCannoli.Enabled = True
        Me.radAddTiramisu.Checked = False
        Me.blnAddTiramisu = False
        Me.radAddTiramisu.Enabled = True
        Me.radAddCheesecake.Checked = False
        Me.blnAddCheesecake = False
        Me.radAddCheesecake.Enabled = True
        Me.lblQuantity.Visible = False
        Me.nudQuantity.Visible = False
        Me.btnSend.Enabled = False
        decCola = 0D
        decLemonLime = 0D
        decGrape = 0D
        decOrange = 0D
        decApple = 0D
        decLemonade = 0D
        decCheesePizza = 0D
        decPepperoniPizza = 0D
        decVegetable = 0D
        decPepperoniCalzone = 0D
        decSausageCalzone = 0D
        decCheeseCalzone = 0D
        decRavioli = 0D
        decSpaghetti = 0D
        decFettuccini = 0D
        decChefs = 0D
        decGreek = 0D
        decItalian = 0D
        decCannoli = 0D
        decTiramisu = 0D
        decCheesecake = 0D
        intColaQuantity = 0
        intLemonLimeQuantity = 0
        intGrapeQuantity = 0
        intOrangeQuantity = 0
        intAppleQuantity = 0
        intLemonadeQuantity = 0
        intCheesePizzaQuantity = 0
        intPepperoniPizzaQuantity = 0
        intVegetableQuantity = 0
        intPepperoniCalzoneQuantity = 0
        intSausageQuantity = 0
        intCheeseCalzoneQuantity = 0
        intRavioliQuantity = 0
        intSpaghettiQuantity = 0
        intFettucciniQuantity = 0
        intChefsQuantity = 0
        intGreekQuantity = 0
        intItalianQuantity = 0
        intCannoliQuantity = 0
        intTiramisuQuantity = 0
        intCheesecakeQuantity = 0
        Me.lstReceipt.Items.Clear()
        Me.txtSpecialRequest.Text = ""
        Me.lblTotalPrice.Text = ("Total: ")
        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        ' This code is executed when the use clicks
        ' help. It speaks to you, and tells you what
        ' to do. 
        Me.lblClickHere1.Visible = False
        If Me.lblSodas.Visible = True Then
            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Choose what beverage you'd like to order by hovering over the category and then the drink.    To add a drink to your menu, click Add to Receipt")
        ElseIf Me.lblPizza.Visible = True Then
            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Choose what entrée you'd like to order by hovering over the category and then the entrée.    To add an entrée to your menu, click Add to Receipt")
        ElseIf Me.lblCannoli.Visible = True Then
            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Choose what dessert you'd like to order by hovering over the dessert.    To add a dessert to your menu, click Add to Receipt")
        Else
            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Welcome to our restaurant. Please select Beverages, Entrées, or Desserts.    When you are done ordering, press Total, then press Send to send your order to the kitchen, and lastly press Done Ordering.")

        End If
    End Sub

    Private Sub btnSendRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendRequest.Click
        ' This code is executed when the user clicks the
        ' Send Request button. It sends the text from the 
        ' textbox as an email.

        If Me.txtSpecialRequest.Text <> "" Then
            Dim SpecialRequest As New MailMessage
            SpecialRequest.Subject = ("Table " & _
                frmInformation.numTable.Text.ToString() & _
                "'s Special Request: " & _
                frmInformation.txtName.Text)
            SpecialRequest.To.Add("restaurantmenu.sfp@gmail.com")
            SpecialRequest.From = New MailAddress("restaurantmenu.sfp@gmail.com")
            SpecialRequest.Body = (txtSpecialRequest.Text)
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("restaurantmenu.sfp@gmail.com", "sciencefair")
            SMTP.Port = 587
            SMTP.Send(SpecialRequest)

            txtSpecialRequest.Text = ""

            Speech = CreateObject("SAPI.spvoice")
            Speech.Speak("Thank you, your special request has been sent.")

        End If
    End Sub
End Class