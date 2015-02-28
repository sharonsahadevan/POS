﻿namespace POS.UserInterfaceLayer.Portal
{
    partial class frmMain
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
            this.mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuItem_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_UserGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_BasicData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_ProductGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Inventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_AdjustReason = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Invntory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_StockInquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_takingInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_OpenTakingInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_CloseTakingInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_OpenningQuantities = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Purchace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_PurcaseOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_PurchaseReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Transfer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_TransferOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_Sales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_SalesOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItem_SalesOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btn_SalesOrder = new System.Windows.Forms.Button();
            this.btn_PurchaceOrder = new System.Windows.Forms.Button();
            this.btn_ReturnSalesOrder = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.btn_AddSupplier = new System.Windows.Forms.Button();
            this.btn_CustomerAccount = new System.Windows.Forms.Button();
            this.btn_SupplierAccount = new System.Windows.Forms.Button();
            this.btn_ReturnPurchaceOrder = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.mnu_MainMenu.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MainMenu
            // 
            this.mnu_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Administration,
            this.mnuItem_BasicData,
            this.mnuItem_Invntory,
            this.mnuItem_Purchace,
            this.mnuItem_Transfer,
            this.mnuItem_Sales});
            this.mnu_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnu_MainMenu.Name = "mnu_MainMenu";
            this.mnu_MainMenu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.mnu_MainMenu.Size = new System.Drawing.Size(702, 25);
            this.mnu_MainMenu.TabIndex = 0;
            this.mnu_MainMenu.Text = "menuStrip1";
            this.mnu_MainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnu_MainMenu_ItemClicked);
            // 
            // mnuItem_Administration
            // 
            this.mnuItem_Administration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_UserGroups});
            this.mnuItem_Administration.Enabled = false;
            this.mnuItem_Administration.Name = "mnuItem_Administration";
            this.mnuItem_Administration.Size = new System.Drawing.Size(71, 19);
            this.mnuItem_Administration.Text = "المستخدمين";
            // 
            // mnuItem_UserGroups
            // 
            this.mnuItem_UserGroups.Enabled = false;
            this.mnuItem_UserGroups.Name = "mnuItem_UserGroups";
            this.mnuItem_UserGroups.Size = new System.Drawing.Size(170, 22);
            this.mnuItem_UserGroups.Text = "مجموعات المستخدمين";
            this.mnuItem_UserGroups.Click += new System.EventHandler(this.mnuItem_UserGroups_Click);
            // 
            // mnuItem_BasicData
            // 
            this.mnuItem_BasicData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_Inventory,
            this.mnuItem_ProductGroup,
            this.mnuItem_Products,
            this.mnuItem_Customers,
            this.mnuItem_Suppliers,
            this.mnuItem_AdjustReason});
            this.mnuItem_BasicData.Enabled = false;
            this.mnuItem_BasicData.Name = "mnuItem_BasicData";
            this.mnuItem_BasicData.Size = new System.Drawing.Size(95, 19);
            this.mnuItem_BasicData.Text = "البيانات الرئيسية";
            // 
            // mnuItem_Customers
            // 
            this.mnuItem_Customers.Enabled = false;
            this.mnuItem_Customers.Name = "mnuItem_Customers";
            this.mnuItem_Customers.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_Customers.Text = "بيانات العملاء";
            this.mnuItem_Customers.Click += new System.EventHandler(this.mnuItem_Customers_Click);
            // 
            // mnuItem_Products
            // 
            this.mnuItem_Products.Enabled = false;
            this.mnuItem_Products.Name = "mnuItem_Products";
            this.mnuItem_Products.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_Products.Text = "الاصناف";
            this.mnuItem_Products.Click += new System.EventHandler(this.mnuItem_Products_Click);
            // 
            // mnuItem_ProductGroup
            // 
            this.mnuItem_ProductGroup.Enabled = false;
            this.mnuItem_ProductGroup.Name = "mnuItem_ProductGroup";
            this.mnuItem_ProductGroup.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_ProductGroup.Text = "مجموعة الاصناف";
            this.mnuItem_ProductGroup.Click += new System.EventHandler(this.mnuItem_ProductGroup_Click);
            // 
            // mnuItem_Suppliers
            // 
            this.mnuItem_Suppliers.Enabled = false;
            this.mnuItem_Suppliers.Name = "mnuItem_Suppliers";
            this.mnuItem_Suppliers.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_Suppliers.Text = "بيانات الموردين";
            this.mnuItem_Suppliers.Click += new System.EventHandler(this.mnuItem_Suppliers_Click);
            // 
            // mnuItem_Inventory
            // 
            this.mnuItem_Inventory.Enabled = false;
            this.mnuItem_Inventory.Name = "mnuItem_Inventory";
            this.mnuItem_Inventory.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_Inventory.Text = "المخازن";
            this.mnuItem_Inventory.Click += new System.EventHandler(this.mnuItem_Inventory_Click);
            // 
            // mnuItem_AdjustReason
            // 
            this.mnuItem_AdjustReason.Enabled = false;
            this.mnuItem_AdjustReason.Name = "mnuItem_AdjustReason";
            this.mnuItem_AdjustReason.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_AdjustReason.Text = "أسباب التسويه";
            this.mnuItem_AdjustReason.Click += new System.EventHandler(this.mnuItem_AdjustReason_Click);
            // 
            // mnuItem_Invntory
            // 
            this.mnuItem_Invntory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_OpenningQuantities,
            this.mnuItem_StockInquiry,
            this.mnuItem_takingInventory});
            this.mnuItem_Invntory.Enabled = false;
            this.mnuItem_Invntory.Name = "mnuItem_Invntory";
            this.mnuItem_Invntory.Size = new System.Drawing.Size(54, 19);
            this.mnuItem_Invntory.Text = "المخازن";
            // 
            // mnuItem_StockInquiry
            // 
            this.mnuItem_StockInquiry.Enabled = false;
            this.mnuItem_StockInquiry.Name = "mnuItem_StockInquiry";
            this.mnuItem_StockInquiry.Size = new System.Drawing.Size(157, 22);
            this.mnuItem_StockInquiry.Text = "إستعلام عن مخزون";
            this.mnuItem_StockInquiry.Click += new System.EventHandler(this.mnuItem_StockInquiry_Click);
            // 
            // mnuItem_takingInventory
            // 
            this.mnuItem_takingInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_OpenTakingInventory,
            this.mnuItem_CloseTakingInventory});
            this.mnuItem_takingInventory.Enabled = false;
            this.mnuItem_takingInventory.Name = "mnuItem_takingInventory";
            this.mnuItem_takingInventory.Size = new System.Drawing.Size(157, 22);
            this.mnuItem_takingInventory.Text = "الجرد";
            // 
            // mnuItem_OpenTakingInventory
            // 
            this.mnuItem_OpenTakingInventory.Enabled = false;
            this.mnuItem_OpenTakingInventory.Name = "mnuItem_OpenTakingInventory";
            this.mnuItem_OpenTakingInventory.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_OpenTakingInventory.Text = "فتح جرد";
            this.mnuItem_OpenTakingInventory.Click += new System.EventHandler(this.mnuItem_OpenTakingInventory_Click);
            // 
            // mnuItem_CloseTakingInventory
            // 
            this.mnuItem_CloseTakingInventory.Enabled = false;
            this.mnuItem_CloseTakingInventory.Name = "mnuItem_CloseTakingInventory";
            this.mnuItem_CloseTakingInventory.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_CloseTakingInventory.Text = "أغلاق الجرد";
            this.mnuItem_CloseTakingInventory.Click += new System.EventHandler(this.mnuItem_CloseTakingInventory_Click);
            // 
            // mnuItem_OpenningQuantities
            // 
            this.mnuItem_OpenningQuantities.Enabled = false;
            this.mnuItem_OpenningQuantities.Name = "mnuItem_OpenningQuantities";
            this.mnuItem_OpenningQuantities.Size = new System.Drawing.Size(157, 22);
            this.mnuItem_OpenningQuantities.Text = "المخزون الأفتتاحى";
            this.mnuItem_OpenningQuantities.Click += new System.EventHandler(this.mnuItem_OpenningQuantities_Click);
            // 
            // mnuItem_Purchace
            // 
            this.mnuItem_Purchace.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_PurcaseOrder,
            this.mnuItem_PurchaseReturn});
            this.mnuItem_Purchace.Enabled = false;
            this.mnuItem_Purchace.Name = "mnuItem_Purchace";
            this.mnuItem_Purchace.Size = new System.Drawing.Size(65, 19);
            this.mnuItem_Purchace.Text = "المشتريات";
            // 
            // mnuItem_PurcaseOrder
            // 
            this.mnuItem_PurcaseOrder.Enabled = false;
            this.mnuItem_PurcaseOrder.Name = "mnuItem_PurcaseOrder";
            this.mnuItem_PurcaseOrder.Size = new System.Drawing.Size(163, 22);
            this.mnuItem_PurcaseOrder.Text = "أمر شراء";
            this.mnuItem_PurcaseOrder.Click += new System.EventHandler(this.mnuItem_PurcaseOrder_Click);
            // 
            // mnuItem_PurchaseReturn
            // 
            this.mnuItem_PurchaseReturn.Enabled = false;
            this.mnuItem_PurchaseReturn.Name = "mnuItem_PurchaseReturn";
            this.mnuItem_PurchaseReturn.Size = new System.Drawing.Size(163, 22);
            this.mnuItem_PurchaseReturn.Text = "أمر مرتجع مشتريات";
            this.mnuItem_PurchaseReturn.Click += new System.EventHandler(this.mnuItem_PurchaseReturn_Click);
            // 
            // mnuItem_Transfer
            // 
            this.mnuItem_Transfer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_TransferOrder});
            this.mnuItem_Transfer.Enabled = false;
            this.mnuItem_Transfer.Name = "mnuItem_Transfer";
            this.mnuItem_Transfer.Size = new System.Drawing.Size(52, 19);
            this.mnuItem_Transfer.Text = "التحويل";
            // 
            // mnuItem_TransferOrder
            // 
            this.mnuItem_TransferOrder.Enabled = false;
            this.mnuItem_TransferOrder.Name = "mnuItem_TransferOrder";
            this.mnuItem_TransferOrder.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_TransferOrder.Text = "امر تحويل";
            this.mnuItem_TransferOrder.Click += new System.EventHandler(this.mnuItem_TransferOrder_Click);
            // 
            // mnuItem_Sales
            // 
            this.mnuItem_Sales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem_SalesOrders,
            this.mnuItem_SalesOrder});
            this.mnuItem_Sales.Enabled = false;
            this.mnuItem_Sales.Name = "mnuItem_Sales";
            this.mnuItem_Sales.Size = new System.Drawing.Size(40, 19);
            this.mnuItem_Sales.Text = "البيع";
            // 
            // mnuItem_SalesOrders
            // 
            this.mnuItem_SalesOrders.Enabled = false;
            this.mnuItem_SalesOrders.Name = "mnuItem_SalesOrders";
            this.mnuItem_SalesOrders.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_SalesOrders.Text = "فواتير العملاء";
            this.mnuItem_SalesOrders.Click += new System.EventHandler(this.mnuItem_SalesOrders_Click);
            // 
            // mnuItem_SalesOrder
            // 
            this.mnuItem_SalesOrder.Enabled = false;
            this.mnuItem_SalesOrder.Name = "mnuItem_SalesOrder";
            this.mnuItem_SalesOrder.Size = new System.Drawing.Size(152, 22);
            this.mnuItem_SalesOrder.Text = "فتح فاتورة جديدة";
            this.mnuItem_SalesOrder.Click += new System.EventHandler(this.mnuItem_SalesOrder_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContent.Controls.Add(this.btn_AddProduct);
            this.pnlContent.Controls.Add(this.btn_ReturnPurchaceOrder);
            this.pnlContent.Controls.Add(this.btn_SupplierAccount);
            this.pnlContent.Controls.Add(this.btn_CustomerAccount);
            this.pnlContent.Controls.Add(this.btn_AddSupplier);
            this.pnlContent.Controls.Add(this.btn_AddCustomer);
            this.pnlContent.Controls.Add(this.btn_ReturnSalesOrder);
            this.pnlContent.Controls.Add(this.btn_PurchaceOrder);
            this.pnlContent.Controls.Add(this.btn_SalesOrder);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 25);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(702, 382);
            this.pnlContent.TabIndex = 6;
            // 
            // btn_SalesOrder
            // 
            this.btn_SalesOrder.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_SalesOrder.Location = new System.Drawing.Point(152, 299);
            this.btn_SalesOrder.Name = "btn_SalesOrder";
            this.btn_SalesOrder.Size = new System.Drawing.Size(102, 71);
            this.btn_SalesOrder.TabIndex = 1;
            this.btn_SalesOrder.Text = "فتح فاتورة بيع";
            this.btn_SalesOrder.UseVisualStyleBackColor = true;
            // 
            // btn_PurchaceOrder
            // 
            this.btn_PurchaceOrder.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_PurchaceOrder.Location = new System.Drawing.Point(30, 22);
            this.btn_PurchaceOrder.Name = "btn_PurchaceOrder";
            this.btn_PurchaceOrder.Size = new System.Drawing.Size(102, 71);
            this.btn_PurchaceOrder.TabIndex = 2;
            this.btn_PurchaceOrder.Text = "أمر شراء";
            this.btn_PurchaceOrder.UseVisualStyleBackColor = true;
            // 
            // btn_ReturnSalesOrder
            // 
            this.btn_ReturnSalesOrder.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_ReturnSalesOrder.Location = new System.Drawing.Point(30, 230);
            this.btn_ReturnSalesOrder.Name = "btn_ReturnSalesOrder";
            this.btn_ReturnSalesOrder.Size = new System.Drawing.Size(102, 71);
            this.btn_ReturnSalesOrder.TabIndex = 3;
            this.btn_ReturnSalesOrder.Text = "مرتجع فاتورة";
            this.btn_ReturnSalesOrder.UseVisualStyleBackColor = true;
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_AddCustomer.Location = new System.Drawing.Point(567, 125);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(102, 71);
            this.btn_AddCustomer.TabIndex = 4;
            this.btn_AddCustomer.Text = "أضافة عميل ";
            this.btn_AddCustomer.UseVisualStyleBackColor = true;
            // 
            // btn_AddSupplier
            // 
            this.btn_AddSupplier.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_AddSupplier.Location = new System.Drawing.Point(567, 228);
            this.btn_AddSupplier.Name = "btn_AddSupplier";
            this.btn_AddSupplier.Size = new System.Drawing.Size(102, 71);
            this.btn_AddSupplier.TabIndex = 5;
            this.btn_AddSupplier.Text = "أضافى مورد";
            this.btn_AddSupplier.UseVisualStyleBackColor = true;
            // 
            // btn_CustomerAccount
            // 
            this.btn_CustomerAccount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_CustomerAccount.Location = new System.Drawing.Point(436, 299);
            this.btn_CustomerAccount.Name = "btn_CustomerAccount";
            this.btn_CustomerAccount.Size = new System.Drawing.Size(102, 71);
            this.btn_CustomerAccount.TabIndex = 6;
            this.btn_CustomerAccount.Text = "حسابات العملاء";
            this.btn_CustomerAccount.UseVisualStyleBackColor = true;
            // 
            // btn_SupplierAccount
            // 
            this.btn_SupplierAccount.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_SupplierAccount.Location = new System.Drawing.Point(294, 299);
            this.btn_SupplierAccount.Name = "btn_SupplierAccount";
            this.btn_SupplierAccount.Size = new System.Drawing.Size(102, 71);
            this.btn_SupplierAccount.TabIndex = 7;
            this.btn_SupplierAccount.Text = "حسابات الموردين";
            this.btn_SupplierAccount.UseVisualStyleBackColor = true;
            // 
            // btn_ReturnPurchaceOrder
            // 
            this.btn_ReturnPurchaceOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnPurchaceOrder.Location = new System.Drawing.Point(30, 127);
            this.btn_ReturnPurchaceOrder.Name = "btn_ReturnPurchaceOrder";
            this.btn_ReturnPurchaceOrder.Size = new System.Drawing.Size(102, 71);
            this.btn_ReturnPurchaceOrder.TabIndex = 8;
            this.btn_ReturnPurchaceOrder.Text = "مرتجع مشتريات";
            this.btn_ReturnPurchaceOrder.UseVisualStyleBackColor = true;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_AddProduct.Location = new System.Drawing.Point(567, 22);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(102, 71);
            this.btn_AddProduct.TabIndex = 9;
            this.btn_AddProduct.Text = "أضافة صنف ";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(702, 407);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.mnu_MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnu_MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامج المخازن";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnu_MainMenu.ResumeLayout(false);
            this.mnu_MainMenu.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_BasicData;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Customers;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Administration;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_UserGroups;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Products;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_ProductGroup;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Suppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Inventory;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_AdjustReason;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Invntory;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_StockInquiry;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_takingInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_OpenTakingInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_CloseTakingInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Purchace;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_PurcaseOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_PurchaseReturn;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Transfer;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_TransferOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_Sales;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_SalesOrders;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_SalesOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuItem_OpenningQuantities;
        private System.Windows.Forms.Button btn_SupplierAccount;
        private System.Windows.Forms.Button btn_CustomerAccount;
        private System.Windows.Forms.Button btn_AddSupplier;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.Button btn_ReturnSalesOrder;
        private System.Windows.Forms.Button btn_PurchaceOrder;
        private System.Windows.Forms.Button btn_SalesOrder;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_ReturnPurchaceOrder;
    }
}