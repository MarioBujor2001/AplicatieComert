namespace AplicatieComert
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadAvailableProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numeProdLbl = new System.Windows.Forms.Label();
            this.cantitateLbl = new System.Windows.Forms.Label();
            this.tipProdusLbl = new System.Windows.Forms.Label();
            this.pretLbl = new System.Windows.Forms.Label();
            this.denProdTb = new System.Windows.Forms.TextBox();
            this.cantitateTb = new System.Windows.Forms.TextBox();
            this.pretTb = new System.Windows.Forms.TextBox();
            this.updateStocBtn = new System.Windows.Forms.Button();
            this.tipProdCb = new System.Windows.Forms.ComboBox();
            this.atributParticularLbl = new System.Windows.Forms.Label();
            this.atributParticularTb = new System.Windows.Forms.TextBox();
            this.seeStockBtn = new System.Windows.Forms.Button();
            this.forUpdateCb = new System.Windows.Forms.ComboBox();
            this.forUpdateLbl = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lvProduse = new System.Windows.Forms.ListView();
            this.colDenum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAtribut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAvailableProductsToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadAvailableProductsToolStripMenuItem
            // 
            this.loadAvailableProductsToolStripMenuItem.Name = "loadAvailableProductsToolStripMenuItem";
            this.loadAvailableProductsToolStripMenuItem.Size = new System.Drawing.Size(146, 20);
            this.loadAvailableProductsToolStripMenuItem.Text = "Load Available Products";
            this.loadAvailableProductsToolStripMenuItem.Click += new System.EventHandler(this.loadAvailableProductsToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToTextToolStripMenuItem,
            this.openFromTextToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToTextToolStripMenuItem
            // 
            this.saveToTextToolStripMenuItem.Name = "saveToTextToolStripMenuItem";
            this.saveToTextToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToTextToolStripMenuItem.Text = "Save to text";
            this.saveToTextToolStripMenuItem.Click += new System.EventHandler(this.saveToTextToolStripMenuItem_Click);
            // 
            // openFromTextToolStripMenuItem
            // 
            this.openFromTextToolStripMenuItem.Name = "openFromTextToolStripMenuItem";
            this.openFromTextToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openFromTextToolStripMenuItem.Text = "Open from text";
            this.openFromTextToolStripMenuItem.Click += new System.EventHandler(this.openFromTextToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 28);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(86, 15);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Bine ati venit !";
            // 
            // numeProdLbl
            // 
            this.numeProdLbl.AutoSize = true;
            this.numeProdLbl.Location = new System.Drawing.Point(16, 61);
            this.numeProdLbl.Name = "numeProdLbl";
            this.numeProdLbl.Size = new System.Drawing.Size(90, 13);
            this.numeProdLbl.TabIndex = 2;
            this.numeProdLbl.Text = "Denumire produs:";
            // 
            // cantitateLbl
            // 
            this.cantitateLbl.AutoSize = true;
            this.cantitateLbl.Location = new System.Drawing.Point(19, 87);
            this.cantitateLbl.Name = "cantitateLbl";
            this.cantitateLbl.Size = new System.Drawing.Size(91, 13);
            this.cantitateLbl.TabIndex = 3;
            this.cantitateLbl.Text = "Cantitate curenta:";
            // 
            // tipProdusLbl
            // 
            this.tipProdusLbl.AutoSize = true;
            this.tipProdusLbl.Location = new System.Drawing.Point(19, 110);
            this.tipProdusLbl.Name = "tipProdusLbl";
            this.tipProdusLbl.Size = new System.Drawing.Size(61, 13);
            this.tipProdusLbl.TabIndex = 4;
            this.tipProdusLbl.Text = "Tip Produs:";
            // 
            // pretLbl
            // 
            this.pretLbl.AutoSize = true;
            this.pretLbl.Location = new System.Drawing.Point(19, 134);
            this.pretLbl.Name = "pretLbl";
            this.pretLbl.Size = new System.Drawing.Size(29, 13);
            this.pretLbl.TabIndex = 5;
            this.pretLbl.Text = "Pret:";
            // 
            // denProdTb
            // 
            this.denProdTb.Enabled = false;
            this.denProdTb.Location = new System.Drawing.Point(113, 61);
            this.denProdTb.Name = "denProdTb";
            this.denProdTb.Size = new System.Drawing.Size(100, 20);
            this.denProdTb.TabIndex = 6;
            this.denProdTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.denProdTb_KeyPress);
            // 
            // cantitateTb
            // 
            this.cantitateTb.Enabled = false;
            this.cantitateTb.Location = new System.Drawing.Point(113, 84);
            this.cantitateTb.Name = "cantitateTb";
            this.cantitateTb.Size = new System.Drawing.Size(100, 20);
            this.cantitateTb.TabIndex = 7;
            this.cantitateTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantitateTb_KeyPress);
            // 
            // pretTb
            // 
            this.pretTb.Enabled = false;
            this.pretTb.Location = new System.Drawing.Point(113, 131);
            this.pretTb.Name = "pretTb";
            this.pretTb.Size = new System.Drawing.Size(100, 20);
            this.pretTb.TabIndex = 9;
            this.pretTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pretTb_KeyPress);
            // 
            // updateStocBtn
            // 
            this.updateStocBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.updateStocBtn.Enabled = false;
            this.updateStocBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateStocBtn.Location = new System.Drawing.Point(22, 191);
            this.updateStocBtn.Name = "updateStocBtn";
            this.updateStocBtn.Size = new System.Drawing.Size(109, 23);
            this.updateStocBtn.TabIndex = 10;
            this.updateStocBtn.Text = "Update Stock";
            this.updateStocBtn.UseVisualStyleBackColor = false;
            this.updateStocBtn.Click += new System.EventHandler(this.updateStocBtn_Click);
            // 
            // tipProdCb
            // 
            this.tipProdCb.Enabled = false;
            this.tipProdCb.FormattingEnabled = true;
            this.tipProdCb.Location = new System.Drawing.Point(113, 107);
            this.tipProdCb.Name = "tipProdCb";
            this.tipProdCb.Size = new System.Drawing.Size(100, 21);
            this.tipProdCb.TabIndex = 11;
            this.tipProdCb.SelectedIndexChanged += new System.EventHandler(this.tipProdCb_SelectedIndexChanged);
            // 
            // atributParticularLbl
            // 
            this.atributParticularLbl.AutoSize = true;
            this.atributParticularLbl.Location = new System.Drawing.Point(19, 160);
            this.atributParticularLbl.Name = "atributParticularLbl";
            this.atributParticularLbl.Size = new System.Drawing.Size(31, 13);
            this.atributParticularLbl.TabIndex = 12;
            this.atributParticularLbl.Text = "ceva";
            // 
            // atributParticularTb
            // 
            this.atributParticularTb.Location = new System.Drawing.Point(113, 157);
            this.atributParticularTb.Name = "atributParticularTb";
            this.atributParticularTb.Size = new System.Drawing.Size(100, 20);
            this.atributParticularTb.TabIndex = 13;
            // 
            // seeStockBtn
            // 
            this.seeStockBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.seeStockBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.seeStockBtn.Location = new System.Drawing.Point(22, 220);
            this.seeStockBtn.Name = "seeStockBtn";
            this.seeStockBtn.Size = new System.Drawing.Size(109, 23);
            this.seeStockBtn.TabIndex = 14;
            this.seeStockBtn.Text = "See Current Stock!";
            this.seeStockBtn.UseVisualStyleBackColor = false;
            this.seeStockBtn.Click += new System.EventHandler(this.seeStockBtn_Click);
            // 
            // forUpdateCb
            // 
            this.forUpdateCb.FormattingEnabled = true;
            this.forUpdateCb.Location = new System.Drawing.Point(153, 221);
            this.forUpdateCb.Name = "forUpdateCb";
            this.forUpdateCb.Size = new System.Drawing.Size(100, 21);
            this.forUpdateCb.TabIndex = 15;
            this.forUpdateCb.SelectedIndexChanged += new System.EventHandler(this.forUpdateCb_SelectedIndexChanged);
            // 
            // forUpdateLbl
            // 
            this.forUpdateLbl.AutoSize = true;
            this.forUpdateLbl.Location = new System.Drawing.Point(153, 200);
            this.forUpdateLbl.Name = "forUpdateLbl";
            this.forUpdateLbl.Size = new System.Drawing.Size(63, 13);
            this.forUpdateLbl.TabIndex = 16;
            this.forUpdateLbl.Text = "For Update:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lvProduse
            // 
            this.lvProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDenum,
            this.colCantit,
            this.colTip,
            this.colPret,
            this.colAtribut});
            this.lvProduse.GridLines = true;
            this.lvProduse.HideSelection = false;
            this.lvProduse.Location = new System.Drawing.Point(232, 61);
            this.lvProduse.Name = "lvProduse";
            this.lvProduse.Size = new System.Drawing.Size(396, 152);
            this.lvProduse.TabIndex = 17;
            this.lvProduse.UseCompatibleStateImageBehavior = false;
            this.lvProduse.View = System.Windows.Forms.View.Details;
            // 
            // colDenum
            // 
            this.colDenum.Text = "DENUMIRE:";
            this.colDenum.Width = 77;
            // 
            // colCantit
            // 
            this.colCantit.Text = "CANTITATE RAMASA:";
            this.colCantit.Width = 124;
            // 
            // colTip
            // 
            this.colTip.Text = "TIP";
            this.colTip.Width = 78;
            // 
            // colPret
            // 
            this.colPret.Text = "PRET";
            this.colPret.Width = 42;
            // 
            // colAtribut
            // 
            this.colAtribut.Text = "ATRIBUT";
            this.colAtribut.Width = 69;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 257);
            this.Controls.Add(this.lvProduse);
            this.Controls.Add(this.forUpdateLbl);
            this.Controls.Add(this.forUpdateCb);
            this.Controls.Add(this.seeStockBtn);
            this.Controls.Add(this.atributParticularTb);
            this.Controls.Add(this.atributParticularLbl);
            this.Controls.Add(this.tipProdCb);
            this.Controls.Add(this.updateStocBtn);
            this.Controls.Add(this.pretTb);
            this.Controls.Add(this.cantitateTb);
            this.Controls.Add(this.denProdTb);
            this.Controls.Add(this.pretLbl);
            this.Controls.Add(this.tipProdusLbl);
            this.Controls.Add(this.cantitateLbl);
            this.Controls.Add(this.numeProdLbl);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AppComert - MainPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadAvailableProductsToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label numeProdLbl;
        private System.Windows.Forms.Label cantitateLbl;
        private System.Windows.Forms.Label tipProdusLbl;
        private System.Windows.Forms.Label pretLbl;
        private System.Windows.Forms.TextBox denProdTb;
        private System.Windows.Forms.TextBox cantitateTb;
        private System.Windows.Forms.TextBox pretTb;
        private System.Windows.Forms.Button updateStocBtn;
        private System.Windows.Forms.ComboBox tipProdCb;
        private System.Windows.Forms.Label atributParticularLbl;
        private System.Windows.Forms.TextBox atributParticularTb;
        private System.Windows.Forms.Button seeStockBtn;
        private System.Windows.Forms.ComboBox forUpdateCb;
        private System.Windows.Forms.Label forUpdateLbl;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromTextToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView lvProduse;
        private System.Windows.Forms.ColumnHeader colDenum;
        private System.Windows.Forms.ColumnHeader colCantit;
        private System.Windows.Forms.ColumnHeader colTip;
        private System.Windows.Forms.ColumnHeader colPret;
        private System.Windows.Forms.ColumnHeader colAtribut;
    }
}

