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
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtNewMoney = new System.Windows.Forms.TextBox();
            this.txtCurrentMoney = new System.Windows.Forms.TextBox();
            this.lblCurrMoney = new System.Windows.Forms.Label();
            this.imgBanner = new System.Windows.Forms.PictureBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnMaxMoney = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.ForeColor = System.Drawing.Color.Black;
            this.lblMoney.Location = new System.Drawing.Point(16, 139);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(67, 13);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "New Money:";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewMoney
            // 
            this.txtNewMoney.Location = new System.Drawing.Point(89, 136);
            this.txtNewMoney.MaxLength = 9;
            this.txtNewMoney.Name = "txtNewMoney";
            this.txtNewMoney.Size = new System.Drawing.Size(100, 20);
            this.txtNewMoney.TabIndex = 5;
            this.txtNewMoney.TextChanged += new System.EventHandler(this.txtNewMoney_TextChanged);
            // 
            // txtCurrentMoney
            // 
            this.txtCurrentMoney.Location = new System.Drawing.Point(89, 110);
            this.txtCurrentMoney.Name = "txtCurrentMoney";
            this.txtCurrentMoney.ReadOnly = true;
            this.txtCurrentMoney.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentMoney.TabIndex = 4;
            // 
            // lblCurrMoney
            // 
            this.lblCurrMoney.AutoSize = true;
            this.lblCurrMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrMoney.Location = new System.Drawing.Point(4, 113);
            this.lblCurrMoney.Name = "lblCurrMoney";
            this.lblCurrMoney.Size = new System.Drawing.Size(79, 13);
            this.lblCurrMoney.TabIndex = 3;
            this.lblCurrMoney.Text = "Current Money:";
            this.lblCurrMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgBanner
            // 
            this.imgBanner.BackColor = System.Drawing.Color.Transparent;
            this.imgBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgBanner.Image = global::RB2MoneyEditor2025.Properties.Resources.header;
            this.imgBanner.Location = new System.Drawing.Point(-8, 193);
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
            this.btnMaxMoney.Location = new System.Drawing.Point(89, 163);
            this.btnMaxMoney.Name = "btnMaxMoney";
            this.btnMaxMoney.Size = new System.Drawing.Size(100, 22);
            this.btnMaxMoney.TabIndex = 7;
            this.btnMaxMoney.Text = "&Max Money";
            this.btnMaxMoney.UseVisualStyleBackColor = false;
            this.btnMaxMoney.Click += new System.EventHandler(this.btnMaxMoney_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Money Offset:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(89, 84);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.ReadOnly = true;
            this.txtOffset.Size = new System.Drawing.Size(100, 20);
            this.txtOffset.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Player Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 58);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 288);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.btnMaxMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblCurrMoney);
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
        private Label label1;
        private TextBox txtOffset;
        private Label label2;
        private TextBox txtName;
    }        
}
