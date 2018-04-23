Namespace T339643
    Partial Public Class SampleReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim objectConstructorInfo1 As New DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo()
            Dim parameter1 As New DevExpress.DataAccess.ObjectBinding.Parameter()
            Dim parameter2 As New DevExpress.DataAccess.ObjectBinding.Parameter()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.SessionVariable = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.UserName = New DevExpress.XtraReports.Parameters.Parameter()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.objectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            DirectCast(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3})
            Me.Detail.HeightF = 25.00001F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Text")})
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(50F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(599.9999F, 25F)
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding(Me.SessionVariable, "Text", "Session Variable: {0}")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(325F, 25F)
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            ' 
            ' SessionVariable
            ' 
            Me.SessionVariable.Name = "SessionVariable"
            Me.SessionVariable.Visible = False
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding(Me.UserName, "Text", "User Name: {0}")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(325F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(325F, 25F)
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            ' 
            ' UserName
            ' 
            Me.UserName.Name = "UserName"
            Me.UserName.Visible = False
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
            Me.ReportHeader.Font = New System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.ReportHeader.HeightF = 25F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.StylePriority.UseBorders = False
            Me.ReportHeader.StylePriority.UseFont = False
            ' 
            ' objectDataSource1
            ' 
            Me.objectDataSource1.Constructor = objectConstructorInfo1
            Me.objectDataSource1.DataMember = "GetReportData"
            Me.objectDataSource1.DataSource = GetType(T339643.ReportDataItem)
            Me.objectDataSource1.Name = "objectDataSource1"
            parameter1.Name = "sessionVaraible"
            parameter1.Type = GetType(DevExpress.DataAccess.Expression)
            parameter1.Value = New DevExpress.DataAccess.Expression("[Parameters.SessionVariable]", GetType(String))
            parameter2.Name = "userName"
            parameter2.Type = GetType(DevExpress.DataAccess.Expression)
            parameter2.Value = New DevExpress.DataAccess.Expression("[Parameters.UserName]", GetType(String))
            Me.objectDataSource1.Parameters.AddRange(New DevExpress.DataAccess.ObjectBinding.Parameter() { parameter1, parameter2})
            ' 
            ' SampleReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.objectDataSource1})
            Me.DataSource = Me.objectDataSource1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.UserName, Me.SessionVariable})
            Me.Version = "15.2"
            DirectCast(Me.objectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private UserName As DevExpress.XtraReports.Parameters.Parameter
        Private SessionVariable As DevExpress.XtraReports.Parameters.Parameter
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private objectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
    End Class
End Namespace
