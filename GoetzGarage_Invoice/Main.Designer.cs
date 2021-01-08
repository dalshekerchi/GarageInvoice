namespace GoetzGarage_Invoice
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label lblCustName;
			System.Windows.Forms.Label lblYear;
			System.Windows.Forms.Label lblBrand;
			System.Windows.Forms.Label lblModel;
			System.Windows.Forms.Label lblVIN;
			System.Windows.Forms.Label lblPlate;
			System.Windows.Forms.Label lblData;
			System.Windows.Forms.Label lblKm;
			System.Windows.Forms.Label lblSupplier;
			System.Windows.Forms.Label lblSupplierInvoice;
			System.Windows.Forms.Label lblInvoiceNum;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.main_CustomerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.main_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mainDBDataSet = new GoetzGarage_Invoice.MainDBDataSet();
			this.toolStripBtnPrint = new System.Windows.Forms.ToolStripButton();
			this.btn_Prodemand = new System.Windows.Forms.ToolStripButton();
			this.main_PartsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.backupDBDataSet = new GoetzGarage_Invoice.BackupDBDataSet();
			this.temp_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.main_CustomerTableAdapter = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.Main_CustomerTableAdapter();
			this.tableAdapterManager = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.TableAdapterManager();
			this.temp_TableTableAdapter = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.Temp_TableTableAdapter();
			this.main_PartsTableAdapter = new GoetzGarage_Invoice.MainDBDataSetTableAdapters.Main_PartsTableAdapter();
			this.customerTableAdapter = new GoetzGarage_Invoice.BackupDBDataSetTableAdapters.CustomerTableAdapter();
			this.tableAdapterManager1 = new GoetzGarage_Invoice.BackupDBDataSetTableAdapters.TableAdapterManager();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lbl_SchoolName = new System.Windows.Forms.Label();
			this.lbl_Address = new System.Windows.Forms.Label();
			this.lbl_Location = new System.Windows.Forms.Label();
			this.lbl_PostalCode = new System.Windows.Forms.Label();
			this.lbl_PhoneNumber = new System.Windows.Forms.Label();
			this.date_of_Completed_WorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.supplierTextBox = new System.Windows.Forms.TextBox();
			this.supplier_InvoiceTextBox = new System.Windows.Forms.TextBox();
			this.txtinvoice = new System.Windows.Forms.TextBox();
			this.lbl_WorkPerformed = new System.Windows.Forms.Label();
			this.lblRecomm = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this.lblTax = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.txtTax = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.lblTecNames = new System.Windows.Forms.Label();
			this.txtTec1 = new System.Windows.Forms.TextBox();
			this.txtTec2 = new System.Windows.Forms.TextBox();
			this.txtTec3 = new System.Windows.Forms.TextBox();
			this.txtTec4 = new System.Windows.Forms.TextBox();
			this.pnlPaperDisplay = new System.Windows.Forms.Panel();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPlate = new System.Windows.Forms.TextBox();
			this.txtVIN = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.cmbBrand = new System.Windows.Forms.ComboBox();
			this.cmbModel = new System.Windows.Forms.ComboBox();
			this.txtRecommendations = new System.Windows.Forms.TextBox();
			this.txtWorkPerformed = new System.Windows.Forms.TextBox();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.customerTableAdapter1 = new GoetzGarage_Invoice.BackupDBDataSetTableAdapters.CustomerTableAdapter();
			this.lblPhone = new System.Windows.Forms.Label();
			this.lblComment = new System.Windows.Forms.Label();
			this.txt_Com = new System.Windows.Forms.TextBox();
			this.cmbService = new System.Windows.Forms.ComboBox();
			this.cmbOilType = new System.Windows.Forms.ComboBox();
			this.cmbCool = new System.Windows.Forms.ComboBox();
			this.cmbWarm = new System.Windows.Forms.ComboBox();
			this.cmbBrake = new System.Windows.Forms.ComboBox();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblPrice = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblchoose = new System.Windows.Forms.Label();
			this.lblTtime = new System.Windows.Forms.Label();
			this.lblTprice = new System.Windows.Forms.Label();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
			this.lblConnection = new System.Windows.Forms.Label();
			this.cmbIP = new System.Windows.Forms.ComboBox();
			lblCustName = new System.Windows.Forms.Label();
			lblYear = new System.Windows.Forms.Label();
			lblBrand = new System.Windows.Forms.Label();
			lblModel = new System.Windows.Forms.Label();
			lblVIN = new System.Windows.Forms.Label();
			lblPlate = new System.Windows.Forms.Label();
			lblData = new System.Windows.Forms.Label();
			lblKm = new System.Windows.Forms.Label();
			lblSupplier = new System.Windows.Forms.Label();
			lblSupplierInvoice = new System.Windows.Forms.Label();
			lblInvoiceNum = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingNavigator)).BeginInit();
			this.main_CustomerBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.main_PartsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backupDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.temp_TableBindingSource)).BeginInit();
			this.pnlPaperDisplay.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCustName
			// 
			lblCustName.AutoSize = true;
			lblCustName.Location = new System.Drawing.Point(321, 79);
			lblCustName.Name = "lblCustName";
			lblCustName.Size = new System.Drawing.Size(85, 13);
			lblCustName.TabIndex = 6;
			lblCustName.Text = "Customer Name:";
			// 
			// lblYear
			// 
			lblYear.AutoSize = true;
			lblYear.Location = new System.Drawing.Point(337, 195);
			lblYear.Name = "lblYear";
			lblYear.Size = new System.Drawing.Size(70, 13);
			lblYear.TabIndex = 8;
			lblYear.Text = "Vehicle Year:";
			// 
			// lblBrand
			// 
			lblBrand.AutoSize = true;
			lblBrand.Location = new System.Drawing.Point(331, 141);
			lblBrand.Name = "lblBrand";
			lblBrand.Size = new System.Drawing.Size(76, 13);
			lblBrand.TabIndex = 10;
			lblBrand.Text = "Vehicle Brand:";
			// 
			// lblModel
			// 
			lblModel.AutoSize = true;
			lblModel.Location = new System.Drawing.Point(327, 167);
			lblModel.Name = "lblModel";
			lblModel.Size = new System.Drawing.Size(80, 13);
			lblModel.TabIndex = 12;
			lblModel.Text = "Vehicle Model :";
			// 
			// lblVIN
			// 
			lblVIN.AutoSize = true;
			lblVIN.Location = new System.Drawing.Point(372, 110);
			lblVIN.Name = "lblVIN";
			lblVIN.Size = new System.Drawing.Size(34, 13);
			lblVIN.TabIndex = 14;
			lblVIN.Text = "V I N:";
			// 
			// lblPlate
			// 
			lblPlate.AutoSize = true;
			lblPlate.Location = new System.Drawing.Point(332, 225);
			lblPlate.Name = "lblPlate";
			lblPlate.Size = new System.Drawing.Size(74, 13);
			lblPlate.TabIndex = 16;
			lblPlate.Text = "License Plate:";
			// 
			// lblData
			// 
			lblData.AutoSize = true;
			lblData.Location = new System.Drawing.Point(279, 251);
			lblData.Name = "lblData";
			lblData.Size = new System.Drawing.Size(127, 13);
			lblData.TabIndex = 18;
			lblData.Text = "Date of Completed Work:";
			// 
			// lblKm
			// 
			lblKm.AutoSize = true;
			lblKm.Location = new System.Drawing.Point(381, 280);
			lblKm.Name = "lblKm";
			lblKm.Size = new System.Drawing.Size(25, 13);
			lblKm.TabIndex = 20;
			lblKm.Text = "Km:";
			// 
			// lblSupplier
			// 
			lblSupplier.AutoSize = true;
			lblSupplier.Location = new System.Drawing.Point(54, 249);
			lblSupplier.Name = "lblSupplier";
			lblSupplier.Size = new System.Drawing.Size(48, 13);
			lblSupplier.TabIndex = 25;
			lblSupplier.Text = "Supplier:";
			// 
			// lblSupplierInvoice
			// 
			lblSupplierInvoice.AutoSize = true;
			lblSupplierInvoice.Location = new System.Drawing.Point(16, 276);
			lblSupplierInvoice.Name = "lblSupplierInvoice";
			lblSupplierInvoice.Size = new System.Drawing.Size(86, 13);
			lblSupplierInvoice.TabIndex = 27;
			lblSupplierInvoice.Text = "Supplier Invoice:";
			// 
			// lblInvoiceNum
			// 
			lblInvoiceNum.AutoSize = true;
			lblInvoiceNum.Location = new System.Drawing.Point(649, 29);
			lblInvoiceNum.Name = "lblInvoiceNum";
			lblInvoiceNum.Size = new System.Drawing.Size(85, 13);
			lblInvoiceNum.TabIndex = 2;
			lblInvoiceNum.Text = "Invoice Number:";
			// 
			// main_CustomerBindingNavigator
			// 
			this.main_CustomerBindingNavigator.AddNewItem = null;
			this.main_CustomerBindingNavigator.BindingSource = this.main_CustomerBindingSource;
			this.main_CustomerBindingNavigator.CountItem = null;
			this.main_CustomerBindingNavigator.DeleteItem = null;
			this.main_CustomerBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.main_CustomerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPrint,
            this.btn_Prodemand});
			this.main_CustomerBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.main_CustomerBindingNavigator.MoveFirstItem = null;
			this.main_CustomerBindingNavigator.MoveLastItem = null;
			this.main_CustomerBindingNavigator.MoveNextItem = null;
			this.main_CustomerBindingNavigator.MovePreviousItem = null;
			this.main_CustomerBindingNavigator.Name = "main_CustomerBindingNavigator";
			this.main_CustomerBindingNavigator.PositionItem = null;
			this.main_CustomerBindingNavigator.Size = new System.Drawing.Size(1494, 27);
			this.main_CustomerBindingNavigator.TabIndex = 0;
			this.main_CustomerBindingNavigator.Text = "bindingNavigator1";
			// 
			// main_CustomerBindingSource
			// 
			this.main_CustomerBindingSource.DataMember = "Main_Customer";
			this.main_CustomerBindingSource.DataSource = this.mainDBDataSet;
			// 
			// mainDBDataSet
			// 
			this.mainDBDataSet.DataSetName = "MainDBDataSet";
			this.mainDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// toolStripBtnPrint
			// 
			this.toolStripBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPrint.Image")));
			this.toolStripBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripBtnPrint.Name = "toolStripBtnPrint";
			this.toolStripBtnPrint.Size = new System.Drawing.Size(24, 24);
			this.toolStripBtnPrint.Text = "btnPrint";
			this.toolStripBtnPrint.Click += new System.EventHandler(this.toolStripBtnPrint_Click);
			// 
			// btn_Prodemand
			// 
			this.btn_Prodemand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btn_Prodemand.Image = ((System.Drawing.Image)(resources.GetObject("btn_Prodemand.Image")));
			this.btn_Prodemand.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Prodemand.Name = "btn_Prodemand";
			this.btn_Prodemand.Size = new System.Drawing.Size(24, 24);
			this.btn_Prodemand.Text = "toolStripButton2";
			this.btn_Prodemand.Click += new System.EventHandler(this.btn_Prodemand_Click);
			// 
			// main_PartsBindingSource
			// 
			this.main_PartsBindingSource.DataMember = "Main_Parts";
			this.main_PartsBindingSource.DataSource = this.mainDBDataSet;
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.backupDBDataSet;
			// 
			// backupDBDataSet
			// 
			this.backupDBDataSet.DataSetName = "BackupDBDataSet";
			this.backupDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// temp_TableBindingSource
			// 
			this.temp_TableBindingSource.DataMember = "Temp_Table";
			this.temp_TableBindingSource.DataSource = this.mainDBDataSet;
			// 
			// main_CustomerTableAdapter
			// 
			this.main_CustomerTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Main_CustomerTableAdapter = this.main_CustomerTableAdapter;
			this.tableAdapterManager.Main_InvoiceFormTableAdapter = null;
			this.tableAdapterManager.Main_PartsTableAdapter = null;
			this.tableAdapterManager.TableTableAdapter = null;
			this.tableAdapterManager.Temp_TableTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = GoetzGarage_Invoice.MainDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// temp_TableTableAdapter
			// 
			this.temp_TableTableAdapter.ClearBeforeFill = true;
			// 
			// main_PartsTableAdapter
			// 
			this.main_PartsTableAdapter.ClearBeforeFill = true;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.CustomerTableAdapter = this.customerTableAdapter;
			this.tableAdapterManager1.PartsTableAdapter = null;
			this.tableAdapterManager1.UpdateOrder = GoetzGarage_Invoice.BackupDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(52, 55);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(246, 39);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Goetz Garage";
			// 
			// lbl_SchoolName
			// 
			this.lbl_SchoolName.AutoSize = true;
			this.lbl_SchoolName.Location = new System.Drawing.Point(98, 94);
			this.lbl_SchoolName.Name = "lbl_SchoolName";
			this.lbl_SchoolName.Size = new System.Drawing.Size(134, 13);
			this.lbl_SchoolName.TabIndex = 1;
			this.lbl_SchoolName.Text = "Father Micheal Goetz S. S.";
			// 
			// lbl_Address
			// 
			this.lbl_Address.AutoSize = true;
			this.lbl_Address.Location = new System.Drawing.Point(98, 107);
			this.lbl_Address.Name = "lbl_Address";
			this.lbl_Address.Size = new System.Drawing.Size(133, 13);
			this.lbl_Address.TabIndex = 2;
			this.lbl_Address.Text = "330 Central Parkway West";
			// 
			// lbl_Location
			// 
			this.lbl_Location.AutoSize = true;
			this.lbl_Location.Location = new System.Drawing.Point(110, 120);
			this.lbl_Location.Name = "lbl_Location";
			this.lbl_Location.Size = new System.Drawing.Size(104, 13);
			this.lbl_Location.TabIndex = 3;
			this.lbl_Location.Text = "Mississauga, Ontario";
			// 
			// lbl_PostalCode
			// 
			this.lbl_PostalCode.AutoSize = true;
			this.lbl_PostalCode.Location = new System.Drawing.Point(136, 133);
			this.lbl_PostalCode.Name = "lbl_PostalCode";
			this.lbl_PostalCode.Size = new System.Drawing.Size(48, 13);
			this.lbl_PostalCode.TabIndex = 4;
			this.lbl_PostalCode.Text = "L5B 3K6";
			// 
			// lbl_PhoneNumber
			// 
			this.lbl_PhoneNumber.AutoSize = true;
			this.lbl_PhoneNumber.Location = new System.Drawing.Point(98, 146);
			this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
			this.lbl_PhoneNumber.Size = new System.Drawing.Size(126, 13);
			this.lbl_PhoneNumber.TabIndex = 5;
			this.lbl_PhoneNumber.Text = "905-277-0326 ext: 63122";
			// 
			// date_of_Completed_WorkDateTimePicker
			// 
			this.date_of_Completed_WorkDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.main_CustomerBindingSource, "Date of Completed Work", true));
			this.date_of_Completed_WorkDateTimePicker.Location = new System.Drawing.Point(412, 248);
			this.date_of_Completed_WorkDateTimePicker.Name = "date_of_Completed_WorkDateTimePicker";
			this.date_of_Completed_WorkDateTimePicker.Size = new System.Drawing.Size(415, 20);
			this.date_of_Completed_WorkDateTimePicker.TabIndex = 9;
			// 
			// supplierTextBox
			// 
			this.supplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Supplier", true));
			this.supplierTextBox.Location = new System.Drawing.Point(107, 246);
			this.supplierTextBox.Name = "supplierTextBox";
			this.supplierTextBox.Size = new System.Drawing.Size(117, 20);
			this.supplierTextBox.TabIndex = 20;
			// 
			// supplier_InvoiceTextBox
			// 
			this.supplier_InvoiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Supplier Invoice", true));
			this.supplier_InvoiceTextBox.Location = new System.Drawing.Point(108, 274);
			this.supplier_InvoiceTextBox.Name = "supplier_InvoiceTextBox";
			this.supplier_InvoiceTextBox.Size = new System.Drawing.Size(116, 20);
			this.supplier_InvoiceTextBox.TabIndex = 21;
			// 
			// txtinvoice
			// 
			this.txtinvoice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.main_CustomerBindingSource, "Invoice Number", true));
			this.txtinvoice.Location = new System.Drawing.Point(740, 26);
			this.txtinvoice.Name = "txtinvoice";
			this.txtinvoice.ReadOnly = true;
			this.txtinvoice.Size = new System.Drawing.Size(86, 20);
			this.txtinvoice.TabIndex = 1;
			// 
			// lbl_WorkPerformed
			// 
			this.lbl_WorkPerformed.AutoSize = true;
			this.lbl_WorkPerformed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_WorkPerformed.Location = new System.Drawing.Point(19, 352);
			this.lbl_WorkPerformed.Name = "lbl_WorkPerformed";
			this.lbl_WorkPerformed.Size = new System.Drawing.Size(181, 25);
			this.lbl_WorkPerformed.TabIndex = 31;
			this.lbl_WorkPerformed.Text = "Work Performed";
			// 
			// lblRecomm
			// 
			this.lblRecomm.AutoSize = true;
			this.lblRecomm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRecomm.Location = new System.Drawing.Point(408, 520);
			this.lblRecomm.Name = "lblRecomm";
			this.lblRecomm.Size = new System.Drawing.Size(158, 20);
			this.lblRecomm.TabIndex = 33;
			this.lblRecomm.Text = "Recommendations";
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.AutoSize = true;
			this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotal.Location = new System.Drawing.Point(40, 685);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.Size = new System.Drawing.Size(87, 20);
			this.lblSubtotal.TabIndex = 35;
			this.lblSubtotal.Text = "Subtotal :";
			// 
			// lblTax
			// 
			this.lblTax.AutoSize = true;
			this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTax.Location = new System.Drawing.Point(80, 709);
			this.lblTax.Name = "lblTax";
			this.lblTax.Size = new System.Drawing.Size(47, 20);
			this.lblTax.TabIndex = 36;
			this.lblTax.Text = "Tax :";
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(30, 729);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(99, 25);
			this.lblTotal.TabIndex = 37;
			this.lblTotal.Text = "TOTAL :";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(133, 685);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.ReadOnly = true;
			this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
			this.txtSubtotal.TabIndex = 14;
			// 
			// txtTax
			// 
			this.txtTax.Location = new System.Drawing.Point(133, 711);
			this.txtTax.Name = "txtTax";
			this.txtTax.ReadOnly = true;
			this.txtTax.Size = new System.Drawing.Size(100, 20);
			this.txtTax.TabIndex = 13;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(133, 737);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 15;
			// 
			// lblTecNames
			// 
			this.lblTecNames.AutoSize = true;
			this.lblTecNames.Location = new System.Drawing.Point(448, 685);
			this.lblTecNames.Name = "lblTecNames";
			this.lblTecNames.Size = new System.Drawing.Size(245, 13);
			this.lblTecNames.TabIndex = 41;
			this.lblTecNames.Text = "Technician(s) which performed the work described";
			// 
			// txtTec1
			// 
			this.txtTec1.Location = new System.Drawing.Point(403, 703);
			this.txtTec1.Name = "txtTec1";
			this.txtTec1.Size = new System.Drawing.Size(193, 20);
			this.txtTec1.TabIndex = 24;
			// 
			// txtTec2
			// 
			this.txtTec2.Location = new System.Drawing.Point(403, 737);
			this.txtTec2.Name = "txtTec2";
			this.txtTec2.Size = new System.Drawing.Size(193, 20);
			this.txtTec2.TabIndex = 25;
			// 
			// txtTec3
			// 
			this.txtTec3.Location = new System.Drawing.Point(622, 703);
			this.txtTec3.Name = "txtTec3";
			this.txtTec3.Size = new System.Drawing.Size(204, 20);
			this.txtTec3.TabIndex = 26;
			// 
			// txtTec4
			// 
			this.txtTec4.Location = new System.Drawing.Point(622, 737);
			this.txtTec4.Name = "txtTec4";
			this.txtTec4.Size = new System.Drawing.Size(204, 20);
			this.txtTec4.TabIndex = 27;
			// 
			// pnlPaperDisplay
			// 
			this.pnlPaperDisplay.AutoScroll = true;
			this.pnlPaperDisplay.BackColor = System.Drawing.Color.White;
			this.pnlPaperDisplay.Controls.Add(this.txtName);
			this.pnlPaperDisplay.Controls.Add(this.txtPlate);
			this.pnlPaperDisplay.Controls.Add(this.txtVIN);
			this.pnlPaperDisplay.Controls.Add(this.txtKm);
			this.pnlPaperDisplay.Controls.Add(this.txtYear);
			this.pnlPaperDisplay.Controls.Add(this.cmbBrand);
			this.pnlPaperDisplay.Controls.Add(this.cmbModel);
			this.pnlPaperDisplay.Controls.Add(this.txtRecommendations);
			this.pnlPaperDisplay.Controls.Add(this.txtWorkPerformed);
			this.pnlPaperDisplay.Controls.Add(this.txtTec4);
			this.pnlPaperDisplay.Controls.Add(this.txtTec3);
			this.pnlPaperDisplay.Controls.Add(this.txtTec2);
			this.pnlPaperDisplay.Controls.Add(this.txtTec1);
			this.pnlPaperDisplay.Controls.Add(this.lblTecNames);
			this.pnlPaperDisplay.Controls.Add(this.txtTotal);
			this.pnlPaperDisplay.Controls.Add(this.txtTax);
			this.pnlPaperDisplay.Controls.Add(this.txtSubtotal);
			this.pnlPaperDisplay.Controls.Add(this.lblTotal);
			this.pnlPaperDisplay.Controls.Add(this.lblTax);
			this.pnlPaperDisplay.Controls.Add(this.lblSubtotal);
			this.pnlPaperDisplay.Controls.Add(this.lblRecomm);
			this.pnlPaperDisplay.Controls.Add(this.lbl_WorkPerformed);
			this.pnlPaperDisplay.Controls.Add(lblInvoiceNum);
			this.pnlPaperDisplay.Controls.Add(this.txtinvoice);
			this.pnlPaperDisplay.Controls.Add(lblSupplierInvoice);
			this.pnlPaperDisplay.Controls.Add(this.supplier_InvoiceTextBox);
			this.pnlPaperDisplay.Controls.Add(lblSupplier);
			this.pnlPaperDisplay.Controls.Add(this.supplierTextBox);
			this.pnlPaperDisplay.Controls.Add(lblKm);
			this.pnlPaperDisplay.Controls.Add(lblData);
			this.pnlPaperDisplay.Controls.Add(this.date_of_Completed_WorkDateTimePicker);
			this.pnlPaperDisplay.Controls.Add(lblPlate);
			this.pnlPaperDisplay.Controls.Add(lblVIN);
			this.pnlPaperDisplay.Controls.Add(lblModel);
			this.pnlPaperDisplay.Controls.Add(lblBrand);
			this.pnlPaperDisplay.Controls.Add(lblYear);
			this.pnlPaperDisplay.Controls.Add(lblCustName);
			this.pnlPaperDisplay.Controls.Add(this.lbl_PhoneNumber);
			this.pnlPaperDisplay.Controls.Add(this.lbl_PostalCode);
			this.pnlPaperDisplay.Controls.Add(this.lbl_Location);
			this.pnlPaperDisplay.Controls.Add(this.lbl_Address);
			this.pnlPaperDisplay.Controls.Add(this.lbl_SchoolName);
			this.pnlPaperDisplay.Controls.Add(this.lblTitle);
			this.pnlPaperDisplay.Location = new System.Drawing.Point(13, 47);
			this.pnlPaperDisplay.Name = "pnlPaperDisplay";
			this.pnlPaperDisplay.Size = new System.Drawing.Size(869, 795);
			this.pnlPaperDisplay.TabIndex = 2;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(412, 79);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(414, 20);
			this.txtName.TabIndex = 3;
			// 
			// txtPlate
			// 
			this.txtPlate.Location = new System.Drawing.Point(413, 222);
			this.txtPlate.Name = "txtPlate";
			this.txtPlate.Size = new System.Drawing.Size(414, 20);
			this.txtPlate.TabIndex = 8;
			// 
			// txtVIN
			// 
			this.txtVIN.Location = new System.Drawing.Point(412, 107);
			this.txtVIN.MaxLength = 17;
			this.txtVIN.Name = "txtVIN";
			this.txtVIN.Size = new System.Drawing.Size(415, 20);
			this.txtVIN.TabIndex = 4;
			this.txtVIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVIN_KeyDown);
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(412, 277);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(415, 20);
			this.txtKm.TabIndex = 10;
			this.txtKm.TextChanged += new System.EventHandler(this.txtKm_TextChanged);
			this.txtKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKm_KeyPress);
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(412, 192);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(415, 20);
			this.txtYear.TabIndex = 7;
			// 
			// cmbBrand
			// 
			this.cmbBrand.FormattingEnabled = true;
			this.cmbBrand.Location = new System.Drawing.Point(412, 136);
			this.cmbBrand.Name = "cmbBrand";
			this.cmbBrand.Size = new System.Drawing.Size(415, 21);
			this.cmbBrand.TabIndex = 5;
			this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
			this.cmbBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBrand_KeyPress);
			// 
			// cmbModel
			// 
			this.cmbModel.FormattingEnabled = true;
			this.cmbModel.Location = new System.Drawing.Point(412, 163);
			this.cmbModel.Name = "cmbModel";
			this.cmbModel.Size = new System.Drawing.Size(415, 21);
			this.cmbModel.TabIndex = 6;
			this.cmbModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbModel_KeyPress);
			// 
			// txtRecommendations
			// 
			this.txtRecommendations.Location = new System.Drawing.Point(384, 554);
			this.txtRecommendations.Multiline = true;
			this.txtRecommendations.Name = "txtRecommendations";
			this.txtRecommendations.Size = new System.Drawing.Size(461, 113);
			this.txtRecommendations.TabIndex = 23;
			// 
			// txtWorkPerformed
			// 
			this.txtWorkPerformed.Location = new System.Drawing.Point(26, 390);
			this.txtWorkPerformed.Multiline = true;
			this.txtWorkPerformed.Name = "txtWorkPerformed";
			this.txtWorkPerformed.Size = new System.Drawing.Size(806, 112);
			this.txtWorkPerformed.TabIndex = 22;
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// customerTableAdapter1
			// 
			this.customerTableAdapter1.ClearBeforeFill = true;
			// 
			// lblPhone
			// 
			this.lblPhone.AutoSize = true;
			this.lblPhone.Location = new System.Drawing.Point(898, 195);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new System.Drawing.Size(81, 13);
			this.lblPhone.TabIndex = 5;
			this.lblPhone.Text = "Phone Number:";
			// 
			// lblComment
			// 
			this.lblComment.AutoSize = true;
			this.lblComment.Location = new System.Drawing.Point(925, 234);
			this.lblComment.Name = "lblComment";
			this.lblComment.Size = new System.Drawing.Size(54, 13);
			this.lblComment.TabIndex = 6;
			this.lblComment.Text = "Comment:";
			// 
			// txt_Com
			// 
			this.txt_Com.Location = new System.Drawing.Point(985, 231);
			this.txt_Com.Name = "txt_Com";
			this.txt_Com.Size = new System.Drawing.Size(202, 20);
			this.txt_Com.TabIndex = 0;
			// 
			// cmbService
			// 
			this.cmbService.FormattingEnabled = true;
			this.cmbService.Location = new System.Drawing.Point(985, 344);
			this.cmbService.Name = "cmbService";
			this.cmbService.Size = new System.Drawing.Size(202, 21);
			this.cmbService.TabIndex = 2;
			this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
			this.cmbService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbService_KeyPress);
			// 
			// cmbOilType
			// 
			this.cmbOilType.FormattingEnabled = true;
			this.cmbOilType.Location = new System.Drawing.Point(985, 377);
			this.cmbOilType.Name = "cmbOilType";
			this.cmbOilType.Size = new System.Drawing.Size(202, 21);
			this.cmbOilType.TabIndex = 58;
			this.cmbOilType.Visible = false;
			this.cmbOilType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbOilType_KeyPress);
			// 
			// cmbCool
			// 
			this.cmbCool.FormattingEnabled = true;
			this.cmbCool.Location = new System.Drawing.Point(985, 418);
			this.cmbCool.Name = "cmbCool";
			this.cmbCool.Size = new System.Drawing.Size(93, 21);
			this.cmbCool.TabIndex = 4;
			this.cmbCool.Visible = false;
			this.cmbCool.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCool_KeyPress);
			// 
			// cmbWarm
			// 
			this.cmbWarm.FormattingEnabled = true;
			this.cmbWarm.Location = new System.Drawing.Point(1094, 418);
			this.cmbWarm.Name = "cmbWarm";
			this.cmbWarm.Size = new System.Drawing.Size(93, 21);
			this.cmbWarm.TabIndex = 5;
			this.cmbWarm.Visible = false;
			this.cmbWarm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbWarm_KeyPress);
			// 
			// cmbBrake
			// 
			this.cmbBrake.FormattingEnabled = true;
			this.cmbBrake.Location = new System.Drawing.Point(985, 377);
			this.cmbBrake.Name = "cmbBrake";
			this.cmbBrake.Size = new System.Drawing.Size(202, 21);
			this.cmbBrake.TabIndex = 3;
			this.cmbBrake.Visible = false;
			this.cmbBrake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBrake_KeyPress);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(1021, 307);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(0, 13);
			this.lblTime.TabIndex = 62;
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(1141, 307);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(0, 13);
			this.lblPrice.TabIndex = 63;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(1046, 457);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// lblchoose
			// 
			this.lblchoose.AutoSize = true;
			this.lblchoose.Location = new System.Drawing.Point(1027, 269);
			this.lblchoose.Name = "lblchoose";
			this.lblchoose.Size = new System.Drawing.Size(114, 13);
			this.lblchoose.TabIndex = 65;
			this.lblchoose.Text = "Choose Service Below";
			// 
			// lblTtime
			// 
			this.lblTtime.AutoSize = true;
			this.lblTtime.Location = new System.Drawing.Point(982, 307);
			this.lblTtime.Name = "lblTtime";
			this.lblTtime.Size = new System.Drawing.Size(33, 13);
			this.lblTtime.TabIndex = 66;
			this.lblTtime.Text = "Time:";
			// 
			// lblTprice
			// 
			this.lblTprice.AutoSize = true;
			this.lblTprice.Location = new System.Drawing.Point(1094, 306);
			this.lblTprice.Name = "lblTprice";
			this.lblTprice.Size = new System.Drawing.Size(43, 13);
			this.lblTprice.TabIndex = 67;
			this.lblTprice.Text = "Price: $";
			// 
			// txtNumber
			// 
			this.txtNumber.Location = new System.Drawing.Point(985, 192);
			this.txtNumber.MaxLength = 10;
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(202, 20);
			this.txtNumber.TabIndex = 1;
			this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
			// 
			// btnAdmin
			// 
			this.btnAdmin.Location = new System.Drawing.Point(985, 47);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(75, 23);
			this.btnAdmin.TabIndex = 7;
			this.btnAdmin.Text = "Admin";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// dataGridViewHistory
			// 
			this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewHistory.Location = new System.Drawing.Point(890, 542);
			this.dataGridViewHistory.Name = "dataGridViewHistory";
			this.dataGridViewHistory.Size = new System.Drawing.Size(592, 210);
			this.dataGridViewHistory.TabIndex = 70;
			// 
			// lblConnection
			// 
			this.lblConnection.AutoSize = true;
			this.lblConnection.Location = new System.Drawing.Point(1113, 52);
			this.lblConnection.Name = "lblConnection";
			this.lblConnection.Size = new System.Drawing.Size(74, 13);
			this.lblConnection.TabIndex = 71;
			this.lblConnection.Text = "Connection: X";
			// 
			// cmbIP
			// 
			this.cmbIP.FormattingEnabled = true;
			this.cmbIP.Location = new System.Drawing.Point(985, 81);
			this.cmbIP.Name = "cmbIP";
			this.cmbIP.Size = new System.Drawing.Size(202, 21);
			this.cmbIP.TabIndex = 72;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1494, 881);
			this.Controls.Add(this.cmbIP);
			this.Controls.Add(this.lblConnection);
			this.Controls.Add(this.dataGridViewHistory);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.lblTprice);
			this.Controls.Add(this.lblTtime);
			this.Controls.Add(this.lblchoose);
			this.Controls.Add(this.lblPrice);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txt_Com);
			this.Controls.Add(this.cmbWarm);
			this.Controls.Add(this.cmbBrake);
			this.Controls.Add(this.lblComment);
			this.Controls.Add(this.cmbCool);
			this.Controls.Add(this.lblPhone);
			this.Controls.Add(this.cmbOilType);
			this.Controls.Add(this.pnlPaperDisplay);
			this.Controls.Add(this.cmbService);
			this.Controls.Add(this.main_CustomerBindingNavigator);
			this.Name = "Main";
			this.Text = "Main";
			((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingNavigator)).EndInit();
			this.main_CustomerBindingNavigator.ResumeLayout(false);
			this.main_CustomerBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.main_CustomerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.main_PartsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backupDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.temp_TableBindingSource)).EndInit();
			this.pnlPaperDisplay.ResumeLayout(false);
			this.pnlPaperDisplay.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MainDBDataSet mainDBDataSet;
        private System.Windows.Forms.BindingSource main_CustomerBindingSource;
        private MainDBDataSetTableAdapters.Main_CustomerTableAdapter main_CustomerTableAdapter;
        private MainDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator main_CustomerBindingNavigator;
        private System.Windows.Forms.BindingSource temp_TableBindingSource;
        private MainDBDataSetTableAdapters.Temp_TableTableAdapter temp_TableTableAdapter;
        private System.Windows.Forms.BindingSource main_PartsBindingSource;
        private MainDBDataSetTableAdapters.Main_PartsTableAdapter main_PartsTableAdapter;
        private System.Windows.Forms.ToolStripButton toolStripBtnPrint;
        private BackupDBDataSet backupDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BackupDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private BackupDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_SchoolName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.DateTimePicker date_of_Completed_WorkDateTimePicker;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox supplier_InvoiceTextBox;
        private System.Windows.Forms.TextBox txtinvoice;
        private System.Windows.Forms.Label lbl_WorkPerformed;
        private System.Windows.Forms.Label lblRecomm;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTecNames;
        private System.Windows.Forms.TextBox txtTec1;
        private System.Windows.Forms.TextBox txtTec2;
        private System.Windows.Forms.TextBox txtTec3;
        private System.Windows.Forms.TextBox txtTec4;
        private System.Windows.Forms.Panel pnlPaperDisplay;
        private System.Windows.Forms.TextBox txtRecommendations;
        private System.Windows.Forms.TextBox txtWorkPerformed;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripButton btn_Prodemand;
        private BackupDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txt_Com;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbWarm;
        private System.Windows.Forms.ComboBox cmbCool;
        private System.Windows.Forms.ComboBox cmbOilType;
        private System.Windows.Forms.ComboBox cmbBrake;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblchoose;
        private System.Windows.Forms.Label lblTtime;
        private System.Windows.Forms.Label lblTprice;
        private System.Windows.Forms.TextBox txtVIN;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
		private System.Windows.Forms.Label lblConnection;
		private System.Windows.Forms.ComboBox cmbIP;
	}
}