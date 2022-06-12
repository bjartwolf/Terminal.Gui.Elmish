﻿namespace Terminal.Gui.Elmish

open Terminal.Gui
open Terminal.Gui.Elmish.Elements



type View =

    static member inline page (props:IProperty list) = PageElement(props) :> TerminalElement
    static member inline page (children:TerminalElement list) = 
        let props = [ prop.children children ]
        PageElement(props) :> TerminalElement

    static member inline window (props:IProperty list) = WindowElement(props) :> TerminalElement
    static member inline window (children:TerminalElement list) = 
        let props = [ prop.children children ]
        WindowElement(props) :> TerminalElement

    static member inline label (props:IProperty list) = LabelElement(props) :> TerminalElement
    static member inline label (children:TerminalElement list) = 
        let props = [ prop.children children ]
        LabelElement(props) :> TerminalElement

    static member inline button (props:IProperty list) = ButtonElement(props) :> TerminalElement
    static member inline button (children:TerminalElement list) = 
        let props = [ prop.children children ]
        ButtonElement(props) :> TerminalElement

    static member inline checkBox (props:IProperty list) = CheckBoxElement(props) :> TerminalElement
    static member inline checkBox (children:TerminalElement list) = 
        let props = [ prop.children children ]
        CheckBoxElement(props) :> TerminalElement

    static member inline colorPicker (props:IProperty list) = ColorPickerElement(props) :> TerminalElement
    static member inline colorPicker (children:TerminalElement list) = 
        let props = [ prop.children children ]
        ColorPickerElement(props) :> TerminalElement

    static member inline comboBox (props:IProperty list) = ComboBoxElement(props) :> TerminalElement
    static member inline comboBox (children:TerminalElement list) = 
        let props = [ prop.children children ]
        ComboBoxElement(props) :> TerminalElement

    static member inline dateField (props:IProperty list) = DateFieldElement(props) :> TerminalElement
    static member inline dateField (children:TerminalElement list) = 
        let props = [ prop.children children ]
        DateFieldElement(props) :> TerminalElement

    static member inline frameView (props:IProperty list) = FrameViewElement(props) :> TerminalElement
    static member inline frameView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        FrameViewElement(props) :> TerminalElement

    static member inline graphView (props:IProperty list) = GraphViewElement(props) :> TerminalElement
    static member inline graphView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        GraphViewElement(props) :> TerminalElement

    static member inline hexView (props:IProperty list) = HexViewElement(props) :> TerminalElement
    static member inline hexView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        HexViewElement(props) :> TerminalElement

    static member inline lineView (props:IProperty list) = LineViewElement(props) :> TerminalElement
    

    static member inline listView (props:IProperty list) = ListViewElement(props) :> TerminalElement
    static member inline listView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        ListViewElement(props) :> TerminalElement

    static member inline panelView (props:IProperty list) = 
        PanelViewElement(props) :> TerminalElement
    static member inline panelView (child:TerminalElement) = 
        let props = [ panelView.child child ]
        PanelViewElement(props) :> TerminalElement

    static member inline progressBar (props:IProperty list) = ProgressBarElement(props) :> TerminalElement
    static member inline progressBar (children:TerminalElement list) = 
        let props = [ prop.children children ]
        ProgressBarElement(props) :> TerminalElement

    static member inline radioGroup (props:IProperty list) = RadioGroupElement(props) :> TerminalElement
    static member inline radioGroup (children:TerminalElement list) = 
        let props = [ prop.children children ]
        RadioGroupElement(props) :> TerminalElement


    // not wroking yet
    //static member inline scrollbarview (props:IProperty list) = ScrollBarViewElement(props) :> TerminalElement
    //static member inline scrollbarview (children:TerminalElement list) = 
    //    let props = [ prop.children children ]
    //    ScrollBarViewElement(props) :> TerminalElement

    static member inline scrollView (props:IProperty list) = ScrollViewElement(props) :> TerminalElement
    static member inline scrollView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        ScrollViewElement(props) :> TerminalElement

    static member inline statusBar (props:IProperty list) = StatusBarElement(props) :> TerminalElement
    static member inline statusBar (children:TerminalElement list) = 
        let props = [ prop.children children ]
        StatusBarElement(props) :> TerminalElement

    static member inline tableView (props:IProperty list) = TableViewElement(props) :> TerminalElement
    static member inline tableView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TableViewElement(props) :> TerminalElement

    static member inline tabView (props:IProperty list) = TabViewElement(props) :> TerminalElement
    static member inline tabView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TabViewElement(props) :> TerminalElement

    static member inline textField (props:IProperty list) = TextFieldElement(props) :> TerminalElement
    static member inline textField (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TextFieldElement(props) :> TerminalElement

    static member inline textValidateField (props:IProperty list) = TextValidateFieldElement(props) :> TerminalElement
    static member inline textValidateField (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TextValidateFieldElement(props) :> TerminalElement

    static member inline textView (props:IProperty list) = TextViewElement(props) :> TerminalElement
    static member inline textView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TextViewElement(props) :> TerminalElement

    static member inline timeField (props:IProperty list) = TimeFieldElement(props) :> TerminalElement
    static member inline timeField (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TimeFieldElement(props) :> TerminalElement

    static member inline treeView (props:IProperty list) = TreeViewElement(props) :> TerminalElement
    static member inline treeView (children:TerminalElement list) = 
        let props = [ prop.children children ]
        TreeViewElement(props) :> TerminalElement

    static member inline dialog (props:IProperty list) = DialogElement(props) :> TerminalElement
    static member inline dialog (children:TerminalElement list) = 
        let props = [ prop.children children ]
        DialogElement(props) :> TerminalElement

    static member inline fileDialog (props:IProperty list) = FileDialogElement(props) :> TerminalElement
    static member inline fileDialog (children:TerminalElement list) = 
        let props = [ prop.children children ]
        FileDialogElement(props) :> TerminalElement

    static member inline saveDialog (props:IProperty list) = SaveDialogElement(props) :> TerminalElement
    static member inline saveDialog (children:TerminalElement list) = 
        let props = [ prop.children children ]
        SaveDialogElement(props) :> TerminalElement

    static member inline openDialog (props:IProperty list) = OpenDialogElement(props) :> TerminalElement
    static member inline openDialog (children:TerminalElement list) = 
        let props = [ prop.children children ]
        OpenDialogElement(props) :> TerminalElement




   

