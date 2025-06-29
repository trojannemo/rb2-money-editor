using System.Windows.Forms;

namespace RB2MoneyEditor2025
{
    partial class MainForm
    {
        protected override void Dispose(bool disposing)
        {
            //if (disposing && this.ch4fAOwdN != null)
              //  this.ch4fAOwdN.Dispose();
            base.Dispose(disposing);
        }
                
        private void InitializeComponent()
        {            
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblNewMoney = new System.Windows.Forms.Label();
            this.txtNewMoney = new System.Windows.Forms.TextBox();
            this.txtCurrentMoney = new System.Windows.Forms.TextBox();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnMaxMoney = new System.Windows.Forms.Button();
            this.lblMoneyOffset = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBand = new System.Windows.Forms.TextBox();
            this.lblBand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewMoney
            // 
            this.lblNewMoney.AutoSize = true;
            this.lblNewMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblNewMoney.ForeColor = System.Drawing.Color.Black;
            this.lblNewMoney.Location = new System.Drawing.Point(20, 165);
            this.lblNewMoney.Name = "lblNewMoney";
            this.lblNewMoney.Size = new System.Drawing.Size(67, 13);
            this.lblNewMoney.TabIndex = 6;
            this.lblNewMoney.Text = "New Money:";
            this.lblNewMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewMoney
            // 
            this.txtNewMoney.Location = new System.Drawing.Point(93, 162);
            this.txtNewMoney.MaxLength = 9;
            this.txtNewMoney.Name = "txtNewMoney";
            this.txtNewMoney.Size = new System.Drawing.Size(96, 20);
            this.txtNewMoney.TabIndex = 5;
            this.txtNewMoney.TextChanged += new System.EventHandler(this.txtNewMoney_TextChanged);
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Location = new System.Drawing.Point(93, 136);
            this.txtCurrentMoney.Name = "txtCurrentMoney";
            this.txtCurrentMoney.ReadOnly = true;
            this.txtCurrentMoney.Size = new System.Drawing.Size(96, 20);
            this.txtCurrentMoney.TabIndex = 4;
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentMoney.Location = new System.Drawing.Point(8, 139);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(79, 13);
            this.lblCurrentMoney.TabIndex = 3;
            this.lblCurrentMoney.Text = "Current Money:";
            this.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgBanner
            // 
            this.imgBanner.BackColor = System.Drawing.Color.Transparent;
            this.imgBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgBanner.Image = global::RB2MoneyEditor2025.Properties.Resources.header;
            this.imgBanner.Location = new System.Drawing.Point(-4, 217);
            this.imgBanner.Name = "imgBanner";
            this.imgBanner.Size = new System.Drawing.Size(269, 96);
            this.imgBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBanner.TabIndex = 2;
            this.imgBanner.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.White;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(174, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 40);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(93, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "&Open File";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnMaxMoney
            // 
            this.btnMaxMoney.BackColor = System.Drawing.Color.White;
            this.btnMaxMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxMoney.Location = new System.Drawing.Point(93, 189);
            this.btnMaxMoney.Name = "btnMaxMoney";
            this.btnMaxMoney.Size = new System.Drawing.Size(96, 22);
            this.btnMaxMoney.TabIndex = 7;
            this.btnMaxMoney.Text = "&Max Money";
            this.btnMaxMoney.UseVisualStyleBackColor = false;
            this.btnMaxMoney.Click += new System.EventHandler(this.btnMaxMoney_Click);
            // 
            // lblMoneyOffset
            // 
            this.lblMoneyOffset.AutoSize = true;
            this.lblMoneyOffset.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyOffset.Location = new System.Drawing.Point(14, 113);
            this.lblMoneyOffset.Name = "lblMoneyOffset";
            this.lblMoneyOffset.Size = new System.Drawing.Size(73, 13);
            this.lblMoneyOffset.TabIndex = 8;
            this.lblMoneyOffset.Text = "Money Offset:";
            this.lblMoneyOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(93, 110);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.ReadOnly = true;
            this.txtOffset.Size = new System.Drawing.Size(96, 20);
            this.txtOffset.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(17, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Player Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 58);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(96, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtBand
            // 
            this.txtBand.Location = new System.Drawing.Point(93, 84);
            this.txtBand.Name = "txtBand";
            this.txtBand.ReadOnly = true;
            this.txtBand.Size = new System.Drawing.Size(156, 20);
            this.txtBand.TabIndex = 13;
            // 
            // lblBand
            // 
            this.lblBand.AutoSize = true;
            this.lblBand.BackColor = System.Drawing.Color.Transparent;
            this.lblBand.Location = new System.Drawing.Point(21, 87);
            this.lblBand.Name = "lblBand";
            this.lblBand.Size = new System.Drawing.Size(66, 13);
            this.lblBand.TabIndex = 12;
            this.lblBand.Text = "Band Name:";
            this.lblBand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 313);
            this.Controls.Add(this.txtBand);
            this.Controls.Add(this.lblBand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMoneyOffset);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.btnMaxMoney);
            this.Controls.Add(this.lblNewMoney);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.txtCurrentMoney);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtNewMoney);
            this.Controls.Add(this.imgBanner);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RB2 Money Editor (2025)";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnMaxMoney;
        private Label lblMoneyOffset;
        private TextBox txtOffset;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtBand;
        private Label lblBand;
    }        
}
